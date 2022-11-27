﻿using FactoryPattern;

ShapeFactory shapeFactory = new(); 

IShape shape1 = shapeFactory.GetShape("CIRCLE"); 
shape1.Draw();
 
IShape shape2 = shapeFactory.GetShape("RECTANGLE"); 
shape2.Draw();
 
IShape shape3 = shapeFactory.GetShape("SQUARE"); 
shape3.Draw();