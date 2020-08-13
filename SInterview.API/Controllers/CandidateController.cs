using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SInterview.API.Resources;
using SInterview.BusinessLogicLayer.Services;
using SInterview.DataAccessLayer;

namespace SInterview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService mCandidateService;
        private readonly IMapper mMapper;

        public CandidateController(ICandidateService candidateService, IMapper mapper)
        {
            mMapper = mapper;
            mCandidateService = candidateService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<CandidateResource> GetCandidates()
        {
            var candidates = mCandidateService.GetAll().ToList();
            var candidatesResource = mMapper.Map<IEnumerable<Candidate>, IEnumerable<CandidateResource>>(candidates);
            return candidatesResource;
        }
        [HttpGet]
        [Route("[action]")]
        public IEnumerable<CandidateResource> GetAllCandidatesWithPosition(string position)
        {
            var candidatesWithPosition = mCandidateService.GetAllCandidatesWithPosition(position).ToList();
            var candidatesWithPositionResource = mMapper.Map<IEnumerable<Candidate>, IEnumerable<CandidateResource>>(candidatesWithPosition);

            return candidatesWithPositionResource;
        }
    }
}
