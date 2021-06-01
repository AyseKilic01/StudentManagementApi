using Ninject.Modules;

namespace StudentManagementApi.Models.Business.DependecnyResolvers
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
           // Bind<IService>().To<CourseManager>();
        }
    }
}