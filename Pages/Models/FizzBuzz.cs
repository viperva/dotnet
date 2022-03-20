using System.ComponentModel.DataAnnotations;

namespace proj.Models{
    public class FizzBuzz{

        [Required, Range(1, 100, ErrorMessage = "Oczekiwana wartość {0} z rzędu {1} a {2}.")]
        [Display(Name = "Szczęśliwy numerek")]
        public int? Number {get; set;}

        public string process(){
            if (this.Number is null){
                return "";
            }else{
                if(this.Number % 15 == 0)return "FizzBuzz";
                if(this.Number % 3 == 0)return "Fizz";
                if(this.Number % 5 == 0)return "Buzz";
                return "Liczba: " + this.Number + " nie spelnia kryteriow FizzBuzz";
            }
        }

    }
}