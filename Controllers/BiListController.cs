using System.Collections.Generic;
using System.Linq;
using ASPNET.Models;
using ASPNET.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ASPNET.Controllers
{
    [ApiController]
    [Route("api/biList")]
    public class BiListController : ControllerBase
    {
        private readonly IRepo _repo;


        public BiListController(IRepo repo)
        {
            _repo = repo;
        }

        [HttpGet]
        public ActionResult GetAllBiLists()
        {
            return Ok(_repo.GetAllBiLists());
        }
        [HttpGet("{id}")]

        public ActionResult GetBiListById(int id)
        {
            return Ok(_repo.GetBiListById(id));
        }
    }
}