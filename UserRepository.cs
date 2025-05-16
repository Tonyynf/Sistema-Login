using System;
using System.Collections.Generic;

public class UserRepository
{
    List<User> Users = new List<User>();

    public void AddUser(string nomeCompleto, string email, string senha)
    {
        Users.Add(new User(nomeCompleto, email, senha));
        Console.WriteLine("Usuário cadastrado!");
    }

    public void ShowUsers()
    {
        if (Users.Count == 0)
        {
            Console.WriteLine("Nenhum usuário cadastrado.");
        }
        else
        {
            Console.WriteLine("ID - Nome - Email");
            foreach (User User in Users)
            {
                Console.WriteLine($"{User.Id} - {User.nome} - {User.email}");
            }
        }
        //Fazer aviso caso não possua usuarios
    }

    public void UpdateUser(int id)
    {

    }

    public void DeleteUser(int id)
    {
        var user = Users.Find(user => user.Id == id);

        if (user != null)
        {
            Users.RemoveAt(id);
            Console.WriteLine("Usuário excluido!");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado!");
        }
    }
}