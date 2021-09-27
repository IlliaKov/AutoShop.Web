using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop.BL.IMPL;
using AutoShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop.Web.Controllers
{
    public class CarController : Controller
    {
        private ICarService _intBase;

        public CarController(ICarService intBase)//initBase
        {
            _intBase = intBase;
        }

        public IActionResult GetList()
        {
            var obList = _intBase.GetAll();
            return View(obList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CarDTO objects)
        {
            try
            {
                _intBase.AddObject(objects);
                return RedirectToAction("GetList");
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            CarDTO dbBase = _intBase.GetElementById(id); //_interfaceBase.GetById(id); now we can inherit our saved info here
            return View(dbBase);
        }

        [HttpPost]
        public IActionResult Edit(CarDTO objects)
        {
            try
            {
                _intBase.UpdateObject(objects);

                return RedirectToAction("GetList");
            }
            catch
            {
                return View();
            }
        }

        public IActionResult Delete(int id)
        {
            CarDTO dbBase = _intBase.GetElementById(id);
            return View(dbBase);
        }

        [HttpPost]
        public IActionResult Delete(int id, CarDTO objects)
        {
            try
            {
                _intBase.DeleteObject(id);

                return RedirectToAction("GetList");
            }
            catch
            {
                return View();
            }
        }
    }
}
