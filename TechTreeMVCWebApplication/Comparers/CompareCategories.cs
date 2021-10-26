using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
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
            throw new NotImplementedException();
        }
    }
}
