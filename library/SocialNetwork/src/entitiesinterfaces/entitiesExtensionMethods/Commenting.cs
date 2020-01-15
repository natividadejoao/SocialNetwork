using System;
using System.Collections.Generic;

namespace SocialNetwork.src.entitiesinterfaces.entitiesExtensionMethods
{
    public static class Commenting{

        public static (IComment comment,IAlbum poster) PostCommentOnAlbum(this IUser by,string content
        ) {return (null,null);}
        
         public static (IComment comment,IComment poster) PostCommentOnComment(this IUser by,string content
        ) {return (null,null);}


     
       
    }
         
}