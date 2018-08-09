/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
        private PolSourceObservation_A polSourceObservation_A { get; set; }
        private PolSourceObservation_B polSourceObservation_B { get; set; }
        #endregion Properties

        #region Constructors
        public PolSourceObservationTest()
        {
            polSourceObservation = new PolSourceObservation();
            polSourceObservation_A = new PolSourceObservation_A();
            polSourceObservation_B = new PolSourceObservation_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void PolSourceObservation_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceObservationID", "PolSourceSiteID", "ObservationDate_Local", "ContactTVItemID", "Observation_ToBeDeleted", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
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
        public void PolSourceObservation_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceSiteTVItemLanguage", "ContactTVItemLanguage", "LastUpdateContactTVItemLanguage", "PolSourceObservationID", "PolSourceSiteID", "ObservationDate_Local", "ContactTVItemID", "Observation_ToBeDeleted", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservation_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PolSourceObservationReportTest", "PolSourceSiteTVItemLanguage", "ContactTVItemLanguage", "LastUpdateContactTVItemLanguage", "PolSourceObservationID", "PolSourceSiteID", "ObservationDate_Local", "ContactTVItemID", "Observation_ToBeDeleted", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservation_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservation_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(PolSourceObservation_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void PolSourceObservation_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceObservation_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void PolSourceObservation_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(PolSourceObservation_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               bool val8 = true;
               polSourceObservation.HasErrors = val8;
               Assert.AreEqual(val8, polSourceObservation.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               polSourceObservation.ValidationResults = val27;
               Assert.AreEqual(val27, polSourceObservation.ValidationResults);
        }
        [TestMethod]
        public void PolSourceObservation_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               polSourceObservation_A.PolSourceSiteTVItemLanguage = val1;
               Assert.AreEqual(val1, polSourceObservation_A.PolSourceSiteTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               polSourceObservation_A.ContactTVItemLanguage = val2;
               Assert.AreEqual(val2, polSourceObservation_A.ContactTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               polSourceObservation_A.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, polSourceObservation_A.LastUpdateContactTVItemLanguage);
               int val4 = 45;
               polSourceObservation_A.PolSourceObservationID = val4;
               Assert.AreEqual(val4, polSourceObservation_A.PolSourceObservationID);
               int val5 = 45;
               polSourceObservation_A.PolSourceSiteID = val5;
               Assert.AreEqual(val5, polSourceObservation_A.PolSourceSiteID);
               DateTime val6 = new DateTime(2010, 3, 4);
               polSourceObservation_A.ObservationDate_Local = val6;
               Assert.AreEqual(val6, polSourceObservation_A.ObservationDate_Local);
               int val7 = 45;
               polSourceObservation_A.ContactTVItemID = val7;
               Assert.AreEqual(val7, polSourceObservation_A.ContactTVItemID);
               string val8 = "Some text";
               polSourceObservation_A.Observation_ToBeDeleted = val8;
               Assert.AreEqual(val8, polSourceObservation_A.Observation_ToBeDeleted);
               DateTime val9 = new DateTime(2010, 3, 4);
               polSourceObservation_A.LastUpdateDate_UTC = val9;
               Assert.AreEqual(val9, polSourceObservation_A.LastUpdateDate_UTC);
               int val10 = 45;
               polSourceObservation_A.LastUpdateContactTVItemID = val10;
               Assert.AreEqual(val10, polSourceObservation_A.LastUpdateContactTVItemID);
               bool val11 = true;
               polSourceObservation_A.HasErrors = val11;
               Assert.AreEqual(val11, polSourceObservation_A.HasErrors);
               IEnumerable<ValidationResult> val36 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               polSourceObservation_A.ValidationResults = val36;
               Assert.AreEqual(val36, polSourceObservation_A.ValidationResults);
        }
        [TestMethod]
        public void PolSourceObservation_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               polSourceObservation_B.PolSourceObservationReportTest = val1;
               Assert.AreEqual(val1, polSourceObservation_B.PolSourceObservationReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               polSourceObservation_B.PolSourceSiteTVItemLanguage = val2;
               Assert.AreEqual(val2, polSourceObservation_B.PolSourceSiteTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               polSourceObservation_B.ContactTVItemLanguage = val3;
               Assert.AreEqual(val3, polSourceObservation_B.ContactTVItemLanguage);
               TVItemLanguage val4 = new TVItemLanguage();
               polSourceObservation_B.LastUpdateContactTVItemLanguage = val4;
               Assert.AreEqual(val4, polSourceObservation_B.LastUpdateContactTVItemLanguage);
               int val5 = 45;
               polSourceObservation_B.PolSourceObservationID = val5;
               Assert.AreEqual(val5, polSourceObservation_B.PolSourceObservationID);
               int val6 = 45;
               polSourceObservation_B.PolSourceSiteID = val6;
               Assert.AreEqual(val6, polSourceObservation_B.PolSourceSiteID);
               DateTime val7 = new DateTime(2010, 3, 4);
               polSourceObservation_B.ObservationDate_Local = val7;
               Assert.AreEqual(val7, polSourceObservation_B.ObservationDate_Local);
               int val8 = 45;
               polSourceObservation_B.ContactTVItemID = val8;
               Assert.AreEqual(val8, polSourceObservation_B.ContactTVItemID);
               string val9 = "Some text";
               polSourceObservation_B.Observation_ToBeDeleted = val9;
               Assert.AreEqual(val9, polSourceObservation_B.Observation_ToBeDeleted);
               DateTime val10 = new DateTime(2010, 3, 4);
               polSourceObservation_B.LastUpdateDate_UTC = val10;
               Assert.AreEqual(val10, polSourceObservation_B.LastUpdateDate_UTC);
               int val11 = 45;
               polSourceObservation_B.LastUpdateContactTVItemID = val11;
               Assert.AreEqual(val11, polSourceObservation_B.LastUpdateContactTVItemID);
               bool val12 = true;
               polSourceObservation_B.HasErrors = val12;
               Assert.AreEqual(val12, polSourceObservation_B.HasErrors);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               polSourceObservation_B.ValidationResults = val39;
               Assert.AreEqual(val39, polSourceObservation_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
