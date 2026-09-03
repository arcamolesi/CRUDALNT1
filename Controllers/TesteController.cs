using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUDALNT1.Data;
using CRUDALNT1.Models;
using Microsoft.AspNetCore.Mvc;


namespace CRUDALNT1.Controllers
{
    public class TesteController: Controller
    {
        private readonly AppDbContext contexto; 

         public TesteController(AppDbContext contexto)
        {
            this.contexto = contexto;
        }
    
        public IActionResult Mostrar()
        {
            return View();
        }  

        public IActionResult Index()
        {
            var alunos = contexto.Alunos.; 
            return View(alunos.ToList());
        }

    }
}