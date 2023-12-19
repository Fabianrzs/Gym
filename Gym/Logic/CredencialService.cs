using Gym.Data;
using Gym.Entity;

namespace Gym.Logic
{
    public class CredentialService
{
    private readonly GenericRepository<Credencial> _credencialRepository;

    public CredentialService()
    {
        _credencialRepository = new GenericRepository<Credencial>(new GymDbContext());
    }

    public Response<bool> RegisterUsuario(string username, string password)
    {
        try
        {
            var existingUser = _credencialRepository.GetByCondition(u => u.Usuario == username).FirstOrDefault();
            if (existingUser != null)
                return new Response<bool>(false, "El usuario ya existe", false);

            var newUser = new Credencial
            {
                Usuario = username,
                Contraseña = password
            };

            _credencialRepository.Insert(newUser);
            _credencialRepository.Save();
            return new Response<bool>(true, "Usuario registrado exitosamente", true);
        }
        catch (Exception ex)
        {
            return new Response<bool>(false, ex.Message, false);
        }
    }

    public Response<bool> ValidateUsuario(string username)
    {
        try
        {
            var existingUser = _credencialRepository.GetByCondition(u => u.Usuario == username).FirstOrDefault();
            if (existingUser != null)
                return new Response<bool>(true, "Usuario encontrado", true);
            else
                return new Response<bool>(false, "Usuario no encontrado", false);
        }
        catch (Exception ex)
        {
            return new Response<bool>(false, ex.Message, false);
        }
    }

    public Response<bool> Login(string username, string password)
    {
        try
        {
            var existingUser = _credencialRepository.GetByCondition(u => u.Usuario == username && u.Contraseña == password).FirstOrDefault();
            if (existingUser != null)
                return new Response<bool>(true, "Inicio de sesión exitoso", true);
            else
                return new Response<bool>(false, "Credenciales inválidas", false);
        }
        catch (Exception ex)
        {
            return new Response<bool>(false, ex.Message, false);
        }
    }
}
}
