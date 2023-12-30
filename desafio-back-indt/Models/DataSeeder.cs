using desafio_back_indt.DataContext;
using desafio_back_indt.Enums;

namespace desafio_back_indt.Models
{
    public class DataSeeder
    {
        private readonly ApplicationDbContext db;
        public DataSeeder(ApplicationDbContext db)
        {
            this.db = db;
        }
        public void Seed()
        {
            if (!db.Usuarios.Any())
            {
                var usuario = new List<UsuarioModel>(){
             new UsuarioModel(){
                Nome = "admin",
                Sobrenome  = "administrador",
                Email = "admin@admin.com",
                Senha ="admin123",
                Nivel_Acesso = 0,
                DataDeCriacao = DateTime.Now.ToLocalTime(),
                DataDeAtualizacao = DateTime.Now.ToLocalTime()
            },
                 new UsuarioModel(){
                Nome = "admin2",
                Sobrenome  = "administrador2",
                Email = "admin2@admin2.com",
                Senha ="admin321",
                Nivel_Acesso = 0,
                DataDeCriacao = DateTime.Now.ToLocalTime(),
                DataDeAtualizacao = DateTime.Now.ToLocalTime()
            },

            new UsuarioModel(){
                Nome = "John",
                Sobrenome  = "Doe",
                Email = "johndoe@jonhdoe.com",
                Senha ="john123",
                Nivel_Acesso = (NivelAcessoEnum)1,
                DataDeCriacao = DateTime.Now.ToLocalTime(),
                DataDeAtualizacao = DateTime.Now.ToLocalTime()
            },

        };
                db.Usuarios.AddRange(usuario);
                db.SaveChanges();
            }
        }

    }

}