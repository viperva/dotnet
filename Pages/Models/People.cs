using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace proj.Models{
    public class People{

        public List<Person> people {get; set;}

        public People(){

            people = new List<Person>();

        }

    }
}