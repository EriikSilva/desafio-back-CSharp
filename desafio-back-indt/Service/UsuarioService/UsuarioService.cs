using desafio_back_indt.DataContext;
using desafio_back_indt.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio_back_indt.Service.UsuarioService
{
    public class UsuarioService : IUsuarioInterface
    {
        private readonly ApplicationDbContext _context;
        public UsuarioService(ApplicationDbContext context) 
        {
            _context = context;
        }
        public async Task<ServiceResponse<List<UsuarioModel>>> CreateUsuario(UsuarioModel novoUsuario)
        {
            ServiceResponse<List<UsuarioModel>> serviceResponse = new ServiceResponse<List<UsuarioModel>>();

            try
            {
                if(novoUsuario == null)
                {
                    serviceResponse.Mensagem = "Informar Dados";
                    serviceResponse.Status = false;
                    serviceResponse.Dados = null;

                    return serviceResponse;
                }

                _context.Add(novoUsuario);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Usuarios.ToList();
                serviceResponse.Mensagem = "Usuário Criado Com Sucesso";

            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;

        }

        public async Task<ServiceResponse<List<UsuarioModel>>> DeleteUsuario(int id)
        {
            ServiceResponse<List<UsuarioModel>> serviceResponse = new ServiceResponse<List<UsuarioModel>>();

            try
            {
                UsuarioModel usuario = _context.Usuarios.FirstOrDefault(x => x.Id == id);

                if (usuario == null)
                {
                    serviceResponse.Mensagem = "Usuário Não Localizado";
                    serviceResponse.Status = false;
                    serviceResponse.Dados = null;

                    return serviceResponse;
                }

                _context.Usuarios.Remove(usuario);
                await _context.SaveChangesAsync();
                serviceResponse.Mensagem = "Usuário Removido Com Sucesso";
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;

        }

        public async Task<ServiceResponse<UsuarioModel>> GetUsuarioById(int id)
        {
            ServiceResponse<UsuarioModel> serviceResponse = new ServiceResponse<UsuarioModel>();

            try
            {
                UsuarioModel usuario = _context.Usuarios.FirstOrDefault(x => x.Id == id);

                if(usuario == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário Não Localizado";
                    serviceResponse.Status = false;
                }

                serviceResponse.Dados = usuario;
                serviceResponse.Mensagem = "Usuário Encontrado Com Sucesso";
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }

        public async Task<ServiceResponse<List<UsuarioModel>>> GetUsuarios()
        {
           ServiceResponse<List<UsuarioModel>> serviceResponse = new ServiceResponse<List<UsuarioModel>>();

            try
            {
                serviceResponse.Dados = _context.Usuarios.ToList();
                if(serviceResponse.Dados.Count == 0)
                {
                    serviceResponse.Mensagem = "Nenhum Dado Encontrado";
                }
            }
            catch(Exception ex)
            {
               serviceResponse.Mensagem = ex.Message;
               serviceResponse.Status = false;
            }

            return serviceResponse;
        }

   
        public async Task<ServiceResponse<List<UsuarioModel>>> UpdateUsuario(UsuarioModel editadoUsuario)
        {
            ServiceResponse<List<UsuarioModel>> serviceResponse = new ServiceResponse<List<UsuarioModel>>();

            try
            {

                UsuarioModel usuario = _context.Usuarios.AsNoTracking().FirstOrDefault(x => x.Id == editadoUsuario.Id);

                if (usuario == null)
                {
                    serviceResponse.Dados = null;
                    serviceResponse.Mensagem = "Usuário Não Localizado";
                    serviceResponse.Status = false;
                }

                usuario.DataDeAtualizacao = DateTime.Now.ToLocalTime();
                _context.Usuarios.Update(editadoUsuario);
                await _context.SaveChangesAsync();

                serviceResponse.Dados = _context.Usuarios.ToList();
            }
            catch (Exception ex)
            {
                serviceResponse.Mensagem = ex.Message;
                serviceResponse.Status = false;
            }

            return serviceResponse;
        }
    }
}
