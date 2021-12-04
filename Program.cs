using System;

namespace Turn_Based
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randomGen = new Random();
            

            int playerHealth = 50;
            int monsterHealth = randomGen.Next(40,50);
            
            System.Console.WriteLine("What is your name Adventurer? \n" );
            string playerName = System.Console.ReadLine();
            System.Console.WriteLine("\n");


            System.Console.WriteLine("Oh I see, well hello there " + playerName + "\n");

            System.Console.WriteLine("Are you ready for your adventure? type 'y' for yes 'n' for no \n");
            string playerChoice = System.Console.ReadLine();

            string monsterName = CreateMonster();

            if(playerChoice.Contains("y" + "\n"))
            {
            
                System.Console.WriteLine("Oh no! a " + monsterName + " appeared \n");

                System.Console.WriteLine("What are you going to do Adventurer? \n");
                
            }
            else if(playerChoice.Contains("n"))
            {
                System.Console.WriteLine("Well... too bad Adventurer...");

            }
            


            while (playerHealth > 0 && monsterHealth > 0)
            {
               

                Random damageGen = new Random();
                Random _randomGen = new Random();

                int playerDamage = damageGen.Next(3,21);

                int monsterDamage = damageGen.Next(3,21);

                int enemyChoice = _randomGen.Next(1,5);

                Random enemyBlockChoiceGen = new Random();

                int enemyBlockChoice = enemyBlockChoiceGen.Next(1,4);

                System.Console.WriteLine("\n");

                System.Console.WriteLine(playerName + " has " + playerHealth + " Health" + "\n");
                System.Console.WriteLine(monsterName + " has " + monsterHealth + " Health" + "\n");


                System.Console.WriteLine("1. Attack     2. Defend       3.Heal      4. Taunt  \n");
                System.Console.WriteLine("--------------------------------");
                int userChoice = Convert.ToInt32(System.Console.ReadLine());

                Random blockChoiceGen = new Random();

                    int blockChoice = blockChoiceGen.Next(1,4);

                switch(userChoice)
                {

                    case 1: // PLAYER ATTACK

                    string playerAttack = PlayerAttack(playerName);
                    System.Console.WriteLine(playerAttack + playerDamage + "\n");

                    if (playerDamage > 15)
                    {
                        System.Console.WriteLine(playerName + " did a huge CRITICAL HIT!");

                        monsterHealth = monsterHealth - playerDamage;
                        
                    }else
                    {
                        monsterHealth = monsterHealth - playerDamage;

                    }
                    
                    break;

                    case 2: // PLAYER BLOCK


                    switch (blockChoice)
                    {
                        
                        case 1:

                        monsterDamage = 0;

                        System.Console.WriteLine(playerName + " blocked all of the " + monsterName + "'s damage");

                        break;

                        case 2:

                        System.Console.WriteLine(playerName + " tried to block an attack but failed! ");

                        break;

                        case 3:

                        System.Console.WriteLine(playerName + " blocked none of the " + monsterName + "'s damage");


                        break;
                    }

                    
                    break;

                    

                case 3: // PLAYER HEAL

                    Random playerHealGen = new Random();

                    int playerHeal;

                    playerHeal = playerHealGen.Next(1, 4);

                    playerHealth = playerHealth + playerHeal;

                    System.Console.WriteLine(playerName + " Rests to regain health points and gained " + playerHeal);
                    
                    break;
                
                case 4: // PLAYER TAUNT
                
                    System.Console.WriteLine(playerName + " Looks at the monster with disgust ");
                    
                break;

            }

                     

                

                 switch(enemyChoice)
                {
                    
                    case 1: // MONSTER ATTACK

                  

                        string monsterAttack = MonsterAttack(monsterName);
                        System.Console.WriteLine(monsterAttack + monsterDamage + "\n");

                    if (monsterDamage > 15)
                    {
                        System.Console.WriteLine(monsterName + " did a huge CRITICAL HIT!");

                        playerHealth = playerHealth - monsterDamage;
                        
                    }
                    else
                    {
                        playerHealth = playerHealth - monsterDamage;
                        
                    }

            
                        
                
                        break;

                    case 2: //MONSTER BLOCK

                    

                    switch (enemyBlockChoice)
                    {
                        
                        case 1:

                        playerDamage = 0;

                        System.Console.WriteLine(monsterName + " blocked all of " + playerName + "'s damage");

                        break;

                        case 2:

                        System.Console.WriteLine(monsterName + " tried to block " + playerName + "'s attack but failed! ");

                        break;

                        case 3:

                        System.Console.WriteLine(monsterName + " blocked none of " + playerName + "'s damage");


                        break;

                    }

                    break;

                    case 3: //MONSTER HEAL

                        Random monsterHealGen = new Random();

                        int monsterHeal = monsterHealGen.Next(1, 3);

                        monsterHealth = monsterHealth + monsterHeal;

                        System.Console.WriteLine(monsterName + " Rests to regain health gained " + monsterHeal);

                         break;

                    case 4: //MONSTER TAUNT

                    System.Console.WriteLine(monsterName + " looks at you with anger");

                         break;
                }

                System.Console.WriteLine("\n");

                System.Console.WriteLine(" Press Enter to go to the next round \n");
                Console.ReadKey();

                if (playerHealth == 0)
                {
                    System.Console.WriteLine("Rip adventurer");
                    
                }
                else if(monsterHealth == 0)
                {
                    System.Console.WriteLine("Rip monster");
                }

            }

        


        


            static string CreateMonster()
            {
                Random monsterGen = new Random ();

                string [] monsterTypes = {" Whack-A-Mole James", " Neowise The Big Brain Bender", " The Weird Troll FuaCruise", " Confused Ciongman", "The Dead Cruz"};

                int index = monsterGen.Next(monsterTypes.Length);

                string monsterName = monsterTypes[index];

                return monsterName;

            }

            static string PlayerAttack(string playerName)
            {
                Random attackGen = new Random();

                string[] attackType = {playerName + " grabbed their flipflop and threw it dealing ", playerName + " uses their fist and punched the enemy dealing ", playerName + " Grabbed the hammer of death and bonked the enemy dealing " };

                int index = attackGen.Next(attackType.Length);

                string attackName = attackType[index];

                return attackName;



            }

              static string MonsterAttack(string monsterName)
            {
                Random attackGen = new Random();
                string [] monsterAttackType = {monsterName + " lunges at you dealing ", monsterName + " scratches you dealing ", monsterName + " bites you dealing ",};
                int index = attackGen.Next(monsterAttackType.Length);

                string monsterAttack = monsterAttackType[index];

                return monsterAttack;
                
            }


            
        }
    }

}
