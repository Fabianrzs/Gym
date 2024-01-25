using Gym.Data;
using Gym.Entity;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace Gym.Logic
{
    public class CredentialService
    {
        private readonly GenericRepository<Credencial> _credencialRepository;
        private readonly GenericRepository<Usuario> _usuarioRepository;
        private readonly GymDbContext _gymDbContext;

        public CredentialService()
        {
            _gymDbContext = new GymDbContext();
            _credencialRepository = new GenericRepository<Credencial>(_gymDbContext);
            _usuarioRepository = new GenericRepository<Usuario>(_gymDbContext);
        }

        public Response<bool> EliminarCredenciales(string nombreUsuario)
        {
            try
            {
                // Eliminar las credenciales del usuario
                var credencialEntity = _credencialRepository.GetByCondition(x => x.NombreUsuario == nombreUsuario).FirstOrDefault();
                
                if (credencialEntity != null)
                {
                    _credencialRepository.Delete(credencialEntity);
                    _credencialRepository.Save();
                    // Si se completaron ambas eliminaciones, devolver una respuesta con éxito verdadero
                    return new Response<bool>(true, "Usuario y credenciales eliminados exitosamente", true);
                }
                else
                {
                    // Si no se encuentran credenciales, devolver una respuesta con éxito falso
                    return new Response<bool>(false, "Credenciales no encontradas", false);
                }

                
            }
            catch (Exception ex)
            {
                // Si se produce una excepción, devolver una respuesta con éxito falso y el mensaje de error
                return new Response<bool>(false, ex.Message, false);
            }

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
                    return new Response<Credencial>(false, "Credenciales inválidas", new Credencial());
            }
        catch (Exception ex)
        {
            return new Response<Credencial>(false, ex.Message, new Credencial());
            }
    }
}
}
