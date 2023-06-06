using DocumentsAPI.Entities;

namespace DocumentsAPI.Repositories.Interfaces
{
    public interface ILookupRepository
    {
        Task<IEnumerable<Department>> GetAllDepartments();
        Task<IEnumerable<Division>> GetAllDivisions();
        Task<IEnumerable<Folder>> GetAllFolders();
        Task<IEnumerable<Office>> GetAllOffices();
        Task<IEnumerable<User>> GetAllUsers();
    }
}
