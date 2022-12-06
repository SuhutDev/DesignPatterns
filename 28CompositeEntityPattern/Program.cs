
using CompositeEntityPattern;

Client client = new Client();
client.SetData("Test", "Data");
client.PrintData();
client.SetData("Second Test", "Data1");
client.PrintData();