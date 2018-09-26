using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EventManagement.Controllers
{
    using EventManagement.Models;
    using EventManagement.Models.DTO;

    public class ProgramController : Controller
    {
        //private List<ProgramView> p = new List<ProgramView>() { new ProgramView { Name = "hi", Product = "Hello" } };
        private List<ProgramView> ProgramViewList = new List<ProgramView>();

        // GET: Program
        [HttpGet]
        public ActionResult CreateProgram()
        {
            return View(ProgramViewList);
        }

        [HttpPost]
        public ActionResult CreateProgram(ProgramView ProgramView)
        {
            if (ModelState.IsValid)
            {
                if (TempData["Users"] != null)
                {
                    ProgramViewList = (List<ProgramView>)TempData.Peek("Users");
                }

                this.ProgramViewList.Add(ProgramView);
                TempData["Users"] = this.ProgramViewList;
            }

            return View(ProgramViewList);
        }

        public ActionResult GetPrograms()
        {
            return View(TempData.Peek("Users"));
        }

        public string DeleteProgram(int Programid)
        {
            if (ModelState.IsValid)
            {
                if (TempData.ContainsKey("Users"))
                {
                    ProgramViewList = TempData.Peek("Users") as List<ProgramView>;
                }

                if (ProgramViewList != null)
                {
                    ProgramViewList.Remove(ProgramViewList.SingleOrDefault(p => p.ProgramID == Programid));
                }

                TempData["Users"] = this.ProgramViewList;

                return "Successfully delete";
            }

            return "Failed to delete the record";
        }

    }
}