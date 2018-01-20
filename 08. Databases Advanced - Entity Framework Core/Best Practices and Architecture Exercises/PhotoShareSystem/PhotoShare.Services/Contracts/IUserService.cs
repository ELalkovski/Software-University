namespace PhotoShare.Services.Contracts
{
    public interface IUserService
    {
        string RegisterUser(string username, string password, string repeatPassword, string email);

        string ModifyUser(string username, string propertyName, string newPropertyValue);

        string DeleteUser(string username);

        string Login(string username, string password);

        string Logout();
    }
}
