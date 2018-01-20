namespace PhotoShare.Services.Contracts
{
    public interface IAlbumService
    {
        string CreateAlbum(string username, string albumTitle, string color, params string[] tags);

        string UploadPicture(string albumName, string pictureTitle, string pictureFilePath);

        string ShareAlbum(int albumId, string username, string permission);
    }
}
