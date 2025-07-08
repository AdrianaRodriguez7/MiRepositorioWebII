using apiServicio.Business.Clases;
using apiServicio.Business.Contracts;
using apiServicio.Models;

namespace apiServicio.Business.Clases
{
    public class RolService : IRolService
    {
        private readonly apiServicio.Business.Contracts.IRolRepository _IRolRepository;

        public RolService(apiServicio.Business.Contracts.IRolRepository tempI)
        {
            _IRolRepository = tempI;
        }

        public Task<List<Rol>> GetList()
        {
            return _IRolRepository.GetList();
        }

        public Task<Rol> AgregaActualiza(Rol l, string t)
        {
            return _IRolRepository.AgregaActualiza(l, t);
        }
    }
}
