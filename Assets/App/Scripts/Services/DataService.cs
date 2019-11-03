using System;
using Microsoft.MixedReality.Toolkit.Utilities;
using Microsoft.MixedReality.Toolkit;

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

		public override void Initialize()
		{
			// Do service initialization here.
		}

		public override void Update()
		{
			// Do service updates here.
		}
	}
}