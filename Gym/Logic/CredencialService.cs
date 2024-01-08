using Gym.Data;
using Gym.Entity;

namespace Gym.Logic
{
    public class CredentialService
{
    private readonly GenericRepository<Credencial> _credencialRepository;
        private readonly GymDbContext _gymDbContext;

        public CredentialService()
        { 
        _gymDbContext = new GymDbContext();
        _credencialRepository = new GenericRepository<Credencial>(_gymDbContext);
    }

    public Response<bool> RegisterUsuario(string username, string password)
    {
        try
        {
            var existingUser = _credencialRepository.GetByCondition(u => u.NombreUsuario == username).FirstOrDefault();
            if (existingUser != null)
                return new Response<bool>(false, "El nombre de usuario ya existe", false);

            var newUser = new Credencial
            {
                NombreUsuario = username,
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
            var existingUser = _credencialRepository.GetByCondition(u => u.NombreUsuario == username).FirstOrDefault();
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

    public Response<Credencial> Login(string username, string password)
    {
        try
        {
            var existingUser = _credencialRepository.GetByCondition(u => u.NombreUsuario == username && u.Contraseña == password).FirstOrDefault();
            if (existingUser != null)
                return new Response<Credencial>(true, "Inicio de sesión exitoso", existingUser);
            else
                return new Response<Credencial>(false, "Credenciales inválidas", existingUser);
        }
        catch (Exception ex)
        {
            return new Response<Credencial>(false, ex.Message, null);
        }
    }
}
}
