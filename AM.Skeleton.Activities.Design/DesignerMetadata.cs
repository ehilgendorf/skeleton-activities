using System.Activities.Presentation.Metadata;
using System.IO;
using System.Reflection;
using AM.Activities.Common.Design.Metadata;

namespace AM.Skeleton.Activities.Design
{
    /// <summary>
    ///     Types implementing IRegisterMetadata can be used to add custom metadata to activities at runtime.
    /// </summary>
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            AttributeTableBuilder builder = new AttributeTableBuilder();
            LoadMetadata(builder);
            MetadataStore.AddAttributeTable(builder.CreateTable());
        }

        /// <summary>
        ///     Loads metadata from an xml file.
        /// </summary>
        /// <param name="builder"><see cref="System.Activities.Presentation.Metadata.AttributeTableBuilder"/></param>
        private static void LoadMetadata(AttributeTableBuilder builder)
        {
            string metadataFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
                                  "\\AM.Skeleton.Activities_metadata.xml";
            Assembly activities = Assembly.GetAssembly(typeof(ExampleCodeActivity));
            BaseDesignerMetadata.LoadMetadata(builder, metadataFile, activities);
        }
    }
}