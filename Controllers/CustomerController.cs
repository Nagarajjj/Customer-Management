using CustomerManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CustomerManagement.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            Nagaraj_DBContext _context = new Nagaraj_DBContext();
            var model = _context.CustomerTable.ToList();
            return View(model);

        }
        public IActionResult Edit(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("Id must be set");
            int aId = int.Parse(id);

            Nagaraj_DBContext context = new Nagaraj_DBContext();
            var model = context.CustomerTable.FirstOrDefault((a) => a.CustId == aId);
            if (model == null) throw new Exception("Customer not found");
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(CustomerTable model)
        {
            Nagaraj_DBContext _context = new Nagaraj_DBContext();
            var selected = _context.CustomerTable.FirstOrDefault((a) => a.CustId == model.CustId);
            if (selected == null) throw new Exception("Failed to get the Customer details");
            selected.CustPhoto = model.CustPhoto;
            selected.CustName = model.CustName;
            selected.CustAddress = model.CustAddress;
            selected.CustBarrowedBooks = model.CustBarrowedBooks;
            _context.SaveChanges();
            return RedirectToAction("Index");



        }

        public IActionResult AddNew()
        {
            return View(new CustomerTable());
        }
        [HttpPost]
        public IActionResult AddNew(CustomerTable model)
        {
            Nagaraj_DBContext _context = new Nagaraj_DBContext();
            _context.CustomerTable.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(string id)
        {
            if (string.IsNullOrEmpty(id))
                throw new Exception("ID Must be set");
            int CId = int.Parse(id);
            Nagaraj_DBContext _context = new Nagaraj_DBContext();
            var model = _context.CustomerTable.FirstOrDefault((e) => e.CustId == CId);
      
            if (model == null) throw new Exception("Customer not found");
            
            _context.CustomerTable.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }

    
}
