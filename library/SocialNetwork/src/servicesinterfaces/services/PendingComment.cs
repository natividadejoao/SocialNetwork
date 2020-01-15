
namespace SocialNetwork.src.servicesinterfaces.services
{
    public class PendingComment :ICommentService{
       

        public string Content {get;}

        public string PostedBy {get;}

        


         public PendingComment(string content, string postedBy)
        {
            Content = content;
            PostedBy = postedBy;
            
            
        }

    }
}