﻿using Microsoft.EntityFrameworkCore;
using SignalRDataAccessLayer.Abstract;
using SignalRDataAccessLayer.Concrete;
using SignalRDataAccessLayer.Repositories;
using SignalREntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRDataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public EfProductDal(SignalRContext context) : base(context)
        {
        }

        public List<Product> GetProductsWithCategoires()
        {
            var context = new SignalRContext();
            var values = context.Products.Include(x => x.Category).ToList();
            return values;
        }

		public int ProductCount()
		{
            using var context = new SignalRContext();
            return context.Products.Count();
		}

		public int ProductCountByCategoryNameDrink()
		{
            using var context = new SignalRContext();
            return context.Products.Where(x => x.CategoryId == (context.Categories.Where
            (y => y.Name == "İçecek").Select(z => z.CategoryId).FirstOrDefault())).Count();
		}

		public int ProductCountByCategoryNameHamburger()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.CategoryId == (context.Categories.Where
			(y => y.Name == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Count();
		}

		public string ProductNameByMaxPrice()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.Price == (context.Products.Max(y => y.Price))).Select(
				z => z.ProductName).FirstOrDefault();		}

		public string ProductNameByMinPrice()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.Price == (context.Products.Min(y => y.Price))).Select(
				z => z.ProductName).FirstOrDefault();
		}

		public decimal ProductPriceAvg()
		{
			using var context = new SignalRContext();
			return context.Products.Average(x=>x.Price);
		}

		public decimal ProductAvgPriceByHamburger()
		{
			using var context = new SignalRContext();
			return context.Products.Where(x => x.CategoryId == (context.Categories.Where
			(y => y.Name == "Hamburger").Select(z => z.CategoryId).FirstOrDefault())).Average(w => w.Price);
		}

        public decimal ProductBySteakBurger()
        {
			using var context = new SignalRContext();
			return context.Products.Where(x => x.ProductName == "Steak Burger").Select(y => y.Price).FirstOrDefault();
        }

        public decimal TotalPriceByDrinkCategory()
        {
            using var context = new SignalRContext();
			int id = context.Categories.Where(x => x.Name == "İçecek").Select(y => y.CategoryId).FirstOrDefault();
			return context.Products.Where(x=>x.CategoryId == id).Sum(y=> y.Price);
        }

        public decimal TotalPriceBySaladCategory()
        {
            using var context = new SignalRContext();
            int id = context.Categories.Where(x => x.Name == "Salata").Select(y => y.CategoryId).FirstOrDefault();
            return context.Products.Where(x => x.CategoryId == id).Sum(y => y.Price);
        }

		public List<Product> GetLast9Products()
		{
			var context = new SignalRContext();
			var values = context.Products.Take(9).ToList();
			return values;
		}
	}
}
