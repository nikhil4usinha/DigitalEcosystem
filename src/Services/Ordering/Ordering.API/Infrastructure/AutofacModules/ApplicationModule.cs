using Autofac;
using EY.Digital.Core.EventBus.Abstractions;
using EY.Digital.Services.Ordering.API.Application.Commands;
using EY.Digital.Services.Ordering.API.Application.Queries;
using EY.Digital.Services.Ordering.Domain.AggregatesModel.BuyerAggregate;
using EY.Digital.Services.Ordering.Domain.AggregatesModel.OrderAggregate;
using EY.Digital.Services.Ordering.Infrastructure.Idempotency;
using EY.Digital.Services.Ordering.Infrastructure.Repositories;
using System.Reflection;

namespace EY.Digital.Services.Ordering.API.Infrastructure.AutofacModules
{

    public class ApplicationModule
        :Autofac.Module
    {

        public string QueriesConnectionString { get; }

        public ApplicationModule(string qconstr)
        {
            QueriesConnectionString = qconstr;

        }

        protected override void Load(ContainerBuilder builder)
        {

            builder.Register(c => new OrderQueries(QueriesConnectionString))
                .As<IOrderQueries>()
                .InstancePerLifetimeScope();

            builder.RegisterType<BuyerRepository>()
                .As<IBuyerRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<OrderRepository>()
                .As<IOrderRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RequestManager>()
               .As<IRequestManager>()
               .InstancePerLifetimeScope();

            builder.RegisterAssemblyTypes(typeof(CreateOrderCommandHandler).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IIntegrationEventHandler<>));

        }
    }
}
