namespace ConsoleZipper.Factory.Interfaces
{
    public interface IOutputFactory
    {
        IOutput GetOutput(string outputType);
    }
}
