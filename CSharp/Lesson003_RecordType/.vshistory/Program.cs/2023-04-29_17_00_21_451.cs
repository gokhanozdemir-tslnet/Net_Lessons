//When do we use: 
// - value equality  (like a class)
// - needs immutable object

RecordType myrecord1 = new("Prop1 test", "Prop2 test");
RecordType myrecord2 = new RecordType("Prop1 test", "Prop2 test");
RecordType myrecord3 = new("Prop1 test1", "Prop2 test");

Console.WriteLine(myrecord1 == myrecord2);
Console.WriteLine(myrecord2 == myrecord3);



//Positional definition
public record RecordType(string Prop1, string Prop2);

