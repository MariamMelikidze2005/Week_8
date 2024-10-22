using week9;

class program
{
    static void Main()
    {
        Student studenti = new Student("mzeo", 20, 123456);
        Teacher maswavlebeli = new Teacher("mediko", 34, "geografia");

        studenti.DisplayInfo();
        maswavlebeli.DisplayInfo();

        studenti.Describe();
        maswavlebeli.Describe();

        Console.WriteLine(studenti.GetOccupation());
        Console.WriteLine(maswavlebeli.GetOccupation());
    }
}
