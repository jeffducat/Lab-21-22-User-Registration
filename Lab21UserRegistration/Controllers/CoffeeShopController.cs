using Lab21UserRegistration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab21UserRegistration.Controllers
{
    public class CoffeeShopController : Controller
    {
        ShopDBEntities ORM = new ShopDBEntities();

        public ActionResult Index()
        {
            ViewBag.Items = ORM.Items.ToList();
            return View();
        }

        public ActionResult ProductForm()
        {
            return View();
        }

        public ActionResult SaveNewProduct(Item newItem)
        {
            if (ModelState.IsValid)
            {
                ORM.Items.Add(newItem);
                ORM.SaveChanges();
                return RedirectToAction("Index",newItem);
            }
            ViewBag.ErrorMessage = "Something did not go right";
            return View("Index");
        }
       
        public ActionResult DeleteProduct(int Id)
        {
            Item found = ORM.Items.Find(Id);
            ORM.Items.Remove(found);
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }
        
        public ActionResult UpdateProduct(int Id)
        {
            Item found = ORM.Items.Find(Id);
            if (Id is 0)
            {
                return RedirectToAction("Index");
            }
            return View(found);
        }

        public ActionResult SaveChanges(Item updatedItem)
        {
            Item originalItem = ORM.Items.Find(updatedItem.Id);

            if (originalItem != null)
            {
                originalItem.Name = updatedItem.Name;
                originalItem.Description = updatedItem.Description;
                originalItem.Quantity = updatedItem.Quantity;
                originalItem.Price = updatedItem.Price;

                ORM.SaveChanges();
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index", updatedItem.Id);
            }
        }
    }
}