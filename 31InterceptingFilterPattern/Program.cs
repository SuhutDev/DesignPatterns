
using InterceptingFilterPattern;

FilterManager filterManager = new(new());
filterManager.SetFilter(new AuthenticationFilter());
filterManager.SetFilter(new DebugFilter());

Client client = new();
client.SetFilterManager(filterManager);
client.SendRequest("HOME");