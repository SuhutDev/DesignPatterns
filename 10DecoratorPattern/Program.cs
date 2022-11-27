using DecoratorPattern;

IShape circle = new Circle();

IShape redCircle = new RedShapeDecorator(new Circle());

IShape redRectangle = new RedShapeDecorator(new Rectangle()); 
System.Console.WriteLine("Circle with normal border");
circle.Draw();
 
System.Console.WriteLine("\nCircle of red border");
redCircle.Draw();
 
System.Console.WriteLine("\nRectangle of red border");
redRectangle.Draw();