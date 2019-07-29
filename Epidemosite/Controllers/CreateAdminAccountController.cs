using EPiServer.Personalization;
using EPiServer.Shell.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Profile;

namespace Epidemosite.Controllers
{
    public class CreateAdminAccountController : Controller
    {
        private UIUserProvider _uiUserProvider;
        private UIRoleProvider _uiRoleProvider;

        public CreateAdminAccountController(UIUserProvider uIUserProvider, UIRoleProvider uIRoleProvider)
        {
            _uiUserProvider = uIUserProvider;
            _uiRoleProvider = uIRoleProvider;
        }

        public ActionResult Index()
        {
            var admin = _uiUserProvider.GetUser("Admin");

            return View(admin);

        }
        public ActionResult CreateAdmin()
        {
            string storedRoleName = "WebAdmins";
            string userName = "Admin";
            string password = "Pa$$w0rd";
            string email = "admin@alloy.com";

            var admin = _uiUserProvider.GetUser(userName);

            if (admin == null)
            {
                UIUserCreateStatus status;
                IEnumerable<string> errors = Enumerable.Empty<string>();
                _uiUserProvider.CreateUser(userName, password, email, null, null, true, out status, out errors);

                _uiRoleProvider.CreateRole(storedRoleName);
                _uiRoleProvider.AddUserToRoles(userName, new string[] { storedRoleName });

                if (ProfileManager.Enabled)
                {
                    var profile = EPiServerProfile.Wrap(ProfileBase.Create(userName));
                    profile.Email = email;
                    profile.Save();
                }
            }

            return RedirectToAction("Index");
        }

    }
}