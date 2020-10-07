using AM.Activities.Example.DatabaseExample;
using AM.ComposerActivitiesBridge.Attributes;

namespace AM.Activities.Example.Design.DatabaseExample
{
    [AnalystDesigner(
        typeof(DatabaseExampleActivity))] // Indicates that this Design will be used for the Analyst view in the composer
    public partial class DatabaseExampleAnalystDesigner
    {
        public DatabaseExampleAnalystDesigner()
        {
            InitializeComponent();
        }
    }
}