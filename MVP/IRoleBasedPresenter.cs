using Model.Users;

namespace MVP
{
    public interface IRoleBasedPresenter
    {
        bool Run();

        Role Role { get; set; }
    }
}
