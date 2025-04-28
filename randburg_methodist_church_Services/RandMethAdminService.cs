using Microsoft.EntityFrameworkCore;
using randburg_methodist_church_DAL;

namespace randburg_methodist_church_Services
{
    public interface IRandMethAdminService
    {
        Task<RandMethAdmin?> GetByUsernameAsync(string username);
    }
    public class RandMethAdminService : IRandMethAdminService
    {
        private readonly RandburgChurchDAL _context;
        public RandMethAdminService(RandburgChurchDAL context)
        {
            _context = context;
        }
        public async Task<RandMethAdmin?> GetByUsernameAsync(string username)
        {
            return await _context.RandMethAdmins.
                  Where(u => u.Username == username)
              .AsNoTracking()
              .FirstOrDefaultAsync();
        }
    }
}
