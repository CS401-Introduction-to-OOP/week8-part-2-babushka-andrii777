using Ass82;

class Program
{
    public static void Main()
    {
        var file = new FileResource("report.txt");
        var network = new NetworkResource("api.company.local");
        using(file)
        {
            file.Dispose();
        }
        using(network)
        {
            network.Dispose();
        }
        var manager = new ResourceManager<Resource>();
        
        manager.Add(file);
        manager.Add(network);
        manager.OpenAll();
        manager.CloseAll();
    }
    
}