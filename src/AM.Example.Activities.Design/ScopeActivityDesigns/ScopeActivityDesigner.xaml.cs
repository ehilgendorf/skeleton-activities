using System.Activities.Presentation;
using System.Windows;
using AM.Activities.Common.Design.DesignsInterfaces;
using AM.ComposerActivitiesBridge.Attributes;
using AM.Example.Activities.ScopeExample;

namespace AM.Example.ActivitiesDesign.ScopeActivityDesigns
{
    /// <summary>
    ///     Scope activity logic. Scope activities need to implement <see cref="IScopeNavigationIcon" />.
    /// </summary>
    [DeveloperDesigner(
        typeof(ScopeActivity))] // Indicates that this Design will be used for the ScopeActivity in the composer
    public partial class ScopeActivityDesigner : IScopeNavigationIcon
    {
        private bool _onlyOnFirstLoad;

        public ScopeActivityDesigner()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Set the Flowchart to the expand state.
        /// </summary>
        /// <param name="e">
        ///     <see cref="RoutedEventArgs" />
        /// </param>
        protected override void OnGotFocus(RoutedEventArgs e)
        {
            base.OnGotFocus(e);

            if (_onlyOnFirstLoad) return;
            if (WorkflowItemPresenter.Item?.View is ActivityDesigner flowchart) flowchart.ExpandState = true;

            _onlyOnFirstLoad = true;
        }
    }
}