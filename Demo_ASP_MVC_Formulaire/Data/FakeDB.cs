using Demo_ASP_MVC_Formulaire.Models;

namespace Demo_ASP_MVC_Formulaire.Data
{
    public static class FakeDB
    {
        public static ICollection<Person> People = new List<Person>
        {
            new Person
            {
                Id = 1,
                Firstname = "Zaza",
                Lastname = "Vanderquack",
                Email= "z.vanderquack@gmail.com"
            },
            new Person
            {
                Id = 2,
                Firstname = "Della",
                Lastname = "Duck",
                Email= "della.duck@outlook.com"
            },
            new Person
            {
                Id = 3,
                Firstname = "Gontran",
                Lastname = "Bonheur",
                Email= "g.bonheur@yahoo.fr"
            }
        };

        public static int LastId { get; set; } = 3;
    }
}
