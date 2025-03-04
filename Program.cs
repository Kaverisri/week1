// See https://aka.ms/new-console-template for more information
using Week1ObjectOriented.Classes;
using Week1ObjectOriented.Interfaces;

//var s = new Square(4);
var square = new Square();
square.SetSide(4);
var circle = new Circle();
circle.SetRadius(5);
Console.WriteLine("The area of Square is " + square.GetArea());
ShapeColourColurHelper.AddColour(square);
Console.WriteLine(square.colour);
ShapeColourColurHelper.ChangeColour(square);

Console.WriteLine(square.colour);

Console.WriteLine("The area of Circle is " + circle.GetArea());
ShapeColourColurHelper.Colour randomColour = ShapeColourColurHelper.GetRandomColour();
Console.WriteLine($"Random Colour for circle:  {randomColour}");

ShapesArray[] shapes = new ShapesArray[5] // Create an array of 5 shapes
        {
            new ShapesArray("Circle"),
            new ShapesArray("Square"),
            new ShapesArray("Triangle"),
            new ShapesArray("Rectangle"),
            new ShapesArray("Hexagon")
        };

foreach (var shape in shapes)
{
    Console.WriteLine(shape);
}

