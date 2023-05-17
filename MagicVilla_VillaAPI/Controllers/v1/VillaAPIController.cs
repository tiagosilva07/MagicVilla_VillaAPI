
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dtos;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using MagicVilla_VillaAPI.Repositories.IRepositories;
using System.Net;
using Microsoft.AspNetCore.Authorization;

namespace MagicVilla_VillaAPI.Controllers.v1
{
    [Route("api/v{version:apiVersion}/VillaAPI")]
    [ApiController]
    [ApiVersion("1.0")]
    public class VillaAPIController : ControllerBase
    {
        protected APIResponse _result;
        private readonly IVillaRepository _db;
        private readonly IMapper _mapper;

        public VillaAPIController(IVillaRepository db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            _result = new();
        }

        [HttpGet]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<APIResponse>> GetVillas()
        {
            var villas = await _db.GetAllAsync();
            _result.Result = _mapper.Map<List<VillaDTO>>(villas);
            _result.StatusCode = HttpStatusCode.OK;
            _result.IsSuccess = true;
            return Ok(_result);
        }

        [HttpGet("{id:int}", Name = "GetVilla")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var villa = await _db.GetAsync(x => x.Id == id);

            if (villa == null)
                return NotFound();

            _result.Result = _mapper.Map<VillaDTO>(villa);
            _result.StatusCode = HttpStatusCode.OK;
            _result.IsSuccess = true;
            return Ok(_result);
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> CreateVilla([FromBody] VillaCreateDTO createDTO)
        {
            if (await _db.GetAsync(v => v.Name.ToLower() == createDTO.Name.ToLower()) != null)
            {
                ModelState.AddModelError("ErrorMessages", "The villa already exists");
                return BadRequest(ModelState);
            }

            if (createDTO == null)
            {
                return BadRequest(createDTO);
            }

            Villa model = _mapper.Map<Villa>(createDTO);

            await _db.CreateAsync(model);

            _result.Result = _mapper.Map<VillaDTO>(model);
            _result.StatusCode = HttpStatusCode.Created;
            _result.IsSuccess = true;

            return CreatedAtRoute("GetVilla", new { id = model.Id }, _result);
        }

        [HttpDelete("{id:int}", Name = "DeleteVilla")]
        [Authorize(Roles = "admin")]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<APIResponse>> DeleteVilla(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var villa = await _db.GetAsync(v => v.Id == id);

            if (villa == null)
            {
                return NotFound();
            }

            await _db.DeleteAsync(villa);
            _result.StatusCode = HttpStatusCode.NoContent;
            _result.IsSuccess = true;


            return Ok(_result);
        }

        [HttpPut("{id:int}", Name = "UpdateVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "admin")]
        public async Task<ActionResult<APIResponse>> UpdateVilla(int id, [FromBody] VillaUpdateDTO updateDTO)
        {
            if (updateDTO == null || id != updateDTO.Id)
            {
                return BadRequest();
            }

            var villa = await _db.GetAsync(v => v.Id == id, false);

            var updatedVilla = _mapper.Map<Villa>(updateDTO);

            await _db.UpdateAsync(updatedVilla);

            _result.StatusCode = HttpStatusCode.NoContent;
            _result.IsSuccess = true;


            return Ok(_result);
        }

        [HttpPatch("{id:int}", Name = "UpdatePartialVilla")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [Authorize(Roles = "admin")]
        public async Task<IActionResult> UpdatePartialVilla(int id, JsonPatchDocument<VillaUpdateDTO> patchDTO)
        {
            if (patchDTO == null || id == 0)
            {
                return BadRequest();
            }

            var villa = await _db.GetAsync(v => v.Id == id, tracked: false);

            if (villa == null)
            {
                return BadRequest();
            }

            var villaUpdateDTO = _mapper.Map<VillaUpdateDTO>(villa);
            patchDTO.ApplyTo(villaUpdateDTO, ModelState);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }


            var updatedVilla = _mapper.Map<Villa>(villaUpdateDTO);

            await _db.UpdateAsync(updatedVilla);


            return NoContent();
        }

    }
}
