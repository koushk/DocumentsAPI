using DocumentsAPI.Data;
using DocumentsAPI.Entities;
using DocumentsAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DocumentsAPI.Repositories
{
    public class LookupRepository : ILookupRepository
    {
        private readonly DbCtx dbCtx;

        public LookupRepository(DbCtx dbCtx)
        {
            this.dbCtx = dbCtx;
        }

        public async Task<IEnumerable<Department>> GetAllDepartments()
        {
            return await this.dbCtx.Departments.ToListAsync();
        }

        public async Task<IEnumerable<Division>> GetAllDivisions()
        {
            return await this.dbCtx.Divisions.ToListAsync();
        }

        public async Task<IEnumerable<Folder>> GetAllFolders()
        {
            return await this.dbCtx.Folders.ToListAsync();
        }

        public async Task<IEnumerable<Office>> GetAllOffices()
        {
            return await this.dbCtx.Offices.ToListAsync();
        }

        public async Task<IEnumerable<User>> GetAllUsers()
        {
            return await this.dbCtx.Users.ToListAsync();
        }
    }
}
