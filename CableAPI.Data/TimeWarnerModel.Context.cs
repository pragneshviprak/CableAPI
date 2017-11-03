﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CableAPI.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TimeWarnerEntities : DbContext
    {
        public TimeWarnerEntities()
            : base("name=TimeWarnerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
    
        public virtual ObjectResult<p_GetCarrierByZipCode_Result> p_GetCarrierByZipCode(string zipCode)
        {
            var zipCodeParameter = zipCode != null ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<p_GetCarrierByZipCode_Result>("p_GetCarrierByZipCode", zipCodeParameter);
        }
    
        public virtual ObjectResult<Nullable<System.Guid>> p_InsertOrder(Nullable<System.Guid> orderId, string unit, string streetAddress, string city, string state, string zipCode, string firstName, string lastName, string email, string phone)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(System.Guid));
    
            var unitParameter = unit != null ?
                new ObjectParameter("Unit", unit) :
                new ObjectParameter("Unit", typeof(string));
    
            var streetAddressParameter = streetAddress != null ?
                new ObjectParameter("StreetAddress", streetAddress) :
                new ObjectParameter("StreetAddress", typeof(string));
    
            var cityParameter = city != null ?
                new ObjectParameter("City", city) :
                new ObjectParameter("City", typeof(string));
    
            var stateParameter = state != null ?
                new ObjectParameter("State", state) :
                new ObjectParameter("State", typeof(string));
    
            var zipCodeParameter = zipCode != null ?
                new ObjectParameter("ZipCode", zipCode) :
                new ObjectParameter("ZipCode", typeof(string));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("FirstName", firstName) :
                new ObjectParameter("FirstName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("LastName", lastName) :
                new ObjectParameter("LastName", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("Email", email) :
                new ObjectParameter("Email", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<System.Guid>>("p_InsertOrder", orderIdParameter, unitParameter, streetAddressParameter, cityParameter, stateParameter, zipCodeParameter, firstNameParameter, lastNameParameter, emailParameter, phoneParameter);
        }
    
        public virtual int p_UpdateOrder(Nullable<System.Guid> orderId, string orderStatus, string accountNumber, string serviceType, string workOrderId, string notes)
        {
            var orderIdParameter = orderId.HasValue ?
                new ObjectParameter("OrderId", orderId) :
                new ObjectParameter("OrderId", typeof(System.Guid));
    
            var orderStatusParameter = orderStatus != null ?
                new ObjectParameter("OrderStatus", orderStatus) :
                new ObjectParameter("OrderStatus", typeof(string));
    
            var accountNumberParameter = accountNumber != null ?
                new ObjectParameter("AccountNumber", accountNumber) :
                new ObjectParameter("AccountNumber", typeof(string));
    
            var serviceTypeParameter = serviceType != null ?
                new ObjectParameter("ServiceType", serviceType) :
                new ObjectParameter("ServiceType", typeof(string));
    
            var workOrderIdParameter = workOrderId != null ?
                new ObjectParameter("WorkOrderId", workOrderId) :
                new ObjectParameter("WorkOrderId", typeof(string));
    
            var notesParameter = notes != null ?
                new ObjectParameter("Notes", notes) :
                new ObjectParameter("Notes", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("p_UpdateOrder", orderIdParameter, orderStatusParameter, accountNumberParameter, serviceTypeParameter, workOrderIdParameter, notesParameter);
        }
    
        public virtual ObjectResult<p_VerifyUser_Result> p_VerifyUser(string userName, string password)
        {
            var userNameParameter = userName != null ?
                new ObjectParameter("UserName", userName) :
                new ObjectParameter("UserName", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<p_VerifyUser_Result>("p_VerifyUser", userNameParameter, passwordParameter);
        }
    }
}
