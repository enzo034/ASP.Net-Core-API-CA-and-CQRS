using Scl.Api.Registrars;

namespace Scl.Api.Registers
{
    public interface IWebApplicationBuilderRegistrar : IRegistrar
    {
        void RegisterServices(WebApplicationBuilder builder);
    }
}
