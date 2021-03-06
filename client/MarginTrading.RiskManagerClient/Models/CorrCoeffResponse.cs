// Code generated by Microsoft (R) AutoRest Code Generator 1.2.2.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace MarginTrading.RiskManagerClient.Models
{
    using MarginTrading.RiskManagerClient;
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CorrCoeffResponse
    {
        /// <summary>
        /// Initializes a new instance of the CorrCoeffResponse class.
        /// </summary>
        public CorrCoeffResponse()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CorrCoeffResponse class.
        /// </summary>
        public CorrCoeffResponse(double calculatedValue, bool overridden, string assetX = default(string), string assetY = default(string), double? overriddenValue = default(double?))
        {
            AssetX = assetX;
            AssetY = assetY;
            CalculatedValue = calculatedValue;
            Overridden = overridden;
            OverriddenValue = overriddenValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assetX")]
        public string AssetX { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "assetY")]
        public string AssetY { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "calculatedValue")]
        public double CalculatedValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overridden")]
        public bool Overridden { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddenValue")]
        public double? OverriddenValue { get; set; }

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
