using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
namespace MAD.API.Procore.Endpoints.RFIs.Models {
	public class ListRFIsRequestResultCostImpact {

		/// <summary>
		/// Cost impact status
		/// </summary>
		[JsonProperty("status")]	public  string Status { get ; set; }

		/// <summary>
		/// Cost impact value in dollars
		/// </summary>
		[JsonProperty("value")]	public  decimal? Value { get ; set; }
	}
}
