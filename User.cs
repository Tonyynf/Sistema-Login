using Microsoft.VisualBasic;

public class User{
    public string email{ get; set;}
    public string senha{get; private set;}
    public string nome{get;set;}

    public User(string email, string senha, string nome){
        this.email = email;
        this.senha = senha;
        this.nome = nome;
    }
}