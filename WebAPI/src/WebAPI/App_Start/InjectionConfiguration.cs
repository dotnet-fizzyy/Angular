using System;
using AutoMapper;
using Ninject.Modules;
using Ninject.Web.Common;
using WebAPI.Application.Repositories;
using WebAPI.Application.Services.Commands;
using WebAPI.Application.Services.Queries;
using WebAPI.ApplicationLogic;
using WebAPI.ApplicationLogic.Services;
using WebAPI.Core.Interfaces.Repository;
using WebAPI.Core.Interfaces.Services;
using WebAPI.Infrastructure.Database.Repositories;
using WebAPI.Infrastructure.MSSQL.Repository;

namespace WebAPI.App_Start
{
	public sealed class InjectionConfiguration : NinjectModule
    {
        public override void Load()
        {
            // Repositories
            this.Bind<IUserRepository>().To<UserRepository>().InRequestScope();
            this.Bind<ITeamRepository>().To<TeamRepository>().InRequestScope();
            this.Bind<IStoryRepository>().To<StoryRepository>().InRequestScope();
            this.Bind<ISprintRepository>().To<SprintRepository>().InRequestScope();
            this.Bind<IEpicRepository>().To<EpicRepository>().InRequestScope();
            this.Bind<IProjectRepository>().To<ProjectRepository>().InRequestScope();


            this.Bind<IEpicReadOnlyRepository>().To<EpicReadOnlyRepository>().InRequestScope();
            this.Bind<IEpicWriteOnlyRepository>().To<EpicWriteOnlyRepository>().InRequestScope();

            this.Bind<IProjectReadOnlyRepository>().To<ProjectReadOnlyRepository>().InRequestScope();
            this.Bind<IProjectWriteOnlyRepository>().To<ProjectWriteOnlyRepository>().InRequestScope();

            this.Bind<ISprintReadOnlyRepository>().To<SprintReadOnlyRepository>().InRequestScope();
            this.Bind<ISprintWriteOnlyRepository>().To<SprintWriteOnlyRepository>().InRequestScope();

            this.Bind<IStoryReadOnlyRepository>().To<StoryReadOnlyRepository>().InRequestScope();
            this.Bind<IStoryWriteOnlyRepository>().To<StoryWriteOnlyRepository>().InRequestScope();

            this.Bind<ITeamReadOnlyRepository>().To<TeamReadOnlyRepository>().InRequestScope();
            this.Bind<ITeamWriteOnlyRepository>().To<TeamWriteOnlyRepository>().InRequestScope();

            this.Bind<IUserReadOnlyRepository>().To<UserReadOnlyRepository>().InRequestScope();
            this.Bind<IUserWriteOnlyRepository>().To<UserWriteOnlyRepository>().InRequestScope();

            // Services
            this.Bind<IProjectService>().To<ProjectService>().InRequestScope();
            this.Bind<ITeamService>().To<TeamService>().InRequestScope();
            this.Bind<ISprintService>().To<SprintService>().InRequestScope();
            this.Bind<IEpicService>().To<EpicService>().InRequestScope();
            this.Bind<IStoryService>().To<StoryService>().InRequestScope();
            this.Bind<IRequestHeadersProvider>().To<RequestHeadersProvider>().InRequestScope();


            this.Bind<IEpicReadOnlyUseCase>().To<EpicReadOnlyUseCase>().InRequestScope();
            this.Bind<IEpicWriteOnlyUseCase>().To<EpicWriteOnlyUseCase>().InRequestScope();

            this.Bind<IUserCommandsUseCase>().To<UserCommandsUserCase>().InRequestScope();
            this.Bind<IUserQueriesUseCase>().To<UserQueriesUseCase>().InRequestScope();

            // Mappers
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.AddMaps(AppDomain.CurrentDomain.GetAssemblies());
            });

            this.Bind<IMapper>().ToConstructor(c => new Mapper(mapperConfig)).InSingletonScope();
        }
    }
}
