using Ecommerce.infrastructure.presentice;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;





namespace Ecommerce.infrastructure.Presistance
{
   public class DBContextApplicationFactory : IDesignTimeDbContextFactory<DBContextApplication>

    {
        
        

        public DBContextApplication CreateDbContext(String[]args)
        
        {
            //build configuration from Appsetting.jason 
            IConfigurationRoot configuration = new ConfigurationBuilder()
                   .SetBasePath(Directory.GetCurrentDirectory())
                   .AddJsonFile("appsettings.json")
                   .Build();
            //get the  connectionstring configutation 
            var connectionstring = configuration.GetConnectionString("DefaultConnection");
            //create DbcontextOption builder with the connection string 
            var OptionBuilder = new DbContextOptionsBuilder<DBContextApplication>();
            OptionBuilder.UseSqlServer(connectionstring);//Adjust for database 
            //retun new istance of Dbcontext Application 
            return new DBContextApplication(OptionBuilder.Options);
        }
    }



}