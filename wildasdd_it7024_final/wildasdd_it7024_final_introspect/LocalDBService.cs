using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wildasdd_it7024_final_introspect
{
    public class LocalDBService
    {
        private SQLiteAsyncConnection _connection;
        private const string DB_NAME = "introspect_db.db3";
        

        public LocalDBService()
        {
            _connection = new SQLiteAsyncConnection(Path.Combine(FileSystem.AppDataDirectory, DB_NAME));
            _connection.CreateTableAsync<Scores>().Wait();
        }
        public async Task<Scores> GetByDate(DateTime date)
        {
             return await _connection.Table<Scores>().FirstOrDefaultAsync(x => x.InputDate == date);
            
        }
        public async Task Create(Scores scores)
        {
            await _connection.InsertAsync(scores);
        }

        public async Task Update(Scores scores)
        {
            await _connection.UpdateAsync(scores);
        }

    }
}
