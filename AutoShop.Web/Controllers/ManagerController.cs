using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoShop.BL.IMPL;
using AutoShop.Models;
using Microsoft.AspNetCore.Mvc;

namespace AutoShop.Web.Controllers
{
    public class ManagerController : Controller
    {
        private IManagerService _intBase;

        public ManagerController(IManagerService intBase)//initBase
        {
            _intBase = intBase;
        }

        public IActionResult GetList()
        {
            var obList = _intBase.GetAllObjects();
            return View(obList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(ManagerDTO objects)
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
            ManagerDTO dbBase = _intBase.GetElementById(id); //_interfaceBase.GetById(id); now we can inherit our saved info here
            return View(dbBase);
        }

        [HttpPost]
        public IActionResult Edit(ManagerDTO objects)
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
            ManagerDTO dbBase = _intBase.GetElementById(id);
            return View(dbBase);
        }

        [HttpPost]
        public IActionResult Delete(int id, ManagerDTO objects)
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
