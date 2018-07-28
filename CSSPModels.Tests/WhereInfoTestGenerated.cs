/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated on 2018 July 28 01:58
 * by Charles on CHARLES-PC machine
 *
 */ 
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
    [TestClass]
    public partial class WhereInfoTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private WhereInfo whereInfo { get; set; }
        #endregion Properties

        #region Constructors
        public WhereInfoTest()
        {
            whereInfo = new WhereInfo();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void WhereInfo_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "PropertyName", "PropertyType", "WhereOperator", "Value", "ValueInt", "ValueDouble", "ValueBool", "ValueDateTime", "ValueEnumText", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(WhereInfo).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void WhereInfo_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(WhereInfo).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void WhereInfo_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.WhereInfoPropertyName);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoPropertyType);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoWhereOperator);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoValue);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoValueInt);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoValueDouble);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoValueBool);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoValueDateTime);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoValueEnumText);
               Assert.IsNotNull(CSSPModelsRes.WhereInfoHasErrors);
        }
        [TestMethod]
        public void WhereInfo_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               whereInfo.PropertyName = val1;
               Assert.AreEqual(val1, whereInfo.PropertyName);
               PropertyTypeEnum val2 = (PropertyTypeEnum)3;
               whereInfo.PropertyType = val2;
               Assert.AreEqual(val2, whereInfo.PropertyType);
               WhereOperatorEnum val3 = (WhereOperatorEnum)3;
               whereInfo.WhereOperator = val3;
               Assert.AreEqual(val3, whereInfo.WhereOperator);
               string val4 = "Some text";
               whereInfo.Value = val4;
               Assert.AreEqual(val4, whereInfo.Value);
               int val5 = 45;
               whereInfo.ValueInt = val5;
               Assert.AreEqual(val5, whereInfo.ValueInt);
               double val6 = 87.9D;
               whereInfo.ValueDouble = val6;
               Assert.AreEqual(val6, whereInfo.ValueDouble);
               bool val7 = true;
               whereInfo.ValueBool = val7;
               Assert.AreEqual(val7, whereInfo.ValueBool);
               DateTime val8 = new DateTime(2010, 3, 4);
               whereInfo.ValueDateTime = val8;
               Assert.AreEqual(val8, whereInfo.ValueDateTime);
               string val9 = "Some text";
               whereInfo.ValueEnumText = val9;
               Assert.AreEqual(val9, whereInfo.ValueEnumText);
               bool val10 = true;
               whereInfo.HasErrors = val10;
               Assert.AreEqual(val10, whereInfo.HasErrors);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               whereInfo.ValidationResults = val33;
               Assert.AreEqual(val33, whereInfo.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
