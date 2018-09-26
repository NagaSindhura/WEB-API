using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Controllers
{
    using EventManagement.Models;

    public class ProgramController : Controller
    {
        // GET: Program
        [HttpGet]
        public ActionResult CreateProgram()
        {
            Program program = new Program();

            return View();
        }

        //[HttpPost]
        public ActionResult PartialProgramWebGrid1(FormCollection formCollection)
        {
            Program program = new Program();
            List<Program> listPrograms = new List<Program>();

            if (ModelState.IsValid)
            {

                program.Name = formCollection["Name"];
                program.Product = formCollection["Product"];

                if (TempData.ContainsKey("Programs"))
                {

                    listPrograms = (List<Program>)TempData.Peek("Programs");
                    listPrograms.Add(program);
                }

                else
                {
                    listPrograms.Add(program);

                    TempData["Programs"] = listPrograms;
                }

                //return this.View();
                //return PartialView("_ProgramWebGrid", listPrograms);
            }


            return RedirectToAction("PartialProgramWebGrid");
        }

        //[HttpGet]
        public PartialViewResult PartialProgramWebGrid()
        {
            IList<Program> listPrograms = new List<Program>();
            if (TempData.ContainsKey("Programs"))
            {
                listPrograms = (List<Program>)TempData.Peek("Programs");
            }

            return PartialView("Shared/_ProgramWebGrid", listPrograms); 
        }
    }
}