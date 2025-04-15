using Microsoft.EntityFrameworkCore;
using BlazorMediLab.Models;

namespace BlazorMediLab.Data
{
    public class SurveyDbContext : DbContext
    {
        public SurveyDbContext(DbContextOptions<SurveyDbContext> options) : base(options) { }

        public DbSet<PHQ2Model> PHQ2Responses { get; set; }
    }
}
