using System;
using System.Collections.Generic;
using System.Text;
using Isopoh.Cryptography.Argon2;

namespace MiniCloud.Main.Helpers.Password
{
    public class PasswordHelper
    {
        public static string HashPassword(string raw)
        {
            return Argon2.Hash(raw);
        }

        public static bool VerifyPassword(string hash, string raw)
        {
            return Argon2.Verify(hash, raw);
        }
    }
}
