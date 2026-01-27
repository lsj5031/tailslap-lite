using System;
using System.Security.Cryptography;
using System.Text;

namespace TailSlap;

public static class Hashing
{
    public static string Sha256Hex(string s)
    {
        if (string.IsNullOrEmpty(s))
            return "";
        try
        {
            byte[] inputBytes = Encoding.UTF8.GetBytes(s);
            Span<byte> hash = stackalloc byte[32];
            SHA256.HashData(inputBytes, hash);
            return Convert.ToHexString(hash);
        }
        catch
        {
            return "";
        }
    }
}
