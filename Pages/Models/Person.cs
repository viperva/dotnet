using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace proj.Models{
    public class Person{

        public int Id {get; set;}

        [Required(ErrorMessage = "Pole '{0}' jest wymagane."), Range(1899, 2022, ErrorMessage = "Oczekiwana wartość '{0}', z zakresu {1} - {2}.")]
        [Display(Name = "Rok urodzenia")]
        public int? Year {get; set;}

        [Required(ErrorMessage = "Pole '{0}' jest wymagane."), StringLength(100)]
        [MaxLength(100)]
        [Column(TypeName="varchar(100)")]
        [Display(Name = "Imię")]
        public string? Name {get; set;}

        [MaxLength(100)]
        [Display(Name = "Nazwisko")]
        public string? LastName {get; set;}

        public DateTime date {get; set;}
        public TimeSpan time {get; set;}

        public string process(){

            string result = "";

            if ((this.Year is null) || (this.Name is null)){
                return "";
            }else{

                if(this.Name[this.Name.Length-1] == 'a'){
                result = char.ToUpper(this.Name[0]) + this.Name.Substring(1) + " urodziła się w " + this.Year + " roku. ";
                }else{
                    result = char.ToUpper(this.Name[0]) + this.Name.Substring(1) + " urodził się w " + this.Year + " roku. ";
                }

                if(this.Year % 4 == 0){
                    result += "To był rok przystępny.";
                    }else{
                        result += "To nie był rok przystępny.";
                    }
                
                return result;
            }
        }

    }
}