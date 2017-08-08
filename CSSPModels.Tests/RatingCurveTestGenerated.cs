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
    public partial class RatingCurveTest : SetupData
    {
        [TestMethod]
        public void RatingCurve_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "RatingCurveID", "HydrometricSiteID", "RatingCurveNumber", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.RatingCurve).GetProperties().OrderBy(c => c.Name))
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
        public void RatingCurve_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(RatingCurve).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void RatingCurve_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.RatingCurveRatingCurveID);
               Assert.IsNotNull(ModelsRes.RatingCurveHydrometricSiteID);
               Assert.IsNotNull(ModelsRes.RatingCurveRatingCurveNumber);
               Assert.IsNotNull(ModelsRes.RatingCurveLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.RatingCurveLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.RatingCurveLastUpdateContactTVText);
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
               string val6 = "Some text";
               ratingCurve.LastUpdateContactTVText = val6;
               Assert.AreEqual(val6, ratingCurve.LastUpdateContactTVText);
               IEnumerable<ValidationResult> val21 = new List<ValidationResult>().AsEnumerable();
               ratingCurve.ValidationResults = val21;
               Assert.AreEqual(val21, ratingCurve.ValidationResults);
        }
    }
}
