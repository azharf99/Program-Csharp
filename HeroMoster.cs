class HeroMonster{
    static int heroHealth = 10;
    static int monsterHealth = 10;
    static Random random = new Random();
    


    public static void showOutput(){
        do{
            int heroAttack = random.Next(1, 11);
            int monsterAttack = random.Next(1, 11);

            monsterHealth -= heroAttack;
            Console.WriteLine($"Monster was damaged and lost {heroAttack} health and now has {monsterHealth} health.");
            if (monsterHealth <= 0) 
                continue;
            heroHealth -= monsterAttack;
            Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} health.");
        }
        while(heroHealth > 0 && monsterHealth > 0);
            if(monsterHealth <= 0){
                Console.WriteLine("Hero wins!");
            } else{
                Console.WriteLine("Monster wins!");
            }

    }
}