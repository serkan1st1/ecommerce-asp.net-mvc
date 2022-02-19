﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using e_commerce.Entity;
using e_commerce.Models;

namespace e_commerce.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var urunler = _context.Products
                .Where(i => i.IsHome && i.IsApproved)
                .Select(i => new ProductModel()
                {
                    Id=i.Id,
                    Name=i.Name.Length>50 ? i.Name.Substring(0, 47) + "....":i.Name, 
                    Description =i.Description.Length>50?i.Description.Substring(0,47)+"....":i.Description,
                    Price=i.Price,
                    Stock=i.Stock,
                    Image=i.Image,
                    CategoryId=i.CategoryId
                }).ToList();
            return View(urunler);
        }

        public ActionResult Details(int id)
        {
            return View(_context.Products.Where(i =>i.Id==id).FirstOrDefault()); //firstordefault tek ürün gönderir
        }
        public ActionResult List(int? id)
        {
            var urunler = _context.Products
                 .Where(predicate: i => i.IsApproved)
                 .Select(i => new ProductModel()
                 {
                     Id = i.Id,
                     Name = i.Name.Length > 50 ? i.Name.Substring(0, 47) + "...." : i.Name,
                     Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "...." : i.Description,
                     Price = i.Price,
                     Stock = i.Stock,
                     Image = i.Image,
                     CategoryId = i.CategoryId
                 }).AsQueryable();
            if (id!=null)
            {
                urunler = urunler.Where(i => i.CategoryId == id);
            }
            return View(urunler.ToList());
        }

        public PartialViewResult GetCategories()
        { 
        
            return PartialView(_context.Categories.ToList());

        
        }

    }
}