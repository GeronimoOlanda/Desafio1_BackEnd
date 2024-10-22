using gerenciamentoTarefas.API.Models;
using Microsoft.EntityFrameworkCore;

namespace gerenciamentoTarefas.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Tarefa> Tarefas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; } 
    }

}
