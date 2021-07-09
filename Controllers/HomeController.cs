using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using AspNetCoreUploadTest.Models.InputModels;

namespace AspNetCoreUploadTest.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View(new ContattoInputModel());
        }

        [HttpPost]
        public IActionResult Index(ContattoInputModel inputModel, [FromServices] IWebHostEnvironment env)
        {
            if (ModelState.IsValid)
            {
                return View("Grazie");
            }

            return View(inputModel);

            // This file will be saved in the wwwroot directory, if it's <100Kb
            // That's the limit configured in the appsettings.json file
            // TODO: Warning: we're not sanitizing the filename provided by the user
            /*string filePath = Path.Combine(env.WebRootPath, image.FileName);
            using var fileStream = System.IO.File.OpenWrite(filePath);
            image.CopyToAsync(fileStream);*/
        }
    }
}
