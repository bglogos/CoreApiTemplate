namespace CoreApiTemplate.Models.Common
{
    /// <summary>
    /// Constants used application wide.
    /// </summary>
    public static class AppConstants
    {
        #region Dependency injection

        /// <summary>
        /// The CoreApiTemplate.Business assembly and namespace.
        /// </summary>
        public const string CoreApiTemplateBusiness = "CoreApiTemplate.Business";

        /// <summary>
        /// The CoreApiTemplate.Data assembly and namespace.
        /// </summary>
        public const string CoreApiTemplateData = "CoreApiTemplate.Data";

        /// <summary>
        /// The CoreApiTemplate.Business namespace.
        /// </summary>
        public const string CoreApiTemplateBusinessServices = "CoreApiTemplate.Business.Services";

        /// <summary>
        /// The CoreApiTemplate.Data namespace.
        /// </summary>
        public const string CoreApiTemplateDataRepositories = "CoreApiTemplate.Data.Repositories";

        /// <summary>
        /// The service classes suffix.
        /// </summary>
        public const string ServiceSuffix = "Service";

        /// <summary>
        /// The repository classes suffix.
        /// </summary>
        public const string RepositorySuffix = "Repository";

        #endregion

        #region Encoding

        /// <summary>
        /// RegEx that matches base64 strings.
        /// </summary>
        public const string Base64Regex = @"^[a-zA-Z0-9\+/]*={0,3}$";

        #endregion
    }
}
