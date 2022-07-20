using Admin.Shared;
using Admin.View;
using Repository;
using System.ComponentModel;

namespace Admin.Presenter
{
    public class StandardPresenter
    {
        private StandardPresenterLogic<StandardForm> StandardPresenterLogic { get; set; }

        public StandardPresenter(ExtendedDbContext dbContext, EntityInfo tableEntity)
        {
            StandardPresenterLogic = new(dbContext, tableEntity, new StandardForm());
        }

        public void Run(IBindingList dataSource)
        {
            StandardPresenterLogic.Run(dataSource);
        }
    }
}
