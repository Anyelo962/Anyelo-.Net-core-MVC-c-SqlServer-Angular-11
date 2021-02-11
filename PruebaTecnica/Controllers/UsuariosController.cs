using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PruebaTecnica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly EmpresaContext context;

        public UsuariosController(EmpresaContext context)
        {
            this.context = context;
        }

        // GET: api/<UsuariosController>
        [HttpGet]
        public async Task<IActionResult> GetUsuarios()
        {
            var lista = await context.Usuario.ToListAsync();
            return Ok(lista);
        }

        // GET api/<UsuariosController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<UsuariosController>
        [HttpPost]

        public async Task<IActionResult> Agregar(Usuario usuario)
        {
            var addUsuario = context.Add(usuario);
            await context.SaveChangesAsync();

            return Ok(addUsuario);
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartamento()
        {
            var getDepartment = context.Departamento.ToListAsync();


            return Ok(getDepartment);

        }

        // PUT api/<UsuariosController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<UsuariosController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
