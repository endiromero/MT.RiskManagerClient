// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MarginTrading.RiskManagerClient.Models
{
    using MarginTrading.RiskManagerClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class PVaRConcentrationMonitorResponse
    {
        /// <summary>
        /// Initializes a new instance of the PVaRConcentrationMonitorResponse
        /// class.
        /// </summary>
        public PVaRConcentrationMonitorResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the PVaRConcentrationMonitorResponse
        /// class.
        /// </summary>
        public PVaRConcentrationMonitorResponse(double takerPVaR, double makerPVaR, bool isSoftLimitSet, bool isHardLimitSet, bool isSoftLimitBreached, bool isHardLimitBreached, string makerCounterPartyId = default(string), string traderCounterPartyId = default(string), double? softLimitPercentage = default(double?), double? hardLimitPercentage = default(double?), double? treshold = default(double?))
        {
            TakerPVaR = takerPVaR;
            MakerPVaR = makerPVaR;
            MakerCounterPartyId = makerCounterPartyId;
            TraderCounterPartyId = traderCounterPartyId;
            SoftLimitPercentage = softLimitPercentage;
            HardLimitPercentage = hardLimitPercentage;
            Treshold = treshold;
            IsSoftLimitSet = isSoftLimitSet;
            IsHardLimitSet = isHardLimitSet;
            IsSoftLimitBreached = isSoftLimitBreached;
            IsHardLimitBreached = isHardLimitBreached;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "takerPVaR")]
        public double TakerPVaR { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "makerPVaR")]
        public double MakerPVaR { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "makerCounterPartyId")]
        public string MakerCounterPartyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "traderCounterPartyId")]
        public string TraderCounterPartyId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "softLimitPercentage")]
        public double? SoftLimitPercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hardLimitPercentage")]
        public double? HardLimitPercentage { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "treshold")]
        public double? Treshold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSoftLimitSet")]
        public bool IsSoftLimitSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isHardLimitSet")]
        public bool IsHardLimitSet { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isSoftLimitBreached")]
        public bool IsSoftLimitBreached { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isHardLimitBreached")]
        public bool IsHardLimitBreached { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}
