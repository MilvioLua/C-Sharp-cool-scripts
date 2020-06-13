using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorUI.Pages.Forms
{       
    public class addressModel : PageModel
    {
        [BindProperty]
        public Models.Address Addddress { get; set; }
        public void OnGet()
        {

        }

        public IActionResult onPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("/index");
        }
    }
}