using SQLite;
using System.ComponentModel.DataAnnotations;

namespace Tela_Login.Model
{
    public class Usuario
    {
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}