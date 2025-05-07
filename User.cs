using System.Diagnostics.Contracts;
using System.Net.WebSockets;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class User{
    public string nome{get;set;}
    public string email{ get; set;}
    public string senha{get; private set;}
    

    public User(string nome, string email, string senha){
        this.nome = nome;
        this.email = email;
        this.senha = senha;
    }

    public void verificarSenha(){
        string senhaSolicitada = "";

        if(senhaSolicitada == senha){
            Console.WriteLine("APERTE ENTER");
        }else{
            Console.WriteLine("Senha incorreta!");
        }
    }
}