using System;
using System.Collections.Generic;
using MongoRepository;
using MongoDB.Bson.Serialization.Attributes;

namespace SocialNetwork.src.entitiesinterfaces.entities
{    [CollectionName("AlbumVideo")]
    public class AlbumVideo : Entity,IAlbum
    {
          public string albumName {get;set;}

        public string descricao {get;set;}

        public DateTime dateCreation {get;set;}

        public List<IComment> comments {get;set;}
        private AlbumVideo(string albumName, string descricao, DateTime dateCreation, List<IComment> comments)
        {
            this.albumName = albumName;
            this.descricao = descricao;
            this.dateCreation = DateTime.Now;
            this.comments = comments;
        }

        public static AlbumVideo NeedValues(string albumName,string descricao,DateTime dateCreation,List<IComment> comments){
            var self = !string.IsNullOrEmpty(albumName) && !string.IsNullOrEmpty(descricao) && (comments.Count > 0) ?
            new AlbumVideo(albumName,descricao,dateCreation,comments) : 
            new AlbumVideo("invalid","invalid",dateCreation,null);
            return self;
        }

    }
}