using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using FactoryManager.Models;
using System.Collections.Generic;
using System.Linq;

namespace FactoryManager.Controllers
{
  public class EngineersController : Controller
  {
    private readonly FactoryManagerContext _db;

    public EngineersController(FactoryManagerContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Engineers.ToList());
    }

    // public ActionResult Create()
    // {
    //   SelectList dbData = new SelectList(_db.Engineers, "EngineerId", "Name");
    //   //Create the select list item you want to add
    //   SelectListItem selListItem = new SelectListItem() { Value = "0", Text = "None" };
    //   //Create a list of select list items - this will be returned as your select list
    //   List<SelectListItem> newList = new List<SelectListItem>();
    //   //Add select list item to list of selectlistitems
    //   newList.Add(selListItem);
    //   newList.AddRange(dbData);
    //   //Return the list of selectlistitems as a selectlist
    //   ViewBag.EngineerId = new SelectList(newList, "Value", "Text", null);
    //   return View();
    // }

    // [HttpPost]
    // public ActionResult Create(Engineer engineer, int EngineerId)
    // {
    //   _db.Engineers.Add(engineer);
    //   _db.SaveChanges();
    //   if (EngineerId != 0)
    //   {
    //     _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, EngineerId = engineer.EngineerId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Details(int id)
    // {
    //   var thisEngineer = _db.Engineers
    //       .Include(engineer => engineer.JoinEntities)
    //       .ThenInclude(join => join.Factory)
    //       .FirstOrDefault(engineer => engineer.EngineerId == id);
    //   return View(thisEngineer);
    // }

    // public ActionResult Edit(int id)
    // {
    //   var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
    //   return View(thisEngineer);
    // }

    // [HttpPost]
    // public ActionResult Edit(Engineer engineer, int EngineerId)
    // {
    //   if (EngineerId != 0)
    //   {
    //     _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, EngineerId = engineer.EngineerId });
    //   }
    //   _db.Entry(engineer).State = EntityState.Modified;
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult AddMachine(int id)
    // {
    //   var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
    //   ViewBag.EngineerId = new SelectList(_db.Engineers, "EngineerId", "Name");
    //   return View(thisEngineer);
    // }

    // [HttpPost]
    // public ActionResult AddMachine(Engineer engineer, int EngineerId)
    // {
    //   if (EngineerId != 0)
    //   {
    //   _db.EngineerMachine.Add(new EngineerMachine() { EngineerId = EngineerId, EngineerId = engineer.EngineerId });
    //   }
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    // }

    // public ActionResult Delete(int id)
    // {
    //   var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
    //   return View(thisEngineer);
    // }

    // [HttpPost, ActionName("Delete")]
    // public ActionResult DeleteConfirmed(int id)
    // {
    //   var thisEngineer = _db.Engineers.FirstOrDefault(engineer => engineer.EngineerId == id);
    //   _db.Engineers.Remove(thisEngineer);
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