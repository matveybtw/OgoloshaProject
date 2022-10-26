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
    public class CharacteristicRepository : IRepository<Characteristic>
    {
        private readonly OgoloshaContext _ogoloshaContext;
        public CharacteristicRepository(OgoloshaContext ogoloshaContext)
        {
            _ogoloshaContext = ogoloshaContext;
        }
        public async Task AddAsync(Characteristic entity)
        {
            _ogoloshaContext.Characteristics.Add(entity);
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _ogoloshaContext.Characteristics.Remove(_ogoloshaContext.Characteristics.Find(id));
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Characteristic>> GetAllAsync()
        {
            return await _ogoloshaContext.Characteristics.ToListAsync();
        }

        public async Task<Characteristic> GetAsync(int id)
        {
            return await _ogoloshaContext.Characteristics.FindAsync(id);
        }

        public async Task UpdateAsync(int id, Characteristic entity)
        {
            var e = await _ogoloshaContext.Characteristics.FindAsync(id);
            e.Name=entity.Name;
            e.Value=entity.Value;
            _ogoloshaContext.Entry(e).State = EntityState.Modified;
            await _ogoloshaContext.SaveChangesAsync();
        }
    }
}
