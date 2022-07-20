using Admin.Shared;
using Admin.View.CustomForms;
using Microsoft.EntityFrameworkCore;
using Model.CatRef;
using Repository;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Admin.Presenter.CustomPresenters
{
    public class MatlabOptimizationMethodPresenter : ICustomPresenter
    {
        private StandardPresenterLogic<MatlabOptimizationMethodForm>? StandardPresenterLogic { get; set; }

        public EntityInfo EntityInfo { get; } = new()
        {
            Name = "Методы оптимизации MATLAB",
            DataType = typeof(MatlabOptimizationMethod)
        };

        private static async Task<string?> Form_ImportFile(MatlabOptimizationMethod matlabOptimMethod, string filePath)
        {
            using var fileReader = new StreamReader(filePath);

            Task<string> readTask = fileReader.ReadToEndAsync();
            string fileText = await readTask;
            if (readTask.Exception is not null)
                return "Произошла ошибка при чтении файла";

            using var lineReader = new StringReader(fileText);
            string? firstLine = await lineReader.ReadLineAsync();

            if (string.IsNullOrEmpty(firstLine))
                return "Первая строка файла не может быть пустой";

            var regex = new Regex(@"\s*function\s*\[(\s*\w+\s*,){7}\s*\w+\s*\]\s*=\s*\w+\((\s*\w+\s*,){6}\s*\w+\s*\)\s*");
            if (!regex.IsMatch(firstLine))
                return "Первая строка файла должна начинаться " +
                    "со слова function, в квадратных скобках иметь 8 выходных параметров: " +
                    "точка, в которой достигается максимум целевой функции; максимальное значение целевой функции; " +
                    "флаг окончания работы метода; количество итераций метода; количество вычислений целевой функции; " +
                    "мера оптимальности первого порядка время работы метода; сообщение об ошибке (если такая возникнет), " +
                    "а также иметь наименование функции и в круглых скобках 7 входных аргументов: " +
                    "нижние границы варьируемых параметров; верхние границы варьируемых параметров; " +
                    "стартовая точка; параметры метода оптимизации; целевая функция; " +
                    "функция критериального ограничения; функция записи точек, сгенерированных методом, например, " +
                    "function[x, F, iterations, flag, funcCount, firstorderopt, elapsedTime, Er] = " +
                    "Optimization(VPLBs, VPUBs, P0, OMP, TF, FoF, OutFun)";

            matlabOptimMethod.MatlabText = fileText;
            return null;
        }

        private static async Task Form_ExportFile(MatlabOptimizationMethod matlabOptimMethod, string filePath, 
            CancellationToken cancellationToken)
        {
            using var writer = new StreamWriter(filePath);
            CancellationTokenSource cancellationTokenSource = new();
            await writer.WriteAsync(matlabOptimMethod.MatlabText.ToArray(),
                cancellationTokenSource.Token);
        }

        public void Run(ExtendedDbContext dbContextTmp)
        {
            var form = new MatlabOptimizationMethodForm();
            form.ExportFile += Form_ExportFile;
            form.ImportFile += Form_ImportFile;
            var dbContext = (CatRefDbContext)dbContextTmp;

            dbContext.MatlabOptimizationMethods.Load();
            StandardPresenterLogic = new StandardPresenterLogic<MatlabOptimizationMethodForm>(dbContext, EntityInfo, form);
            StandardPresenterLogic.Run(dbContext.MatlabOptimizationMethods.Local.ToBindingList());
        }
    }
}
