using System.Net.Mail;
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("123joao@gmail.com", "ddd123", "Anthony");

        Console.WriteLine("Menu:\n1 - Cadastro\n2 - Login\n3 - Exclusão de conta\n4 - Alteração dados\n5 - Sair");
        
        int op = int.Parse(Console.ReadLine());

        switch(op){
            case 1:
              Console.Write("Nome completo: ");
                string nomeCompleto = Console.ReadLine();
            Console.Write("Email: ");
                string Email = Console.ReadLine();
            Console.Write("Senha: ");
                string Senha = Console.ReadLine();
                
                User user2 = new User(nomeCompleto, Email, Senha);
            
                break;
            case 2:

                break;
            case 3:
                break;
            case 4:                                      
                break;
            case 5:
                Environment.Exit(0);
                break;
            default:
                Console.WriteLine("Opção Inválida!");
                break;
        }
    
    }
}
