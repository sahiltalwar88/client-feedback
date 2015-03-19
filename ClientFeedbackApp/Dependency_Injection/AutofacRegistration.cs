using Autofac;
using ClientFeedbackApp.DataLayer;
using ClientFeedbackApp.DataLayer.EntityFramework;

namespace ClientFeedbackApp.Dependency_Injection
{
    public class AutofacRegistration
    {
        public static void RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<ClientFeedbackContext>().As<IClientFeedbackContext>();
        }
    }
}