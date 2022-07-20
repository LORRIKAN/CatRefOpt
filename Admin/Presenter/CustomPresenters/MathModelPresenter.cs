using Admin.Shared;
using Admin.View.CustomForms;
using Microsoft.EntityFrameworkCore;
using Model.CatRef;
using Repository;

namespace Admin.Presenter.CustomPresenters
{
    public class MathModelPresenter : ICustomPresenter
    {
        private StandardPresenterLogic<MathModelForm>? StandardPresenterLogic { get; set; }

        public EntityInfo EntityInfo { get; } = new()
        {
            Name = "Математические модели",
            DataType = typeof(MatlabMathModel),
        };


        public void Run(ExtendedDbContext dbContextTmp)
        {
            var form = new MathModelForm();

            var dbContext = (CatRefDbContext)dbContextTmp;
            dbContext.MatlabMathModels.Load();
            StandardPresenterLogic = new StandardPresenterLogic<MathModelForm>(dbContext, EntityInfo, form);
            StandardPresenterLogic.Run(dbContext.MatlabMathModels.Local.ToBindingList());
        }
    }
}
