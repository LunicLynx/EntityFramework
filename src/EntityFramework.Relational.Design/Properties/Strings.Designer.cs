// <auto-generated />
namespace Microsoft.Data.Entity.Relational.Design
{
    using System.Diagnostics;
    using System.Globalization;
    using System.Reflection;
    using System.Resources;
	using JetBrains.Annotations;

    public static class Strings
    {
        private static readonly ResourceManager _resourceManager
            = new ResourceManager("EntityFramework.Relational.Design.Strings", typeof(Strings).GetTypeInfo().Assembly);

        /// <summary>
        /// Assembly {assemblyName} does not contain an implemetation of {metadataModelProviderInterfaceName}.
        /// </summary>
        public static string AssemblyDoesNotContainMetadataModelProvider([CanBeNull] object assemblyName, [CanBeNull] object metadataModelProviderInterfaceName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("AssemblyDoesNotContainMetadataModelProvider", "assemblyName", "metadataModelProviderInterfaceName"), assemblyName, metadataModelProviderInterfaceName);
        }

        /// <summary>
        /// ConnectionString is required to generate code.
        /// </summary>
        public static string ConnectionStringRequired
        {
            get { return GetString("ConnectionStringRequired"); }
        }

        /// <summary>
        /// Namespace is required to generate code.
        /// </summary>
        public static string NamespaceRequired
        {
            get { return GetString("NamespaceRequired"); }
        }

        /// <summary>
        /// Provider {providerTypeName} did not provide a ContextModelCodeGenerator.
        /// </summary>
        public static string NoContextModelCodeGenerator([CanBeNull] object providerTypeName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoContextModelCodeGenerator", "providerTypeName"), providerTypeName);
        }

        /// <summary>
        /// Provider {providerTypeName} did not provide a EntityTypeModelCodeGenerator.
        /// </summary>
        public static string NoEntityTypeModelCodeGenerator([CanBeNull] object providerTypeName)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("NoEntityTypeModelCodeGenerator", "providerTypeName"), providerTypeName);
        }

        /// <summary>
        /// OutputPath is required to generate code.
        /// </summary>
        public static string OutputPathRequired
        {
            get { return GetString("OutputPathRequired"); }
        }

        /// <summary>
        /// ProviderAssembly is required to generate code.
        /// </summary>
        public static string ProviderAssemblyRequired
        {
            get { return GetString("ProviderAssemblyRequired"); }
        }

        /// <summary>
        /// Metadata model returned should not be null. Provider: {providerTypeName} , connection string: {connectionString}.
        /// </summary>
        public static string ProviderReturnedNullModel([CanBeNull] object providerTypeName, [CanBeNull] object connectionString)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ProviderReturnedNullModel", "providerTypeName", "connectionString"), providerTypeName, connectionString);
        }

        /// <summary>
        /// No files generated in directory {outputDirectoryName}. The following file(s) already exist and must be made writeable to continue: {readOnlyFiles}.
        /// </summary>
        public static string ReadOnlyFiles([CanBeNull] object outputDirectoryName, [CanBeNull] object readOnlyFiles)
        {
            return string.Format(CultureInfo.CurrentCulture, GetString("ReadOnlyFiles", "outputDirectoryName", "readOnlyFiles"), outputDirectoryName, readOnlyFiles);
        }

        private static string GetString(string name, params string[] formatterNames)
        {
            var value = _resourceManager.GetString(name);

            Debug.Assert(value != null);

            if (formatterNames != null)
            {
                for (var i = 0; i < formatterNames.Length; i++)
                {
                    value = value.Replace("{" + formatterNames[i] + "}", "{" + i + "}");
                }
            }

            return value;
        }
    }
}
