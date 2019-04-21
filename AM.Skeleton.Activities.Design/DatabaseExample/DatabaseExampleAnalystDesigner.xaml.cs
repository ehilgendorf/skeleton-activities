using AM.Core.ActivityDesignBase;
using AM.Skeleton.Activities.DatabaseExample;

namespace AM.Skeleton.Activities.Design.DatabaseExample
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