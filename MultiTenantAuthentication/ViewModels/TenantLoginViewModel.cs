namespace MultiTenantAuthentication.Models
{
    public class TenantLoginViewModel
    {
        public Tenant Tenant { get; set; }
        public UserProfile UserProfile { get; set; }
    }
}