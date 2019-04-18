using System.Windows;

namespace AM.Skeleton.Activities.Design.CustomEditor
{
    /// <summary>
    /// Example of a Custom Editor
    /// </summary>
    public partial class EditorResources : ResourceDictionary
    {
        private static ResourceDictionary _resources;
        
        public EditorResources()
        {
            InitializeComponent();
        }
        
        public static ResourceDictionary GetResources()
        {
            return _resources ?? (_resources = new EditorResources());
        }
    }
}
