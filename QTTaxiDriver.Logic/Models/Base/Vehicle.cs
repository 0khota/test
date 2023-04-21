﻿//@GeneratedCode
namespace QTTaxiDriver.Logic.Models.Base
{
    ///
    /// Generated by the generator
    ///
    public partial class Vehicle
    {
        ///
        /// Generated by the generator
        ///
        static Vehicle()
        {
            ClassConstructing();
            ClassConstructed();
        }
        static partial void ClassConstructing();
        static partial void ClassConstructed();
        
        ///
        /// Generated by the generator
        ///
        public Vehicle()
        {
            Constructing();
            _source = new Entities.Base.Vehicle();
            Constructed();
        }
        partial void Constructing();
        partial void Constructed();
        ///
        /// Generated by the generator
        ///
        internal Vehicle(Entities.Base.Vehicle source)
        {
            Constructing();
            _source = source;
            Constructed();
        }
        
        new internal Entities.Base.Vehicle Source
        {
            get => (Entities.Base.Vehicle)(_source!);
            set => _source = value;
        }
        
        public IdType CompanyId
        {
            get => Source.CompanyId;
            set => Source.CompanyId = value;
        }
        
        public System.DateTime ApprovalDate
        {
            get => Source.ApprovalDate;
            set => Source.ApprovalDate = value;
        }
        
        public System.String Brand
        {
            get => Source.Brand;
            set => Source.Brand = value;
        }
        
        public System.String Model
        {
            get => Source.Model;
            set => Source.Model = value;
        }
        
        public QTTaxiDriver.Logic.Modules.Common.VehicleType Type
        {
            get => Source.Type;
            set => Source.Type = value;
        }
        
        public System.String LicensePlate
        {
            get => Source.LicensePlate;
            set => Source.LicensePlate = value;
        }
        
        public System.Int32 Mileage
        {
            get => Source.Mileage;
            set => Source.Mileage = value;
        }
        
        public QTTaxiDriver.Logic.Models.Base.Company? Company
        {
            get => Source.Company != null ? QTTaxiDriver.Logic.Models.Base.Company.Create(Source.Company) : null;
            set => Source.Company = value?.Source;
        }
        
        private CommonBase.Modules.Collection.DelegateList<QTTaxiDriver.Logic.Entities.Base.Driver, QTTaxiDriver.Logic.Models.Base.Driver>? _drivers;
        public System.Collections.Generic.IList<QTTaxiDriver.Logic.Models.Base.Driver> Drivers
        {
            get => _drivers ??= new CommonBase.Modules.Collection.DelegateList<QTTaxiDriver.Logic.Entities.Base.Driver, QTTaxiDriver.Logic.Models.Base.Driver>(Source.Drivers, e => QTTaxiDriver.Logic.Models.Base.Driver.Create(e));
        }
        ///
        /// Generated by the generator
        ///
        internal void CopyProperties(Entities.Base.Vehicle other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                CompanyId = other.CompanyId;
                ApprovalDate = other.ApprovalDate;
                Brand = other.Brand;
                Model = other.Model;
                Type = other.Type;
                LicensePlate = other.LicensePlate;
                Mileage = other.Mileage;
                Company = other.Company != null ? QTTaxiDriver.Logic.Models.Base.Company.Create((object)other.Company) : null;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(Entities.Base.Vehicle other, ref bool handled);
        partial void AfterCopyProperties(Entities.Base.Vehicle other);
        ///
        /// Generated by the generator
        ///
        public void CopyProperties(QTTaxiDriver.Logic.Models.Base.Vehicle other)
        {
            bool handled = false;
            BeforeCopyProperties(other, ref handled);
            if (handled == false)
            {
                CompanyId = other.CompanyId;
                ApprovalDate = other.ApprovalDate;
                Brand = other.Brand;
                Model = other.Model;
                Type = other.Type;
                LicensePlate = other.LicensePlate;
                Mileage = other.Mileage;
                Company = other.Company != null ? QTTaxiDriver.Logic.Models.Base.Company.Create((object)other.Company) : null;
                Id = other.Id;
            }
            AfterCopyProperties(other);
        }
        partial void BeforeCopyProperties(QTTaxiDriver.Logic.Models.Base.Vehicle other, ref bool handled);
        partial void AfterCopyProperties(QTTaxiDriver.Logic.Models.Base.Vehicle other);
        ///
        /// Generated by the generator
        ///
        public override bool Equals(object? obj)
        {
            bool result = false;
            if (obj is Models.Base.Vehicle other)
            {
                result = Id == other.Id;
            }
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public override int GetHashCode()
        {
            return this.CalculateHashCode(CompanyId, ApprovalDate, Brand, Model, Type, LicensePlate, Mileage, Company, Drivers, Id);
        }
        ///
        /// Generated by the generator
        ///
        public static QTTaxiDriver.Logic.Models.Base.Vehicle Create()
        {
            BeforeCreate();
            var result = new QTTaxiDriver.Logic.Models.Base.Vehicle();
            AfterCreate(result);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTTaxiDriver.Logic.Models.Base.Vehicle Create(object other)
        {
            BeforeCreate(other);
            var result = new QTTaxiDriver.Logic.Models.Base.Vehicle();
            CommonBase.Extensions.ObjectExtensions.CopyFrom(result, other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTTaxiDriver.Logic.Models.Base.Vehicle Create(QTTaxiDriver.Logic.Models.Base.Vehicle other)
        {
            BeforeCreate(other);
            var result = new QTTaxiDriver.Logic.Models.Base.Vehicle();
            result.CopyProperties(other);
            AfterCreate(result, other);
            return result;
        }
        ///
        /// Generated by the generator
        ///
        public static QTTaxiDriver.Logic.Models.Base.Vehicle Create(Entities.Base.Vehicle other)
        {
            BeforeCreate(other);
            var result = new QTTaxiDriver.Logic.Models.Base.Vehicle();
            result.Source = other;
            AfterCreate(result, other);
            return result;
        }
        static partial void BeforeCreate();
        static partial void AfterCreate(QTTaxiDriver.Logic.Models.Base.Vehicle instance);
        static partial void BeforeCreate(object other);
        static partial void AfterCreate(QTTaxiDriver.Logic.Models.Base.Vehicle instance, object other);
        static partial void BeforeCreate(QTTaxiDriver.Logic.Models.Base.Vehicle other);
        static partial void AfterCreate(QTTaxiDriver.Logic.Models.Base.Vehicle instance, QTTaxiDriver.Logic.Models.Base.Vehicle other);
        static partial void BeforeCreate(Entities.Base.Vehicle other);
        static partial void AfterCreate(QTTaxiDriver.Logic.Models.Base.Vehicle instance, Entities.Base.Vehicle other);
    }
}
