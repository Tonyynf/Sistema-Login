using System.Net.Mail;

public class Program
{
    static void Main(string[] args)
    {
        User user1 = new User("123joao@gmail.com", "ddd123", "Anthony");
        //teste
        Console.WriteLine("Digite uma senha: ");
        string senha1 = Console.ReadLine();

        Console.WriteLine("Digite a mesma senha novamente senha: ");
        string senha2 = Console.ReadLine();

        string hash1 = HashHelper.GerarHash(senha1);

        string hash2 = HashHelper.GerarHash(senha2);

        Console.WriteLine($"\nHash 1: {hash1}");
        Console.WriteLine($"Hash 2: {hash2}");

        if (hash1 == hash2)
        {
            Console.WriteLine("Hashs iguais");
        }
        else
        {
            Console.WriteLine("Hashs diferentes");
        }
        //string senhaSolicitada = Console.ReadLine();
        /* Colocar metodo para gerar hash*/
        Console.WriteLine(user1.nome + " " + user1.email);
    }
}
