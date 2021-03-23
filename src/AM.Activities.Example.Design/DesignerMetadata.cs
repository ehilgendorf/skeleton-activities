using System;
using System.Activities.Presentation.Metadata;
using System.IO;
using System.Reflection;

using AM.Activities.Common.Design.Helpers;
using AM.Activities.Common.Design.Metadata;

namespace AM.Activities.Example.Design
{
    /// <summary>
    ///     Types implementing IRegisterMetadata can be used to add custom metadata to activities at runtime.
    /// </summary>
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            AttributeTableBuilder builder = new AttributeTableBuilder();
            AddActivityIcons(builder);
            LoadMetadata(builder);
            MetadataStore.AddAttributeTable(builder.CreateTable());
        }

        private static void AddActivityIcons(AttributeTableBuilder builder)
        {
            Assembly assembly = Assembly.GetAssembly(typeof(ExampleCodeActivity));
            string assemblyFolder = Path.GetDirectoryName(assembly.Location);
            string iconsFolderPath = Path.Combine(assemblyFolder, "Icons");
            MetadataLoading.LoadActivityIcons(builder, assembly.GetName().Name, iconsFolderPath);
        }

        /// <summary>
        ///     Loads metadata from an xml file.
        /// </summary>
        /// <param name="builder"><see cref="System.Activities.Presentation.Metadata.AttributeTableBuilder"/></param>
        private static void LoadMetadata(AttributeTableBuilder builder)
        {
            string metadataFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? throw new ArgumentNullException(),
                                  "AM.Activities.Example_metadata.xml");
            Assembly activities = Assembly.GetAssembly(typeof(ExampleCodeActivity));
            BaseDesignerMetadata.LoadMetadata(builder, metadataFile, activities);
        }
    }
}