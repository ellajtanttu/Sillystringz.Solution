using System.Collections.Generic;
namespace FactoryManager.Models
{
  public class Engineer
  {
    public Engineer()
    {
      this.MachineEntities = new HashSet<EngineerMachine>();
    }
    public int EngineerId {get; set;}
    public string Name {get; set;}
    public virtual ICollection<EngineerMachine> EngineerEntities {get;set;}
  }
}