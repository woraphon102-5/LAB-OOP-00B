using LABOOP00B;

Student student1 = new Student();
student1.name = "Beer";
student1.weight = 80.0f;

Student student2 = new Student();
student2.name = "Mark";
student2.weight = 73.0f;

Student student3 = new Student();
student3.name = "Big";
student3.weight = 65.0f;

Student student4 = new Student();
student4.name = "Tira";
student4.weight = 75.0f;

Student student5 = new Student();
student5.name = "Pun";
student5.weight = 90.0f;

float avgweight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Avg weight of all students ==> " + " " + avgweight);
Console.WriteLine("Name and weight of the heaviest person: " + " " + student5.name + " " + student5.weight);
Console.WriteLine("Name and weight of the person with the least weight: " + " " + student3.name + " " + student3.weight);
Console.WriteLine("Name and StudentId of Developer: " + " " + "WOraphon Pontri \n 653450296-6");