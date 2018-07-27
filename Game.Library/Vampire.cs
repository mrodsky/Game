using Game.Library.Abstract;
namespace Game.Library
{
  public class Vampire : Enemy
  {
 
    public Vampire()
    {
      
    }
   public override void Heal()
    {
       System.Console.WriteLine("{0} has healed for {1}  ", this.ToString(), 9000);
    }
}
}
