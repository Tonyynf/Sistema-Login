using System.Net.Mail;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.ComponentModel;


public class Program
{
    static void Main(string[] args)
    {
        var userRepository = new UserRepository();
        
        while (true)
        {
            Console.WriteLine("Menu:\n1 - Cadastro\n2 - Mostrar lista de usuarios\n3 - Exclusão de conta\n4 - Alteração dados\n5 - Login\n6 - Sair\n");

            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Nome completo: ");
                    string nomeCompleto = Console.ReadLine();
                    Console.Write("Email: "); 
                    string Email = Console.ReadLine();
                    if (!User.ValidarEmail(Email)){
                        Console.WriteLine("\nO email precisa conter o @! Tente novamente.");
                        break;
                    }
                    Console.Write("Senha: ");
                    string Senha = Console.ReadLine();

                    userRepository.AddUser(nomeCompleto, Email, Senha);
                    break;
                case 2:
                    userRepository.ShowUsers();
                    break;
                case 3:
                    Console.Write("Digite o número do seu id: ");
                    int id = int.Parse(Console.ReadLine());
                    userRepository.DeleteUser(id);
                    break;
                case 4:
                    Console.Write("Digite o número do seu id: ");
                    int idUser = int.Parse(Console.ReadLine());

                    Console.Write("Digite um novo nome: ");
                    string novoNome = Console.ReadLine();

                    Console.Write("Digite um novo email: ");
                    string novoEmail = Console.ReadLine();

                    if (!User.ValidarEmail(novoEmail))
                    {
                        Console.WriteLine("\nO email precisa conter o @! Tente novamente.");
                        break;
                    }
                    userRepository.UpdateUser(idUser, novoNome, novoEmail);
                    break;
                case 5:
                    Console.WriteLine("Login");
                    Console.Write("Digite seu email: ");
                    string EmailLogin = Console.ReadLine();
                    Console.Write("Digite sua senha: ");
                    string SenhaLogin = Console.ReadLine();

                    userRepository.LoginUser(EmailLogin,SenhaLogin);
                    break;
                case 6:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("\nOpção Inválida!");
                    break;
            }
            Console.WriteLine("\nPressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
