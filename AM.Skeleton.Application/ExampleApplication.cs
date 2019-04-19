namespace AM.Skeleton.Application
{
    public class ExampleApplication : IExampleApplication
    {
        private ExamplePropertyOptions _options;

        public string ExampleEditor { get; set; }

        public string ReturnText(string text)
        {
            return "This text will be shown: " + text;
        }

        public void SetOption(ExamplePropertyOptions options)
        {
            _options = options;
        }
    }
}