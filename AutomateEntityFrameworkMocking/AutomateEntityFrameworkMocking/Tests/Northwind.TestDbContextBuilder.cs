﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AutomateEntityFrameworkMocking.Tests
{


	using System;
	using System.Collections.Generic;
	using System.Linq;

	using AutomateEntityFrameworkMocking.Domain;

	using Moq;

	

	public class DbContextBuilder
	{   

	   
		
		public List<Category> Categories = new List<Category>();
		
	   
		
		public List<Customer> Customers = new List<Customer>();
		
	   
		
		public List<Employee> Employees = new List<Employee>();
		
	   
		
		public List<Order_Detail> Order_Details = new List<Order_Detail>();
		
	   
		
		public List<Order> Orders = new List<Order>();
		
	   
		
		public List<Product> Products = new List<Product>();
		
	   
		
		public List<Shipper> Shippers = new List<Shipper>();
		
	   
		
		public List<Supplier> Suppliers = new List<Supplier>();
		
	

	    public Mock<IDbContext> BuildMockDbContext(MockBehavior mockBehavior)
	    {
	        var mockDbContext = new Mock<IDbContext>(mockBehavior);
	   	
			mockDbContext
				.Setup(context => context.Categories)
				.Returns(Categories.AsQueryable());
				
    		mockDbContext
                .Setup(context => context.Add(It.IsAny<Category>()))
                .Callback((Category dataRow) => Categories.Add(dataRow));		
	   	
			mockDbContext
				.Setup(context => context.Customers)
				.Returns(Customers.AsQueryable());
				
    		mockDbContext
                .Setup(context => context.Add(It.IsAny<Customer>()))
                .Callback((Customer dataRow) => Customers.Add(dataRow));		
	   	
			mockDbContext
				.Setup(context => context.Employees)
				.Returns(Employees.AsQueryable());
				
    		mockDbContext
                .Setup(context => context.Add(It.IsAny<Employee>()))
                .Callback((Employee dataRow) => Employees.Add(dataRow));		
	   	
			mockDbContext
				.Setup(context => context.Order_Details)
				.Returns(Order_Details.AsQueryable());
				
    		mockDbContext
                .Setup(context => context.Add(It.IsAny<Order_Detail>()))
                .Callback((Order_Detail dataRow) => Order_Details.Add(dataRow));		
	   	
			mockDbContext
				.Setup(context => context.Orders)
				.Returns(Orders.AsQueryable());
				
    		mockDbContext
                .Setup(context => context.Add(It.IsAny<Order>()))
                .Callback((Order dataRow) => Orders.Add(dataRow));		
	   	
			mockDbContext
				.Setup(context => context.Products)
				.Returns(Products.AsQueryable());
				
    		mockDbContext
                .Setup(context => context.Add(It.IsAny<Product>()))
                .Callback((Product dataRow) => Products.Add(dataRow));		
	   	
			mockDbContext
				.Setup(context => context.Shippers)
				.Returns(Shippers.AsQueryable());
				
    		mockDbContext
                .Setup(context => context.Add(It.IsAny<Shipper>()))
                .Callback((Shipper dataRow) => Shippers.Add(dataRow));		
	   	
			mockDbContext
				.Setup(context => context.Suppliers)
				.Returns(Suppliers.AsQueryable());
				
    		mockDbContext
                .Setup(context => context.Add(It.IsAny<Supplier>()))
                .Callback((Supplier dataRow) => Suppliers.Add(dataRow));		
		
			return mockDbContext;	
		}

	  	public Mock<IDbContext> BuildMockDbContext()
	    {
	        return BuildMockDbContext(MockBehavior.Default);
	    }
		
		public IDbContext BuildDbContext()
		{
		    var dbContext = Mock.Of<IDbContext>(
		          context =>
	   
			context.Categories == Categories.AsQueryable()	
	   
			&& context.Customers == Customers.AsQueryable()	
	   
			&& context.Employees == Employees.AsQueryable()	
	   
			&& context.Order_Details == Order_Details.AsQueryable()	
	   
			&& context.Orders == Orders.AsQueryable()	
	   
			&& context.Products == Products.AsQueryable()	
	   
			&& context.Shippers == Shippers.AsQueryable()	
	   
			&& context.Suppliers == Suppliers.AsQueryable()	
	
			);
		return dbContext;
		}
		
	}


}
