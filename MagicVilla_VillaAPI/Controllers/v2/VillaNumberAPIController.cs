using MagicVilla_VillaAPI.Models.Dtos;
using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using MagicVilla_VillaAPI.Repositories.IRepositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace MagicVilla_VillaAPI.Controllers.v2
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("2.0")]
    public class VillaNumberAPIController : ControllerBase
    {
        private readonly IVillaNumberRepository _db;
        private readonly IVillaRepository _dbVillas;
        private readonly IMapper _mapper;
        protected APIResponse _result;

        public VillaNumberAPIController(IVillaNumberRepository db, IMapper mapper, IVillaRepository dbVillas)
        {
            _db = db;
            _mapper = mapper;
            _dbVillas = dbVillas;
            _result = new APIResponse();

        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<APIResponse>> GetVillaNumbers()
        {
            var villaNumberList = await _db.GetAllAsync(includeProperties: "Villa");
            _result.Result = _mapper.Map<List<VillaNumberDTO>>(villaNumberList);
            _result.StatusCode = HttpStatusCode.OK;
            _result.IsSuccess = true;
            return Ok(_result);
        }

 
    }
}
