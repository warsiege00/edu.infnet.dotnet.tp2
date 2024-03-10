using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dotnet_tp2.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnet_tp2.Pages
{
	public class PessoaPageModel : PageModel
    {
        public List<Pessoa> Pessoas { get; set; }

        public void OnGet()
        {
            Pessoas = new List<Pessoa>
            {
                new Pessoa("João", 30, "123.456.789-00"),
                new Pessoa("Maria", 25, "987.654.321-00"),
                new Pessoa("José", 40, "111.222.333-44")
            };
        }
    }
}
