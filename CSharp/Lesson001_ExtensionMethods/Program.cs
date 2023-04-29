// See https://aka.ms/new-console-template for more information
using Lesson001_ExtensionMethods;
using Lesson001_ExtensionMethods.Extensions;

Console.WriteLine("Hello, World!");

MyClass myclass = new MyClass
{
    Id = 1,
    Name = "Test",
    Description = "Test description"
};

Console.WriteLine(myclass.MyMeyhod("my param"));