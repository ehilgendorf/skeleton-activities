namespace AM.Activities.Example
{
    public interface IExampleApplication
    {
        string ExampleEditor { get; set; }

        string SetText(string text);

        void SetOption(ExamplePropertyOptions options);

        ExamplePropertyOptions GetOption();
    }
}