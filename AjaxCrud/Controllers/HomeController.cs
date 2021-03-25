using AjaxCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxCrud.Controllers
{
    public class HomeController : Controller
    {
        private readonly TransactionDbContext _context;

        public HomeController(TransactionDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(TransactionModel model)
        {



                using (var transaction = _context.Database.BeginTransaction())
                {
                    try
                    {


                            var NewTransaction = new TransactionModel
                            {
                                BankName = model.BankName,
                                AccountNumber = model.AccountNumber
                            };

                            _context.transactions.Add(NewTransaction);
                            _context.SaveChanges();


                             throw new Exception();


                            var Test = new TestModel
                            {
                               AccountNumber = model.AccountNumber
                            };

                            _context.Test.Add(Test);
                            _context.SaveChanges();


                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                    }
                }




            return View();
        }




        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
