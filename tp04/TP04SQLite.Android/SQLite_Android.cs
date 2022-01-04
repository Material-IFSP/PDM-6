using System.IO;
using Xamarin.Forms;
using TP04SQLite.Data;
using TP04SQLite.Droid;

[assembly:
Dependency(typeof(SQLite_Android))]
namespace TP04SQLite.Droid
{
    class SQLite_Android : ISQLite
    {
        public SQLite_Android()
        {
        }
        public SQLite.SQLiteConnection
        GetConexao()
        {
            var arquivodb = "ifspdb.db3";
            string caminho =
            System.Environment.GetFolderPath
            (System.Environment.SpecialFolder.Personal);
            var local = Path.Combine(caminho,
            arquivodb);
            var conexao = new
            SQLite.SQLiteConnection(local);
            return conexao;
        }
    }
}