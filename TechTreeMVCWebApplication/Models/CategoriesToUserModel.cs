<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
=======
﻿using System.Collections.Generic;
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
using TechTreeMVCWebApplication.Entities;

namespace TechTreeMVCWebApplication.Models
{
    public class CategoriesToUserModel
    {
        public string UserId { get; set; }
        public ICollection<Category> Categories { get; set; }
<<<<<<< HEAD
=======

>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
        public ICollection<Category> CategoriesSelected { get; set; }

    }
}
