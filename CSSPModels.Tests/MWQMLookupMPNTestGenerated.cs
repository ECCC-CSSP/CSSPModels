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
    public partial class MWQMLookupMPNTest : SetupData
    {
        [TestMethod]
        public void MWQMLookupMPN_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMLookupMPNID", "Tubes10", "Tubes1", "Tubes01", "MPN_100ml", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();

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
        public void MWQMLookupMPN_Navigation_Test()
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
        public void MWQMLookupMPN_Has_ValidationResults_Test()
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
               Assert.IsNotNull(ModelsRes.MWQMLookupMPNLastUpdateContactTVText);
        }
        [TestMethod]
        public void MWQMLookupMPN_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMLookupMPN.MWQMLookupMPNID = val1;
               Assert.AreEqual(val1, mWQMLookupMPN.MWQMLookupMPNID);
               int val2 = 45;
               mWQMLookupMPN.Tubes10 = val2;
               Assert.AreEqual(val2, mWQMLookupMPN.Tubes10);
               int val3 = 45;
               mWQMLookupMPN.Tubes1 = val3;
               Assert.AreEqual(val3, mWQMLookupMPN.Tubes1);
               int val4 = 45;
               mWQMLookupMPN.Tubes01 = val4;
               Assert.AreEqual(val4, mWQMLookupMPN.Tubes01);
               int val5 = 45;
               mWQMLookupMPN.MPN_100ml = val5;
               Assert.AreEqual(val5, mWQMLookupMPN.MPN_100ml);
               DateTime val6 = new DateTime(2010, 3, 4);
               mWQMLookupMPN.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, mWQMLookupMPN.LastUpdateDate_UTC);
               int val7 = 45;
               mWQMLookupMPN.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, mWQMLookupMPN.LastUpdateContactTVItemID);
               string val8 = "Some text";
               mWQMLookupMPN.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, mWQMLookupMPN.LastUpdateContactTVText);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               mWQMLookupMPN.ValidationResults = val27;
               Assert.AreEqual(val27, mWQMLookupMPN.ValidationResults);
        }
    }
}
