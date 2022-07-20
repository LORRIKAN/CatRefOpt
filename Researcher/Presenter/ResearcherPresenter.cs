using Model.CatRef;
using Model.Users;
using MVP;
using Repository;
using Researcher.Shared;
using Researcher.View;
using Researcher.View.InterfaceElements.ParamsIO.NumericsValidation;
using WinFormsShared;
using System.Diagnostics;
using OptimizationMatlab;
using VisualizationMatlab;
using Researcher.Shared.Messages.VisOptimMsgs;
using Researcher.Shared.Messages.ExportMsgs;
using Researcher.Presenter.Export;

namespace Researcher.Presenter
{
    public partial class ResearcherPresenter : RoleBasedPresenterBase<ResearcherForm>
    {
        private CatRefDbContext DbContext { get; set; }

        public ResearcherPresenter(Role role, ResearcherForm form, CatRefDbContext dbContext)
            : base(role, form)
        {
            DbContext = dbContext;

            Form.HelpRequired += Form_HelpRequired;
            Form.GetAllocatedMemoryInMb += Form_GetAllocatedMemoryInMb;
            Form.GetValuesTableSizeParams += Form_GetValuesTableSizeParams;
            Form.GetPlants += Form_GetPlants;
            Form.GetReactors += Form_GetReactors;
            Form.GetMaterials += Form_GetMaterials;
            Form.GetCatalysts += Form_GetCatalysts;
            Form.GetMathModels += Form_GetMathModels;
            Form.GetTargetFuncs += Form_GetTargetFuncs;
            Form.GetReactorInputParams += Form_GetReactorInputParams;
            Form.GetMaterialInputParams += Form_GetMaterialInputParams;
            Form.GetCatalystInputParams += Form_GetCatalystInputParams;
            Form.GetVariableParams += Form_GetVariableParams;
            Form.GetOptimMethodParams += Form_GetOptimMethodParams;
            Form.StartOptimization += Form_StartOptimization;
            Form.StartVisualization += Form_StartVisualization;
            Form.BuildPathPlot += Form_BuildPathPlot;
            Form.BuildValuesTable += Form_BuildValuesTable;
            Form.CanBuildPathPlot += Form_CanBuildPathPlot;
            Form.SaveOptimResults += Form_SaveOptimResults;
            Form.SaveVisResults += Form_SaveVisResults;
            Form.Shown += (_, _) => { Form.Activate(); Form.WindowState = FormWindowState.Maximized; };
        }
    }
}
