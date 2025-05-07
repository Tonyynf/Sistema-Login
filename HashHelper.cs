using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;

public static class HashHelper{
    public static string GerarHash(string senha){
        byte[] bytes = System.Text.Encoding.UTF8.GetBytes(senha);
        SHA256 sha256 = SHA256.Create();
        byte[] hashBytes = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hashBytes);
    }
}
