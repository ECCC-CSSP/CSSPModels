using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;
using CSSPEnums;
using System.ComponentModel.DataAnnotations;

namespace CSSPModels.Tests
{
    public partial class AddressTest : SetupData
    {
        [TestMethod]
        public void Address_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "AddressID", "AddressTVItemID", "AddressType", "CountryTVItemID", "ProvinceTVItemID", "MunicipalityTVItemID", "StreetName", "StreetNumber", "StreetType", "PostalCode", "GoogleAddressText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ParentTVItemID", "AddressTVText", "CountryTVText", "ProvinceTVText", "MunicipalityTVText", "AddressTypeText", "StreetTypeText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Address).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Address).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void Address_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Address).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Address).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void Address_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Address).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Address_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.AddressAddressID);
               Assert.IsNotNull(ModelsRes.AddressAddressTVItemID);
               Assert.IsNotNull(ModelsRes.AddressAddressType);
               Assert.IsNotNull(ModelsRes.AddressCountryTVItemID);
               Assert.IsNotNull(ModelsRes.AddressProvinceTVItemID);
               Assert.IsNotNull(ModelsRes.AddressMunicipalityTVItemID);
               Assert.IsNotNull(ModelsRes.AddressStreetName);
               Assert.IsNotNull(ModelsRes.AddressStreetNumber);
               Assert.IsNotNull(ModelsRes.AddressStreetType);
               Assert.IsNotNull(ModelsRes.AddressPostalCode);
               Assert.IsNotNull(ModelsRes.AddressGoogleAddressText);
               Assert.IsNotNull(ModelsRes.AddressLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.AddressLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.AddressParentTVItemID);
               Assert.IsNotNull(ModelsRes.AddressAddressTVText);
               Assert.IsNotNull(ModelsRes.AddressCountryTVText);
               Assert.IsNotNull(ModelsRes.AddressProvinceTVText);
               Assert.IsNotNull(ModelsRes.AddressMunicipalityTVText);
               Assert.IsNotNull(ModelsRes.AddressAddressTypeText);
               Assert.IsNotNull(ModelsRes.AddressStreetTypeText);
        }
        [TestMethod]
        public void Address_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               address.AddressID = val1;
               Assert.AreEqual(val1, address.AddressID);
               int val2 = 45;
               address.AddressTVItemID = val2;
               Assert.AreEqual(val2, address.AddressTVItemID);
               AddressTypeEnum val3 = (AddressTypeEnum)3;
               address.AddressType = val3;
               Assert.AreEqual(val3, address.AddressType);
               int val4 = 45;
               address.CountryTVItemID = val4;
               Assert.AreEqual(val4, address.CountryTVItemID);
               int val5 = 45;
               address.ProvinceTVItemID = val5;
               Assert.AreEqual(val5, address.ProvinceTVItemID);
               int val6 = 45;
               address.MunicipalityTVItemID = val6;
               Assert.AreEqual(val6, address.MunicipalityTVItemID);
               string val7 = "Some text";
               address.StreetName = val7;
               Assert.AreEqual(val7, address.StreetName);
               string val8 = "Some text";
               address.StreetNumber = val8;
               Assert.AreEqual(val8, address.StreetNumber);
               StreetTypeEnum val9 = (StreetTypeEnum)3;
               address.StreetType = val9;
               Assert.AreEqual(val9, address.StreetType);
               string val10 = "Some text";
               address.PostalCode = val10;
               Assert.AreEqual(val10, address.PostalCode);
               string val11 = "Some text";
               address.GoogleAddressText = val11;
               Assert.AreEqual(val11, address.GoogleAddressText);
               DateTime val12 = new DateTime(2010, 3, 4);
               address.LastUpdateDate_UTC = val12;
               Assert.AreEqual(val12, address.LastUpdateDate_UTC);
               int val13 = 45;
               address.LastUpdateContactTVItemID = val13;
               Assert.AreEqual(val13, address.LastUpdateContactTVItemID);
               int val14 = 45;
               address.ParentTVItemID = val14;
               Assert.AreEqual(val14, address.ParentTVItemID);
               string val15 = "Some text";
               address.AddressTVText = val15;
               Assert.AreEqual(val15, address.AddressTVText);
               string val16 = "Some text";
               address.CountryTVText = val16;
               Assert.AreEqual(val16, address.CountryTVText);
               string val17 = "Some text";
               address.ProvinceTVText = val17;
               Assert.AreEqual(val17, address.ProvinceTVText);
               string val18 = "Some text";
               address.MunicipalityTVText = val18;
               Assert.AreEqual(val18, address.MunicipalityTVText);
               string val19 = "Some text";
               address.AddressTypeText = val19;
               Assert.AreEqual(val19, address.AddressTypeText);
               string val20 = "Some text";
               address.StreetTypeText = val20;
               Assert.AreEqual(val20, address.StreetTypeText);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>().AsEnumerable();
               address.ValidationResults = val63;
               Assert.AreEqual(val63, address.ValidationResults);
        }
    }
}
