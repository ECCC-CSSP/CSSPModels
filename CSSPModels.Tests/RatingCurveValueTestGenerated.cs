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
    public partial class RatingCurveValueTest : SetupData
    {
        [TestMethod]
        public void RatingCurveValue_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "RatingCurveValueID", "RatingCurveID", "StageValue_m", "DischargeValue_m3_s", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.RatingCurveValue).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(RatingCurveValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RatingCurveValue_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "RatingCurve",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurveValue).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RatingCurveValue).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void RatingCurveValue_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(RatingCurveValue).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void RatingCurveValue_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.RatingCurveValueRatingCurveValueID);
               Assert.IsNotNull(ModelsRes.RatingCurveValueRatingCurveID);
               Assert.IsNotNull(ModelsRes.RatingCurveValueStageValue_m);
               Assert.IsNotNull(ModelsRes.RatingCurveValueDischargeValue_m3_s);
               Assert.IsNotNull(ModelsRes.RatingCurveValueLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.RatingCurveValueLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.RatingCurveValueRatingCurve);
        }
        [TestMethod]
        public void RatingCurveValue_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               ratingCurveValue.RatingCurveValueID = val1;
               Assert.AreEqual(val1, ratingCurveValue.RatingCurveValueID);
               int val2 = 45;
               ratingCurveValue.RatingCurveID = val2;
               Assert.AreEqual(val2, ratingCurveValue.RatingCurveID);
               double val3 = 87.9D;
               ratingCurveValue.StageValue_m = val3;
               Assert.AreEqual(val3, ratingCurveValue.StageValue_m);
               double val4 = 87.9D;
               ratingCurveValue.DischargeValue_m3_s = val4;
               Assert.AreEqual(val4, ratingCurveValue.DischargeValue_m3_s);
               DateTime val5 = new DateTime(2010, 3, 4);
               ratingCurveValue.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, ratingCurveValue.LastUpdateDate_UTC);
               int val6 = 45;
               ratingCurveValue.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, ratingCurveValue.LastUpdateContactTVItemID);
               RatingCurve val15 = new RatingCurve();
               ratingCurveValue.RatingCurve = val15;
               Assert.AreEqual(val15, ratingCurveValue.RatingCurve);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>().AsEnumerable();
               ratingCurveValue.ValidationResults = val24;
               Assert.AreEqual(val24, ratingCurveValue.ValidationResults);
        }
    }
}
