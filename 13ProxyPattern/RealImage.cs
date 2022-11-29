using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPattern;

public class RealImage : IImage
{
    private string _fileName;
    public RealImage(string fileName)
    {
        _fileName = fileName;
        LoadFromDisk(fileName);
    }

    public void Display()
    {
        System.Console.WriteLine($"Displaying {_fileName}");
    }

    private void LoadFromDisk(string fileName)
    {
        System.Console.WriteLine($"Loading {_fileName}");
    }
}
