using DocumentsAPI.DTOs;
using DocumentsAPI.Entities;
using DocumentsAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DocumentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocumentController : Controller
    {
        private readonly IDocumentService documentService;

        public DocumentController(IDocumentService documentService) 
        {
            this.documentService = documentService;
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var list = await this.documentService.GetAll();
            return this.GetJsonResultWithDocDTO(HttpStatusCode.OK, true, list);
        }

        [HttpPost]
        [Route("Add")]
        public async Task<IActionResult> Add([FromBody]DocumentDTO addDto)
        {
            if (!this.ModelState.IsValid)
            {
                return this.GetJsonResultWithMsg(HttpStatusCode.ExpectationFailed, false);
            }

            try
            {
                var dto = await this.documentService.Add(addDto);
                return this.GetJsonResultWithDocDTO(HttpStatusCode.OK, true, new List<DocumentDTOWithId> { dto });
            }
            catch (Exception ex)
            {
                return this.GetJsonResultWithMsg(HttpStatusCode.InternalServerError, false, ex.Message);
            }
        }

        [HttpPut]
        [Route("Update")]
        public async Task<IActionResult> Update([FromBody] DocumentDTOWithId dto)
        {
            if (!this.ModelState.IsValid)
            {
                return this.GetJsonResultWithMsg(HttpStatusCode.ExpectationFailed, false);
            }

            try
            {
                var responseDto = await this.documentService.Update(dto);
                return this.GetJsonResultWithDocDTO(HttpStatusCode.OK, true, new List<DocumentDTOWithId> {responseDto});
            }
            catch (Exception ex)
            {
                return this.GetJsonResultWithMsg(HttpStatusCode.InternalServerError, false, ex.Message);
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<IActionResult> Delete([FromRoute]Guid id)
        {
            if(!this.ModelState.IsValid)
            {
                return this.GetJsonResultWithMsg(HttpStatusCode.ExpectationFailed, false);
            }

            try
            {
                var isDeleted = await this.documentService.Delete(id);
                var jsonRes = isDeleted ?
                    this.GetJsonResultWithMsg(HttpStatusCode.OK, isDeleted, "Document has been succesfully deleted") :
                    this.GetJsonResultWithMsg(HttpStatusCode.NotFound, isDeleted);
                return jsonRes;
            }
            catch (Exception ex)
            {
                return this.GetJsonResultWithMsg(HttpStatusCode.InternalServerError, false, ex.Message);
            }
        }

        private JsonResult GetJsonResultWithMsg(HttpStatusCode httpStatusCode, bool isSuccess, string msg = null)
        {
            return Json(new
            {
                statusCode = httpStatusCode,
                success = isSuccess,
                message = msg
            });
        }

        private JsonResult GetJsonResultWithDocDTO(HttpStatusCode httpStatusCode, bool isSuccess, IEnumerable<DocumentDTOWithId> list)
        {
            return Json(new
            {
                statusCode = httpStatusCode,
                success = isSuccess,
                documents = list
            });
        }
    }
}
