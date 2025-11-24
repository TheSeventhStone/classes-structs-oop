using System.Web;

namespace ConsoleApp1
{
    internal class Program
    {
        public class Character {
            public string name;
            public int exp = 0;

            public Character() {
                name = "Not assigned";
            }
            public Character(string name) {
                this.name = name;
            }
            public void printStatsInfo(){
                Console.WriteLine($"Hero: {this.name} - {this.exp} EXP");
            }
        }
        public struct Weapon {
            public string name;
            public int damage;
            public Weapon(string name, int damage) {
                this.name=name;
                this.damage=damage;
            }
            public void printWeaponStats() {
                Console.WriteLine($"Weapon: {this.name} - {this.damage} DMG");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Character hero = new Character();
            hero.printStatsInfo();
            Character heroine = new Character("Zeld B");
            heroine.printStatsInfo();
            Weapon huntingBow = new Weapon("Hunting Bow", 105);
            huntingBow.printWeaponStats();
            //testing ref types
            Character villain = hero;
            hero.printStatsInfo();
            villain.printStatsInfo();
            villain.name = "Skywalker";
            hero.printStatsInfo();
            villain.printStatsInfo();
            //testing val types
            Weapon warBow = huntingBow;
            huntingBow.printWeaponStats();
            warBow.printWeaponStats();
            warBow.name = "War Bow";
            warBow.damage = warBow.damage * 2;
            huntingBow.printWeaponStats();
            warBow.printWeaponStats();

        }
    }
}
