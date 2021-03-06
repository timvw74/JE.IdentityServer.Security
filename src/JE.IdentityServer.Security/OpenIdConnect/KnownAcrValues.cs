﻿using JE.IdentityServer.Security.Resources;

namespace JE.IdentityServer.Security.OpenIdConnect
{
    public class KnownAcrValues
    {
        public string OsVersion { get; set; }

        public string RecaptchaResponse { get; set; }

        public string Language { get; set; }

        public IDevice Device { get; set; }

        public string Tenant { get; set; }
    }
}
