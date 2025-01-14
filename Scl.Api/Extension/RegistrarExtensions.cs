using Scl.Api.Registers;
using Scl.Api.Registrars;

namespace Scl.Api.Extension
{
    public static class RegistrarExtensions
    {
        public static void RegisterServicesExtensions(this WebApplicationBuilder builder, Type scanningType)
        {
            var registrars = GetRegistrars<IWebApplicationBuilderRegistrar>(scanningType);

            foreach (var registrar in registrars)
            {
                registrar.RegisterServices(builder); //Llama a las implementaciones de IWebApplicationBuilderRegistrar
            }
        }

        public static void RegisterPipelineComponentsExtensions(this WebApplication app, Type scanningType)
        {
            var registrars = GetRegistrars<IWebApplicationRegistrar>(scanningType);
            foreach (var registrar in registrars)
            {
                registrar.RegisterPipelineComponents(app); //Llama a las implementaciones de IWebApplicationRegistrar
            }
        }

        private static IEnumerable<T> GetRegistrars<T>(Type scanningType) where T : IRegistrar
        {
            return scanningType.Assembly.GetTypes()
                .Where(t => t.IsAssignableTo(typeof(T)) && !t.IsAbstract && !t.IsInterface)
                .Select(Activator.CreateInstance)
                .Cast<T>();
        }
    }
}
