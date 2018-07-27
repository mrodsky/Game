using Game.Library.Abstract;
namespace Game.Library
{
  public class Ninja : Enemy
  {



      public Ninja()
      {

      }
      public Ninja(double number)
      {
       AttackStr = number;
      }

      public Ninja(double number, int number2)
      {
        AttackStr = number;
        Health = number2;
      }
// this is BEHAVIOR of a ninja
  public double GetAttackStr()
  {
      return AttackStr;
  }
  
  public void SetAttackStr(double str)
  {
    
    if (str >= 0 && (str.GetType() == typeof(double)))
    {
    
    AttackStr = str;
    }
    else {
      System.Console.WriteLine("cannot have negative attack strength");
      AttackStr = 0D;
    }
    
    
  }

   public override void Heal()
    {
       System.Console.WriteLine("{0} has healed for {1}  ", this.ToString(), 150);
    }
}
}
