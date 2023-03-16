using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_meldrumn.Models
{
    public interface ICheckoutRepository
    {
        IQueryable<Checkout> Checkout { get; }

        void SaveCheckout(Checkout checkout);
    }
}
