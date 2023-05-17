using MagicVilla_VillaAPI.Models.Dtos;
using MagicVilla_VillaAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using MagicVilla_VillaAPI.Repositories.IRepositories;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace MagicVilla_VillaAPI.Controllers.v1
{
    [Route("api/v{version:apiVersion}/VillaNumberAPI")]
    [ApiController]
    [ApiVersion("1.0")]
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


        [HttpGet("{id:int}", Name = "GetVillaNumber")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVillaNumber(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villaNumber = await _db.GetAsync(x => x.VillaNo == id, includeProperties: "Villa");

            if (villaNumber == null)
                return NotFound();

            _result.Result = _mapper.Map<VillaNumberDTO>(villaNumber);
            _result.StatusCode = HttpStatusCode.OK;
            _result.IsSuccess = true;
            return Ok(_result);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVillaNumber([FromBody] VillaNumberCreateDTO createDTO)
        {
            if (await _db.GetAsync(v => v.VillaNo == createDTO.VillaNo) != null)
            {
                ModelState.AddModelError("ErrorMessages", "The villa number already exists");
                return BadRequest(ModelState);
            }

            if (await _dbVillas.GetAsync(v => v.Id == createDTO.VillaId) == null)
            {
                ModelState.AddModelError("ErrorMessages", "The villaNumber is Invalid");
                return BadRequest(ModelState);
            }

            if (createDTO == null)
            {
                return BadRequest(createDTO);
            }

            var model = _mapper.Map<VillaNumber>(createDTO);

            await _db.CreateAsync(model);

            _result.Result = _mapper.Map<VillaNumberDTO>(model);
            _result.StatusCode = HttpStatusCode.Created;
            _result.IsSuccess = true;

            return CreatedAtRoute("GetVillaNumber", new { id = model.VillaNo }, _result);
        }

        [HttpDelete("{id:int}", Name = "DeleteVillaNumber")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> DeleteVillaNumber(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villaNumber = await _db.GetAsync(v => v.VillaNo == id);

            if (villaNumber == null)
            {
                return NotFound();
            }

            await _db.DeleteAsync(villaNumber);
            _result.StatusCode = HttpStatusCode.NoContent;
            _result.IsSuccess = true;


            return Ok(_result);
        }

        [HttpPut("{id:int}", Name = "UpdateVillaNumber")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> UpdateVillaNumber(int id, [FromBody] VillaNumberUpdateDTO updateDTO)
        {
            try
            {
                if (updateDTO == null || id != updateDTO.VillaNo)
                {
                    return BadRequest();
                }

                if (await _dbVillas.GetAsync(v => v.Id == updateDTO.VillaId) == null)
                {
                    ModelState.AddModelError("ErrorMessages", "The villaNumber is Invalid");
                    return BadRequest(ModelState);
                }

                var villaNumber = await _db.GetAsync(v => v.VillaNo == updateDTO.VillaNo, tracked: false);

                VillaNumber updatedVillaNumber = _mapper.Map<VillaNumber>(updateDTO);
                villaNumber = updatedVillaNumber;
                await _db.UpdateAsync(villaNumber);

                _result.StatusCode = HttpStatusCode.NoContent;
                _result.IsSuccess = true;

            }
            catch (Exception ex)
            {
                _result.IsSuccess = false;
                _result.ErrorMessages = new List<string> { ex.Message };
            }

            return Ok(_result);
        }
    }
}
