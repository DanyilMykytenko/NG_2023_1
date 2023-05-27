using DAL.DbStartUp;
using DAL.Entity;
using DAL.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly DBContext _dBContext;
        public GenericRepository(DBContext dBContext)
        {
            _dBContext = dBContext;
        }
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            var result = await _dBContext.Set<TEntity>().AddAsync(entity);
            await _dBContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteAsync(int id)
        {
            var item = await _dBContext.Set<TEntity>().FirstOrDefaultAsync(x => x.Id == id);
            _dBContext.Remove(item);
            await _dBContext.SaveChangesAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            var result = await _dBContext.Set<TEntity>().FirstOrDefaultAsync(x=>x.Id == id);
            return result;
        }
         
        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            var result = _dBContext.Set<TEntity>().Update(entity);
            await _dBContext.SaveChangesAsync();
            return result.Entity;
        }
    }
}
