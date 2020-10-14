using System.Windows;

namespace AM.Activities.Example.Design.CustomEditor
{
    /// <summary>
    ///     Example of a Custom Editor
    /// </summary>
    public partial class EditorTemplates
    {
        /// <summary>
        /// </summary>
        private static ResourceDictionary _resources = new EditorTemplates();

        public EditorTemplates()
        {
            InitializeComponent();
        }

        public static DataTemplate FileBrowserDialogEditor => (DataTemplate)_resources["ExampleEditor"];
    }
}