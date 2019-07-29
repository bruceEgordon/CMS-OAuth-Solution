using System;
using System.Linq;
using System.Web.Security;
using EPiServer.Framework;
using EPiServer.Framework.Initialization;

namespace Epidemosite.Business.Initialization
{
    [InitializableModule]
    [ModuleDependency(typeof(EPiServer.Web.InitializationModule))]
    public class AdminAccountInitializationModule : IInitializableModule
    {
        public void Initialize(InitializationEngine context)
        {
            //string virtualRoleName = "CmsAdmins";
            //string storedRoleName = "WebAdmins";
            //string userName = "Admin";
            //string password = "Pa$$w0rd";
            //string email = "admin@alloy.com";

            //MembershipUser user = Membership.GetUser(userName);

            //if(user == null)
            //{
            //    Membership.CreateUser(userName, password, email);
            //    if (!Roles.RoleExists(storedRoleName))
            //    {
            //        Roles.CreateRole(storedRoleName);
            //    }
            //    Roles.AddUserToRole(userName, storedRoleName);
            //}
        }

        public void Uninitialize(InitializationEngine context)
        {
            //Add uninitialization logic
        }
    }
}