using Lista_Semana_1__M3__DotNet_DevInHouse.DataBase;
using Lista_Semana_1__M3__DotNet_DevInHouse.Entities;
using Lista_Semana_1__M3__DotNet_DevInHouse.Models;
using Microsoft.EntityFrameworkCore;

namespace Lista_Semana_1__M3__DotNet_DevInHouse.Repository
{

    public class BandRepository : IBandRepository<BandModel>
    {

        private readonly IDbContextFactory<Context> _dbContextFactory;

        public BandRepository(IDbContextFactory<Context> dbContextFactory)
        {
            _dbContextFactory = dbContextFactory;
        }

        public int Add(BandModel model)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Add(model);
                context.SaveChanges();
            }

            return model.Id;
        }

        public bool Delete(int id)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Remove<BandModel>(new BandModel { Id = id });
                return context.SaveChanges() > 0;
            }
        }

        public IList<BandModel> GetAll()
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                return context.Banda.ToList();
            }
        }

        public bool Update(BandModel model)
        {
            using (var context = _dbContextFactory.CreateDbContext())
            {
                context.Update(model);
                return context.SaveChanges() > 0;
            }
        }
    }
}
