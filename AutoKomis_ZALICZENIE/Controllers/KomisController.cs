using AutoKomis_ZALICZENIE.Logic;
using AutoKomis_ZALICZENIE.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoKomis_ZALICZENIE.Controllers
{
    public class KomisController : Controller
    {
            public IActionResult Index()
            {
                var manager = new AutaManager();
                var cars = manager.GetVehicles();
                return View(cars);
            }

            [HttpGet]
            public IActionResult Add()
            {
                return View();
            }

            [HttpGet]
            public IActionResult Details(int id)
            {
                var vehicleManager = new AutaManager();
                var car = vehicleManager.GetVehicle(id);
                return View(car);
            }

            [HttpPost]
            public IActionResult Add(KomisModel auto)
            {
                var vehicleManager = new AutaManager();
                vehicleManager.AddVehicle(auto);
                return RedirectToAction("Index");
            }


            [HttpGet]
            public IActionResult Remove(int id)
            {
                var vehicleManager = new AutaManager();
                var car = vehicleManager.GetVehicle(id);
                return View(car);
            }

            [HttpPost]
            public IActionResult RemoveConfirm(int id)
            {
                var vehicleManager = new AutaManager();

                try
                {
                    var car = vehicleManager.GetVehicle(id);
                    vehicleManager.RemoveVehicle(car.ID);
                    return RedirectToAction("Index");
                }
                catch (System.Exception)
                {
                    throw;
                }

            }

            [HttpGet]
            public IActionResult Edit(int id)
            {
                var vehicleManager = new AutaManager();
                var car = vehicleManager.GetVehicle(id);
                return View(car);
            }

            [HttpPost]
            public IActionResult Edit(KomisModel vehicleModel)
            {
                var vehicleManager = new AutaManager();
                vehicleManager.UpdateVehicle(vehicleModel);
                return RedirectToAction("Index");
            }
    }
}
