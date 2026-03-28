namespace Ass82;

public class FileResource : Resource, IDisposable
{
    public FileResource(string name) : base(name){}
    public override void Open()
    {
        IsOpen = true;
    }
    public override void Close()
    {
        IsOpen = false;
    }
    public void Dispose()
    {
        this.Open();
        Console.WriteLine("The file was open");
    }
}
