using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.Entities;

namespace Application.Services
{
    public class MarvelService:IMarvelService
    {
        private readonly IMarvelService _marvelService;

        public MarvelService(IMarvelService marvelService)
        {
            _marvelService = marvelService;
        }

        public async Task<List<Creator>> GetItemsAsync<Creator>()
        {
           var creatorFound = await _marvelService.GetItemsAsync<Creator>();
            return creatorFound;
        }
    }
}
