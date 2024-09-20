using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Xml.Serialization;
using WebApplication2.Models;
using WebApplication2.Repositories;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly HomeRepository _repository;

        public HomeController(ILogger<HomeController> logger, HomeRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }
        [HttpPost]
        public IActionResult Index(IFormFile file)
        {
            var fileName = $"{file.FileName}";
            var fileExtension = Path.GetExtension(fileName);
            Siteinfo siteinfo = new Siteinfo();
            if (fileExtension == ".xml")
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Siteinfo));
                using (var reader = new StreamReader(file.OpenReadStream()))
                {
                    Siteinfo result = (Siteinfo)serializer.Deserialize(reader);

                    Site site = new Site();
                    Area area = new Area();
                    Unit unit = new Unit();
                    UnitType unittype = new UnitType();
                    SiteService siteservice = new SiteService();
                    Address address = new Address();
                    SiteGLCode siteGLCode = new SiteGLCode();
                    SiteCAPrimaryCharge siteCAPrimaryCharge = new SiteCAPrimaryCharge();
                    VendorAccount vendorAccount = new VendorAccount();

                    site = result.Sites.Site;
                    _repository.InsertSiteAsync(site);
                }

            }
            return View();
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
    }
}
