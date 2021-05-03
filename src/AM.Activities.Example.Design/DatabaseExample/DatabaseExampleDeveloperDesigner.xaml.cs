using AM.Activities.Example.DatabaseExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.DatabaseExample
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