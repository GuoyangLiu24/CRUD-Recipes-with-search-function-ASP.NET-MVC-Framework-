using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Recipes.Models
{
    public class Recipe
    {
        public int RecipeID { get; set; }
        [Required(ErrorMessage = "Please enter your recipe's name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter the main ingredients")]
        public string MainIngredients { get; set; }
        [Required(ErrorMessage = "Please enter the whole ingredients")]
        public string Ingredients { get; set; }
        [Required(ErrorMessage = "Please enter the whole steps")]
        public string Steps { get; set; }
        [Required(ErrorMessage = "Please enter how many yields it serve")]
        public decimal Yields { get; set; }
        [Required(ErrorMessage = "Please enter the total time it cost")]
        public decimal Minutes { get; set; }

    }
}
