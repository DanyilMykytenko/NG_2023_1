using EFLection.DbStartup;
using EFLection.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFLection.Service
{
    public class DbService
    {
        private readonly EFLectionContext _context;
        public DbService(EFLectionContext context) 
        {
            _context = context;
        }

        public async Task AddAsync(User entity)
        {
            await _context.Set<User>().AddAsync(entity);
            await _context.SaveChangesAsync();
        }

        public async Task<User> GetByIdAsync(int id)
        {
            var entity = await _context.Set<User>().FirstOrDefaultAsync(x => x.Id == id);
            
            return entity;
        }

        public async Task<ICollection<User>> GetAllAsync()
        {
            var entities = await _context.Set<User>().Select(x => x).ToListAsync();

            return entities;
        }

        public async Task UpdateAsync(User model)
        {
            _context.Set<User>().Update(model);
            await _context.SaveChangesAsync();
        }

        public void Delete(User model) 
        {
            _context.Set<User>().Remove(model);
            _context.SaveChangesAsync();
        }
    }
}
