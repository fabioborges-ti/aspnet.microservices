﻿using Basket.API.Entities;
using System.Threading.Tasks;

namespace Basket.API.Repositories.Interfaces
{
    public interface IBasketRepository
    {
        Task<ShoppingCart> GetBasket(string username);
        Task<ShoppingCart> UpdateBasket(ShoppingCart basket);
        Task DeleteBasket(string userName);
    }
}
