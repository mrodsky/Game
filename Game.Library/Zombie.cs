using System;
using Game.Library.Abstract;
namespace Game.Library
{
  public static class Zombie 
  {
 
    public static int ZombieAttackStr { get; set; }
    

    public static void ZombieAttack()
    {
      System.Console.WriteLine("Zombie hit your for {0} " , ZombieAttackStr);
    }
   
}
}
