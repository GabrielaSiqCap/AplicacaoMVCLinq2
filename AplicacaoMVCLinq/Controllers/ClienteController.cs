using AplicacaoMVCLinq.Models;
using Microsoft.AspNetCore.Mvc;

namespace AplicacaoMVCLinq.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetClientes()
        {
            Cliente c1 = new Cliente(1, "Gabriela", "gabrilasiqueiracaputti@gmail.com", "99824-6236", new DateOnly(2008, 03, 16));
            Cliente c2 = new Cliente(2, "Ana Laura Gomes", "ana.laura@gmail.com", "99835-6789", new DateOnly(2000, 01, 28));
            Cliente c3 = new Cliente(3, "Livia Modesto Ormeleze ", "livia.ormeleze@portalsesisp.org.br", "99824-6236", new DateOnly(2005, 07, 22));
            Cliente c4 = new Cliente(4, "Bruno Santos", "bruno.maromba@portalsesisp.org.br ", "99824-6236", new DateOnly(2007, 05, 19));
            Cliente c5 = new Cliente(5, "Ana Clara de Souza", "ana.souzaportalsesisp.org.br", "99824-6236", new DateOnly(2011, 12, 04));

            List<Cliente> listaClientes = new List<Cliente>();
            listaClientes.Add(c1);
            listaClientes.Add(c2);
            listaClientes.Add(c3);
            listaClientes.Add(c4);
            listaClientes.Add(c5);
            return View(listaClientes);
        }
    }
}