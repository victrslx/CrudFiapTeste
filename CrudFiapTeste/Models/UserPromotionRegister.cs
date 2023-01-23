using System.ComponentModel.DataAnnotations;

namespace CrudFiapTeste.Models
{
    public class UserPromotionRegister
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }
        [Range(100000000, 100000000000, ErrorMessage = "{0} exemple: 999358773 or 11999358773")]
        public int number { get; set; }
    }
}
