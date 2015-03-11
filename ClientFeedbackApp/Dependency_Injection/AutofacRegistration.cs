using Autofac;
using ClientFeedbackApp.DataLayer;

namespace ClientFeedbackApp.Dependency_Injection
{
    public class AutofacRegistration
    {
        public static void RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<ClientFeedbackRepository>().As<IClientFeedbackRepository>();
        }
    }
}