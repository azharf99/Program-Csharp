// Student         Exam Score      Overall Grade   Extra Credit

// Sophia          92.2            95.88   A       92 (3.68 pts)
// Andrew          89.6            91.38   A-      89 (1.78 pts)
// Emma            85.6            90.94   A-      89 (5.34 pts)
// Logan           91.2            93.12   A       96 (1.92 pts)



class ExtraCredit{
    // initialize variables - graded assignments 
    static decimal[] sophiaScores = new decimal[] { 90, 86, 87, 98, 100 };
    static decimal[] andrewScores = new decimal[] { 92, 89, 81, 96, 90 };
    static decimal[] emmaScores = new decimal[] { 90, 85, 87, 98, 68 };
    static decimal[] loganScores = new decimal[] { 90, 95, 87, 88, 96 };
    static decimal[] newSophiaScores = new decimal[] { 94, 90 };
    static decimal[] newAndrewScores = new decimal[] { 89 };
    static decimal[] newEmmaScores = new decimal[] { 89, 89, 89 };
    static decimal[] newLoganScores = new decimal[] { 96 };
    static decimal[] studentScores = new decimal[]{
        sophiaScores.Average(), 
        andrewScores.Average(), 
        emmaScores.Average(), 
        loganScores.Average(), 
        };
    static decimal[] newStudentScores = new decimal[]{
        (sophiaScores.Sum() + (newSophiaScores.Sum()/10))/5,
        (andrewScores.Sum() + (newAndrewScores.Sum()/10))/5,
        (emmaScores.Sum() + (newEmmaScores.Sum()/10))/5,
        (loganScores.Sum() + (newLoganScores.Sum()/10))/5,
        };

    static Dictionary<string, decimal> data = new Dictionary<string, decimal>();
    static Dictionary<string, decimal> newData = new Dictionary<string, decimal>();
    // Student names
    static string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };
    // static int sophiaSum = 0;
    // static decimal sophiaScore;
    static string currentStudentLetterGrade = "";


    public static void ShowOutput(){
        Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");
        for(int i=0; i<studentNames.Length; i++)
        {

            data.Add(studentNames[i], studentScores[i]);
            newData.Add(studentNames[i], newStudentScores[i]);
            // sophiaScore = (decimal) sophiaScores.Sum() / currentAssignments;

        }
        foreach (var item in data)
        {
            foreach (var newItem in newData)
            {
                if(item.Key == newItem.Key){
                    if (newItem.Value >= 97)
                        currentStudentLetterGrade = "A+";

                    else if (newItem.Value >= 93)
                        currentStudentLetterGrade = "A";

                    else if (newItem.Value >= 90)
                        currentStudentLetterGrade = "A-";

                    else if (newItem.Value >= 87)
                        currentStudentLetterGrade = "B+";

                    else if (newItem.Value >= 83)
                        currentStudentLetterGrade = "B";

                    else if (newItem.Value >= 80)
                        currentStudentLetterGrade = "B-";

                    else if (newItem.Value >= 77)
                        currentStudentLetterGrade = "C+";

                    else if (newItem.Value >= 73)
                        currentStudentLetterGrade = "C";

                    else if (newItem.Value >= 70)
                        currentStudentLetterGrade = "C-";

                    else if (newItem.Value >= 67)
                        currentStudentLetterGrade = "D+";

                    else if (newItem.Value >= 63)
                        currentStudentLetterGrade = "D";

                    else if (newItem.Value >= 60)
                        currentStudentLetterGrade = "D-";

                    else
                        currentStudentLetterGrade = "F";

                    Console.WriteLine($"{newItem.Key}:\t\t{item.Value}\t\t{newItem.Value}\t{currentStudentLetterGrade}\t{item.Value} ({newItem.Value-item.Value} pts)");
                }
                
            }
            
        }

        Console.WriteLine("-----------------------------------------------------------------");

    }

}