using CommandPattern;

Stock abcStock = new();

BuyStock buyStockOrder = new(abcStock);
SellStock sellStockOrder = new(abcStock);

Broker broker = new Broker();
broker.TakeOrder(buyStockOrder);
broker.TakeOrder(sellStockOrder);

broker.PlaceOrders();