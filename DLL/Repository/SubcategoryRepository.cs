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
    public class SubcategoryRepository : IRepository<Subcategory>
    {
        private readonly OgoloshaContext _ogoloshaContext;
        public SubcategoryRepository(OgoloshaContext ogoloshaContext)
        {
            _ogoloshaContext = ogoloshaContext;
        }
        public async Task AddAsync(Subcategory entity)
        {
            _ogoloshaContext.Subcategories.Add(entity);
            await _ogoloshaContext.SaveChangesAsync();
        } 
        public async Task DeleteAsync(int id)
        {
            _ogoloshaContext.Subcategories.Remove(_ogoloshaContext.Subcategories.Find(id));
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Subcategory>> GetAllAsync()
        {
            return await _ogoloshaContext.Subcategories.ToListAsync();
        }

        public async Task<Subcategory> GetAsync(int id)
        {
            return await _ogoloshaContext.Subcategories.FindAsync(id);
        }
         
        public async Task UpdateAsync(int id, Subcategory entity)
        {
            var e = await _ogoloshaContext.Subcategories.FindAsync(id);
            e.Category = entity.Category;
            e.Chars=entity.Chars;
            _ogoloshaContext.Entry(e).State = EntityState.Modified;
            await _ogoloshaContext.SaveChangesAsync();

        }
    }
}
