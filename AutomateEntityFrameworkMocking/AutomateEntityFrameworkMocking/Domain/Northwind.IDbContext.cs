﻿

//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace AutomateEntityFrameworkMocking.Domain
{

	using System;
	using System.Linq;


	public interface IDbContext : IDisposable
	{   

		void SaveChanges();

    	void Add<T>(T entity) where T : class;
	
		void Delete<TEntity,TEntityKey>(TEntityKey id) where TEntity : class;	

    	void Delete<TEntity>(TEntity item) where TEntity : class;
	 
		IQueryable<Category> Categories	{ get; }
	
   		IQueryable<Customer> Customers	{ get; }
	  
		IQueryable<Employee> Employees	{ get; }
	 
		IQueryable<Order_Detail> Order_Details	{ get; }
	  
		IQueryable<Order> Orders	{ get; }
	  
		IQueryable<Product> Products	{ get; }
	
   		IQueryable<Shipper> Shippers	{ get; }
		
		IQueryable<Supplier> Suppliers	{ get; }
	
	}

}

