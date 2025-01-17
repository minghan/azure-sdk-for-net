// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Avs.Models
{
    /// <summary> Administrative credentials for accessing vCenter and NSX-T. </summary>
    public partial class AdminCredentials
    {
        /// <summary> Initializes a new instance of AdminCredentials. </summary>
        internal AdminCredentials()
        {
        }

        /// <summary> Initializes a new instance of AdminCredentials. </summary>
        /// <param name="nsxtUsername"> NSX-T Manager username. </param>
        /// <param name="nsxtPassword"> NSX-T Manager password. </param>
        /// <param name="vCenterUsername"> vCenter admin username. </param>
        /// <param name="vCenterPassword"> vCenter admin password. </param>
        internal AdminCredentials(string nsxtUsername, string nsxtPassword, string vCenterUsername, string vCenterPassword)
        {
            NsxtUsername = nsxtUsername;
            NsxtPassword = nsxtPassword;
            VCenterUsername = vCenterUsername;
            VCenterPassword = vCenterPassword;
        }

        /// <summary> NSX-T Manager username. </summary>
        public string NsxtUsername { get; }
        /// <summary> NSX-T Manager password. </summary>
        public string NsxtPassword { get; }
        /// <summary> vCenter admin username. </summary>
        public string VCenterUsername { get; }
        /// <summary> vCenter admin password. </summary>
        public string VCenterPassword { get; }
    }
}
