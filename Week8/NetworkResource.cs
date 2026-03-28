namespace Ass82;

public class NetworkResource : Resource, IDisposable
{
    public NetworkResource(string name) : base(name){}
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
        Console.WriteLine("The network was open");
    }
}