using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
<<<<<<< HEAD
using System.Linq;
using System.Threading.Tasks;
using TechTreeMVCWebApplication.Areas.Admin.Models;
=======
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
using TechTreeMVCWebApplication.Entities;

namespace TechTreeMVCWebApplication.Comparers
{
    public class CompareCategories : IEqualityComparer<Category>
    {
        public bool Equals(Category x, Category y)
        {
            if (y == null) return false;

            if (x.Id == y.Id)
                return true;

            return false;

        }

        public int GetHashCode([DisallowNull] Category obj)
        {
<<<<<<< HEAD
           return obj.Id.GetHashCode();
=======
            throw new NotImplementedException();
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
        }
    }
}
