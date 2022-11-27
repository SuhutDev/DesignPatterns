namespace PrototypePattern ;
 
public class ShapeCache
{
    private static Dictionary<string, Shape> shapeMap=new();

    public static Shape GetShape (string shapeId) {

        Shape? cachedShape;
        if(shapeMap.TryGetValue(shapeId,out cachedShape)) {
            return (Shape)cachedShape.Clone();
        }
        
        throw new ArgumentException();
    }

    public static void LoadCache() {
        Cirle cirle=new();
        cirle.SetId("1");
        shapeMap.Add(cirle.GetId(), cirle);

        Square square=new();
        square.SetId("2");
        shapeMap.Add(square.GetId(), square);

        Rectangle rectangle=new();
        rectangle.SetId("3");
        shapeMap.Add(rectangle.GetId(), rectangle);


    }
}
