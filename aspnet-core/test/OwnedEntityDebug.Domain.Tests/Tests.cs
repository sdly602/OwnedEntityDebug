using System;
using System.Threading.Tasks;
using Shouldly;
using Volo.Abp.Domain.Repositories;
using Xunit;

namespace OwnedEntityDebug
{
    public class OwnedEntityDebugTests : OwnedEntityDebugDomainTestBase
    {
        private readonly IRepository<Order, Guid> _orderRepo;

        public OwnedEntityDebugTests()
        {
            _orderRepo = GetRequiredService<IRepository<Order, Guid>>();
        }

        [Fact]
        public async Task Should_Not_Get_Invoice_Address()
        {
            var orderId = Guid.NewGuid();
            var order = new Order(orderId);

            order.InvoiceAddress = new Address { City = "BeiJing", Street = "ChangAn" };
            order.Cargoes.Add(new Cargo { ConsigeeAddress = order.InvoiceAddress,OrderId=orderId });
            await _orderRepo.InsertAsync(order, true);

            var orderReloaded = await _orderRepo.GetAsync(orderId);

            //failed ,InvoiceAddress is null
            orderReloaded.InvoiceAddress.ShouldNotBeNull();
            orderReloaded.InvoiceAddress.City.ShouldBe("BeiJing");
        }

        [Fact]
        public async Task Should_Get_Invoice_Address()
        {
            var orderId = Guid.NewGuid();
            var order = new Order(orderId);
            order.InvoiceAddress = new Address { City = "BeiJing", Street = "ChangAn" };

            var cargoAddress= new Address { City = "BeiJing", Street = "ChangAn" };
            order.Cargoes.Add(new Cargo { ConsigeeAddress = cargoAddress,OrderId=orderId });

            await _orderRepo.InsertAsync(order, true);

            var orderReloaded = await _orderRepo.GetAsync(orderId);
            orderReloaded.InvoiceAddress.ShouldNotBeNull();
            orderReloaded.InvoiceAddress.City.ShouldBe("BeiJing");
        }
    }
}