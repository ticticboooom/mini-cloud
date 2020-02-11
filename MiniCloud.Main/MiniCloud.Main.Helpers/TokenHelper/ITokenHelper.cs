using System;
using System.Collections.Generic;
using System.Text;

namespace MiniCloud.Main.Helpers.TokenHelper
{
    public interface ITokenHelper
    {
        string Generate(Dictionary<string, object> payload);
    }
}
