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
    public partial class BoxModelResultTest
    {
        [TestMethod]
        public void BoxModelResult_Properties_OK()
        {
            List<string> propNameList = new List<string>() { "BoxModelResultID", "BoxModelID", "BoxModelResultType", "Volume_m3", "Surface_m2", "Radius_m", "LeftSideDiameterLineAngle_deg", "CircleCenterLatitude", "CircleCenterLongitude", "FixLength", "FixWidth", "RectLength_m", "RectWidth_m", "LeftSideLineAngle_deg", "LeftSideLineStartLatitude", "LeftSideLineStartLongitude", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.BoxModelResult).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(BoxModelResult).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void BoxModelResult_Navigation_OK()
        {
            List<string> foreignNameList = new List<string>() { "BoxModel",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(BoxModelResult).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(BoxModelResult).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void BoxModelResult_Has_ValidationResults_OK()
        {
             Assert.IsTrue(typeof(BoxModelResult).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void BoxModelResult_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.BoxModelResultBoxModelResultID);
               Assert.IsNotNull(ModelsRes.BoxModelResultBoxModelID);
               Assert.IsNotNull(ModelsRes.BoxModelResultBoxModelResultType);
               Assert.IsNotNull(ModelsRes.BoxModelResultVolume_m3);
               Assert.IsNotNull(ModelsRes.BoxModelResultSurface_m2);
               Assert.IsNotNull(ModelsRes.BoxModelResultRadius_m);
               Assert.IsNotNull(ModelsRes.BoxModelResultLeftSideDiameterLineAngle_deg);
               Assert.IsNotNull(ModelsRes.BoxModelResultCircleCenterLatitude);
               Assert.IsNotNull(ModelsRes.BoxModelResultCircleCenterLongitude);
               Assert.IsNotNull(ModelsRes.BoxModelResultFixLength);
               Assert.IsNotNull(ModelsRes.BoxModelResultFixWidth);
               Assert.IsNotNull(ModelsRes.BoxModelResultRectLength_m);
               Assert.IsNotNull(ModelsRes.BoxModelResultRectWidth_m);
               Assert.IsNotNull(ModelsRes.BoxModelResultLeftSideLineAngle_deg);
               Assert.IsNotNull(ModelsRes.BoxModelResultLeftSideLineStartLatitude);
               Assert.IsNotNull(ModelsRes.BoxModelResultLeftSideLineStartLongitude);
               Assert.IsNotNull(ModelsRes.BoxModelResultLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.BoxModelResultLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.BoxModelResultBoxModel);
        }
    }
}
