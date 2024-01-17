
class BelajarArray{

    static string[] fraudulentOrderIDs = new string[3];
    static string[] names = { "Rowena", "Robin", "Bao" };
    static int[] inventory = { 200, 450, 700, 175, 250 };
    static int sum = 0;


    public static void ShowOutput(){
        fraudulentOrderIDs[0] = "A123";
        fraudulentOrderIDs[1] = "B456";
        fraudulentOrderIDs[2] = "C789";

        Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
        Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
        Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
        Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        
        foreach (int items in inventory)
        {
            sum += items;
        }

        Console.WriteLine($"We have {sum} items in inventory.");
        Console.WriteLine($"We have {inventory.Sum()} items in inventory.");
    }

}