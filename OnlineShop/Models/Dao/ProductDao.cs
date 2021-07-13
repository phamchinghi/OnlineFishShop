﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineShop.Models.Dao
{
    public class ProductDao
    {
        ShopDbContext db = null;
        public ProductDao()
        {
            db = new ShopDbContext();
        }
        public List<Product> ListNewProduct(int top)
        {
            return db.Products.OrderByDescending(x => x.Date).Take(top).ToList();
        }

        public Product ViewDetail(long id)
        {

            return db.Products.Find(id);
        }
    }
}