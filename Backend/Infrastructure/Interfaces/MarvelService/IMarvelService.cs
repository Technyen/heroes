namespace Infrastructure.Interfaces.MarvelService
{
    public interface IMarvelService
    {
        Task<List<CreatorResult>> GetCreatorsAsync();
    }
}
