using Admin.Shared;
using Admin.View.CustomForms;
using Microsoft.EntityFrameworkCore;
using Model.CatRef;
using Repository;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace Admin.Presenter.CustomPresenters
{
    public class MatlabFuncPresenter : ICustomPresenter
    {
        private StandardPresenterLogic<MatlabFuncForm>? StandardPresenterLogic { get; set; }

        public EntityInfo EntityInfo { get; } = new()
        {
            Name = "Функции MATLAB",
            DataType = typeof(MatlabFunc)
        };

        private static async Task<string?> Form_ImportFile(MatlabFunc matlabFunc, string filePath)
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

            var regex = new Regex(@"\s*function\s*\[\s*\w+\s*]\s*=\s*\w+\(\s*\w+\s*,\s*\w+\s*\)\s*");
            if (!regex.IsMatch(firstLine))
                return "Первая строка файла должна начинаться " +
                    "со слова function, в квадратных скобках иметь 1 выходной параметр: " +
                    "полученное значение функции, " +
                    "а также иметь наименование функции и в круглых скобках 2 входных аргумента: " +
                    "обозначения и значения параметров; обозначения и значения эмпирических коэффициентов, " +
                    "например, function [F,Er] = Selection(In,Ec)";

            matlabFunc.MatlabFuncText = fileText;
            return null;
        }

        private static async Task Form_ExportFile(MatlabFunc matlabFunc, string filePath, 
            CancellationToken cancellationToken)
        {
            using var writer = new StreamWriter(filePath);
            CancellationTokenSource cancellationTokenSource = new();
            await writer.WriteAsync(matlabFunc.MatlabFuncText.ToArray(),
                cancellationTokenSource.Token);
        }

        public void Run(ExtendedDbContext dbContextTmp)
        {
            var form = new MatlabFuncForm();
            form.ExportFile += Form_ExportFile;
            form.ImportFile += Form_ImportFile;
            var dbContext = (CatRefDbContext)dbContextTmp;

            dbContext.MatlabFuncs.Load();
            StandardPresenterLogic = new StandardPresenterLogic<MatlabFuncForm>(dbContext, EntityInfo, form);
            StandardPresenterLogic.Run(dbContext.MatlabFuncs.Local.ToBindingList());
        }
    }
}
