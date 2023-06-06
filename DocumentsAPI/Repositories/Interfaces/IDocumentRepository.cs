using DocumentsAPI.Entities;

namespace DocumentsAPI.Repositories.Interfaces
{
    public interface IDocumentRepository
    {
        Task<IEnumerable<Document>> GetAll();
        Task<Document> Add(Document document);
        Task<Document> Update(Document document);
        Task<bool> Delete(Guid id);
    }
}
