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
    public partial class TVLocationTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private TVLocation tVLocation { get; set; }
        #endregion Properties

        #region Constructors
        public TVLocationTest()
        {
            tVLocation = new TVLocation();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void TVLocation_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "Error", "TVItemID", "TVText", "TVType", "SubTVType", "TVTypeText", "SubTVTypeText", "MapObjList", "HasErrors",  }.OrderBy(c => c).ToList();
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
               Assert.IsNotNull(CSSPModelsRes.TVLocationError);
               Assert.IsNotNull(CSSPModelsRes.TVLocationTVItemID);
               Assert.IsNotNull(CSSPModelsRes.TVLocationTVText);
               Assert.IsNotNull(CSSPModelsRes.TVLocationTVType);
               Assert.IsNotNull(CSSPModelsRes.TVLocationSubTVType);
               Assert.IsNotNull(CSSPModelsRes.TVLocationTVTypeText);
               Assert.IsNotNull(CSSPModelsRes.TVLocationSubTVTypeText);
               Assert.IsNotNull(CSSPModelsRes.TVLocationMapObjList);
               Assert.IsNotNull(CSSPModelsRes.TVLocationHasErrors);
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
               List<MapObj> val8 = new List<MapObj>() { new MapObj(), new MapObj() };
               tVLocation.MapObjList = val8;
               Assert.AreEqual(val8, tVLocation.MapObjList);
               bool val9 = true;
               tVLocation.HasErrors = val9;
               Assert.AreEqual(val9, tVLocation.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               tVLocation.ValidationResults = val30;
               Assert.AreEqual(val30, tVLocation.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
