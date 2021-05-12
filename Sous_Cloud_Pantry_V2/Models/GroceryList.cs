using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry_V2.models
{
    public partial class GroceryList
    {
        public int UserId { get; set; }
        public string ListItem { get; set; }
        public string UserName { get; set; }
    }
}
