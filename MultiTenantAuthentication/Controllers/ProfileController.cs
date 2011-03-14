using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiTenantAuthentication.Models;
using MultiTenantAuthentication.Helpers;
using MultiTenantAuthentication.ViewModels;

namespace MultiTenantAuthentication.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        TenantRegistryEntities db = new TenantRegistryEntities();
        AppDBEntities appDb = new AppDBEntities(UserProfileHelper.ResolveUserDBConnectionString());

        //
        // GET: /Profile/

        public ActionResult Index()
        {
            // Register Username and TenantId to memory 
            UserProfileHelper.RegisterUserTenant();

            var profile = db.UserProfiles.Include("Tenant").SingleOrDefault(u => u.Username == User.Identity.Name);

            // get tenant id from memory variable
            var tid = UserProfileHelper.UserTenantLookup[User.Identity.Name].ToString();
            var customers = appDb.Customers.Where(c=> c.TenantId == tid).ToList();

            var models = new ProfileCustomerViewModel
                             {
                                 UserProfile = profile, 
                                 Customers = customers
                             };


            return View(models);
        }

        // GET: /Profile/AssignProfile

        // Assign profile to login User, using profile manager
        [HttpGet]
        public ActionResult AssignProfile()
        {
            var profile = new MultiTenantAuthentication.Models.UserProfile();

            // default value
            profile.Username = User.Identity.Name;

            return View(profile);
        }


        // POST: /Profile/AssignProfile
        [HttpPost]
        public ActionResult AssignProfile(UserProfile  profile)
        {
            profile.TenantId = "Test id";

            db.UserProfiles.AddObject(profile);
            db.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}
