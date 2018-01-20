namespace PhotoShare.Services.Contracts
{
    public interface IFriendService
    {
        string AddFriend(string firstUsername, string secondUsername);

        string AcceptFriend(string firstUsername, string secondUsername);

        string ListFriends(string username);
    }
}
