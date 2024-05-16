﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pronia.DataAccesLayer;
using Pronia.ViewModels.Products;

namespace Pronia.ViewComponents
{
    public class ProductViewComponent(ProniaContext _context) : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _context.Products.Select(p => new GetProductVM
            {
                Id = p.Id,
                Name = p.Name,
                Discount = p.Discount,
                ImageUrl = p.ImageUrl,
                IsStock = p.StockCount > 0,
                Rating = p.Raiting,
                SellPrice = p.SellPrice
            }).ToListAsync());
        }
    }
}
