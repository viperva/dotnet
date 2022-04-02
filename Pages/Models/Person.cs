using System.ComponentModel.DataAnnotations;

namespace proj.Models{
    public class Person{

        [Required(ErrorMessage = "Pole '{0}' jest wymagane."), Range(1899, 2022, ErrorMessage = "Oczekiwana wartość '{0}', z zakresu {1} - {2}.")]
        [Display(Name = "Rok urodzenia")]
        public int? Year {get; set;}

        [Required(ErrorMessage = "Pole '{0}' jest wymagane."), StringLength(100)]
        [Display(Name = "Imię")]
        public string? Name {get; set;}

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