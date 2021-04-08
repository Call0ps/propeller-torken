﻿using PropellerTorkenMain.Models.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PropellerTorkenMain.Services
{
    public class ProductService
    {

        public List<Product> productList { get; set; }

        PropellerDataContext pdc; 



        public ProductService()
        {

            pdc = new PropellerDataContext();

        }

        public IEnumerable<Product> GetAllProducts()
        {
            return pdc.Products.ToList();
        }

        public IEnumerable<Product> GetProductsByName(string s)
        {

            if (string.IsNullOrEmpty(s))

            {
                return pdc.Products.ToList();
            }
            else
            {
                return pdc.Products.Where(p => p.Name.ToLower().Contains(s)).ToList();
            }
        }

        public string DeleteProduct(int id)
        {
            var productToDelete = pdc.Products.Where(p => p.Id == id).Single<Product>();
            pdc.Products.Remove(productToDelete);
            pdc.SaveChanges();
            return "Record was successfully deleted";

        }

        public string AddProduct(string name, int price, int qty)
        {

            pdc.Products.Add(new Product() { Name=name, Price=price, Qty=qty});
            pdc.SaveChanges();
            return "New product was succesfully created";
        }

    }
}

