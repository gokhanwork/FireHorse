using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TableController : ControllerBase
    {
        ITableService _tableService;

        public TableController(ITableService tableService)
        {
            _tableService = tableService;
        }
        [HttpPost("add")]
        public IActionResult Add(Table table)
        {
            var result = _tableService.Add(table);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
        [HttpGet("getAll")]
        public IActionResult GetAll()
        {
            var result = _tableService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
