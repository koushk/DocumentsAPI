using AutoMapper;
using DocumentsAPI.DTOs;
using DocumentsAPI.Entities;
using DocumentsAPI.Repositories.Interfaces;
using DocumentsAPI.Services.Interfaces;

namespace DocumentsAPI.Services
{
    public class LookupService : ILookupService
    {
        private readonly ILookupRepository lookupRepository;

        public LookupService(ILookupRepository lookupRepository)
        {
            this.lookupRepository = lookupRepository;
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await this.lookupRepository.GetAllDepartments();
        }

        public async Task<IEnumerable<Division>> GetAllDivisions()
        {
            return await this.lookupRepository.GetAllDivisions();
        }

        public async Task<IEnumerable<Folder>> GetAllFolders()
        {
            return await this.lookupRepository.GetAllFolders();
        }

        public async Task<IEnumerable<Office>> GetAllOffices()
        {
            return await this.lookupRepository.GetAllOffices();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await this.lookupRepository.GetAllUsers();
        }
    }
}
