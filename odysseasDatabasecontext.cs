using Microsoft.EntityFrameworkCore;

using odysseasAPI.models;

namespace odysseasAPI
{
    public class ΟdysseasDatabasecontext:DbContext
    {

        public ΟdysseasDatabasecontext(DbContextOptions<ΟdysseasDatabasecontext> options): base(options)
        {

        }
        public DbSet<User> Odysseas_Users {  get; set; }
            


    }
}
