using Domain.Entities;
using Infrastructure.Interfaces.MarvelService;

namespace Application.Services
{
    public class CreatorService 
    {
        private readonly IMarvelService _marvelService;

        public CreatorService(IMarvelService marvelService)
        {
            _marvelService = marvelService;
        }

        public async Task<List<Creator>> GetCreatorsAsync()
        {
            var creatorResults = await _marvelService.GetCreatorsAsync();
            var creators = creatorResults.Select(x => new Creator { Id = x.Id, FullName = x.FullName });
            
            foreach (var result in creators)
            {
                    Console.WriteLine(result);
            }
           return creators.ToList();
        }
    }
}
