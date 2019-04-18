using System;
using System.Activities;
using System.IO;
using System.Threading.Tasks;
using AM.Common.Activities;
using AM.Common.Activities.BaseActivities;

namespace AM.Skeleton.Activities.ScopeExample
{
    
    public class ChildActivity : AbstractCodeActivity 
    {
        public ChildActivity()
        {
            Constraints.Add(
                ActivityConstraints.CreateAncestorConstraint<ChildActivity>(typeof(ScopeActivity),
                    isWarning: true));
        }

        protected override void ExecuteActivity(CodeActivityContext context)
        {
            
            
        }
    }
    
    
}