using SQLite;
using Tela_Login.Model;

namespace Tela_Login.Data
{
    public class SQLiteData
    {
        readonly SQLiteAsyncConnection _connection;

        public SQLiteData(string path)
        {
            _connection = new SQLiteAsyncConnection(path);
            _connection.CreateTableAsync<Usuario>().Wait();
        }
        //public UsuarioData UsusarioDatable { get; set; }

    }
}