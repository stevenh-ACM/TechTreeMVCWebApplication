using System;
using System.Collections.Generic;
<<<<<<< HEAD
using System.Linq;
=======
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
using System.Threading.Tasks;
using TechTreeMVCWebApplication.Entities;

namespace TechTreeMVCWebApplication.Data
{
    public class DataFunctions : IDataFunctions
    {
        private readonly ApplicationDbContext _context;

        public DataFunctions(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task UpdateUserCategoryEntityAsync(List<UserCategory> userCategoryItemsToDelete, List<UserCategory> userCategoryItemsToAdd)
        {
            using (var dbContextTransaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {

                    _context.RemoveRange(userCategoryItemsToDelete);
                    await _context.SaveChangesAsync();

                    if (userCategoryItemsToAdd != null)
                    {
                        _context.AddRange(userCategoryItemsToAdd);
                        await _context.SaveChangesAsync();
                    }
                    await dbContextTransaction.CommitAsync();

                }
<<<<<<< HEAD

=======
>>>>>>> 5e70a58685a3b76d1267297bc365fd9bd4d8cd67
                catch (Exception ex)
                {
                    await dbContextTransaction.DisposeAsync();
                }
            }
        }
    }
}
