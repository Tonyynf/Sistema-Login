using System;
using System.Collections.Generic;

public class UserRepository{
    List<User> Users = new List<User>(); 
     
    public void AddUser(string nomeCompleto, string email, string senha){
        Users.Add(new User(nomeCompleto, email, senha));
    }   
    
    public void ShowUsers(){
        foreach(User User in Users){
            Console.WriteLine($"{User.Id} - {User.nome} - {User.email}");
        }
        //Fazer aviso caso não possua usuarios
    }
    public void SelectUser(int id){

    }

    public void UpdateUser(int id){

    }

    public void DeleteUser(int id){
        Users.RemoveAt(id);
    }

    public void DeleteAllUsers(){
        
    }

}