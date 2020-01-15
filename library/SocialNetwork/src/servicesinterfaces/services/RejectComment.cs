

namespace SocialNetwork.src.servicesinterfaces.services
{
    public class RejectComment : ICommentService
    {
       
        public string Content {get;}

        public string PostedBy {get;}

    

         public RejectComment(string content, string postedBy)
        {
            Content = content;
            PostedBy = postedBy;
            
            
        }
    }
}