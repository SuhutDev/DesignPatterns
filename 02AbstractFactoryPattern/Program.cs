using AbstractFactoryPattern;

IFactory shapeFactory=FactoryProducer.GetFactory(false);

IShape shape1=shapeFactory.GetShape("RECTANGLE");
shape1.Draw();

IShape shape2=shapeFactory.GetShape("SQUARE");
shape2.Draw();


IFactory shapeFactory1=FactoryProducer.GetFactory(true);
IShape shape3=shapeFactory1.GetShape("RECTANGLE");
shape3.Draw();

IShape shape4=shapeFactory1.GetShape("SQUARE");
shape4.Draw();
