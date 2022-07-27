using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebAppForRemoteDebug.Views
{
    public class MyPage : PageModel
    {
        public void OnGet()
        {
            Console.WriteLine("qweqwewq");
        }
    }
}