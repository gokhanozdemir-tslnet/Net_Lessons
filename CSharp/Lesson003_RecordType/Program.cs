//When do we use: 
// - value equality  (like a class)
// - needs immutable object

using System;

RecordType myrecord1 = new("Prop1 test", "Prop2 test");
RecordType myrecord2 = new RecordType("Prop1 test", "Prop2 test");
RecordType myrecord3 = new("Prop1 test1", "Prop2 test");

Console.WriteLine($"Value Eguality = {myrecord1 == myrecord2}");
Console.WriteLine($"Reference Equality = {ReferenceEquals(myrecord1, myrecord2)}");
Console.WriteLine($"Value Equality = {myrecord2 == myrecord3}");


Console.WriteLine("using with");
Person person1 = new("Nancy", "Davolio") { PhoneNumbers = new string[1] };
Console.WriteLine(person1);
// output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }

Person person2 = person1 with { FirstName = "John" };
Console.WriteLine(person2);
// output: Person { FirstName = John, LastName = Davolio, PhoneNumbers = System.String[] }
Console.WriteLine(person1 == person2); // output: False

person2 = person1 with { PhoneNumbers = new string[1] };
Console.WriteLine(person2);
// output: Person { FirstName = Nancy, LastName = Davolio, PhoneNumbers = System.String[] }
Console.WriteLine(person1 == person2); // output: False

person2 = person1 with { };
Console.WriteLine(person1 == person2); // output: True

//Positional definition
public record RecordType(string Prop1, string Prop2);

public record Person(string FirstName, string LastName)
{
    public string[] PhoneNumbers { get; init; }
}