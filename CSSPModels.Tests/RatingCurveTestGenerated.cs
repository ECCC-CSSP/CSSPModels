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
    public partial class RatingCurveTest
    {
        [TestMethod]
        public void RatingCurve_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "RatingCurveID", "HydrometricSiteID", "RatingCurveNumber", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

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
        public void RatingCurve_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "HydrometricSite",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "RatingCurveValues",  }.OrderBy(c => c).ToList();

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
        public void RatingCurve_Has_ValidationResults_OK()
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
               Assert.IsNotNull(ModelsRes.RatingCurveRatingCurveValues);
               Assert.IsNotNull(ModelsRes.RatingCurveHydrometricSite);
        }
    }
}
