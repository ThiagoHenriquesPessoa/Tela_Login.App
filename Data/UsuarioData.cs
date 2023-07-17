using SQLite;
using Tela_Login.Model;

namespace Tela_Login.Data
{
    public class UsuarioData
    {
        private SQLiteAsyncConnection _connectionDB;
        public UsuarioData(SQLiteAsyncConnection connectionDB)
        {
            _connectionDB = connectionDB;
        }

        public Task<List<Usuario>> ListaUsuarios()
        {
            var lista = _connectionDB.Table<Usuario>().ToListAsync();
            return lista;
        }

        public Task<Usuario> ObtemUsuario(string email, string senha)
        {
            var usuario = _connectionDB.Table<Usuario>().Where(x => x.Email == email && x.Senha == senha).FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<int> SalvaUsuarios(Usuario usuario)
        {
            var usuarioIsSalvo = await ObtemUsuario(usuario.Email, usuario.Senha);
            if (usuarioIsSalvo == null)
            {
                 
                return await _connectionDB.InsertAsync(usuario);
            }
            else
            {
                Guid num = usuarioIsSalvo.Id;
                return 0;
            }
        }

        public Task<Usuario> ObtemUsuarioID(Guid id)
        {
            var usuario = _connectionDB.Table<Usuario>().Where(x => x.Id == id).FirstOrDefaultAsync();
            return usuario;
        }

        public async Task<int> SalvaUsuarios(Guid id)
        {
            return await _connectionDB.DeleteAsync(id);
        }
    }
}