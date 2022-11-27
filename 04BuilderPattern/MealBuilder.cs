namespace BuilderPattern;

public class MealBuilder
{
    public Meal PrepareVegMeal() {
        Meal meal=new();
        meal.AddItem(new VedBurger());
        meal.AddItem(new Coke()); 

        return meal;
    }

    public Meal PrepareNonVegMeal() {
        Meal meal=new();
        meal.AddItem(new ChickenBurger());
        meal.AddItem(new Pepsi());

        return meal;
    } 
}
