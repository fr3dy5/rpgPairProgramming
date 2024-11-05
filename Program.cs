//Fredy and Samantha pair programming
using System;

class Battle
{
    public static void PerformBattle(Hero hero, Enemy enemy)
    {
        int round = 0;

        while (hero.HeroHealth > 0 && enemy.EnemyHealth > 0)
        {
            round++;

            Console.WriteLine($"Round {round}!");

            enemy.EnemyHealth -= hero.HeroAttack;
            if (enemy.EnemyHealth <= 0)
            {
                Console.WriteLine($"{enemy.EnemyName} has been defeated");
                break;
            }

            hero.HeroHealth -= enemy.EnemyAttack;
            if (hero.HeroHealth <= 0)
            {
                Console.WriteLine($"{hero.HeroName} has been defeated");
                break;
            }
        }
        if (hero.HeroHealth > enemy.EnemyHealth)
        {
            Console.WriteLine($"{hero.HeroName} wins");
        }
        else if (enemy.EnemyHealth > hero.HeroHealth)
        {
            Console.WriteLine($"{enemy.EnemyName} wins");
        }
        else
        {
            Console.WriteLine("DRAW");
        }
    }
}

class Hero
{
    // Properties
    public string HeroName { get; set; }
    public int HeroHealth { get; set; }
    public int HeroAttack { get; set; }
 
    public Hero(string name, int health, int attack)
    {
        HeroName = name;
        HeroHealth = health;
        HeroAttack = attack;
    }

}
//////////////////////////////////////////////////

 class Enemy
{
    // Properties
    public string EnemyName { get; set; }
    public int EnemyHealth { get; set; }
    public int EnemyAttack { get; set; }
 
 
    // Constructor
    public Enemy(string name, int health, int attack)
    {
        EnemyName = name;
        EnemyHealth = health;
        EnemyAttack = attack;
    }
}
//////////////////////////////////////////////
// put battle function in hero? since heros going to initiate battle with enemies?  
    // Methods

 
//main function
class Program
{
    static void Main(string[] args)
    {
        Hero hero = new Hero("Player", 100, 10);
        Enemy enemy = new Enemy("Bad Guy", 150, 5);

        Battle.PerformBattle(hero, enemy);
    }
}