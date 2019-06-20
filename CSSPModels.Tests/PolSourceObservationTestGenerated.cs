/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 */ 
using System;
using System.Text;
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
    [TestClass]
    public partial class PolSourceObservationTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private PolSourceObservation polSourceObservation { get; set; }
        private PolSourceObservationExtraA polSourceObservationExtraA { get; set; }
        private PolSourceObservationExtraB polSourceObservationExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObservationTest()
        {
            polSourceObservation = new PolSourceObservation();
            polSourceObservationExtraA = new PolSourceObservationExtraA();
            polSourceObservationExtraB = new PolSourceObservationExtraB();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void PolSourceObservation_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceObservationID", "PolSourceSiteID", "ObservationDate_Local", "ContactTVItemID", "DesktopReviewed", "Observation_ToBeDeleted", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation).GetProperties().OrderBy(c => c.Name))
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
        public void PolSourceObservationExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceSiteText", "ContactName", "LastUpdateContactText", "PolSourceObservationID", "PolSourceSiteID", "ObservationDate_Local", "ContactTVItemID", "DesktopReviewed", "Observation_ToBeDeleted", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservationExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservationExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservationExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceObservationReportTest", "PolSourceSiteText", "ContactName", "LastUpdateContactText", "PolSourceObservationID", "PolSourceSiteID", "ObservationDate_Local", "ContactTVItemID", "DesktopReviewed", "Observation_ToBeDeleted", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservationExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservationExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

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
        public void PolSourceObservationExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservationExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservationExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservationExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservationExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservationExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservationExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceObservationExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceObservationExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceObservationExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val5 = true;
               polSourceObservation.DesktopReviewed = val5;
               Assert.AreEqual(val5, polSourceObservation.DesktopReviewed);
               string val6 = "Some text";
               polSourceObservation.Observation_ToBeDeleted = val6;
               Assert.AreEqual(val6, polSourceObservation.Observation_ToBeDeleted);
               DateTime val7 = new DateTime(2010, 3, 4);
               polSourceObservation.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, polSourceObservation.LastUpdateDate_UTC);
               int val8 = 45;
               polSourceObservation.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, polSourceObservation.LastUpdateContactTVItemID);
               bool val9 = true;
               polSourceObservation.HasErrors = val9;
               Assert.AreEqual(val9, polSourceObservation.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               polSourceObservation.ValidationResults = val30;
               Assert.AreEqual(val30, polSourceObservation.ValidationResults);
        }
        [TestMethod]
        public void PolSourceObservationExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               polSourceObservationExtraA.PolSourceSiteText = val1;
               Assert.AreEqual(val1, polSourceObservationExtraA.PolSourceSiteText);
               string val2 = "Some text";
               polSourceObservationExtraA.ContactName = val2;
               Assert.AreEqual(val2, polSourceObservationExtraA.ContactName);
               string val3 = "Some text";
               polSourceObservationExtraA.LastUpdateContactText = val3;
               Assert.AreEqual(val3, polSourceObservationExtraA.LastUpdateContactText);
               int val4 = 45;
               polSourceObservationExtraA.PolSourceObservationID = val4;
               Assert.AreEqual(val4, polSourceObservationExtraA.PolSourceObservationID);
               int val5 = 45;
               polSourceObservationExtraA.PolSourceSiteID = val5;
               Assert.AreEqual(val5, polSourceObservationExtraA.PolSourceSiteID);
               DateTime val6 = new DateTime(2010, 3, 4);
               polSourceObservationExtraA.ObservationDate_Local = val6;
               Assert.AreEqual(val6, polSourceObservationExtraA.ObservationDate_Local);
               int val7 = 45;
               polSourceObservationExtraA.ContactTVItemID = val7;
               Assert.AreEqual(val7, polSourceObservationExtraA.ContactTVItemID);
               bool val8 = true;
               polSourceObservationExtraA.DesktopReviewed = val8;
               Assert.AreEqual(val8, polSourceObservationExtraA.DesktopReviewed);
               string val9 = "Some text";
               polSourceObservationExtraA.Observation_ToBeDeleted = val9;
               Assert.AreEqual(val9, polSourceObservationExtraA.Observation_ToBeDeleted);
               DateTime val10 = new DateTime(2010, 3, 4);
               polSourceObservationExtraA.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, polSourceObservationExtraA.LastUpdateDate_UTC);
               int val11 = 45;
               polSourceObservationExtraA.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, polSourceObservationExtraA.LastUpdateContactTVItemID);
               bool val12 = true;
               polSourceObservationExtraA.HasErrors = val12;
               Assert.AreEqual(val12, polSourceObservationExtraA.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               polSourceObservationExtraA.ValidationResults = val39;
               Assert.AreEqual(val39, polSourceObservationExtraA.ValidationResults);
        }
        [TestMethod]
        public void PolSourceObservationExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               polSourceObservationExtraB.PolSourceObservationReportTest = val1;
               Assert.AreEqual(val1, polSourceObservationExtraB.PolSourceObservationReportTest);
               string val2 = "Some text";
               polSourceObservationExtraB.PolSourceSiteText = val2;
               Assert.AreEqual(val2, polSourceObservationExtraB.PolSourceSiteText);
               string val3 = "Some text";
               polSourceObservationExtraB.ContactName = val3;
               Assert.AreEqual(val3, polSourceObservationExtraB.ContactName);
               string val4 = "Some text";
               polSourceObservationExtraB.LastUpdateContactText = val4;
               Assert.AreEqual(val4, polSourceObservationExtraB.LastUpdateContactText);
               int val5 = 45;
               polSourceObservationExtraB.PolSourceObservationID = val5;
               Assert.AreEqual(val5, polSourceObservationExtraB.PolSourceObservationID);
               int val6 = 45;
               polSourceObservationExtraB.PolSourceSiteID = val6;
               Assert.AreEqual(val6, polSourceObservationExtraB.PolSourceSiteID);
               DateTime val7 = new DateTime(2010, 3, 4);
               polSourceObservationExtraB.ObservationDate_Local = val7;
               Assert.AreEqual(val7, polSourceObservationExtraB.ObservationDate_Local);
               int val8 = 45;
               polSourceObservationExtraB.ContactTVItemID = val8;
               Assert.AreEqual(val8, polSourceObservationExtraB.ContactTVItemID);
               bool val9 = true;
               polSourceObservationExtraB.DesktopReviewed = val9;
               Assert.AreEqual(val9, polSourceObservationExtraB.DesktopReviewed);
               string val10 = "Some text";
               polSourceObservationExtraB.Observation_ToBeDeleted = val10;
               Assert.AreEqual(val10, polSourceObservationExtraB.Observation_ToBeDeleted);
               DateTime val11 = new DateTime(2010, 3, 4);
               polSourceObservationExtraB.LastUpdateDate_UTC = val11;
               Assert.AreEqual(val11, polSourceObservationExtraB.LastUpdateDate_UTC);
               int val12 = 45;
               polSourceObservationExtraB.LastUpdateContactTVItemID = val12;
               Assert.AreEqual(val12, polSourceObservationExtraB.LastUpdateContactTVItemID);
               bool val13 = true;
               polSourceObservationExtraB.HasErrors = val13;
               Assert.AreEqual(val13, polSourceObservationExtraB.HasErrors);
               IEnumerable<ValidationResult> val42 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               polSourceObservationExtraB.ValidationResults = val42;
               Assert.AreEqual(val42, polSourceObservationExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
