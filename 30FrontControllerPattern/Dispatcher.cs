
namespace FrontControllerPattern;

public class Dispatcher
{
    private StudentView _studentView;
    private HomeView _homeView;
    public Dispatcher()
    {
        _studentView = new StudentView();
        _homeView = new HomeView();
    }

    public void Dispatch(string request)
    {
        if (request.Equals("STUDENT", System.StringComparison.OrdinalIgnoreCase))
        {
            _studentView.Show();
        }
        else
        {
            _homeView.Show();
        }
    }
}
