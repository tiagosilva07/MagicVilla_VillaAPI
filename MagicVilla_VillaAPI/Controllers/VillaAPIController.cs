using MagicVilla_VillaAPI.Data;
using MagicVilla_VillaAPI.Models;
using MagicVilla_VillaAPI.Models.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MagicVilla_VillaAPI.Controllers
{

    public class VillaAPIController : BaseApiController
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaDataStore.VillaList;
        }

        [HttpGet ("{id:int}")]
        public VillaDTO GetVilla(int id) 
        { 
            return VillaDataStore.VillaList.FirstOrDefault(x => x.Id == id);
        }
    }
}
