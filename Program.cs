using System.Net.Mail;

public class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("123joao@gmail.com", "ddd123", "Anthony");

        Console.WriteLine("Menu:\n1 - Cadastro\n2 - Login\n3 - Exclusão de conta\n4 - Alteração dados\n5 - Sair");
        
        /* Colocar metodo para gerar hash*/
        Console.WriteLine(user1.nome + " " + user1.email);
    }
}
