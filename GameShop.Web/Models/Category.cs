using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace GameShop.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Поле 'Title' не заполнено")]
        [MaxLength(50, ErrorMessage = "Длинна должна быть не более 50 символов")]
        [MinLength(10, ErrorMessage = "Длинна должна быть не менее 10 символов")]
        public string Title { get; set; }
    }
}
