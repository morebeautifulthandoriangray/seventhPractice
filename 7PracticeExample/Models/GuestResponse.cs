using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _7PracticeExample.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Пожалуйста, введите своё имя")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите свой email")]
        [RegularExpression("\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*", ErrorMessage = "Вы ввели некорректный email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Пожалуйста, введите телефон")]
        [RegularExpression("^[\\+]?[(]?[0-9]{3}[)]?[-\\s\\.]?[0-9]{3}[-\\s\\.]?[0-9]{4,7}$", ErrorMessage = "Вы ввели некорректный номер телефона")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Пожалуйста, Укажите, примите ли вы участие в вечеринке")]
        public Boolean WillAttend { get; set; }
    }
}