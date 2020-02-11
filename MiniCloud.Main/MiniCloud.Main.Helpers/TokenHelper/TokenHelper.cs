using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JWT.Algorithms;
using JWT.Builder;
using Microsoft.Extensions.Options;
using MiniCloud.Main.Helpers.Config;

namespace MiniCloud.Main.Helpers.TokenHelper
{
    public class TokenHelper : ITokenHelper
    {
        private readonly IOptions<TokenConfig> _config;

        public TokenHelper(IOptions<TokenConfig> config)
        {
            _config = config;
        }

        public string Generate(Dictionary<string, object> payload)
        {
            var token = new JwtBuilder()
                .WithAlgorithm(new HMACSHA512Algorithm())
                .WithSecret(_config.Value.Secret)
                .AddClaim("exp", DateTimeOffset.UtcNow.AddHours(1).ToUnixTimeSeconds())
                .AddClaims(payload.ToList())
                .Encode();
            return token;
        }
    }
}
