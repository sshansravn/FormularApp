using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormularApp.Models;


// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FormularApp.Controllers
{



    public class ModtagFormularController : Controller
    {
        // GET: /<controller>/
        /* public IActionResult Index()
         {
             return View();
         }
         */

        [HttpPost]
        public IActionResult Index(string navn, string email, string telefon)
        {
            var fieldNavn = navn;
            var fieldEmail = email;
            var fieldTelefon = telefon;

            var formularModel = new FormModel(){ navn = fieldNavn, email=fieldEmail, telefon=fieldTelefon };
            return View(formularModel);
        }
        
        /*[HttpPost]
        public IActionResult Index(string navn, string email, string telefon)
        {
            var formnavn = navn;
            var formemail = email;
            var formtelefon = telefon;

            var FormModel = new FormModel()
            {navn = "Ha";
            
        
            }
           
        }*/
    }
}
