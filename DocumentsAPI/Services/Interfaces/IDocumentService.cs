using DocumentsAPI.DTOs;
using DocumentsAPI.Entities;

namespace DocumentsAPI.Services.Interfaces
{
    public interface IDocumentService
    {
        Task<IEnumerable<DocumentDTOWithId>> GetAll();

        Task<DocumentDTOWithId> Add(DocumentDTO dto);

        Task<DocumentDTOWithId> Update(DocumentDTOWithId dto);

        Task<bool> Delete(Guid id);
    }
}
