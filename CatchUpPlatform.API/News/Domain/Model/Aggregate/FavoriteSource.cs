namespace CatchUpPlatform.API.News.Domain.Model.Aggregate;

public class FavoriteSource
{
    protected FavoriteSource()
    {
        NewsApiKey = string.Empty;
        SourceId = string.Empty;
    }
    
    public int Id { get; }
    public string NewsApiKey { get; private set; }
    public string SourceId { get; private set; }
}