using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationPrueba.Data;
using WebApplicationPrueba.Entities;

namespace WebApplicationPrueba.Controllers
{
    public class ConsultasController : Controller
    {
        readonly ApplicationDbContext _context;
        public ConsultasController(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }

        public IEnumerable<Departamento> Departamentos()
        {
            return _context.Departamentos;
             
        }

        public IEnumerable<Empleado> Empleados()
        {
            //return _context.Empleados.OrderBy(x => x.Apellido);

            //return _context.Empleados.OrderByDescending(x => x.Apellido);

            //return _context.Empleados.OrderBy(x => x.Nombre).ThenBy(x => x.Apellido);

            var empleados = _context.Empleados.ToList();
            return empleados.OrderBy(e => e.NombreCompleto);
        }
    }
}
