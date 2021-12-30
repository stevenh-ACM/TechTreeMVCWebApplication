<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;
using System.Linq;
=======
﻿using System.Collections.Generic;
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
using System.Threading.Tasks;
using TechTreeMVCWebApplication.Entities;

namespace TechTreeMVCWebApplication.Data
{
    public interface IDataFunctions
    {
        Task UpdateUserCategoryEntityAsync(List<UserCategory> userCategoryItemsToDelete, List<UserCategory> userCategoryItemsToAdd);
    }
}
