using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Store.Models;

namespace Store.Controllers
{
[Route("v1")] //Prefixo
public class HomeController : Controller
{
[Route("")]
[HttpGet]
    public IEnumerable<Products> Get()
{
    var listaproduct = new List<Products>();
    listaproduct.Add(new Products{Title = "Mouse"});
    return listaproduct;
}
   
}
}
