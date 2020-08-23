using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace ChefsDishes.Models
{
    public class Dish
    {
        [Key]
        public int DishId {get;set;}
        public string Name{get;set;}
        public int Tastiness {get;set;}
        public int Calories {get;set;}
        public string Description {get;set;}
        public int ChefId{get;set;}
        public Chef Creator {get;set;}
        
    }
}