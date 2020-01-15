using System.Collections.Generic;


namespace SocialNetwork.src.entitiesinterfaces
{
    public interface IUser {

        string name{get;}
        string surname{get;}
        string birthDate{get;}
        string email{get;}
        string password {get;}
        string phoneNumber {get;}
        List<IAlbum> albuns{get;}
       
       
    }
}