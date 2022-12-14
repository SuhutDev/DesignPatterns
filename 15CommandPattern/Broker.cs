
namespace CommandPattern;

public class Broker
{
    private List<IOrder> _orderList = new();

    public void TakeOrder(IOrder order)
    {

        _orderList.Add(order);
    }

    public void PlaceOrders()
    {
        foreach (var order in _orderList)
        {
            order.Execute();
        }
        _orderList.Clear();
    }
}
