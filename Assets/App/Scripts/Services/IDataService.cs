using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Json;
using Microsoft.MixedReality.Toolkit;

namespace Services
{
	public interface IDataService : IMixedRealityExtensionService
    {
        Task<IList<DemoData>> GetNames();
    }
}