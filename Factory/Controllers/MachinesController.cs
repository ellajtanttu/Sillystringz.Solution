using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FactoryManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace FactoryManager.Controllers
{
  public class MachinesController : Controller
  {
    private readonly FactoryManagerContext _db;

    public MachinesController(FactoryManagerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Machines.ToList());
    }

    // public ActionResult Create()
    // {
    //   SelectList dbData = new SelectList(_db.Machines, "MachineId", "Name");
    //   //Create the select list item you want to add
    //   SelectListItem selListItem = new SelectListItem() { Value = "0", Text = "None" };
    //   //Create a list of select list items - this will be returned as your select list
    //   List<SelectListItem> newList = new List<SelectListItem>();
    //   //Add select list item to list of selectlistitems
    //   newList.Add(selListItem);
    //   newList.AddRange(dbData);
    //   //Return the list of selectlistitems as a selectlist
    //   ViewBag.MachineId = new SelectList(newList, "Value", "Text", null);
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Machine machine, int MachineId)
    // {
    //   _db.Machines.Add(machine);
    //   _db.SaveChanges();
    //   if (MachineId != 0)
    //   {
    //     _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, MachineId = machine.MachineId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Details(int id)
    // {
    //   var thisMachine = _db.Machines
    //       .Include(machine => machine.JoinEntities)
    //       .ThenInclude(join => join.Factory)
    //       .FirstOrDefault(machine => machine.MachineId == id);
    //   return View(thisMachine);
    // }

    // public ActionResult Edit(int id)
    // {
    //   var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
    //   return View(thisMachine);
    // }

    // [HttpPost]
    // public ActionResult Edit(Machine machine, int MachineId)
    // {
    //   if (MachineId != 0)
    //   {
    //     _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, MachineId = machine.MachineId });
    //   }
    //   _db.Entry(machine).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult AddMachine(int id)
    // {
    //   var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
    //   ViewBag.MachineId = new SelectList(_db.Machines, "MachineId", "Name");
    //   return View(thisMachine);
    // }

    // [HttpPost]
    // public ActionResult AddMachine(Machine machine, int MachineId)
    // {
    //   if (MachineId != 0)
    //   {
    //   _db.EngineerMachine.Add(new EngineerMachine() { MachineId = MachineId, MachineId = machine.MachineId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
    //   return View(thisMachine);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisMachine = _db.Machines.FirstOrDefault(machine => machine.MachineId == id);
    //   _db.Machines.Remove(thisMachine);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // [HttpPost]
    // public ActionResult DeleteMachine(int joinId)
    // {
    //   var joinEntry = _db.EngineerMachine.FirstOrDefault(entry => entry.EngineerMachineId == joinId);
    //   _db.EngineerMachine.Remove(joinEntry);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }
  }
}