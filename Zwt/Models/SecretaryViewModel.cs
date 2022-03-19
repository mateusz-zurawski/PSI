using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zwt.Data.Entity;

namespace Zwt.Models
{
    public class SecretaryViewModel
    {
        public AppUser User { get; set; }
        public IEnumerable<AppUser> Doctors { get; set; }
        public List<SelectListItem> DentistsSelectList { get; internal set; }
    }
}
