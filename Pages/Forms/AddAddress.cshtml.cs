using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContactLista.Pages.Forms
{
    public class AddAddressModel : PageModel
    {

        [BindProperty]

        public AddAddressModel Address { get; set; }

        public void OnGet()
        {

        }
    }
}
