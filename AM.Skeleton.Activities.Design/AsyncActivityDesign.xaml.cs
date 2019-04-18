using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using AM.Core.ActivityDesignBase;

namespace AM.Skeleton.Activities.Design
{
    /// <summary>
    /// The Attributes declare that this Design should be used for the Analyst or the Developer view.
    ///
    /// These Attributes can also be declared independently to have independent designs for each view
    /// </summary>
    [AnalystDesigner(typeof(AsyncActivityDesign))]
    [DeveloperDesigner(typeof(AsyncActivityDesign))]
    public partial class AsyncActivityDesign
    {
        public AsyncActivityDesign()
        {
            InitializeComponent();
        }
    }
}
