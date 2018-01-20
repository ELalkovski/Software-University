namespace PhotoShare.Services.Contracts
{
    public interface ITagService
    {
        string AddTag(string tag);

        string AddTagTo(string albumTitle, string tag);
    }
}
