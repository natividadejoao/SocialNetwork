//using System.Collections.Generic;
using System;
using System.Collections.Generic;
using MongoRepository;
using MongoDB.Bson.Serialization.Attributes;
using SocialNetwork.src.entitiesinterfaces.entitiesExtensionMethods;



namespace SocialNetwork.src.entitiesinterfaces.entities
{   [CollectionName("RegisterUser")]
    
    public class RegisterUser : Entity,IUser,IUserActions{
        [BsonId]
       public string id {get;set;}
        public string name {get;set;}

        public string surname {get;set;}

        public string birthDate {get;set;}

        public string email {get;set;}

        public string password {get;set;}

        public string phoneNumber {get;}
         [BsonIgnoreIfNull]
        public List<IAlbum> albuns {get;set;}
        private RegisterUser(string name, string surname, string birthDate, string email, string password, string phoneNumber,
         List<IAlbum> albuns)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
            this.albuns = albuns;
        }

        public static RegisterUser NeedValues(string name, string surname, string birthDate, string email, string password, string phoneNumber,
         List<IAlbum> albuns){
            var self = !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && (!string.IsNullOrEmpty(birthDate) &&
            DateTime.Now.Year - DateTime.Parse(birthDate).Year > 17) && (!string.IsNullOrEmpty(password) && password.Length == 8 ) 
            && (!string.IsNullOrEmpty(phoneNumber) && phoneNumber.Length == 9) && (albuns.Count > 0) ?
            new RegisterUser(name,surname,birthDate,email,password,phoneNumber,albuns) : 
            new RegisterUser("invalid","invalid","invalid","invalid","invalid",
            "invalid",null);
            return self;
        }

        public ( IComment b, IAlbum c) ChooseToActionsOnAlbum(IUser a, string content, string action)
        {
            Func<IUser,string,(IComment,IAlbum)> commentingAlbum = (a,content) => Commenting.PostCommentOnAlbum(a,content);
          
            if(action == "commentingAlbum") return  commentingAlbum(a,content);
            if(string.IsNullOrEmpty(action)) return commentingAlbum(a = null,content = null) ;
            return commentingAlbum(a = null,content = null) ;
        }

        public (IComment b,IComment c) ChooseToActionsOnComment(IUser a ,string content,string action){
            Func<IUser,string,(IComment,IComment)> commentingComment = (a,content) => Commenting.PostCommentOnComment(a,content);
            if(action == "commentingAlbum") return  commentingComment(a,content);
            if(string.IsNullOrEmpty(action)) return commentingComment(a = null,content = null) ;
            return commentingComment(a = null,content = null) ;
        }

 
    }
}