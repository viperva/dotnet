using System.ComponentModel.DataAnnotations;

namespace proj.Models{
    public class People{

        public List<Person> people {get; set;}

        public People(){

            people = new List<Person>();

        }

    }
}