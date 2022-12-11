
namespace InterceptingFilterPattern;

public class FilterChain
{
    private List<IFilter> _filters = new();
    private Target? _target;

    public void AddFilter(IFilter filter)
    {
        _filters.Add(filter);
    }

    public void Execute(String request)
    {
        foreach (var filter in _filters)
        {
            filter.Execute(request);
        }
        _target?.execute(request);
    }

    public void SetTarget(Target target)
    {
        _target = target;
    }
}
