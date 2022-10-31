using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NZWalks.API.Models.DTO;
using NZWalks.API.Repositories;

namespace NZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class RegionsController : ControllerBase
    {
        private readonly IRegionRepository regionRepository;
        private readonly IMapper mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this.regionRepository = regionRepository;
            this.mapper = mapper;
        }

        [HttpGet ]
        public async Task<IActionResult> GetAllRegions()
        {
            var regions = await regionRepository.GetAllRegionsAsync();
            //var regionsDTO = new List<Region>();
            //regions.ToList().ForEach(region =>
            //{
            //    var regionDTO = new Region()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population
            //    };
            //    regionsDTO.Add(regionDTO);
            //});
            
            //Implementation using Automapper
            var regionsDTO = mapper.Map<List<Region>>(regions);
            return Ok(regionsDTO);
        }
    }
}
