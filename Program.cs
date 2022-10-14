internal class Program
{
    private static void Main(string[] args)
    {
        int playerHp = 40;
        int enemyHp = 20;

        int playerAttack = 5;
        int enemyAttack = 7;

        int healAmount = 5;

        Random random = new Random();


        while (playerHp > 0 && enemyHp > 0 )
        {
            //player turn
            Console.WriteLine("--Player turn --");
            Console.WriteLine("Player hp - " + playerHp + ". enemy Hp - " + enemyHp);
            Console.WriteLine("Enter 'a' to attack or 'h' to heal");


            string choice = Console.ReadLine();

            if (choice == "a")
            {
                enemyHp -= playerAttack;
                Console.WriteLine("Player attack enemy and deals " + playerAttack + "damage!");
            }
            else
            {
                playerHp += healAmount;
                Console.WriteLine("Player restore " + healAmount + "health restore!");
            }

            // enemy turn

            if (enemyHp > 0)
            {
                Console.WriteLine("-- Enemy turn --");
                Console.WriteLine("Player hp - " + playerHp + ". enemy Hp - " + enemyHp);
                int enemyChoise = random.Next(0, 2);

                if (enemyChoise == 0)
                {
                    playerHp -= enemyAttack;
                    Console.WriteLine("Enemy attacks and deals " + enemyAttack + " damage! ");
                }
                else
                {
                    enemyHp += healAmount;
                    Console.WriteLine("Enemy restore " + healAmount + " health points!");
                }

            }
        }

        if (playerHp > 0)
        {
            Console.WriteLine("Congratukations, you have won!");

        }
        else
        {
            Console.WriteLine("You loose!");
        }


    }
}