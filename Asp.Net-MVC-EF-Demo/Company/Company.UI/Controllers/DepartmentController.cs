using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Company.Model;
using Company.IBLL;

namespace Company.UI.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentService departmentService = BLLContainer.Container.Resolve<IDepartmentService>();
        // GET: Department
        public ActionResult Index()
        {
            List<Department> list = departmentService.GetModels(p => true).ToList();
            return View(list);
        }

        public ActionResult Add(Department dept)
        {
            if (departmentService.Add(dept))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }

        public ActionResult Update(Department dept)
        {
            if (departmentService.Update(dept))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }

        public ActionResult Delete(int id)
        {
            var department = departmentService.GetModels(p => p.Id == id).FirstOrDefault();
            if (departmentService.Delete(department))
            {
                return Redirect("Index");
            }
            else
            {
                return Content("no");
            }
        }
    }
}