using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using empleadosSQL.Data;
using empleadosSQL.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace empleadosSQL.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadosController : ControllerBase
    {
        private readonly EmpleadoContexto _contexto;

        public EmpleadosController(EmpleadoContexto contexto)
        {
            _contexto = contexto;
        }

        // Petición GET todos los registros: api/Empleados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Empleado>>> GetEmpleadoItems()
        {
            return await _contexto.EmpleadoItems.ToListAsync();
        }

        // Petición GET un solo registro: api/Empleados/2
        [HttpGet("{id}")]
        public async Task<ActionResult<Empleado>> GetEmpleadoItem(int id)
        {
            var empleadoItem = await _contexto.EmpleadoItems.FindAsync(id);
            if (empleadoItem == null)
            {
                return NotFound();
            }

            return empleadoItem;
        }

        // Petición POST para insertar un registro: api/Empleados
        [HttpPost]
        public async Task<ActionResult<Empleado>> PostEmpleadoItem([FromBody] Empleado empleado)
        {
            _contexto.EmpleadoItems.Add(empleado);
            await _contexto.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmpleadoItem), new { id = empleado.Id }, empleado);
        }

        // Petición PUT para actualizar un registro: api/Empleados/2
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmpleadoItem(int id, [FromBody] Empleado empleado)
        {
            if (id != empleado.Id)
            {
                return BadRequest();
            }

            _contexto.Entry(empleado).State = EntityState.Modified;
            await _contexto.SaveChangesAsync();

            return NoContent();
        }

        // Petición DELETE para borrar un registro: api/Empleados/2
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmpleadoItem(int id)
        {
            var empleadoItem = await _contexto.EmpleadoItems.FindAsync(id);
            if (empleadoItem == null)
            {
                return NotFound();
            }

            _contexto.EmpleadoItems.Remove(empleadoItem);
            await _contexto.SaveChangesAsync();

            return NoContent();
        }
    }
}
