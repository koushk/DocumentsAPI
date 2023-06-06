using AutoMapper;
using DocumentsAPI.DTOs;
using DocumentsAPI.Entities;
using DocumentsAPI.Repositories.Interfaces;
using DocumentsAPI.Services.Interfaces;

namespace DocumentsAPI.Services
{
    public class DocumentService : IDocumentService
    {
        private readonly IDocumentRepository documentRepository;
        private readonly IMapper mapper;

        public DocumentService(IDocumentRepository documentRepository, IMapper mapper)
        {
            this.documentRepository = documentRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<DocumentDTOWithId>> GetAll()
        {
            var documents = await documentRepository.GetAll();
            return this.mapper.Map<IEnumerable<DocumentDTOWithId>>(documents);
        }

        public async Task<DocumentDTOWithId> Add(DocumentDTO dto)
        {
            var document = this.mapper.Map<Document>(dto);
            document.Id = Guid.NewGuid();
            document.AzureStorageReference = "Sample Ref";//Reference of the document in Azure Cloud Storage.

            await this.documentRepository.Add(document);
            return this.mapper.Map<DocumentDTOWithId>(document);
        }

        public async Task<DocumentDTOWithId> Update(DocumentDTOWithId dto)
        {
            var document = this.mapper.Map<Document>(dto);
            document.AzureStorageReference = "Sample Ref";//Reference of the document in Azure Cloud Storage.
            await this.documentRepository.Update(document);
            return dto;
        }

        public async Task<bool> Delete(Guid id)
        {
            return await this.documentRepository.Delete(id);
        }
    }
}
