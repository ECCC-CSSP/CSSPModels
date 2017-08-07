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
    public partial class TVLocationTest : SetupData
    {
        [TestMethod]
        public void TVLocation_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "TVItemID", "TVText", "TVType", "SubTVType", "TVTypeText", "SubTVTypeText", "MapObjList",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVLocation).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void TVLocation_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVLocation).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVLocation_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVLocationError);
               Assert.IsNotNull(ModelsRes.TVLocationTVItemID);
               Assert.IsNotNull(ModelsRes.TVLocationTVText);
               Assert.IsNotNull(ModelsRes.TVLocationTVType);
               Assert.IsNotNull(ModelsRes.TVLocationSubTVType);
               Assert.IsNotNull(ModelsRes.TVLocationTVTypeText);
               Assert.IsNotNull(ModelsRes.TVLocationSubTVTypeText);
               Assert.IsNotNull(ModelsRes.TVLocationMapObjList);
        }
        [TestMethod]
        public void TVLocation_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               tVLocation.Error = val1;
               Assert.AreEqual(val1, tVLocation.Error);
               int val2 = 45;
               tVLocation.TVItemID = val2;
               Assert.AreEqual(val2, tVLocation.TVItemID);
               string val3 = "Some text";
               tVLocation.TVText = val3;
               Assert.AreEqual(val3, tVLocation.TVText);
               TVTypeEnum val4 = (TVTypeEnum)3;
               tVLocation.TVType = val4;
               Assert.AreEqual(val4, tVLocation.TVType);
               TVTypeEnum val5 = (TVTypeEnum)3;
               tVLocation.SubTVType = val5;
               Assert.AreEqual(val5, tVLocation.SubTVType);
               string val6 = "Some text";
               tVLocation.TVTypeText = val6;
               Assert.AreEqual(val6, tVLocation.TVTypeText);
               string val7 = "Some text";
               tVLocation.SubTVTypeText = val7;
               Assert.AreEqual(val7, tVLocation.SubTVTypeText);
               List<MapObj> val17 = new List<MapObj>();
               tVLocation.MapObjList = val17;
               Assert.AreEqual(val17, tVLocation.MapObjList);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>().AsEnumerable();
               tVLocation.ValidationResults = val27;
               Assert.AreEqual(val27, tVLocation.ValidationResults);
        }
    }
}
