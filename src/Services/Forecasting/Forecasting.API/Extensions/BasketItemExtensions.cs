﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static EY.Digital.Services.Forecasting.API.Application.Commands.CreateOrderForecastCommand;

namespace EY.Digital.Services.Forecasting.API.Application.Models
{
    public static class BasketItemExtensions
    {
        public static IEnumerable<OrderItemDTO> ToOrderItemsDTO(this IEnumerable<BasketItem> basketItems)
        {
            foreach (var item in basketItems)
            {
                yield return item.ToOrderItemDTO();
            }
        }

        public static OrderItemDTO ToOrderItemDTO(this BasketItem item)
        {
            return new OrderItemDTO()
            {
                ProductId = int.TryParse(item.ProductId, out int id) ? id : -1,
                ProductName = item.ProductName,
                PictureUrl = item.PictureUrl,
                UnitPrice = item.UnitPrice,
                Units = item.Quantity
            };
        }
    }
}
