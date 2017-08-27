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
    public partial class MWQMSubsectorTest : SetupData
    {
        [TestMethod]
        public void MWQMSubsector_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MWQMSubsectorID", "MWQMSubsectorTVItemID", "SubsectorHistoricKey", "TideLocationSIDText", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "SubsectorTVText", "LastUpdateContactTVText", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.MWQMSubsector).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMSubsector).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MWQMSubsector_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMSubsector).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMSubsector_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.MWQMSubsectorMWQMSubsectorID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorMWQMSubsectorTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorSubsectorHistoricKey);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorTideLocationSIDText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorSubsectorTVText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.MWQMSubsectorHasErrors);
        }
        [TestMethod]
        public void MWQMSubsector_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mWQMSubsector.MWQMSubsectorID = val1;
               Assert.AreEqual(val1, mWQMSubsector.MWQMSubsectorID);
               int val2 = 45;
               mWQMSubsector.MWQMSubsectorTVItemID = val2;
               Assert.AreEqual(val2, mWQMSubsector.MWQMSubsectorTVItemID);
               string val3 = "Some text";
               mWQMSubsector.SubsectorHistoricKey = val3;
               Assert.AreEqual(val3, mWQMSubsector.SubsectorHistoricKey);
               string val4 = "Some text";
               mWQMSubsector.TideLocationSIDText = val4;
               Assert.AreEqual(val4, mWQMSubsector.TideLocationSIDText);
               DateTime val5 = new DateTime(2010, 3, 4);
               mWQMSubsector.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, mWQMSubsector.LastUpdateDate_UTC);
               int val6 = 45;
               mWQMSubsector.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, mWQMSubsector.LastUpdateContactTVItemID);
               string val7 = "Some text";
               mWQMSubsector.SubsectorTVText = val7;
               Assert.AreEqual(val7, mWQMSubsector.SubsectorTVText);
               string val8 = "Some text";
               mWQMSubsector.LastUpdateContactTVText = val8;
               Assert.AreEqual(val8, mWQMSubsector.LastUpdateContactTVText);
               bool val9 = true;
               mWQMSubsector.HasErrors = val9;
               Assert.AreEqual(val9, mWQMSubsector.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               mWQMSubsector.ValidationResults = val30;
               Assert.AreEqual(val30, mWQMSubsector.ValidationResults);
        }
    }
}
