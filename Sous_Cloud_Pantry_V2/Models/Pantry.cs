﻿using System;
using System.Collections.Generic;

#nullable disable

namespace Sous_Cloud_Pantry_V2.models
{
    public partial class Pantry
    {
        public int? UserId { get; set; }
        public string PantryLocation { get; set; }

        public virtual UserTable User { get; set; }
    }
}
