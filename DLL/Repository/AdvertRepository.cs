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
    public class AdvertRepository:IRepository<Advert>
    {
        private readonly OgoloshaContext _ogoloshaContext;
        public AdvertRepository(OgoloshaContext ogoloshaContext)
        {
            _ogoloshaContext = ogoloshaContext;
        }
        public async Task AddAsync(Advert entity)
        {
            _ogoloshaContext.Adverts.Add(entity);
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _ogoloshaContext.Adverts.Remove(_ogoloshaContext.Adverts.Find(id));
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<Advert>> GetAllAsync()
        {
            return await _ogoloshaContext.Adverts.ToListAsync();
        }

        public async Task<Advert> GetAsync(int id)
        {
            return await _ogoloshaContext.Adverts.FindAsync(id);
        }

        public async Task UpdateAsync(int id, Advert entity)
        {
            var e = await _ogoloshaContext.Adverts.FindAsync(id);
            e.Name = entity.Name;
            e.Place = entity.Place;
            e.Description = entity.Description;
            e.Salary=entity.Salary;
            e.Subcategory=entity.Subcategory;
            e.Photo=entity.Photo;
            e.Characteristics = entity.Characteristics;
            e.Contacts=entity.Contacts;
            e.Video=entity.Video;
            _ogoloshaContext.Entry(e).State = EntityState.Modified;
            await _ogoloshaContext.SaveChangesAsync();

        }
    }
}
