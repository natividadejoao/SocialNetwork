using System.Collections.Generic;
using System;
using MongoRepository;
using MongoDB.Bson.Serialization.Attributes;
using SocialNetwork.src.entitiesinterfaces.entitiesExtensionMethods;

namespace SocialNetwork.src.entitiesinterfaces.entities
{   [CollectionName("AdminUser")]
    public class AdminUser:Entity,IUser{   
       
        [BsonId]
        public string id{get;set;}
       public string name {get;set;}

        public string surname {get;set;}

        public string birthDate {get;set;}

        public string email {get;set;}

        public string password {get;set;}

        public string phoneNumber {get;set;}

        public List<IAlbum> albuns {get;set;}
        private AdminUser(string name, string surname, string birthDate, string email, string password, string phoneNumber)
        {
            this.name = name;
            this.surname = surname;
            this.birthDate = birthDate;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
            
        }

        public static AdminUser NeedValues(string name, string surname, string birthDate, string email, string password, string phoneNumber,
         List<IAlbum> albuns){
            var self = !string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(surname) && (!string.IsNullOrEmpty(birthDate) &&
            DateTime.Now.Year - DateTime.Parse(birthDate).Year > 17) && (!string.IsNullOrEmpty(password) && password.Length == 8 ) 
            && (!string.IsNullOrEmpty(phoneNumber) && phoneNumber.Length == 9) ?
            new AdminUser(name,surname,birthDate,email,password,phoneNumber) : 
            new AdminUser("invalid","invalid","invalid","invalid","invalid",
            "invalid");
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