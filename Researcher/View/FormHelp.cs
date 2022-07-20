using Model.CatRef;
using Researcher.View.InterfaceElements;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsShared;

namespace Researcher.View
{
    public partial class ResearcherForm
    {
        public event Action? HelpRequired;

        private void aboutButt_Click(object sender, EventArgs e)
        {
            if (HelpRequired is null)
            {
                MessageDialog.ShowMessage(MessageType.Error, this, "Ошибка", "Ошибка в программном коде",
                    "Ошибка при попытке открытия справки. Проблема в программном коде.");
                return;
            }
            HelpRequired();
        }

        private void helpButtOnMathModelVis_Click(object sender, EventArgs e)
        {
            if (mathModelVis.SelectedItem is not MatlabMathModel mathModel)
            {
                MessageDialog.ShowMessage(MessageType.Error, this, text: "Сначала выберите математическую модель");
                return;
            }

            new DescriptionForm().Run(mathModel.Name, mathModel.Description ?? string.Empty);
        }

        private void helpButtOnOptimMethod_Click(object sender, EventArgs e)
        {
            if (optimMethod.SelectedItem is not MatlabOptimizationMethod optimMethodInner)
            {
                MessageDialog.ShowMessage(MessageType.Error, this, text: "Сначала выберите метод нелинейного программирования");
                return;
            }

            new DescriptionForm().Run(optimMethodInner.Name, optimMethodInner.Description ?? string.Empty);
        }
    }
}
