using Microsoft.AspNetCore.Mvc;
using NET7_API_TRAINING.Models;
using NET7_API_TRAINING.Models.Data;
using NET7_API_TRAINING.Models.Dto;

namespace NET7_API_TRAINING.Controllers
{
    [Route("api/VillaAPI")]
    [ApiController]
    public class VillaAPIController: ControllerBase
    {
        [HttpGet]
        public IEnumerable<VillaDTO> GetVillas()
        {
            return VillaStore.villaList;
        }

        [HttpGet("/{id}")]
        public VillaDTO GetVilla(int id)
        {
            return VillaStore.villaList.FirstOrDefault(u => u.Id == id);
        }


    }
}

