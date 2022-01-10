using System.Collections.Generic;
namespace FactoryManager.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.EngineerEntities = new HashSet<EngineerMachine>(); //THIS WAS .MACHINEENTITIES
    }
    public int EngineerId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<EngineerMachine> EngineerEntities {get;set;}
  }
}