namespace AM.Skeleton.Application
{
    public interface IExampleApplication
    {
        string ExampleEditor { get; set; }
        string ReturnText(string text);

        void SetOption(ExamplePropertyOptions options);
    }
}