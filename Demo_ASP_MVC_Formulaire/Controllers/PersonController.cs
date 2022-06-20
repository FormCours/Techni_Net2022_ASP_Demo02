using Demo_ASP_MVC_Formulaire.Data;
using Demo_ASP_MVC_Formulaire.Models;
using Microsoft.AspNetCore.Mvc;

namespace Demo_ASP_MVC_Formulaire.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            // La list de personne
            IEnumerable<Person> people = FakeDB.People.OrderBy(p => p.Lastname);

            // Envoi de la liste de données
            return View(people);
        }

        public IActionResult Add()
        {
            Console.WriteLine("Affichage du formulaire (GET)");
            // Le formulaire d'ajout

            return View(new PersonForm());
        }

        [HttpPost]
        public IActionResult Add([FromForm] PersonForm personForm)
        {
            Console.WriteLine("Reception des données du formulaire (POST)");

            // Traitement des données
            if (!ModelState.IsValid)
            {
                return View(personForm);
            }

            // Ajout dans la liste
            int id = ++FakeDB.LastId;

            FakeDB.People.Add(new Person
            {
                Id = id,
                Firstname = personForm.Firstname,
                Lastname = personForm.Lastname,
                Email = personForm.Email
            });

            // Redirection vers la liste
            return RedirectToAction(nameof(Index)); 
        }
    }
}
