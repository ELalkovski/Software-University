namespace PhotoShare.Services.IO
{
    public class Messages
    {
        public const string WrongPassword = "Password do not match!";
        public const string ExistingUsername = "Username {0} is already taken!";
        public const string UserAddedSuccessfully = "User {0} was registered successfully!";
        public const string UserModifiedSuccessfully = "User {0} {1} is {2}.";
        public const string UsernameNotFound = "User {0} not found!";
        public const string PropertyNotSupported = "Property {0} not supported!";
        public const string InvalidValue = "Value {0} not valid.";
        public const string TownAddedSuccessfully = "Town {0} was added successfully!";
        public const string ExistingTown = "Town {0} was already added!";
        public const string TownNotFound = "Town {0} not found!";
        public const string UserAlreadyDeleted = "User {0} already deleted!";
        public const string UserDeleted = "User {0} was deleted successfully!";
        public const string ExistingTag = "Tag {0} exists!";
        public const string TagAddedSuccessfully = "Tag {0} was added successfully!";
        public const string UnexistingTagOrAlbum = "Either tag or album do not exist!";
        public const string AlbumTagAddedSuccessfully = "Tag {0} added to {1}!";
        public const string ExistingAlbum = "Album {0} exists!";
        public const string UnexistingColor = "Color {0} not found!";
        public const string UnexistingTag = "Invalid tags!";
        public const string AlbumAddedSuccessfully = "Album {0} successfully created!";
        public const string PictureAddedSuccessfully = "Picture {0} added to {1}!";
        public const string UnexistingAlbum = "Album {0} not found!";
        public const string WrongPermission = "Permission must be either \"Owner\" or \"Viewer\"!";
        public const string AlbumShared = "Username {0} added to album {1} ({2})";
        public const string FriendAddedSuccessfully = "Friend {0} added to {1}";
        public const string ExistingFriend = "{0} is already a friend to {1}";
        public const string RequestSent = "Friend request already sent!";
        public const string NoRequest = "{0} has not added {1} as a friend";
        public const string FriendshipAccepted = "{0} accepted {1} as a friend";
        public const string NoFriends = "No friends for this user. :(";
        public const string UnexistingCommand = "Command {0} not valid!";
        public const string SuccessfullLogin = "User {0} successfully logged in!";
        public const string InvalidLoginCreditentials = "Invalid username or password!";
        public const string AlreadyLogedIn = "You should logout first!";
        public const string SuccessfullLogout = "User {0} successfully logged out!";
        public const string NotLoggedin = "You should log in first in order to logout.";
        public const string InvalidCreditentials = "Invalid Creditentials";
    }
}
