/*Console.Write("Hello, ");
while(true){
    Console.WriteLine("choose what you want to do by entering a number and then pressing enter.");
    Console.WriteLine("(1) Add some students to the ");
    switch (Console.ReadLine())
    {
        case "1":

            break;
        default:
        Console.WriteLine("Hey, you need to enter a number that corresponds to any number in the menu.");
        break;
    }
}*/
Console.WriteLine("Now, two staffmembers and five students will be added...\n");
Staff staff1 = new Staff("Uno", "Grusvägen 857", "NTI Gymnasiet Stockholm Odenplan", 34.89);
Staff staff2 = new Staff("Birgitta", "Rökenbergsgatan 11", "Södra Latin", 45.45);
Student student1 = new Student("Oliver", "Höggatan 420", "Teknik", 3, 451.23);
Student student2 = new Student("Leo", "Odengatan 21", "Teknik", 3, 4567.56);
Student student3 = new Student("Viktor", "Strandvägen 1", "Ekonomi", 4, 45.60);
Student student4 = new Student("Hillevi", "Daddelvägen 34", "Barn och Fritid", 3, 0.00);
Student student5 = new Student("Sten", "Donkvägen 85", "Bygg", 5, 57.30);
String staffOne = staff1.ToStringer();
String staffTwo = staff2.ToStringer();
String studentOne = student1.ToStringer();
String studentTwo = student2.ToStringer();
String studentThree = student3.ToStringer();
String studentFour = student4.ToStringer();
String studentFive = student5.ToStringer();

Console.WriteLine("Here are all staffmembers:\n");
Console.WriteLine(staffOne);
Console.WriteLine(staffTwo);
Console.WriteLine("\nAnd here are all students:\n");
Console.WriteLine(studentOne);
Console.WriteLine(studentTwo);
Console.WriteLine(studentThree);
Console.WriteLine(studentFour);
Console.WriteLine(studentFive);
Console.ReadLine();
