using ProxyPattern;

IImage image = new ProxyImage("test_10bm.jpg");

//image will be loaded from disk
image.Display();
System.Console.WriteLine("");

//imange will not be loaded from database
image.Display();