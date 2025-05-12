using System;
using System.Collections.Generic;

public class UserRepository{
    List<User> Users = new List<User>(); 
    /* Terminar de fazer o sitema de armazenamento de dados */ 
     

    public void AddUser(){
            
            }   
    
    public void ShowUsers(){
        foreach(User User in Users){
            Console.WriteLine($"{User.nome} - {User.email}");
        }
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