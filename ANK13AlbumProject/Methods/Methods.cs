using System.Security.Cryptography;
using System.Text;

namespace ANK13AlbumProject.Functions
{
    public static class Methods
    {
        public static string Sha256Hash(string sifre)
        {
            using (SHA256 hash = SHA256.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.GetBytes(sifre)).Select(l => l.ToString("X2")));
            }
        }

        public static bool PasswordControl(string sifre)
        {
            char[] ozelKarakterler = { '!', '+', ':', '*' };
            if (sifre.Length < 8)
                return false;
            if (sifre.Count(c => Char.IsUpper(c)) < 2)
                return false;
            if (sifre.Count(c => Char.IsLower(c)) < 3)
                return false;
            if (sifre.Count(c => ozelKarakterler.Contains(c)) < 2)
                return false;

            return true;
        }


    }
}
