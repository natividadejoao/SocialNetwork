

namespace SocialNetwork.src.entitiesinterfaces
{
    public interface IComment{  
       
       string Content {get;}
       string PostedBy{get;}
       IUser user{get;}

   
    }
}