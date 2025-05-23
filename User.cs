using System.Diagnostics.Contracts;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;


public class User
{
    private static int proximoId = 1;
    public int Id { get; }
    public string nome { get; private set; }
    public string email { get; private set; }
    private string senhaHash;

    public User(string nome, string email, string senha)
    {
        Id = proximoId++;
        this.nome = nome;
        this.email = email;
        this.senhaHash = HashHelper.GerarHash(senha);
    }

    public void AtualizarDados(string novoNome, string novoEmail)
    {
        nome = novoNome;
        email = novoEmail;
    }

    public bool ValidarSenha(string senha)
    {
        return senhaHash == HashHelper.GerarHash(senha);
    }
    public static bool ValidarEmail(string email)
    {
        string regex = @"^([\w\.\-]+)@([\w\-]+)\.([\w]{2,})+";
        if (email == null)
        {
            return false;
        }

        return Regex.IsMatch(email, regex);
    }
}
