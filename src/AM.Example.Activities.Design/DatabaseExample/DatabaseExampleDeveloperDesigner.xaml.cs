using AM.ComposerActivitiesBridge.Attributes;
using AM.Example.Activities.DatabaseExample;

namespace AM.Example.ActivitiesDesign.DatabaseExample
{
    [DeveloperDesigner(
        typeof(DatabaseExampleActivity))] // Indicates that this Design will be used for the DatabaseExampleActivity in the composer
    public partial class DatabaseExampleDeveloperDesigner
    {
        public DatabaseExampleDeveloperDesigner()
        {
            InitializeComponent();
        }
    }
}