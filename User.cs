using System.Diagnostics.Contracts;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using System.Security.Cryptography;
using Microsoft.VisualBasic;


public class User{
    public string nome{get; private set;}
    public string email{ get; private set;}
    private string senhaHash;

    public User(string nome, string email, string senha){
        this.nome = nome;
        this.email = email;
        this.senhaHash = HashHelper.GerarHash(senha);
    }
}
