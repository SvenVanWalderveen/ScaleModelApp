using Microsoft.EntityFrameworkCore;
using ScaleModelDomain.Base.Storage;
using ScaleModelDomain.Database.Entities.Manuals;
using ScaleModelDomain.Database.Entities.Projects;

namespace ScaleModelDomain.Database.Context
{
    public class ScaleModelDatabaseContext : DbContext
    {
        internal DbSet<Manual> Manuals { get; set; }
        internal DbSet<ManualStep> ManualSteps { get; set; }
        internal DbSet<ManualAttachment> ManualAttachments { get; set; }


        internal DbSet<ScaleModelProject> ScaleModelProjects { get; set; }
        internal DbSet<ScaleModelTask> ScaleModelTasks { get; set; }
        internal DbSet<ScaleModelPictures> ScaleModelPictures { get; set; }
        internal DbSet<ScaleModelProjectType> ScaleModelProjectTypes { get; set; }
        internal DbSet<ScaleModelProjectTypeInputField> ScaleModelProjectTypeInputFields { get; set; }
        internal DbSet<InputFieldConfiguration> InputFieldConfigurations { get; set; }
        internal DbSet<ScaleModelOrder> ScaleModelOrders { get; set; }
        internal DbSet<ScaleModelOrderLine> ScaleModelOrderLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) => options.UseSqlite("Data Source=" + GlobalVariables.DatabaseLocation);
    }
}

