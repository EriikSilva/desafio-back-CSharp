using desafio_back_indt.Models;
using Microsoft.EntityFrameworkCore;

namespace desafio_back_indt.DataContext
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }
        //AQUI ELE CRIA A TABELA
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}
