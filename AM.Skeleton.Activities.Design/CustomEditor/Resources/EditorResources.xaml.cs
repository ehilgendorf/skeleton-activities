using System.Windows;

namespace AM.Skeleton.Activities.Design.CustomEditor.Resources
{
    /// <summary>
    ///     Example of a Custom Editor
    /// </summary>
    public partial class EditorResources : ResourceDictionary
    {
        /// <summary>
        /// </summary>
        private static ResourceDictionary _resources;

        public EditorResources()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     Provides a dictionary that contains WPF resources used by components
        /// </summary>
        /// <returns>ResourceDictionary with WPF resources used by components</returns>
        public static ResourceDictionary GetResources()
        {
            return _resources ?? (_resources = new EditorResources());
        }
    }
}