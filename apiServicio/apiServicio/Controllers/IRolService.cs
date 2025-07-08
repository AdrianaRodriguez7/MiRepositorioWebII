using apiServicio.Models;

public interface IRolService
{
    Task<Rol> AgregaActualiza(Rol l, string t);
    Task<List<Rol>> GetList();
}