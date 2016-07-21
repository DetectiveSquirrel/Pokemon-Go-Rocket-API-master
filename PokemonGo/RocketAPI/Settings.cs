using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGo.RocketAPI
{
    public static class Settings
    {
        //Fetch these settings from intercepting the /auth call in headers and body (only needed for google auth)
        public const bool UsePTC = true; // Change this to true if you want to use Pokemon Trainer Club account.
        public const string PtcUsername = "usrname"; // Change this to your pokemon trainer club account username
        public const string PtcPassword = "password"; // Change this to your pokemon trainer club account password
        public const string DeviceId = "SM-G925F";
        public const string Email = "fake@gmail.com";
        public const string ClientSig = "fake";
        public const string LongDurationToken = "fakeid";
        public const double DefaultLatitude = -36.81207636022354;
        public const double DefaultLongitude = 174.72496390342712;

    }
}
