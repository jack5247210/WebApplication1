using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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


        public void OnGet()
        {
            using (weiDBContext context = new weiDBContext())
            {
                Table1 table1 = new Table1()
                {
                    Guid = Guid.NewGuid().ToString(),
                    Name = "Test",
                    Age = 7,
                    Ip = "192.168.1.106"
                };
                context.Table1s.Add(table1);
                context.SaveChanges();
            }
        }

        public List<Table1> Testlist()
        {
            using (weiDBContext context = new weiDBContext())
            {
                List<Table1> list = context.Table1s.Where(x=>x==x).ToList();
                context.
                return list;
            }
        }
    }
}

