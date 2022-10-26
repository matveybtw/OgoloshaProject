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
    public class UserInfoRepository:IRepository<UserInfo>
    {
        private readonly OgoloshaContext _ogoloshaContext;
        public UserInfoRepository(OgoloshaContext ogoloshaContext)
        {
            _ogoloshaContext = ogoloshaContext;
        }
        public async Task AddAsync(UserInfo entity)
        {
            _ogoloshaContext.UserInfos.Add(entity);
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            _ogoloshaContext.UserInfos.Remove(_ogoloshaContext.UserInfos.Find(id));
            await _ogoloshaContext.SaveChangesAsync();
        }

        public async Task<IEnumerable<UserInfo>> GetAllAsync()
        {
            return await _ogoloshaContext.UserInfos.ToListAsync();
        }

        public async Task<UserInfo> GetAsync(int id)
        {
            return await _ogoloshaContext.UserInfos.FindAsync(id);
        }

        public async Task UpdateAsync(int id, UserInfo entity)
        {
            var e = await _ogoloshaContext.UserInfos.FindAsync(id);
            e.Name=entity.Name;
            e.User = entity.User;
            e.UserId = entity.UserId;
            e.Place=entity.Place;
            e.Photo=entity.Photo;
            e.Description=entity.Description;
            _ogoloshaContext.Entry(e).State = EntityState.Modified;
            await _ogoloshaContext.SaveChangesAsync();

        }
    }
}
