using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Networking.Connectivity;

namespace getBing
{
    public class NetworkUtils
    {
        public static bool IsInternetConnected()
        {
            return NetworkInformation.GetInternetConnectionProfile() != null;
        }

        public static bool IsInternetConnectedByWWAN()
        {
            ConnectionProfile profile = NetworkInformation.GetInternetConnectionProfile();
            if (profile == null)
                return false;
            return profile.IsWwanConnectionProfile;
        }
    }
}
