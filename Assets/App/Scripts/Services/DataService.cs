using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Json;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit;
using Newtonsoft.Json;

namespace Services
{
	[MixedRealityExtensionService(SupportedPlatforms.WindowsStandalone|SupportedPlatforms.MacStandalone|SupportedPlatforms.LinuxStandalone|SupportedPlatforms.WindowsUniversal)]
	public class DataService : BaseExtensionService, IDataService, IMixedRealityExtensionService
	{
		private DataServiceProfile dataServiceProfile;

		public DataService(IMixedRealityServiceRegistrar registrar,  string name,  uint priority,  BaseMixedRealityProfile profile) : base(registrar, name, priority, profile) 
		{
			dataServiceProfile = (DataServiceProfile)profile;
		}

        public async Task<IList<DemoData>> GetNames()
        {
            using (var request = new HttpRequestMessage(HttpMethod.Post, dataServiceProfile.DataUrl))
            {
                using (var client = new HttpClient())
                {
                    var response = await client.SendAsync(request);
                    response.EnsureSuccessStatusCode();
                    var result = await response.Content.ReadAsStringAsync();
                    return JsonConvert.DeserializeObject<IList<DemoData>>(result);
                }
            }
        }
    }
}