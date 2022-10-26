using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DLL.Repository;
using Domain.Models;

namespace BL
{
    public class OgoloshaService
    {
        private AdvertRepository advertRepository;
        private CategoryRepository categoryRepository;
        private CharacteristicRepository characteristicRepository;
        private ContactRepository contactRepository;
        private SubcategoryRepository subcategoryRepository;
        private UserRepository userRepository;
        private UserInfoRepository userInfoRepository;
        public OgoloshaService(AdvertRepository advertRepository, CategoryRepository categoryRepository, CharacteristicRepository characteristicRepository, ContactRepository contactRepository, SubcategoryRepository subcategoryRepository, UserInfoRepository userInfoRepository, UserRepository userRepository)
        {
            this.advertRepository = advertRepository;
            this.categoryRepository = categoryRepository;
            this.characteristicRepository = characteristicRepository;
            this.contactRepository = contactRepository;
            this.subcategoryRepository = subcategoryRepository;
            this.userInfoRepository = userInfoRepository;
            this.userRepository = userRepository;
        }
        public async Task AddAdvert(Advert advert)
        {
            await advertRepository.AddAsync(advert);
        }
        public async Task RemoveAdvert(int id)
        {
            await advertRepository.DeleteAsync(id);
        }
        public async Task UpdateAdvert(int id, Advert advert)
        {
            await advertRepository.UpdateAsync(id, advert);
        }
        public async Task<Advert> GetAdvert(int id)
        {
            return await advertRepository.GetAsync(id);
        }
        public async Task<IEnumerable<Advert>> GetAllAdvertsAsync()
        {
            return await advertRepository.GetAllAsync();
        }
        public async Task AddContact(Contact contact)
        {
            await contactRepository.AddAsync(contact);
        }
        public async Task RemoveContact(int id)
        {
            await contactRepository.DeleteAsync(id);
        }
        public async Task UpdateContact(int id, Contact contact)
        {
            await contactRepository.UpdateAsync(id, contact);
        }
        public async Task<Contact> GetContact(int id)
        {
            return await contactRepository.GetAsync(id);
        }
        public async Task<IEnumerable<Contact>> GetAllContactsAsync()
        {
            return await contactRepository.GetAllAsync();
        }
        public async Task AddCategory(Category category)
        {
            await categoryRepository.AddAsync(category);
        }
        public async Task RemoveCategory(int id)
        {
            await categoryRepository.DeleteAsync(id);
        }
        public async Task UpdateCategory(int id, Category category)
        {
            await categoryRepository.UpdateAsync(id, category);
        }
        public async Task<Category> GetCategory(int id)
        {
            return await categoryRepository.GetAsync(id);
        }
        public async Task<IEnumerable<Category>> GetAllCategorysAsync()
        {
            return await categoryRepository.GetAllAsync();
        }
        public async Task AddSubcategory(Subcategory subcategory)
        {
            await subcategoryRepository.AddAsync(subcategory);
        }
        public async Task RemoveSubcategory(int id)
        {
            await subcategoryRepository.DeleteAsync(id);
        }
        public async Task UpdateSubcategory(int id, Subcategory subcategory)
        {
            await subcategoryRepository.UpdateAsync(id, subcategory);
        }
        public async Task<Subcategory> GetSubcategory(int id)
        {
            return await subcategoryRepository.GetAsync(id);
        }
        public async Task<IEnumerable<Subcategory>> GetAllSubcategorysAsync()
        {
            return await subcategoryRepository.GetAllAsync();
        }
        public async Task AddCharacteristic(Characteristic characteristic)
        {
            await characteristicRepository.AddAsync(characteristic);
        }
        public async Task RemoveCharacteristic(int id)
        {
            await characteristicRepository.DeleteAsync(id);
        }
        public async Task UpdateCharacteristic(int id, Characteristic characteristic)
        {
            await characteristicRepository.UpdateAsync(id, characteristic);
        }
        public async Task<Characteristic> GetCharacteristic(int id)
        {
            return await characteristicRepository.GetAsync(id);
        }
        public async Task<IEnumerable<Characteristic>> GetAllCharacteristicsAsync()
        {
            return await characteristicRepository.GetAllAsync();
        }
        public async Task AddUser(User user)
        {
            await userRepository.AddAsync(user);
        }
        public async Task RemoveUser(int id)
        {
            await userRepository.DeleteAsync(id);
        }
        public async Task UpdateUser(int id, User user)
        {
            await userRepository.UpdateAsync(id, user);
        }
        public async Task<User> GetUser(int id)
        {
            return await userRepository.GetAsync(id);
        }
        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await userRepository.GetAllAsync();
        }
        public async Task AddUserInfo(UserInfo userInfo)
        {
            await userInfoRepository.AddAsync(userInfo);
        }
        public async Task RemoveUserInfo(int id)
        {
            await userInfoRepository.DeleteAsync(id);
        }
        public async Task UpdateUserInfo(int id, UserInfo userInfo)
        {
            await userInfoRepository.UpdateAsync(id, userInfo);
        }
        public async Task<UserInfo> GetUserInfo(int id)
        {
            return await userInfoRepository.GetAsync(id);
        }
        public async Task<IEnumerable<UserInfo>> GetAllUserInfosAsync()
        {
            return await userInfoRepository.GetAllAsync();
        }
    }
}
