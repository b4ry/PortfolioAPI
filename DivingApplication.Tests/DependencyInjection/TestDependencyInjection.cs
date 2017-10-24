﻿using Autofac;
using Autofac.Core;
using DivingApplication.Api.Extensions;
using DivingApplication.Services.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Xunit;

namespace DivingApplication.Tests.DependencyInjection
{
    public class TestDependencyInjection
    {
        [Fact]
        public void UnitOfWorkMustBeRegisteredWhenInversionOfControlContainerIsRegistered()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            IComponentRegistration componentRegistration = null;
            var container = serviceCollection.AddApplicationModules();

            container.ComponentRegistry.TryGetRegistration(new TypedService(typeof(IUnitOfWork)), out componentRegistration);
            var resolvedComponentType = componentRegistration.Activator.LimitType.GetType();

            Assert.Equal(componentRegistration.Activator.LimitType.FullName, typeof(UnitOfWork).FullName);
        }

        [Fact]
        public void IUnitOfWorkMustBeResolvedProperlyWhenResolveIsCalled()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<DivingApplicationDbContext>();
            IContainer container = serviceCollection.AddApplicationModules();

            var builder = new DbContextOptionsBuilder<DivingApplicationDbContext>().UseInMemoryDatabase();
            var options = builder.Options;
            var divingApplicationDbContext = new DivingApplicationDbContext(options);

            IUnitOfWork resolvedComponent = container.Resolve<IUnitOfWork>();

            Assert.IsType(typeof(UnitOfWork), resolvedComponent);
        }
    }
}