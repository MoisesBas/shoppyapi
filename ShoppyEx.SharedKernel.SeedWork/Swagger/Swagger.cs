﻿namespace ShoppyEx.SharedKernel.SeedWork.Swagger
{
    public class Swagger
    {
        public sealed class EndPoint
        {
            public const string Name = "ShoppyEx API {0}";
            public const string Url = "/swagger/{0}/swagger.json";
        }

        public sealed class Info
        {
            public const string ContactEmail = "test@email.com";
            public const string ContactName = "Test Contact Name";
            public const string Description = "API to serve the ShoppyEx API application.";
            public const string Title = "ShoppyEx API";
        }
        public sealed class SecurityDefinition
        {
            public const string Description = "JWT Authorization header using the Bearer scheme. Example: \"Authorization: Bearer {token}\"";
            public const string Name = "Authorization";
        }

        public sealed class Versions
        {
            public const string v1_0 = "1.0";
            public const string v1_1 = "1.1";
        }

        public sealed class DocVersions
        {
            public const string v1_0 = "v1.0";
            public const string v1_1 = "v1.1";
        }
    }
}
