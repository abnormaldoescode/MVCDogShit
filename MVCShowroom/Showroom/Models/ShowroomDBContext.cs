using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Showroom.Models
{

    public class ShowroomDbContext : IdentityDbContext<ApplicationUser>
    {
        public ShowroomDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ShowroomDbContext Create()
        {
            return new ShowroomDbContext();
        }
    }
}