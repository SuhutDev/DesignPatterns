
using VisitorPattern;

IComputerPart computer = new Computer();
computer.Accept(new ComputerPartDisplayVisitor());