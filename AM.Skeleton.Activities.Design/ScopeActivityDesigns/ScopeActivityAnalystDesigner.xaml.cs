using System.Activities.Presentation;
using System.Windows;
using AM.Common.Activities.Design.DesignsInterfaces;
using AM.Core.ActivityDesignBase;
using AM.Skeleton.Activities.ScopeExample;

namespace AM.Skeleton.Activities.Design
{
    [AnalystDesigner(typeof(ScopeActivity))]
    public partial class ScopeActivityAnalystDesigner : IScopeNavigationIcon
    {
        private bool _onlyOnFirstLoad;

        public ScopeActivityAnalystDesigner()
        {
            InitializeComponent();
        }

        protected override void OnGotFocus(RoutedEventArgs e)
        {
            base.OnGotFocus(e);

            if (_onlyOnFirstLoad) return;
            if (WorkflowItemPresenter.Item?.View is ActivityDesigner flowchart) flowchart.ExpandState = true;

            _onlyOnFirstLoad = true;
        }
    }
}