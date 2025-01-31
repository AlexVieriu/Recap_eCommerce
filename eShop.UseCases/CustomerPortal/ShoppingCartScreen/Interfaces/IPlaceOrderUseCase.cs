﻿namespace eShop.UseCases.CustomerPortal.ShoppingCartScreen.Interfaces;

public interface IPlaceOrderUseCase
{
    Task<string> ExecuteAsync(Order order);
}
