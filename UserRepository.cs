using System;
using System.Collections.Generic;
using System.Reflection;

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
            Console.WriteLine("ID | Nome | Email");
            foreach (User User in Users)
            {
                Console.WriteLine($"{User.Id} - {User.nome} - {User.email}");
            }
        }
    }

    public void UpdateUser(int id, string nome, string email)
    {
        var user = Users.Find(user => user.Id == id);
        if (user == null)
        {
            Console.WriteLine("Usuário não encontrado.");
            return;
        }
        user.AtualizarDados(nome,email);
        Console.WriteLine("Usuário atualizado!");
    }

    public void DeleteUser(int
    id)
    {
        var user = Users.Find(user => user.Id == id);

        if (user != null)
        {
            Users.Remove(user);
            Console.WriteLine("Usuário excluido!");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado!");
        }
    }

    public void LoginUser(string email, string senha)
    {
        var user = Users.Find(user => user.email == email && user.ValidarSenha(senha));

        if (user != null)
        {
            Console.WriteLine($"Bem-vindo, {user.nome}!");
        }
        else
        {
            Console.WriteLine("Usuário não encontrado!");
        }
        
    }
}