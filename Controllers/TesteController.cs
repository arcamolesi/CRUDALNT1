using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDALNT1.Data;
using CRUDALNT1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CRUDALNT1.Controllers
{
    public class TesteController : Controller
    {
        private readonly AppDbContext contexto;

        public TesteController(AppDbContext context)
        {
            contexto = context;
        }

        public IActionResult Mostrar()
        {
            return View();
        }

        // GET: Alunos
        public async Task<IActionResult> Index()
        {
            var appDbContext = contexto.Alunos.Include(a => a.curso);
            return View(await appDbContext.ToListAsync());
        }

        // GET: Alunos/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["cursoid"] = new SelectList(contexto.Cursos, "id", "sigla");
            return View();
        }

              // POST: Alunos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id,nome,idade,cursoid,nota")] Aluno aluno)
        {
            if (ModelState.IsValid)
            {
                contexto.Add(aluno);
                await contexto.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["cursoid"] = new SelectList(contexto.Cursos, "id", "area", aluno.cursoid);
            return View(aluno);
        }


       // GET: Alunos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var aluno = await contexto.Alunos.Include(a => a.curso)
            .FirstOrDefaultAsync(m => m.id == id);
            if (aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

    }
}
