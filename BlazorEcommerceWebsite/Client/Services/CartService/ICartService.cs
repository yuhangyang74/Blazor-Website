﻿using System;
namespace BlazorEcommerceWebsite.Client.Services.CartService
{
    public interface ICartService
    {
        event Action OnChange;
        Task AddToCart ( CartItem cartItem );
        Task<List<CartItem>> GetCartItems();
        Task<List<CartProductResponseDTO>> GetCartProducts();
        Task RemoveProductFromCart ( int productId, int productTypeId );
    }
}
