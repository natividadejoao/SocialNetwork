using SocialNetwork.src.repositoryinterfaces.repository;



namespace SocialNetwork.src.repositoryinterfaces
{
    public interface IMongoRepository
    {  
        RegisterUserRepo registerUserRepo {get;}
        AlbumMusicRepo albumMusicRepo {get;}
       AlbumFotoRepo albumFotoRepo {get;}
       AlbumVideoRepo albumVideoRepo {get;}

        CommentRepo commentRepo {get;}

        AdminUserRepo adminRepo{get;}
         
    }
}