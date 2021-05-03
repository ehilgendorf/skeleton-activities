namespace AM.Activities.Example
{
    public interface IExampleApplication
    {
        string ExampleEditor { get; set; }

        string SetText(string text);

        ExamplePropertyOptions Option { get; set; }
    }
}