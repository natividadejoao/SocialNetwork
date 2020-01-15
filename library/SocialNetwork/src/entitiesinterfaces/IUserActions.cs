using System;
namespace SocialNetwork.src.entitiesinterfaces
{
    public interface IUserActions
    {
         (IComment b,IAlbum c) ChooseToActionsOnAlbum(IUser a ,string content,string action);
         (IComment b,IComment c) ChooseToActionsOnComment(IUser a ,string content,string action);
    }
}