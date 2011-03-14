using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MultiTenantAuthentication.Models;

namespace MultiTenantAuthentication.Helpers
{
    public class UserProfileHelper
    {
        public static Hashtable UserTenantLookup = new Hashtable();

        // resolve the connection string of AppDB against the current user
        private static string ResolveUserDBConnectionStringName()
        {
            TenantRegistryEntities db = new TenantRegistryEntities();
            var userDB = db.UserProfiles.Include("Tenant").Single(u=> u.Username == HttpContext.Current.User.Identity.Name);

            return userDB.Tenant.ConnectionStringName;

        }

        // Get the connection string for the db that the current user login belong to
        public static string ResolveUserDBConnectionString()
        {
            return System.Configuration.ConfigurationManager.ConnectionStrings[ResolveUserDBConnectionStringName()].ToString();
        }

        // regist the Username and TenantId pair to hash table
        public static void RegisterUserTenant()
        {

            // Get tenant id from database
            TenantRegistryEntities db = new TenantRegistryEntities();
            var userDB = db.UserProfiles.Include("Tenant").Single(u=> u.Username == HttpContext.Current.User.Identity.Name);

            // check if UserTenant hash table contain the user record
            if (!UserTenantLookup.ContainsKey(HttpContext.Current.User.Identity.Name))
            { 
                // add to hash table if user was not found in hash table (new login)
                UserTenantLookup.Add(HttpContext.Current.User.Identity.Name, userDB.Tenant.id);
            }
        }
    }
}