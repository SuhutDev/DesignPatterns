using FrontControllerPattern;

FrontController frontController = new();
frontController.DispatchRequest("HOME");
frontController.DispatchRequest("STUDENT");