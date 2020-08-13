using AutoMapper;
using SInterview.API.Resources;
using SInterview.DataAccessLayer;

namespace SInterview.API
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Candidate, CandidateResource>();

            CreateMap<CandidateResource, Candidate>();
        }
    }
}
