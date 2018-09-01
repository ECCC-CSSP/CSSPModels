/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    public partial class RatingCurveTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private RatingCurve ratingCurve { get; set; }
        private RatingCurve_A ratingCurve_A { get; set; }
        private RatingCurve_B ratingCurve_B { get; set; }
        #endregion Properties

        #region Constructors
        public RatingCurveTest()
        {
            ratingCurve = new RatingCurve();
            ratingCurve_A = new RatingCurve_A();
            ratingCurve_B = new RatingCurve_B();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void RatingCurve_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "RatingCurveID", "HydrometricSiteID", "RatingCurveNumber", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RatingCurve_A_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "RatingCurveID", "HydrometricSiteID", "RatingCurveNumber", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve_A).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RatingCurve_B_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "RatingCurveReportTest", "LastUpdateContactTVItemLanguage", "RatingCurveID", "HydrometricSiteID", "RatingCurveNumber", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve_B).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RatingCurve_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RatingCurve_A_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve_A).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve_A).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RatingCurve_B_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve_B).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurve_B).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RatingCurve_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(RatingCurve).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void RatingCurve_A_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(RatingCurve_A).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void RatingCurve_B_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(RatingCurve_B).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void RatingCurve_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               ratingCurve.RatingCurveID = val1;
               Assert.AreEqual(val1, ratingCurve.RatingCurveID);
               int val2 = 45;
               ratingCurve.HydrometricSiteID = val2;
               Assert.AreEqual(val2, ratingCurve.HydrometricSiteID);
               string val3 = "Some text";
               ratingCurve.RatingCurveNumber = val3;
               Assert.AreEqual(val3, ratingCurve.RatingCurveNumber);
               DateTime val4 = new DateTime(2010, 3, 4);
               ratingCurve.LastUpdateDate_UTC = val4;
               Assert.AreEqual(val4, ratingCurve.LastUpdateDate_UTC);
               int val5 = 45;
               ratingCurve.LastUpdateContactTVItemID = val5;
               Assert.AreEqual(val5, ratingCurve.LastUpdateContactTVItemID);
               bool val6 = true;
               ratingCurve.HasErrors = val6;
               Assert.AreEqual(val6, ratingCurve.HasErrors);
               IEnumerable<ValidationResult> val21 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               ratingCurve.ValidationResults = val21;
               Assert.AreEqual(val21, ratingCurve.ValidationResults);
        }
        [TestMethod]
        public void RatingCurve_A_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               ratingCurve_A.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, ratingCurve_A.LastUpdateContactTVItemLanguage);
               int val2 = 45;
               ratingCurve_A.RatingCurveID = val2;
               Assert.AreEqual(val2, ratingCurve_A.RatingCurveID);
               int val3 = 45;
               ratingCurve_A.HydrometricSiteID = val3;
               Assert.AreEqual(val3, ratingCurve_A.HydrometricSiteID);
               string val4 = "Some text";
               ratingCurve_A.RatingCurveNumber = val4;
               Assert.AreEqual(val4, ratingCurve_A.RatingCurveNumber);
               DateTime val5 = new DateTime(2010, 3, 4);
               ratingCurve_A.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, ratingCurve_A.LastUpdateDate_UTC);
               int val6 = 45;
               ratingCurve_A.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, ratingCurve_A.LastUpdateContactTVItemID);
               bool val7 = true;
               ratingCurve_A.HasErrors = val7;
               Assert.AreEqual(val7, ratingCurve_A.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               ratingCurve_A.ValidationResults = val24;
               Assert.AreEqual(val24, ratingCurve_A.ValidationResults);
        }
        [TestMethod]
        public void RatingCurve_B_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               ratingCurve_B.RatingCurveReportTest = val1;
               Assert.AreEqual(val1, ratingCurve_B.RatingCurveReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               ratingCurve_B.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, ratingCurve_B.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               ratingCurve_B.RatingCurveID = val3;
               Assert.AreEqual(val3, ratingCurve_B.RatingCurveID);
               int val4 = 45;
               ratingCurve_B.HydrometricSiteID = val4;
               Assert.AreEqual(val4, ratingCurve_B.HydrometricSiteID);
               string val5 = "Some text";
               ratingCurve_B.RatingCurveNumber = val5;
               Assert.AreEqual(val5, ratingCurve_B.RatingCurveNumber);
               DateTime val6 = new DateTime(2010, 3, 4);
               ratingCurve_B.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, ratingCurve_B.LastUpdateDate_UTC);
               int val7 = 45;
               ratingCurve_B.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, ratingCurve_B.LastUpdateContactTVItemID);
               bool val8 = true;
               ratingCurve_B.HasErrors = val8;
               Assert.AreEqual(val8, ratingCurve_B.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               ratingCurve_B.ValidationResults = val27;
               Assert.AreEqual(val27, ratingCurve_B.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
