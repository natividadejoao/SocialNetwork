using System.Collections.Generic;
using System;

namespace SocialNetwork.src.entitiesinterfaces
{
    public interface IAlbum{

         
         string albumName{get;}
         string descricao{get;}
         DateTime dateCreation {get;}
         List<IComment> comments  {get;}
    }   
}