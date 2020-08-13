using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SInterview.BusinessLogicLayer.Services;
using SInterview.DataAccessLayer;

namespace SInterview.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController : ControllerBase
    {
        private readonly ICandidateService mCandidateService;
        public CandidateController(ICandidateService candidateService)
        {
            mCandidateService = candidateService;
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Candidate> GetAllCandidatesWithPosition(string postion)
        {
            return mCandidateService.GetAllCandidatesWithPosition(postion).ToList();
        }
    }
}
