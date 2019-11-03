using System;
using UnityEngine;
using Microsoft.MixedReality.Toolkit;

namespace Services
{
	[MixedRealityServiceProfile(typeof(IDataService))]
	[CreateAssetMenu(fileName = "DataServiceProfile", 
        menuName = "MixedRealityToolkit/DataService Configuration Profile")]
	public class DataServiceProfile : BaseMixedRealityProfile
	{
        [SerializeField]
        private string _dataUrl;

        public string DataUrl => _dataUrl;
    }
}