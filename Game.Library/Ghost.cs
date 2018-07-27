using Game.Library.Abstract;
namespace Game.Library
{
  public class Ghost : Enemy
  {
  

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
      string x = "hello";
      x.ToCharArray();
       System.Console.WriteLine("{0} has healed for {1}  ", this.ToString(), 70);
    }
  }
  
}


