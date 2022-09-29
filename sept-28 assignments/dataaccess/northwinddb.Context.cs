﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace dataaccess
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class NorthwindEntities : DbContext
    {
        public NorthwindEntities()
            : base("name=NorthwindEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<book> books { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<CustomerDemographic> CustomerDemographics { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<member> members { get; set; }
        public virtual DbSet<Order_Detail> Order_Details { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<Shipper> Shippers { get; set; }
        public virtual DbSet<student> students { get; set; }
        public virtual DbSet<Supplier> Suppliers { get; set; }
        public virtual DbSet<Territory> Territories { get; set; }
    
        public virtual int CustOrderHist(Nullable<int> p_id1, string p_name1)
        {
            var p_id1Parameter = p_id1.HasValue ?
                new ObjectParameter("p_id1", p_id1) :
                new ObjectParameter("p_id1", typeof(int));
    
            var p_name1Parameter = p_name1 != null ?
                new ObjectParameter("p_name1", p_name1) :
                new ObjectParameter("p_name1", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CustOrderHist", p_id1Parameter, p_name1Parameter);
        }
    
        public virtual ObjectResult<CustOrdersDetail_Result> CustOrdersDetail(Nullable<int> orderID)
        {
            var orderIDParameter = orderID.HasValue ?
                new ObjectParameter("OrderID", orderID) :
                new ObjectParameter("OrderID", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustOrdersDetail_Result>("CustOrdersDetail", orderIDParameter);
        }
    
        public virtual ObjectResult<CustOrdersOrders_Result> CustOrdersOrders(string customerID)
        {
            var customerIDParameter = customerID != null ?
                new ObjectParameter("CustomerID", customerID) :
                new ObjectParameter("CustomerID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<CustOrdersOrders_Result>("CustOrdersOrders", customerIDParameter);
        }
    
        public virtual ObjectResult<Employee_Sales_by_Country_Result> Employee_Sales_by_Country(Nullable<System.DateTime> beginning_Date, Nullable<System.DateTime> ending_Date)
        {
            var beginning_DateParameter = beginning_Date.HasValue ?
                new ObjectParameter("Beginning_Date", beginning_Date) :
                new ObjectParameter("Beginning_Date", typeof(System.DateTime));
    
            var ending_DateParameter = ending_Date.HasValue ?
                new ObjectParameter("Ending_Date", ending_Date) :
                new ObjectParameter("Ending_Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Employee_Sales_by_Country_Result>("Employee_Sales_by_Country", beginning_DateParameter, ending_DateParameter);
        }
    
        [DbFunction("NorthwindEntities", "fn_Emplist")]
        public virtual IQueryable<fn_Emplist_Result> fn_Emplist()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_Emplist_Result>("[NorthwindEntities].[fn_Emplist]()");
        }
    
        public virtual ObjectResult<Procedure_Result> Procedure(Nullable<int> param1, Nullable<int> param2)
        {
            var param1Parameter = param1.HasValue ?
                new ObjectParameter("param1", param1) :
                new ObjectParameter("param1", typeof(int));
    
            var param2Parameter = param2.HasValue ?
                new ObjectParameter("param2", param2) :
                new ObjectParameter("param2", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Procedure_Result>("Procedure", param1Parameter, param2Parameter);
        }
    
        public virtual ObjectResult<Sales_by_Year_Result> Sales_by_Year(Nullable<System.DateTime> beginning_Date, Nullable<System.DateTime> ending_Date)
        {
            var beginning_DateParameter = beginning_Date.HasValue ?
                new ObjectParameter("Beginning_Date", beginning_Date) :
                new ObjectParameter("Beginning_Date", typeof(System.DateTime));
    
            var ending_DateParameter = ending_Date.HasValue ?
                new ObjectParameter("Ending_Date", ending_Date) :
                new ObjectParameter("Ending_Date", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Sales_by_Year_Result>("Sales_by_Year", beginning_DateParameter, ending_DateParameter);
        }
    
        public virtual ObjectResult<SalesByCategory_Result> SalesByCategory(string categoryName, string ordYear)
        {
            var categoryNameParameter = categoryName != null ?
                new ObjectParameter("CategoryName", categoryName) :
                new ObjectParameter("CategoryName", typeof(string));
    
            var ordYearParameter = ordYear != null ?
                new ObjectParameter("OrdYear", ordYear) :
                new ObjectParameter("OrdYear", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SalesByCategory_Result>("SalesByCategory", categoryNameParameter, ordYearParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> sp_callfun()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("sp_callfun");
        }
    
        public virtual int sp_CustomerDelete(Nullable<int> bookid)
        {
            var bookidParameter = bookid.HasValue ?
                new ObjectParameter("bookid", bookid) :
                new ObjectParameter("bookid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_CustomerDelete", bookidParameter);
        }
    
        public virtual int sp_DeleteEmployee(Nullable<int> p_bookid)
        {
            var p_bookidParameter = p_bookid.HasValue ?
                new ObjectParameter("p_bookid", p_bookid) :
                new ObjectParameter("p_bookid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteEmployee", p_bookidParameter);
        }
    
        public virtual int sp_FindEmployee(Nullable<int> p_bookid, ObjectParameter p_bookname, ObjectParameter p_bookauthor)
        {
            var p_bookidParameter = p_bookid.HasValue ?
                new ObjectParameter("p_bookid", p_bookid) :
                new ObjectParameter("p_bookid", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_FindEmployee", p_bookidParameter, p_bookname, p_bookauthor);
        }
    
        public virtual ObjectResult<Ten_Most_Expensive_Products_Result> Ten_Most_Expensive_Products()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Ten_Most_Expensive_Products_Result>("Ten_Most_Expensive_Products");
        }
    
        public virtual int UpdateEmployeeDetails(string p_name1, Nullable<int> p_id1)
        {
            var p_name1Parameter = p_name1 != null ?
                new ObjectParameter("p_name1", p_name1) :
                new ObjectParameter("p_name1", typeof(string));
    
            var p_id1Parameter = p_id1.HasValue ?
                new ObjectParameter("p_id1", p_id1) :
                new ObjectParameter("p_id1", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateEmployeeDetails", p_name1Parameter, p_id1Parameter);
        }
    }
}