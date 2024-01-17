
class CalculateScore{
    // initialize variables - graded assignments 
    static decimal[] sophiaScores = new decimal[] { 90, 86, 87, 98, 100 };
    static decimal[] andrewScores = new decimal[] { 92, 89, 81, 96, 90 };
    static decimal[] emmaScores = new decimal[] { 90, 85, 87, 98, 68 };
    static decimal[] loganScores = new decimal[] { 90, 95, 87, 88, 96 };
    static decimal[] studentScores = new decimal[]{
        sophiaScores.Sum()/sophiaScores.Length, 
        andrewScores.Sum()/andrewScores.Length, 
        emmaScores.Sum()/emmaScores.Length, 
        loganScores.Sum()/loganScores.Length, 
        };

    static Dictionary<string, decimal> data = new Dictionary<string, decimal>();
    // Student names
    static string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
    // static int sophiaSum = 0;
    // static decimal sophiaScore;
    static string currentStudentLetterGrade = "";


    public static void ShowOutput(){
        Console.WriteLine("Student\t\tGrade\n");
        for(int i=0; i<studentNames.Length; i++)
        {

            data.Add(studentNames[i], studentScores[i]);
            // sophiaScore = (decimal) sophiaScores.Sum() / currentAssignments;

        }
        foreach (var item in data)
        {
            if (item.Value >= 97)
                currentStudentLetterGrade = "A+";

            else if (item.Value >= 93)
                currentStudentLetterGrade = "A";

            else if (item.Value >= 90)
                currentStudentLetterGrade = "A-";

            else if (item.Value >= 87)
                currentStudentLetterGrade = "B+";

            else if (item.Value >= 83)
                currentStudentLetterGrade = "B";

            else if (item.Value >= 80)
                currentStudentLetterGrade = "B-";

            else if (item.Value >= 77)
                currentStudentLetterGrade = "C+";

            else if (item.Value >= 73)
                currentStudentLetterGrade = "C";

            else if (item.Value >= 70)
                currentStudentLetterGrade = "C-";

            else if (item.Value >= 67)
                currentStudentLetterGrade = "D+";

            else if (item.Value >= 63)
                currentStudentLetterGrade = "D";

            else if (item.Value >= 60)
                currentStudentLetterGrade = "D-";

            else
                currentStudentLetterGrade = "F";

            Console.WriteLine($"{item.Key}:\t\t" + "{0:N2}", item.Value + $"\t{currentStudentLetterGrade}");
            
        }

        Console.WriteLine("-----------------------------------------------------------------");
    }

}