using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Researcher.Presenter
{
    public partial class ResearcherPresenter
    {
        private void Form_HelpRequired()
        {
            string directory = Path.Combine(Environment.CurrentDirectory, "helpResearcher");

            string filePath = Path.Combine(directory, "index.htm");

            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }

        private int Form_GetAllocatedMemoryInMb()
        {
            Process currentProcess = Process.GetCurrentProcess();
            long usedMemory = currentProcess.PrivateMemorySize64 / (1024 * 1024);

            return (int)usedMemory;
        }

        private bool Form_CanBuildPathPlot()
        {
            return LastOptimResult is not null && LastOptimResult.Value.ParamsOptimValues.Length is 2;
        }
    }
}
