using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using EY.Digital.Services.Forecasting.API.Application.Commands;
using EY.Digital.Services.Forecasting.API.Application.Queries;
using EY.Digital.Services.Forecasting.API.Infrastructure.Services;
using EY.Digital.Services.Forecasting.Domain.Events;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace EY.Digital.Services.Forecasting.API.Controllers
{
    [Route("api/v1/[controller]")]
    [Authorize]
    public class OrderForecastController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IOrderQueries _orderQueries;
        private readonly IIdentityService _identityService;

        public OrderForecastController(IMediator mediator, IOrderQueries orderQueries, IIdentityService identityService)
        {

            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
            _orderQueries = orderQueries ?? throw new ArgumentNullException(nameof(orderQueries));
            _identityService = identityService ?? throw new ArgumentNullException(nameof(identityService));
        }

       
        [Route("{orderId:int}")]
        [HttpGet]
        [ProducesResponseType(typeof(Order),(int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetOrder(int orderId)
        {
            try
            {
                var order = await _orderQueries
                    .GetOrderAsync(orderId);

                return Ok(order);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }
        }

        [Route("")]
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<OrderSummary>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetOrders()
        {
            var orders = await _orderQueries.GetOrdersAsync();

            return Ok(orders);
        }

    }
}


