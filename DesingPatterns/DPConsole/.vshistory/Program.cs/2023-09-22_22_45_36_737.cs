// See https://aka.ms/new-console-template for more information

using DPConsole.Creational.Singleton;
using DPConsole.Creational.Singleton.RealWorldExample;
using System.Data.Common;

var singletonOperation = Singleton.GetInstance();
Console.WriteLine(singletonOperation.MySetting.MyClassPropId);
Console.WriteLine(singletonOperation.GuidId);
var singletonOperation2 = Singleton.GetInstance();
Console.WriteLine(singletonOperation2.MySetting.MyClassPropId);
Console.WriteLine(singletonOperation2.GuidId);

//Singleton Real World
Console.WriteLine("Request1----" + DBConfiguration.GetDBConfiguration().DbConnection.ConnectionString);
Console.WriteLine("Request2----" + DBConfiguration.GetDBConfiguration().DbConnection.ConnectionString);
Console.WriteLine("Request3----" + DBConfiguration.GetDBConfiguration().DbConnection.ConnectionString);