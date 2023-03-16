﻿using Microsoft.AspNetCore.Mvc;
using Mission09_meldrumn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_meldrumn.Components
{
    public class CartSummaryViewComponent : ViewComponent
    {
        private Basket basket;
        public CartSummaryViewComponent(Basket basketService)
        {
            basket = basketService;
        }
        public IViewComponentResult Invoke()
        {
            return View(basket);
        }
    }
}
