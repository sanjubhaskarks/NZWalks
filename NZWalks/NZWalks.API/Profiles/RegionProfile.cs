using AutoMapper;


namespace NZWalks.API.Profiles
{
    public class RegionProfile: Profile
    {
        public RegionProfile()
        {
            CreateMap<Models.DTO.Region, Models.Domain.Region>().ReverseMap();
        }
    }
}
