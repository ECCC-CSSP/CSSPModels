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
    public partial class PolSourceObservationTest : SetupData
    {
        [TestMethod]
        public void PolSourceObservation_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceObservationID", "PolSourceSiteID", "ObservationDate_Local", "ContactTVItemID", "Observation_ToBeDeleted", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.PolSourceObservation).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservation_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "ContactTVItem", "PolSourceSite",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "PolSourceObservationIssues",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservation_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceObservation).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceObservation_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.PolSourceObservationPolSourceObservationID);
               Assert.IsNotNull(ModelsRes.PolSourceObservationPolSourceSiteID);
               Assert.IsNotNull(ModelsRes.PolSourceObservationObservationDate_Local);
               Assert.IsNotNull(ModelsRes.PolSourceObservationContactTVItemID);
               Assert.IsNotNull(ModelsRes.PolSourceObservationObservation_ToBeDeleted);
               Assert.IsNotNull(ModelsRes.PolSourceObservationLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.PolSourceObservationLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.PolSourceObservationPolSourceObservationIssues);
               Assert.IsNotNull(ModelsRes.PolSourceObservationContactTVItem);
               Assert.IsNotNull(ModelsRes.PolSourceObservationPolSourceSite);
        }
        [TestMethod]
        public void PolSourceObservation_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               polSourceObservation.PolSourceObservationID = val1;
               Assert.AreEqual(val1, polSourceObservation.PolSourceObservationID);
               int val2 = 45;
               polSourceObservation.PolSourceSiteID = val2;
               Assert.AreEqual(val2, polSourceObservation.PolSourceSiteID);
               DateTime val3 = new DateTime(2010, 3, 4);
               polSourceObservation.ObservationDate_Local = val3;
               Assert.AreEqual(val3, polSourceObservation.ObservationDate_Local);
               int val4 = 45;
               polSourceObservation.ContactTVItemID = val4;
               Assert.AreEqual(val4, polSourceObservation.ContactTVItemID);
               string val5 = "Some text";
               polSourceObservation.Observation_ToBeDeleted = val5;
               Assert.AreEqual(val5, polSourceObservation.Observation_ToBeDeleted);
               DateTime val6 = new DateTime(2010, 3, 4);
               polSourceObservation.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, polSourceObservation.LastUpdateDate_UTC);
               int val7 = 45;
               polSourceObservation.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, polSourceObservation.LastUpdateContactTVItemID);
               ICollection<PolSourceObservationIssue> val19 = new List<PolSourceObservationIssue>();
               polSourceObservation.PolSourceObservationIssues = val19;
               Assert.AreEqual(val19, polSourceObservation.PolSourceObservationIssues);
               TVItem val20 = new TVItem();
               polSourceObservation.ContactTVItem = val20;
               Assert.AreEqual(val20, polSourceObservation.ContactTVItem);
               PolSourceSite val21 = new PolSourceSite();
               polSourceObservation.PolSourceSite = val21;
               Assert.AreEqual(val21, polSourceObservation.PolSourceSite);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               polSourceObservation.ValidationResults = val33;
               Assert.AreEqual(val33, polSourceObservation.ValidationResults);
        }
    }
}
