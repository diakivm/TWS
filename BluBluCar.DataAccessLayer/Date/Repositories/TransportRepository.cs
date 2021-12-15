using Aplication.DataAccess.Date.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TWS.DataAccessLayer.Entities;
using TWS.DataAccessLayer.Interface.Repositories;
using TWS.DataAccessLayer.TWSContext;

namespace TWS.DataAccessLayer.Date.Repositories
{
    public class TransportRepository : GenericRepository<Transport>, ITransportRepository
    {
        public TransportRepository(TWSDBContext dbContext)
         : base(dbContext)
        {
        }

        public override Task<Transport> GetCompleteEntityAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
