using Intersoft.Crosslight;
using Intersoft.Crosslight.WinRT;
using ServicesSamples.Infrastructure;

namespace ServicesSamples.WinRT.Infrastructure
{
    public sealed class AppInitializer : IApplicationInitializer
    {
        #region Methods

        public IApplicationService GetApplicationService(IApplicationContext context)
        {
            return new ServicesSamplesAppService(context);
        }

        public void InitializeApplication(IApplicationHost appHost)
        {
        }

        public void InitializeComponents(IApplicationHost appHost)
        {
        }

        public void InitializeServices(IApplicationHost appHost)
        {
            ServiceProvider.AddService<IApplicationStateService, ApplicationStateService>();
        }

        #endregion
    }
}