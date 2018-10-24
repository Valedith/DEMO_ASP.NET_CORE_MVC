using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DEMO_ASP.NET_CORE_MVC.Models
{
    public class Recipe
    {
        public int ID { get; set; }
        public string RecipeName { get; set; }
        public int Quantity { get; set; }
        public bool isAvailable { get; set; }

        [Display(Name = "Register Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime RegisterDate { get; set; }
    }
}
