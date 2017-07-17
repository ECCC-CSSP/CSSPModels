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
    public partial class MWQMLookupMPNTest
    {
        [TestMethod]
        public void MWQMLookupMPN_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "MWQMLookupMPNID", "Tubes10", "Tubes1", "Tubes01", "MPN_100ml", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMLookupMPN).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPN_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMLookupMPN_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(MWQMLookupMPN).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMLookupMPN_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMLookupMPNMWQMLookupMPNID);
               Assert.IsNotNull(ModelsRes.MWQMLookupMPNTubes10);
               Assert.IsNotNull(ModelsRes.MWQMLookupMPNTubes1);
               Assert.IsNotNull(ModelsRes.MWQMLookupMPNTubes01);
               Assert.IsNotNull(ModelsRes.MWQMLookupMPNMPN_100ml);
               Assert.IsNotNull(ModelsRes.MWQMLookupMPNLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMLookupMPNLastUpdateContactTVItemID);
        }
    }
}
