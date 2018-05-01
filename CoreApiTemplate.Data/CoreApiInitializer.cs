using System.Threading.Tasks;

namespace CoreApiTemplate.Data
{
    /// <summary>
    /// The default DB initializer.
    /// </summary>
    public static class CoreApiInitializer
    {
        /// <summary>
        /// Initializes the database asynchronous.
        /// </summary>
        /// <param name="context">The context.</param>
        public static async Task InitializeAsync(CoreApiContext context)
        {
            await context.Database.EnsureCreatedAsync();
        }
    }
}
