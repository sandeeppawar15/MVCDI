using DAL;
using Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace MVCDI
{
    // public static class UnityConfig
    // {
    //     public static void RegisterComponents()
    //     {
    //var container = new UnityContainer();

    //         // register all your components with the container here
    //         // it is NOT necessary to register your controllers

    //         // e.g. container.RegisterType<ITestService, TestService>();

    //         DependencyResolver.SetResolver(new UnityDependencyResolver(container));
    //     }
    // }

    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            container.RegisterType<ICustomerRepository, CustomerRepository>();
            container.RegisterType<ICustomerService, CustomerService>();
        }
    }


}