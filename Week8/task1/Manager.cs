namespace Ass82;

class ResourceManager<T> where T : Resource
{
    private readonly List<T> _resources = new();
    public void Add(T resource)
    {
        _resources.Add(resource);
    }
    public void OpenAll()
    {
        foreach(T resource in _resources)
        {
            resource.Open();
        }
    }
    public void CloseAll()
    {
        foreach(T resource in _resources)
        {
            resource.Close();
        }
    }

}