using System;
using System.Collections.Generic;
using System.Linq;



namespace library.BlackGame.interfaces.entities{
  
    public class Player {
       

        public string firstName { get; }
        public string lastName{get;}
        public string birthDate { get;}

         public Player(string firstName, string lastName, string birthDate){
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthDate = birthDate;
        }

          public static Player NeedValues(string firstName,string lastName,string birthDate){
            var self = !String.IsNullOrEmpty(firstName) && !String.IsNullOrEmpty(lastName) && !String.IsNullOrEmpty(birthDate)
            && DateTime.Now.Year - DateTime.Parse(birthDate).Year > 18 ?
            new Player(firstName.ToUpper(),lastName.ToLower(),birthDate) : new Player(firstName = "Invalid name",
            lastName = "invalid lastName",birthDate = "invalid birthdate");
            return self;
        }

        public List<string> ChooseActionPlayer(List<string> players, string x){
            Func<List<string>,List<string>> getAllFullName = (players) => {
                var listaNames = players.Where(elem => !elem.Contains("/")).ToList();
                 return new List<string>(){String.Join(" ", listaNames)};
            };     
           
            
            if(x == "getAllFullName")  return getAllFullName(players);
          //if(x == "getFullName") return getFullName(players);
            if(String.IsNullOrEmpty(x) ) return new List<string>(){"Choose a method"};
            return new List<string>(){"Método not found"};
        }
    }
        
      

}