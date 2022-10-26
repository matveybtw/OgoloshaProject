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
    public class ContactRepository : IRepository<Contact>
    {
        private readonly OgoloshaContext _ogoloshaContext;
        public ContactRepository(OgoloshaContext ogoloshaContext)
        {
            _ogoloshaContext = ogoloshaContext;
        }
        public async Task AddAsync(Contact entity)
        {
            _ogoloshaContext.Contacts.Add(entity);
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _ogoloshaContext.Contacts.Remove(_ogoloshaContext.Contacts.Find(id));
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Contact>> GetAllAsync()
        {
            return await _ogoloshaContext.Contacts.ToListAsync();
        }

        public async Task<Contact> GetAsync(int id)
        {
            return await _ogoloshaContext.Contacts.FindAsync(id);
        }

        public async Task UpdateAsync(int id, Contact entity)
        {
            var e = await _ogoloshaContext.Contacts.FindAsync(id);
            e.Name=entity.Name;
            e.Number=entity.Number;
            _ogoloshaContext.Entry(e).State = EntityState.Modified;
            await _ogoloshaContext.SaveChangesAsync();
        }
    }
}
