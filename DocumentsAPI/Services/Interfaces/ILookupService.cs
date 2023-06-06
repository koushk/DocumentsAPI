using DocumentsAPI.Entities;

namespace DocumentsAPI.Services.Interfaces
{
    public interface ILookupService
    {
        Task<IEnumerable<Department>> GetAllDepartments();
        Task<IEnumerable<Division>> GetAllDivisions();
        Task<IEnumerable<Folder>> GetAllFolders();
        Task<IEnumerable<Office>> GetAllOffices();
        Task<IEnumerable<User>> GetAllUsers();
    }
}
