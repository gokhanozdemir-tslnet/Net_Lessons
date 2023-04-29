// See https://aka.ms/new-console-template for more information

using DPConsole.Creational.Singleton;

var singletonOperation = Singleton.GetInstance();
Console.WriteLine(singletonOperation.MySetting.MyClassPropId);
var singletonOperation2 = Singleton.GetInstance();
Console.WriteLine(singletonOperation2.MySetting.MyClassPropId);
