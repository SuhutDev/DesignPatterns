using BuilderPattern;

MealBuilder mealBuilder=new();

Meal vegMeal=mealBuilder.PrepareVegMeal();
System.Console.WriteLine("Veg Meal");
vegMeal.ShowItems();
System.Console.WriteLine($"Total Cost : {vegMeal.GetCost().ToString()}");

Meal nonVegMeal=mealBuilder.PrepareNonVegMeal();
System.Console.WriteLine("Non-Veg Meal");
nonVegMeal.ShowItems();
System.Console.WriteLine($"Total Cost : {nonVegMeal.GetCost().ToString()}");



