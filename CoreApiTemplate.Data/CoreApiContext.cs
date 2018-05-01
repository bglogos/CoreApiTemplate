using Microsoft.EntityFrameworkCore;

namespace CoreApiTemplate.Data
{
    /// <summary>
    /// The default DB context.
    /// </summary>
    /// <seealso cref="DbContext" />
    public class CoreApiContext : DbContext
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="CoreApiContext"/> class.
        /// </summary>
        /// <param name="options">The options.</param>
        public CoreApiContext(DbContextOptions<CoreApiContext> options)
            : base(options)
        {
        }

        #endregion

        #region Properties

        /////// <summary>
        /////// Gets or sets the item.
        /////// </summary>
        ////public DbSet<Item> Item { get; set; }

        #endregion
    }
}
