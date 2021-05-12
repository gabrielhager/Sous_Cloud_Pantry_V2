using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry_V2.models
{
    public partial class Recipe
    {
        public int RecipeId { get; set; }
        public string Title { get; set; }
        public string IngredientList { get; set; }
        public string UserName { get; set; }
    }
}
