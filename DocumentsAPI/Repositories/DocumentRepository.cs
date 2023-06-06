using DocumentsAPI.Data;
using DocumentsAPI.Entities;
using DocumentsAPI.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DocumentsAPI.Repositories
{
    public class DocumentRepository : IDocumentRepository
    {
        private readonly DbCtx dbCtx;

        public DocumentRepository(DbCtx dbCtx)
        {
            this.dbCtx = dbCtx;
        }

        public async Task<IEnumerable<Document>> GetAll()
        {
            return await this.dbCtx.Documents.ToListAsync();
        }

        public async Task<Document> Add(Document document)
        {
            this.dbCtx.Documents.Add(document);
            await this.dbCtx.SaveChangesAsync();
            return document; 
        }

        public async Task<Document> Update(Document document)
        {
            this.dbCtx.Documents.Update(document);
            await this.dbCtx.SaveChangesAsync();
            return document;
        }

        public async Task<bool> Delete(Guid id)
        {
            bool res = false;
            var doc = this.dbCtx.Documents.FirstOrDefault(d => d.Id == id);
            if (doc != null)
            {
                this.dbCtx.Documents.Remove(doc);
                await this.dbCtx.SaveChangesAsync();
                res = true;
            }
            return res; 
        }
    }
}
