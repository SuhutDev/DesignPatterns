
using ServiceLocatorPattern;

IService service = ServiceLocator.GetService("Service1");
service.Execute();
service = ServiceLocator.GetService("Service2");
service.Execute();
service = ServiceLocator.GetService("Service1");
service.Execute();
service = ServiceLocator.GetService("Service2");
service.Execute();