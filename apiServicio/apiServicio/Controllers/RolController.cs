using apiServicio.Business.Contracts;
using apiServicio.Models;
using Microsoft.AspNetCore.Mvc;

namespace apiServicio.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : ControllerBase
    {
        private readonly IRolService _IRolService;

        public RolController(IRolService iTemp)
        {
            _IRolService = iTemp;
        }

        [HttpGet("GetList")]
        public async Task<List<Rol>> GetList()
        {
            return await _IRolService.GetList();
        }

        [HttpPost("AgregaActualiza")]
        public async Task<Rol> AgregaActualiza(int Id, string NombreRol, string t)
        {
            Rol l = new Rol
            {
                Id = Id,
                NombreRol = NombreRol
            };
            return await _IRolService.AgregaActualiza(l, t);
        }
    }
}
