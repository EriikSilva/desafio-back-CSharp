using desafio_back_indt.Models;
using desafio_back_indt.Service.UsuarioService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace desafio_back_indt.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioInterface _usuarioInterface;
  
        public UsuarioController(IUsuarioInterface usuarioInterface)
        {
            _usuarioInterface = usuarioInterface;
        }
        [HttpGet]
        public async Task<ActionResult<List<UsuarioModel>>> GetUsuarios()
        {
            return Ok(await _usuarioInterface.GetUsuarios());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<UsuarioModel>>> GetUsuarioById(int id)
        {
            ServiceResponse<UsuarioModel> serviceResponse = await _usuarioInterface.GetUsuarioById(id);

            return Ok(serviceResponse);
        }

        [HttpPost]
        public async Task<ActionResult<List<UsuarioModel>>> CreateUsuario(UsuarioModel novoUsuario)
        {
            return Ok(await _usuarioInterface.CreateUsuario(novoUsuario));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<UsuarioModel>>>> UpdateUsuario(UsuarioModel editadoUsuario)
        {
            ServiceResponse<List<UsuarioModel>> serviceResponse = await _usuarioInterface.UpdateUsuario(editadoUsuario);
            return Ok(serviceResponse);
        }


        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<UsuarioModel>>>> DeleteUsuario(int id)
        {
           ServiceResponse<List<UsuarioModel>>  serviceResponse = await _usuarioInterface.DeleteUsuario(id);
            return Ok(serviceResponse);

        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginModel model)
        {
            try
            {
                ServiceResponse<UsuarioModel> serviceResponse = await _usuarioInterface.Login(model.Email, model.Senha);

                if (!serviceResponse.Status)
                {
                    return Unauthorized(new { Message = serviceResponse.Mensagem });
                }

                return Ok(new { Message = serviceResponse.Mensagem, User = serviceResponse.Dados });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Message = "Erro interno do servidor" });
            }
        }


    }
}
