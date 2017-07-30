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
    public partial class BoxModelResultTest : SetupData
    {
        [TestMethod]
        public void BoxModelResult_Properties_Test()
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
        public void BoxModelResult_Navigation_Test()
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
        public void BoxModelResult_Has_ValidationResults_Test()
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
        [TestMethod]
        public void BoxModelResult_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               boxModelResult.BoxModelResultID = val1;
               Assert.AreEqual(val1, boxModelResult.BoxModelResultID);
               int val2 = 45;
               boxModelResult.BoxModelID = val2;
               Assert.AreEqual(val2, boxModelResult.BoxModelID);
               BoxModelResultTypeEnum val3 = (BoxModelResultTypeEnum)3;
               boxModelResult.BoxModelResultType = val3;
               Assert.AreEqual(val3, boxModelResult.BoxModelResultType);
               double val4 = 87.9D;
               boxModelResult.Volume_m3 = val4;
               Assert.AreEqual(val4, boxModelResult.Volume_m3);
               double val5 = 87.9D;
               boxModelResult.Surface_m2 = val5;
               Assert.AreEqual(val5, boxModelResult.Surface_m2);
               double val6 = 87.9D;
               boxModelResult.Radius_m = val6;
               Assert.AreEqual(val6, boxModelResult.Radius_m);
               double val7 = 87.9D;
               boxModelResult.LeftSideDiameterLineAngle_deg = val7;
               Assert.AreEqual(val7, boxModelResult.LeftSideDiameterLineAngle_deg);
               double val8 = 87.9D;
               boxModelResult.CircleCenterLatitude = val8;
               Assert.AreEqual(val8, boxModelResult.CircleCenterLatitude);
               double val9 = 87.9D;
               boxModelResult.CircleCenterLongitude = val9;
               Assert.AreEqual(val9, boxModelResult.CircleCenterLongitude);
               bool val10 = true;
               boxModelResult.FixLength = val10;
               Assert.AreEqual(val10, boxModelResult.FixLength);
               bool val11 = true;
               boxModelResult.FixWidth = val11;
               Assert.AreEqual(val11, boxModelResult.FixWidth);
               double val12 = 87.9D;
               boxModelResult.RectLength_m = val12;
               Assert.AreEqual(val12, boxModelResult.RectLength_m);
               double val13 = 87.9D;
               boxModelResult.RectWidth_m = val13;
               Assert.AreEqual(val13, boxModelResult.RectWidth_m);
               double val14 = 87.9D;
               boxModelResult.LeftSideLineAngle_deg = val14;
               Assert.AreEqual(val14, boxModelResult.LeftSideLineAngle_deg);
               double val15 = 87.9D;
               boxModelResult.LeftSideLineStartLatitude = val15;
               Assert.AreEqual(val15, boxModelResult.LeftSideLineStartLatitude);
               double val16 = 87.9D;
               boxModelResult.LeftSideLineStartLongitude = val16;
               Assert.AreEqual(val16, boxModelResult.LeftSideLineStartLongitude);
               DateTime val17 = new DateTime(2010, 3, 4);
               boxModelResult.LastUpdateDate_UTC = val17;
               Assert.AreEqual(val17, boxModelResult.LastUpdateDate_UTC);
               int val18 = 45;
               boxModelResult.LastUpdateContactTVItemID = val18;
               Assert.AreEqual(val18, boxModelResult.LastUpdateContactTVItemID);
               BoxModel val39 = new BoxModel();
               boxModelResult.BoxModel = val39;
               Assert.AreEqual(val39, boxModelResult.BoxModel);
               IEnumerable<ValidationResult> val60 = new List<ValidationResult>().AsEnumerable();
               boxModelResult.ValidationResults = val60;
               Assert.AreEqual(val60, boxModelResult.ValidationResults);
        }
    }
}
