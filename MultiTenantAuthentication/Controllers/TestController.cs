using System.Linq;
using System.Web.Mvc;
using MultiTenantAuthentication.Helpers;
using MultiTenantAuthentication.Models;
using System.Web.Security;
using System.Web.Routing;

namespace MultiTenantAuthentication.Controllers
{
    public class TestController : Controller
    {
        public IFormsAuthenticationService FormsService { get; set; }
        public IMembershipService MembershipService { get; set; }

        protected override void Initialize(RequestContext requestContext)
        {
            if (FormsService == null) { FormsService = new FormsAuthenticationService(); }
            if (MembershipService == null) { MembershipService = new AccountMembershipService(); }

            base.Initialize(requestContext);
        }
        //
        // GET: /Test/

        public ActionResult Index()
        {
            return View();
        }

        // GET: /Test/ListCustomer
        public ActionResult ListCustomer()
        {
            var tenantDb = new TenantRegistryEntities();
            var appDb = new AppDBEntities(UserProfileHelper.ResolveUserDBConnectionString());

            // Register Username and TenantId to memory 
            UserProfileHelper.RegisterUserTenant();

            // get tenant id from memory variable
            var tid = UserProfileHelper.UserTenantLookup[User.Identity.Name].ToString();
            var customers = appDb.Customers.Where(c => c.TenantId == tid);

            return View(customers);
        }

        // GET: /Test/ListAllCustomer
        public  ActionResult ListAllCustomer()
        {
            var tenantDb = new TenantRegistryEntities();
            var appDb = new AppDBEntities(UserProfileHelper.ResolveUserDBConnectionString());

            var customers = appDb.Customers.ToList();

            return View(customers);
        }

        // GET: /Test/CreateLoginForExistingTenant
        [HttpGet]
        [Authorize]
        public ActionResult CreateLoginForExistingTenant()
        {
            //var appDb = new AppDBEntities(UserProfileHelper.ResolveUserDBConnectionString());
            //var belongToTenant =  
            //var login = new TenantLoginViewModel
            //{
            //    Tenant = new Tenant(),
            //    UserProfile = new UserProfile()
            //};


            //ViewBag = 

            //// Test default values

            //return View(login);   
            return View();
        }


        // GET: /Test/CreateLogin
        /// <summary>
        /// Create login for new company
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult CreateLogin()
        {
            var login = new TenantLoginViewModel
            {
                Tenant = new Tenant { Name = "required" },
                UserProfile = new UserProfile { Username = "required too" }
            };

            return View(login);
        }

       

        // POST: /Test/CreateLogin
        /// <summary>
        /// Create login for new company
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult CreateLogin(FormCollection form, TenantLoginViewModel model)
        {
            //todo: implement role for users!  Please design the architecture first!!!
            var tenantDb = new TenantRegistryEntities();
            var tenant = new Tenant
            {
                id = System.Guid.NewGuid().ToString(),
                Name = model.Tenant.Name,
                db = System.Web.Configuration.WebConfigurationManager.AppSettings["NewTenantDatabaseName"],  // todo: Default Tenant db must be get from a separate class
                ConnectionStringName = System.Web.Configuration.WebConfigurationManager.AppSettings["NewTenantConnectionString"] // todo: Tenant connection string must be get from a separate class
            };

            var userprofile = new UserProfile
            {
                Username = model.UserProfile.Username,
                FirstName = model.UserProfile.FirstName,
                LastName = model.UserProfile.LastName
            };


            // Save tenant
            tenant.UserProfiles.Add(userprofile);
            tenantDb.Tenants.AddObject(tenant);
            tenantDb.SaveChanges();


            // Create asp.net login
            if (ModelState.IsValid)
            {
                // Attempt to register the user
                var pw = form["Password"].ToString();
                var email = form["Email"].ToString();
                MembershipCreateStatus createStatus = MembershipService.CreateUser(model.UserProfile.Username, pw, email);

                if (createStatus == MembershipCreateStatus.Success)
                {
                    //FormsService.SignIn(model.UserProfile.Username, false /* createPersistentCookie */);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError("", AccountValidation.ErrorCodeToString(createStatus));
                }
            }

            return View("Index");
        }
    }
}
