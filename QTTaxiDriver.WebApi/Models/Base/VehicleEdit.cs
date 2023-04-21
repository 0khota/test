﻿//@GeneratedCode
namespace QTTaxiDriver.WebApi.Models.Base
{
    using System;
    ///
    /// Generated by the generator
    ///
    public partial class VehicleEdit
    {
        ///
        /// Generated by the generator
        ///
        static VehicleEdit()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public VehicleEdit()
        {
            Constructing();
            
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        public IdType CompanyId { get; set; }
        ///
        /// Generated by the generator
        ///
        public System.DateTime ApprovalDate { get; set; }
        ///
        /// Generated by the generator
        ///
        public System.String Brand { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.String Model { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///
        public QTTaxiDriver.Logic.Modules.Common.VehicleType Type { get; set; }
        ///
        /// Generated by the generator
        ///
        public System.String LicensePlate { get; set; } = string.Empty;
        ///
        /// Generated by the generator
        ///
        public System.Int32 Mileage { get; set; }
        ///
        /// Generated by the generator
        ///
        public QTTaxiDriver.WebApi.Models.Base.Company? Company { get; set; }
    }
}