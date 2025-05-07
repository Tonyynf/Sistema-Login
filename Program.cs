using System.Net.Mail;

public class Program{
    static void Main(string[] args){
        User user1 = new User("123joao@gmail.com", "ddd123","Anthony");

        string senhaSolicitada = Console.ReadLine();

        user1.verificarSenha();
        Console.WriteLine(user1.nome + " " + user1.email);
    }
}
