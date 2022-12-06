
using BusinessDelegatePattern;

BusinessDelegate businessDelegate = new();

businessDelegate.SetServiceType("EJB");

Client client = new(businessDelegate);
client.DoTask();

businessDelegate.SetServiceType("JMS");
client.DoTask();