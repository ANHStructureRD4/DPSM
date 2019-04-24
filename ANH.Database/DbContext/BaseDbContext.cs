using ANH.Core;
using Microsoft.EntityFrameworkCore;

namespace ANH.Database
{
    /// <summary>
    /// The database context for the client data store
    /// </summary>
    public class BaseDbContext : DbContext
    {
        #region DbSets 

        /// <summary>
        /// The client login credentials
        /// </summary>
        public DbSet<EquipmentDataModel> Equipment { get; set; }

        #endregion

        #region Constructor

        /// <summary>
        /// Default constructor
        /// </summary>
        public BaseDbContext(DbContextOptions<BaseDbContext> options) : base(options) { }

        #endregion

        #region Model Creating

        /// <summary>
        /// Configures the database structure and relationships
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Fluent API

            // Configure LoginCredentials
            // --------------------------
            //
            // Set Id as primary key
            modelBuilder.Entity<EquipmentDataModel>().HasKey(a => a.EquipID);
            

            //modelBuilder.Entity<EquipmentDataModel>().HasData(new EquipmentDataModel() { EquipName = "Composite3", cnt=1, IconSource="", IsSelected=true });

            // Set up limits
            //modelBuilder.Entity<BaseListItemDataModel>().Property(a => a.FirstName).HasMaxLength(50);
        }

        #endregion
    }
}
