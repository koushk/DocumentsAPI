using DocumentsAPI.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace DocumentsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LookupController : ControllerBase
    {
        private readonly ILookupService lookupService;

        public LookupController(ILookupService lookupService)
        {
            this.lookupService = lookupService;
        }

        [HttpGet]
        [Route("Departments/GetAll")]
        public async Task<IActionResult> GetAllDepartments()
        {
            var list = await this.lookupService.GetAllDepartments();
            return Ok(list);
        }

        [HttpGet]
        [Route("Divisions/GetAll")]
        public async Task<IActionResult> GetAllDivisions()
        {
            var list = await this.lookupService.GetAllDivisions();
            return Ok(list);
        }

        [HttpGet]
        [Route("Folders/GetAll")]
        public async Task<IActionResult> GetAllFolders()
        {
            var list = await this.lookupService.GetAllFolders();
            return Ok(list);
        }


        [HttpGet]
        [Route("Offices/GetAll")]
        public async Task<IActionResult> GetAllOffices()
        {
            var list = await this.lookupService.GetAllOffices();
            return Ok(list);
        }

        [HttpGet]
        [Route("Users/GetAll")]
        public async Task<IActionResult> GetAllUsers()
        {
            var list = await this.lookupService.GetAllUsers();
            return Ok(list);
        }
    }
}
