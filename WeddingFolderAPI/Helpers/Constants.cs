using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WeddingFolderAPI.Helpers
{
    public class Constants
    {

        public static class Strings
        {
            public static class JwtClaimIdentifiers
            {

                
                public const string Rol =  "rol";
                public const string Hacker = "hackerman";
                public const string Id = "id";
                
            }

            public static class JwtClaims
            {
                public const string ApiAccess = "api_access";
                public const string HackerAccess = "hacker_access";
            }
        }
    }
}
