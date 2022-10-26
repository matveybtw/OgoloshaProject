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
    public class CategoryRepository : IRepository<Category>
    {
        private readonly OgoloshaContext _ogoloshaContext;
        public CategoryRepository(OgoloshaContext ogoloshaContext)
        {
            _ogoloshaContext = ogoloshaContext;
        }
        public async Task AddAsync(Category entity)
        {
            _ogoloshaContext.Categories.Add(entity);
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _ogoloshaContext.Categories.Remove(_ogoloshaContext.Categories.Find(id));
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Category>> GetAllAsync()
        {
            return await _ogoloshaContext.Categories.ToListAsync();
        }

        public async Task<Category> GetAsync(int id)
        {
            return await _ogoloshaContext.Categories.FindAsync(id);
        }

        public async Task UpdateAsync(int id, Category entity)
        {
            var e = await _ogoloshaContext.Categories.FindAsync(id);
            e.Name = entity.Name;
            e.Subcategories = entity.Subcategories;
            _ogoloshaContext.Entry(e).State = EntityState.Modified;
            await _ogoloshaContext.SaveChangesAsync();

        }
    }
}
