using System;
using MongoRepository;
using MongoDB.Bson.Serialization.Attributes;
namespace SocialNetwork.src.entitiesinterfaces.entities
{   
    [CollectionName("Comment")]
    public class Comment : Entity{
        [BsonId]
        public string id{get;set;}
        public string comment { get;set;}
        public DateTime postData {get;set;}   
        
        public IUser user{get;set;}

        public Comment(string comment,DateTime postData){
            this.comment = comment;
            this.postData = postData;
            
        }

        public Comment NeedValues(string content){
             var self = !string.IsNullOrEmpty(content) ? 
             new Comment(comment,DateTime.Now) : new Comment("need a context",DateTime.Now);
             return self;
        }

        
    }
}