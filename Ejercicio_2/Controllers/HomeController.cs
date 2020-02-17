using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ejercicio_2.Models;
using Ejercicio_2.Helpers;

namespace Ejercicio_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Valores a)
        {
            if (ModelState.IsValid)
                return RedirectToAction("Presentar", a);
            return View(a);
        }

        public IActionResult Presentar(Valores a)
        {
            List<int> numeros = new List<int>();
            numeros.Add(a.numero0);
            numeros.Add(a.numero1);
            numeros.Add(a.numero2);
            numeros.Add(a.numero3);
            numeros.Add(a.numero4);
            numeros.Add(a.numero5);
            numeros.Add(a.numero6);
            numeros.Add(a.numero7);
            numeros.Add(a.numero8);
            numeros.Add(a.numero9);


            a.mayor = Comparar.elMayor(numeros);
            a.menor = Comparar.elMenor(numeros);

            numeros.Add(a.mayor);
            numeros.Add(a.menor);

            return View(numeros);
        }

       

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
