using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TWS.DataAccessLayer.TWSContext;

namespace TWS.Data
{
    class DbInitializer
    {
        private readonly TWSDBContext _db;
        private readonly ILogger<DbInitializer> _Logger;

        public DbInitializer(TWSDBContext db, ILogger<DbInitializer> Logger)
        {
            _db = db;
            _Logger = Logger;
        }

        public async Task InitializeAsync()
        {
            var timer = Stopwatch.StartNew();
            _Logger.LogInformation("Инициализация БД...");

            //_Logger.LogInformation("Удаление существующей БД...");
            //await _db.Database.EnsureDeletedAsync().ConfigureAwait(false);
            //_Logger.LogInformation("Удаление существующей БД выполнено за {0} мс", timer.ElapsedMilliseconds);

            //_db.Database.EnsureCreated();

            _Logger.LogInformation("Миграция БД...");
            await _db.Database.MigrateAsync().ConfigureAwait(false);
            _Logger.LogInformation("Миграция БД выполнена за {0} мс", timer.ElapsedMilliseconds);


           

            _Logger.LogInformation("Инициализация БД выполнена за {0} с", timer.Elapsed.TotalSeconds);
        }

       
    }
}
