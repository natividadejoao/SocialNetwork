using System;
using System.Collections.Generic;
using MongoRepository;
using MongoDB.Bson.Serialization.Attributes;

namespace SocialNetwork.src.entitiesinterfaces.entities
{    [CollectionName("AlbumFoto")]
    public class AlbumFoto : Entity,IAlbum
    {   
        [BsonId]
        public string id{get;set;}
        public string albumName {get;set;}

        public string descricao {get;set;}

        public DateTime dateCreation {get;set;}

        public List<IComment> comments {get;set;}
        private AlbumFoto(string albumName, string descricao, DateTime dateCreation, List<IComment> comments)
        {
            this.albumName = albumName;
            this.descricao = descricao;
            this.dateCreation = DateTime.Now;
            this.comments = comments;
        }

        public static AlbumFoto NeedValues(string albumName,string descricao,DateTime dateCreation,List<IComment> comments){
            var self = !string.IsNullOrEmpty(albumName) && !string.IsNullOrEmpty(descricao) && (comments.Count > 0) ?
            new AlbumFoto(albumName,descricao,dateCreation,comments) : 
            new AlbumFoto("invalid","invalid",dateCreation,null);
            return self;
        }

       
       
    }
}