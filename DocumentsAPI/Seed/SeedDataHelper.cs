using DocumentsAPI.Entities;

namespace DocumentsAPI.Seed
{
    public class SeedDataHelper
    {
        private static readonly Guid user1Guid = new Guid("3F2504E0-4F89-11D3-9A0C-0305E82C3301");
        private static readonly Guid user2Guid = new Guid("6B29FC40-CA47-1067-B31D-00DD010662DA");

        private static readonly Guid doc1Guid = new Guid("F47AC10B-58CC-4372-A567-0E02B2C3D479");
        private static readonly Guid doc2Guid = new Guid("9F1FEF20-4E98-4C1F-8769-43B7CB2EDAFB");

        public SeedDataHelper()
        {
            
        }

        public Department[] GetDepartments()
        {
            var list = new List<Department>()
            {
                new Department { Id = 1, Name = "Networking Services" },
                new Department { Id = 2, Name = "Dept X"},
                new Department { Id = 3, Name = "Dept Y"},
            };
            return list.ToArray();
        }

        public Office[] GetOffices()
        {
            var list = new List<Office>()
            {
                new Office { Id = 1, Name = "Server Unit" },
                new Office { Id = 2, Name = "Office X"},
                new Office { Id = 3, Name = "Office Y"},
            };
            return list.ToArray();
        }

        public Division[] GetDivisions()
        {
            var list = new List<Division>()
            {
                new Division { Id = 1, Name = "TISS" },
                new Division { Id = 2, Name = "Division X"},
                new Division { Id = 3, Name = "Division Y"},
            };
            return list.ToArray();
        }

        public Folder[] GetFolders()
        {
            var list = new List<Folder>()
            {
                new Folder { Id = 1, Name = "Servers" },
                new Folder { Id = 2, Name = "Folder X" },
                new Folder { Id = 3, Name = "Folder Y" },
            };
            return list.ToArray();
        }

        public User[] GetUsers()
        {
            var list = new List<User>()
            {
                new User { Id = user1Guid , Name = "John" },
                new User { Id = user2Guid, Name = "Adam"},
            };
            return list.ToArray();
        }

        public Document[] GetDocuments()
        {
            var list = new List<Document>()
            {
                new Document
                {
                    Id = doc1Guid,
                    DepartmentId = 1,
                    DivisionId = 1,
                    FolderId = 1,
                    OfficeId = 1,
                    FileName = "PlanningDocument",
                    FileType = "Pdf",
                    ModifiedBy = user1Guid,
                    ModifiedOn =  DateTime.Today,
                    AzureStorageReference = "SampleReference1"
                },
                new Document
                {
                    Id = doc2Guid,
                    DepartmentId = 2,
                    DivisionId = 3,
                    FolderId = 2,
                    OfficeId = 1,
                    FileName = "PlanningDocument",
                    FileType = "docx",
                    ModifiedBy = user2Guid,
                    ModifiedOn =  DateTime.Today,
                    AzureStorageReference = "SampleReference2"
                },
            };
            return list.ToArray();
        }
    }
}
