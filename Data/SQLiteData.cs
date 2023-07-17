using SQLite;
using Tela_Login.Model;

namespace Tela_Login.Data
{
    public class SQLiteData
    {
        static SQLiteAsyncConnection _bancoDados;
        public static SQLiteAsyncConnection BancoDados
        {
            get
            {
                if (_bancoDados == null)
                {
                    _bancoDados = new SQLiteAsyncConnection(Constants.DatabasePath, Constants.Flags);

                    //_bancoDados = new SQLiteData(DependencyService.Get<ISQLiteDB>().SQLiteLocalPath("Dados.db3"));	
                }
                return _bancoDados;
            }
        }
    }
}