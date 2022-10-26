using DLL.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Repository
{
    public class UserRepository:IRepository<User>
    {
        private readonly OgoloshaContext _ogoloshaContext;
        public UserRepository(OgoloshaContext ogoloshaContext)
        {
            _ogoloshaContext = ogoloshaContext;
        }
        public async Task AddAsync(User entity)
        {
            _ogoloshaContext.Users.Add(entity);
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _ogoloshaContext.Users.Remove(_ogoloshaContext.Users.Find(id));
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<User>> GetAllAsync()
        {
            return await _ogoloshaContext.Users.ToListAsync();
        }

        public async Task<User> GetAsync(int id)
        {
            return await _ogoloshaContext.Users.FindAsync(id);
        }

        public async Task UpdateAsync(int id, User entity)
        {
            var e = await _ogoloshaContext.Users.FindAsync(id);
            e.Email=entity.Email; 
            e.Password=entity.Password;
            e.UserInfo=entity.UserInfo;
            _ogoloshaContext.Entry(e).State = EntityState.Modified;
            await _ogoloshaContext.SaveChangesAsync();

        }
    }
}
