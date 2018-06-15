using System;
using System.Activities.Presentation.Metadata;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using AM.Core.ActivityDesignBase.Metadata;


namespace AM.Skeleton.Activities.Design
{
    /// <summary>
    /// Types implementing IRegisterMetadata can be used to add custom metadata to activities at runtime.
    /// </summary>
    public class DesignerMetadata : IRegisterMetadata
    {
        public void Register()
        {
            AttributeTableBuilder builder = new AttributeTableBuilder();
            LoadMetadata(builder);
        }

        /// <summary>
        /// Loads metadata from an xml file.
        /// </summary>
        /// <param name="builder"></param>
        private static void LoadMetadata(AttributeTableBuilder builder)
        {
            string metadataFile = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
                                  "\\AM.Skeleton.Activities_metadata.xml";
            Assembly activities = Assembly.GetAssembly(typeof(ExampleActivity));
            BaseDesignerMetadata.LoadMetadata(builder, metadataFile, activities);
        }
    }
    
}
