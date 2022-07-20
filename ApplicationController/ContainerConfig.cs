using Autofac;
using Login.Presenter;
using Login.View;
using Admin.Presenter;
using Admin.View;
using Model.Users;
using MVP;
using Repository;
using Researcher.Presenter;
using Researcher.View;
using Admin.Presenter.CustomPresenters;
using Admin.Shared.DbEntities;
using Admin.Shared;

namespace ApplicationController
{
    internal static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<CatRefUsersDbContext>().As<ExtendedDbContext>().AsSelf();
            builder.RegisterType<CatRefDbContext>().As<ExtendedDbContext>().AsSelf();

            builder.RegisterType<MathModelPresenter>().As<ICustomPresenter>();
            builder.RegisterType<MatlabFuncPresenter>().As<ICustomPresenter>();
            builder.RegisterType<MatlabOptimizationMethodPresenter>().As<ICustomPresenter>();
            builder.RegisterType<ProcessCharacteristicsDbEntity>().As<IDbEntity>();
            builder.RegisterType<MathModelsLibDbEntity>().As<IDbEntity>();
            builder.RegisterType<OptimMethodsLibDbEntity>().As<IDbEntity>();
            builder.RegisterType<UsersDbEntity>().As<IDbEntity>();
            builder.RegisterType<MainForm>().AsSelf();
            builder.RegisterType<MainPresenter>()
                .WithParameter(new TypedParameter(typeof(Role), 
                 new Role { Name = "Администратор" }))
                .As<IRoleBasedPresenter>();

            builder.RegisterType<ResearcherForm>().AsSelf();
            builder.RegisterType<ResearcherPresenter>().As<IRoleBasedPresenter>().AsSelf()
                .WithParameter(new TypedParameter(typeof(Role), 
                new Role { Name = "Исследователь" }));

            builder.RegisterType<LoginForm>().AsSelf();
            builder.RegisterType<LoginPresenter>().As<ILoginPresenter>();

            builder.RegisterType<PresentersWorker>().AsSelf();

            return builder.Build();
        }
    }
}