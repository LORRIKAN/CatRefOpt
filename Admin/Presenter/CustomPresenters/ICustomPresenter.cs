using Admin.Shared;
using Repository;
using System.ComponentModel;

namespace Admin.Presenter.CustomPresenters
{
    public interface ICustomPresenter
    {
        EntityInfo EntityInfo { get; }

        void Run(ExtendedDbContext dbContext);
    }
}