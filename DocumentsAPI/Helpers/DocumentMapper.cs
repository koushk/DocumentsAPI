using AutoMapper;
using DocumentsAPI.DTOs;
using DocumentsAPI.Entities;

namespace DocumentsAPI.Helpers
{
    public class DocumentMapper : Profile
    {
        public DocumentMapper()
        {
            CreateMap<Document, DocumentDTOWithId>().ReverseMap();
            CreateMap<Document, DocumentDTO>().ReverseMap();
        }
    }
}
