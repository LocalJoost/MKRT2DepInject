using System.Collections.Generic;
using System.Threading.Tasks;
using Json;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit;

namespace Services
{
    [MixedRealityExtensionService(SupportedPlatforms.WindowsStandalone|SupportedPlatforms.MacStandalone|SupportedPlatforms.LinuxStandalone|SupportedPlatforms.WindowsUniversal)]
    public class MockDataService : BaseExtensionService, 
                                   IDataService
    {
        public MockDataService(IMixedRealityServiceRegistrar registrar,  string name,  uint priority,  BaseMixedRealityProfile profile) : base(registrar, name, priority, profile) 
        {
        }

        public async Task<IList<DemoData>> GetNames()
        {
            var data = new List<DemoData>
            {
                new DemoData {FirstName = "Joost", LastName = "van Schaik"},
                new DemoData {FirstName = "John", LastName = "Doe"},
                new DemoData {FirstName = "Kermit", LastName = "the Frog"},
            };
            await Task.Yield();
            return data;
        }
    }
}