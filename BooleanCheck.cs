class BooleanCheck{
    
    
    

    public static void ShowOutput(){
        Console.WriteLine("a" == "a");
        Console.WriteLine("a" == "A");
        string value1 = " a";
        string value2 = "A ";
        Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
        string pangram = "The quick brown fox jumps over the lazy dog.";
        Console.WriteLine(pangram.Contains("fox"));
        Console.WriteLine(pangram.Contains("cow"));
        int saleAmount = 1001;
        int discount = saleAmount > 1000 ? 100 : 50;
        Console.WriteLine($"Discount: {discount}");

        Random random = new Random();
        Console.WriteLine((random.Next(0, 2) == 0) ? "heads" : "tails");
    }

    
}