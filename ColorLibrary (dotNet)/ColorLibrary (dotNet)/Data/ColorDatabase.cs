using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using ColorLibrary__dotNet_.Models;


namespace ColorLibrary__dotNet_.Data
{
    public class ColorDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public ColorDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Item>().Wait();
        }

        public Task<List<Item>> GetItemAsync()
        {
            return _database.Table<Item>().ToListAsync();
        }

        public Task<Item> GetItemAsync(int id)
        {
            return _database.Table<Item>()
                            .Where(i => i.ID == id)
                            .FirstOrDefaultAsync();
        }

        public Task<int> SaveItemAsync(Item note)
        {
            if (note.ID != 0)
            {
                return _database.UpdateAsync(note);
            }
            else
            {
                return _database.InsertAsync(note);
            }
        }

        public Task<int> DeleteItemAsync(Item note)
        {
            return _database.DeleteAsync(note);
        }
    }

}
