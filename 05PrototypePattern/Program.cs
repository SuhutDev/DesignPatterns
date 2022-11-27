using PrototypePattern;

ShapeCache.LoadCache();

var clonedShape=(Shape)ShapeCache.GetShape("1");  
System.Console.WriteLine($"Shape : {clonedShape.GetTypeX()}");

var clonedShape2=(Shape)ShapeCache.GetShape("2");  
System.Console.WriteLine($"Shape : {clonedShape2.GetTypeX()}");


var clonedShape3=(Shape)ShapeCache.GetShape("3");  
System.Console.WriteLine($"Shape : {clonedShape3.GetTypeX()}");

