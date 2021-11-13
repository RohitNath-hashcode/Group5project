using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.IO;
using Group5Try1.Models;
using Microsoft.AspNetCore.Http;

namespace Group5Try1.Controllers
{
    [Route("Api/new")]
    [ApiController]
    public class ApiController : Controller
    {
        private SettingDbContext Context;
        public ApiController(SettingDbContext context)
        {
            Context = context;
        }
        
        [HttpGet]
        [Route("ShowAll")]
        public IActionResult ShowAll()
        {
            var AllAccountSetting = from setting in Context.Settings
                                    join speciality in Context.Specialities
                                    on setting.Speciality_id equals speciality.Id
                                    select new {setting,speciality};
            return Ok(AllAccountSetting);
        }

        [HttpGet]
        [Route("SearchAccount/{name?}")]
        public IActionResult SearchAccount(string name)
        {
            if (string.IsNullOrEmpty(name))
                return BadRequest();
            var AccountSetting = from setting in Context.Settings.Where(n => n.Name == name)
                                    join speciality in Context.Specialities
                                    on setting.Speciality_id equals speciality.Id
                                    join plocation in Context.PLocations
                                    on setting.PLocation_id equals plocation.Id
                                    select new { setting, speciality, plocation };
            return Ok(AccountSetting);
        }

        [HttpGet]
        [Route("SearchAccountById/{id?}")]
        public IActionResult SearchAccount(int? id)
        {
            if (id==null)
                return BadRequest();
            var AccountSetting = from setting in Context.Settings.Where(n => n.Id == id)
                                 join speciality in Context.Specialities
                                 on setting.Speciality_id equals speciality.Id
                                 join plocation in Context.PLocations
                                 on setting.PLocation_id equals plocation.Id
                                 select new { setting, speciality, plocation };
            return Ok(AccountSetting);
        }

        [HttpPost]
        [Route("UpdateAccount")]
        public IActionResult UpdateAccount([FromForm] Setting setting)
        {
            var files = HttpContext.Request.Form.Files;
            foreach (var formFile in files)
            {
                setting.PImage = formFile.ToString();
            }
            

            Context.Settings.Add(setting);
            Context.SaveChanges();

            return RedirectToAction("Index", "Setting");
        }

        [HttpPost]
        [Route("AddAccount")]
        public IActionResult AddAccount([FromForm] Setting setting)
        {
            Context.Settings.Add(setting);
            Context.SaveChanges();

            return RedirectToAction("Index", "Setting");
        }
    }
}
