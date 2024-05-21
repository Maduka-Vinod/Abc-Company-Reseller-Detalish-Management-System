using AbcCompanyRDMS.Data;
using AbcCompanyRDMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace AbcCompanyRDMS.Controllers
{
    public class ResellerController : Controller
    {
        private ApplicationDbContext context;

        public ResellerController(ApplicationDbContext context)
        {
            this.context = context;
        }
        public IActionResult Index(string searchString)
        {
            var resellers = context.Resellers.ToList();
            if(!string.IsNullOrEmpty(searchString))
            {
                resellers = resellers.Where(s => s.ResellerName.Contains(searchString)||s.ResellerEmail.Contains(searchString)).ToList();
            }
            return View(resellers);
            
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        public IActionResult Create(Reseller reseller)
        {
            Reseller resellers = new Reseller()
            {
                ResellerName = reseller.ResellerName,
                ResellerAddress= reseller.ResellerAddress,
                ResellerEmail= reseller.ResellerEmail,
                ResellerPhone= reseller.ResellerPhone,
                ResellerContactPerson= reseller.ResellerContactPerson,
                ResellerContactPersonPhone= reseller.ResellerContactPersonPhone

            };
            context.Resellers.Add(reseller);
            context.SaveChanges();

            return RedirectToAction("Index","Reseller");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var reseller = context.Resellers.Find(id);
            if (reseller == null)
            {
                return RedirectToAction("Index", "Reseller");
            }

            var Reseller = new Reseller()
            {
                ResellerId = reseller.ResellerId,
                ResellerName = reseller.ResellerName,
                ResellerAddress = reseller.ResellerAddress,
                ResellerEmail = reseller.ResellerEmail,
                ResellerPhone = reseller.ResellerPhone,
                ResellerContactPerson = reseller.ResellerContactPerson,
                ResellerContactPersonPhone = reseller.ResellerContactPersonPhone
            };

            return View(Reseller);
        }
        [HttpPost]
        public IActionResult Edit(int id,Reseller reseller)
        {
            var Reseller = context.Resellers.Find(id);
            if (Reseller == null)
            {
                return RedirectToAction("Index", "Reseller");
            }
            if (!ModelState.IsValid)
            {
                return View(Reseller);
            }
            Reseller.ResellerName = reseller.ResellerName;
            Reseller.ResellerAddress = reseller.ResellerAddress;
            Reseller.ResellerEmail = reseller.ResellerEmail;
            Reseller.ResellerPhone = reseller.ResellerPhone;
            Reseller.ResellerContactPerson = reseller.ResellerContactPerson;
            Reseller.ResellerContactPersonPhone = reseller.ResellerContactPersonPhone;

            //context.Resellers.Update(reseller);
            context.SaveChanges();
            return RedirectToAction("Index", "Reseller");
        }

        public IActionResult Delete(int id)
        {
            var Reseller = context.Resellers.Find(id);
            if (Reseller == null)
            {
                return RedirectToAction("Index", "Reseller");
            }
            context.Resellers.Remove(Reseller);
            context.SaveChanges();
            return RedirectToAction("Index", "Reseller");
        }
    }
}
