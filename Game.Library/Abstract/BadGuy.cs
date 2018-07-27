

namespace Game.Library.Abstract
{
  public abstract class BadGuy
  {
    public double  AttackStr;  
    public int Health;


    public void BasicAttack()
    {
      System.Console.WriteLine("{1} has hit you  for {0} Damage ", AttackStr, this.ToString());
    }

    public void BasicAttack(double a)
    {
       
      System.Console.WriteLine("{1} has hit you  for {0} Damage ", a, this.ToString());
      
    }

    public  void KillFunction(Enemy e1, Enemy e2 )
    
    {
        System.Console.WriteLine("{0} has killed {1}", e1, e2);
       
    }

    public virtual void Heal()
    {
      System.Console.WriteLine("{0} has healed for {1}  ", this.ToString(), 30);
    }
  }
}