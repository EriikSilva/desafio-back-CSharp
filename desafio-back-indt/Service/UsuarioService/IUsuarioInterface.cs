using desafio_back_indt.Models;

namespace desafio_back_indt.Service.UsuarioService
{
    public interface IUsuarioInterface
    {
        Task<ServiceResponse<List<UsuarioModel>>> GetUsuarios();
        Task<ServiceResponse<List<UsuarioModel>>> CreateUsuario(UsuarioModel novoUsuario);
        Task<ServiceResponse<UsuarioModel>> GetUsuarioById(int id);

        Task<ServiceResponse<List<UsuarioModel>>> UpdateUsuario(UsuarioModel editadoUsuario);

        Task<ServiceResponse<List<UsuarioModel>>> DeleteUsuario(int id);

        Task<ServiceResponse<UsuarioModel>> Login(string username, string senha);

        //Task<ServiceResponse<List<UsuarioModel>>> InativaUsuario(int id);
    }
}
