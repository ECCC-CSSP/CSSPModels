using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Globalization;
using System.Transactions;
using System.Collections.Generic;
using CSSPModels.Resources;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Reflection;

namespace CSSPModels.Tests
{
    public partial class AddressTest
    {
        [TestMethod]
        public void Address_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "AddressID", "AddressTVItemID", "AddressType", "CountryTVItemID", "ProvinceTVItemID", "MunicipalityTVItemID", "StreetName", "StreetNumber", "StreetType", "PostalCode", "GoogleAddressText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.Address).GetProperties().OrderBy(c => c.Name))
            {
                Assert.AreEqual(propNameList[index], propertyInfo.PropertyType.Name);
                index += 1;
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
        public void Address_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "AddressTVItem", "CountryTVItem", "MunicipalityTVItem", "ProvinceTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Address).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual)
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
        public void Address_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.AddressAddressTVItem);
               Assert.IsNotNull(ModelsRes.AddressCountryTVItem);
               Assert.IsNotNull(ModelsRes.AddressMunicipalityTVItem);
               Assert.IsNotNull(ModelsRes.AddressProvinceTVItem);
        }
    }
}
