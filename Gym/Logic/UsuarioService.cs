﻿using Gym.Data;
using Gym.Entity;

namespace Gym.Logic
{
    public class UsuarioService
{
    private readonly GenericRepository<Usuario> _usuarioRepository;

    public UsuarioService()
    {
        _usuarioRepository = new GenericRepository<Usuario>(new GymDbContext());
    }

    public Response<IQueryable<Usuario>> GetAllUsuarios()
    {
        try
        {
            var usuarios = _usuarioRepository.GetAll();
            return new Response<IQueryable<Usuario>>(true, "Operación exitosa", usuarios);
        }
        catch (Exception ex)
        {
            return new Response<IQueryable<Usuario>>(false, ex.Message, null);
        }
    }

    public Response<Usuario> GetUsuarioById(int id)
    {
        try
        {
            var usuario = _usuarioRepository.GetById(id);
            if (usuario != null)
                return new Response<Usuario>(true, "Operación exitosa", usuario);
            else
                return new Response<Usuario>(false, "Usuario no encontrado", null);
        }
        catch (Exception ex)
        {
            return new Response<Usuario>(false, ex.Message, null);
        }
    }

        public Response<Usuario> GetUsuarioByCredencial(string credencial)
        {
            try
            {
                var usuario = _usuarioRepository.GetByCondition(x => x.Credencial == credencial).FirstOrDefault();
                if (usuario != null)
                    return new Response<Usuario>(true, "Operación exitosa", usuario);
                else
                    return new Response<Usuario>(false, "Usuario no encontrado", null);
            }
            catch (Exception ex)
            {
                return new Response<Usuario>(false, ex.Message, null);
            }
        }

        public Response<bool> InsertUsuario(Usuario usuario)
        {
            try
        {
                var findUser = _usuarioRepository.GetByCondition(x => x.Identificacion == usuario.Identificacion).FirstOrDefault();
                if (findUser == null)
                {
                    _usuarioRepository.Insert(usuario);
                    _usuarioRepository.Save();
                    return new Response<bool>(true, "Operación exitosa", true);
                }
                return new Response<bool>(false, "Usuario con identificacion ya registrada", false);
        }
        catch (Exception ex)
        {
            return new Response<bool>(false, ex.Message, false);
        }
    }

    public Response<bool> UpdatePagoUsuario(int id)
    {
        try
        {
            var usuario = _usuarioRepository.GetById(id);
                if (usuario != null)
                {
                    usuario.UltimoPago = DateTime.Now;

                    _usuarioRepository.Update(usuario);
                    _usuarioRepository.Save();
                    return new Response<bool>(true, "Operación exitosa", true);
                }
                    return new Response<bool>(false, "Usuario no encontrado", false);
                
        }
        catch (Exception ex)
        {
            return new Response<bool>(false, ex.Message, false);
        }
    }

        public Response<bool> UpdateUsuario(Usuario usuario)
    {
        try
        {
            _usuarioRepository.Update(usuario);
            _usuarioRepository.Save();
            return new Response<bool>(true, "Operación exitosa", true);
        }
        catch (Exception ex)
        {
            return new Response<bool>(false, ex.Message, false);
        }
    }

    public Response<bool> DeleteUsuario(int id)
    {
        try
        {
            _usuarioRepository.Delete(id);
            _usuarioRepository.Save();
            return new Response<bool>(true, "Operación exitosa", true);
        }
        catch (Exception ex)
        {
            return new Response<bool>(false, ex.Message, false);
        }
    }
}
}