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
            Console.WriteLine("Menu:\n1 - Cadastro\n2 - Mostrar lista de usuarios\n3 - Exclusão de conta\n4 - Alteração dados\n5 - Sair");
            //Adicionar no menu a opção - login -
            int op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.Write("Nome completo: ");
                    string nomeCompleto = Console.ReadLine();
                    Console.Write("Email: "); //Fazer personalização para verificar se email mesmo
                    string Email = Console.ReadLine();
                    Console.Write("Senha: ");
                    string Senha = Console.ReadLine();

                    userRepository.AddUser(nomeCompleto, Email, Senha);
                
                    break;
                case 2:
                    userRepository.ShowUsers();
                    break;
                case 3:
                    Console.Write("Digite o número do seu id: "); //Colocar tipo uma "certeza que é sua conta"
                    int id = int.Parse(Console.ReadLine());
                    userRepository.DeleteUser(id);
                    break;
                case 4:
                    //int id = int.Parse(Console.ReadLine());
                    //userRepository.UpdateUser(id); //colocar o id para criar automaticamente
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
}
