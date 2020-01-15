

namespace SocialNetwork.src.servicesinterfaces.services
{
    public class ApprovedComment : ICommentService
    {
        

        public string Content {get;}

        public string PostedBy {get;}

    


         public ApprovedComment(string content, string postedBy)
        {
            Content = content;
            PostedBy = postedBy;
            
            
        }

        
    }
}