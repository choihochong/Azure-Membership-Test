using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace MultiTenantAuthentication.Models
{
    [MetadataType(typeof(TenantMetaData))]
    public partial class Tenant
    {
        

    }

    public class TenantMetaData
    {
        [Required]
        [DisplayName("Tenant Name (Company Name)")]
        public string Name { get; set; }

        
    }
}