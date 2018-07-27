using System;
using Game.Library;
using Game.Library.Abstract;

namespace Game.Client
{
  class Program
  {
    static void Main(string[] args)
    {


      Ninja n1 = new Ninja();
     
      Vampire v1 = new Vampire();
      Ninja n2 = new Ninja();
      Ninja n3 = new Ninja();
      Ninja n4 = new Ninja();
      Ghost g1 = new Ghost();
      Vampire v10 = new Vampire();



      n1.SetAttackStr(90);
      n2.SetAttackStr(75);
      n3.SetAttackStr(50);
      n4.SetAttackStr(-20);
      v10.AttackStr = 100;

      v1.AttackStr = 2019;



      System.Console.WriteLine("ninja 1 has attack strength {0}", n1.GetAttackStr());
      System.Console.WriteLine("ninja 2 has attack strength {0}", n2.GetAttackStr());
      System.Console.WriteLine("ninja 3 has attack strength {0}", n3.GetAttackStr());
      System.Console.WriteLine("ninja 4 has attack strength {0}", n4.GetAttackStr());
      System.Console.WriteLine("ninja 10 has attack strength {0}", v10.AttackStr);
      n1.BasicAttack(); // this => n1
      v1.BasicAttack(); // this => v1

      

      n1.KillFunction(v1, g1);



     // Zombie z1 = new Zombie();  cannot instantiate a staic class

      Zombie.ZombieAttackStr = 200;
      Zombie.ZombieAttack();


      Ninja n20 = new Ninja(2000);
      System.Console.WriteLine("ninja 20 has attack strength {0}", n20.GetAttackStr());

      Ninja n30 = new Ninja(3000, 56);
      System.Console.WriteLine("ninja 30 has attack strength {0} and health {1}" 
                                , n20.GetAttackStr(), n30.Health);




        Ghost g5 = new Ghost();
      g5.BasicAttack(666); // in this case this => g5
      SwampMonster swampmon1 = new SwampMonster();

      g5.Heal();
      n30.Heal();
      v1.Heal();
      swampmon1.Heal();
    }
  }
}
