﻿using apiServicio.Models;

namespace apiservicio.Business.Clases
{
    public interface IRolRepository
    {
        Task<Rol> AgregaActualiza(Rol l, string t);
        Task<List<Rol>> GetList();
    }
}