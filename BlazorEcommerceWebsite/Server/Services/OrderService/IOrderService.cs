﻿using System;
namespace BlazorEcommerceWebsite.Server.Services.OrderService
{
    public interface IOrderService
    {
        Task<ServiceResponse<bool>> PlaceOrder ();

    }
}
