/*
 * Auto generated from the CSSPModelsGenerateCode.proj
 *
 * Do not edit this file.
 *
 * Last generated by Charles LeBlanc
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
            List<string> propNameList = new List<string>() { "PropertyName", "WhereOperator", "Value", "ValueInt", "ValueDouble", "ValueBool", "ValueDateTime", "ValueEnumText", "HasErrors",  }.OrderBy(c => c).ToList();
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
               WhereOperatorEnum val2 = (WhereOperatorEnum)3;
               whereInfo.WhereOperator = val2;
               Assert.AreEqual(val2, whereInfo.WhereOperator);
               string val3 = "Some text";
               whereInfo.Value = val3;
               Assert.AreEqual(val3, whereInfo.Value);
               int val4 = 45;
               whereInfo.ValueInt = val4;
               Assert.AreEqual(val4, whereInfo.ValueInt);
               double val5 = 87.9D;
               whereInfo.ValueDouble = val5;
               Assert.AreEqual(val5, whereInfo.ValueDouble);
               bool val6 = true;
               whereInfo.ValueBool = val6;
               Assert.AreEqual(val6, whereInfo.ValueBool);
               DateTime val7 = new DateTime(2010, 3, 4);
               whereInfo.ValueDateTime = val7;
               Assert.AreEqual(val7, whereInfo.ValueDateTime);
               string val8 = "Some text";
               whereInfo.ValueEnumText = val8;
               Assert.AreEqual(val8, whereInfo.ValueEnumText);
               bool val9 = true;
               whereInfo.HasErrors = val9;
               Assert.AreEqual(val9, whereInfo.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               whereInfo.ValidationResults = val30;
               Assert.AreEqual(val30, whereInfo.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
