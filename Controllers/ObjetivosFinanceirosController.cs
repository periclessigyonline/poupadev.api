using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using poupadev.api.Models;

namespace poupadev.api.Controllers
{
    [ApiController]
    [Route("api/objetivos-financeiros")]
    public class ObjetivosFinanceirosController: ControllerBase
    {
        //GET api/objetivos-financeiros
        [HttpGet]
        public IActionResult GetTodos(){
            return Ok();
        }

        //GET api/objetivos-financeiros/1
        [HttpGet("{id}")]
        public IActionResult GetPorId(int id){
            return Ok();
        }

        //POST api/objetivos-financeiros
        [HttpPost]
        public IActionResult Post(ObjetivosFinanceirosInputModel Model){
            return Ok();
        }

        //POST api/objetivos-financeiros/1
        [HttpPost("{id}/operacoes")]
        public IActionResult PostOperacao(){
            
        }
    }
}