namespace AM.Activities.Example
{
    public class ExampleApplication : IExampleApplication
    {
        public string ExampleEditor { get; set; }

        public string SetText(string text)
        {
            return "This text will be shown: " + text;
        }

        public ExamplePropertyOptions Option { get; set; }
    }
}