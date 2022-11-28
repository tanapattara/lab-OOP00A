// See https://aka.ms/new-console-template for more information
//Data type
using LABOOP00A;

Student student1 = new Student();
student1.name = "Mickey";
student1.weight = 20.8f;

Student student2 = new Student();
student2.name = "Minnie";
student2.weight = 18.2f;

float avgWeight = (student1.weight + student2.weight)/2;
Console.WriteLine("Weight avg of Student:" + avgWeight);