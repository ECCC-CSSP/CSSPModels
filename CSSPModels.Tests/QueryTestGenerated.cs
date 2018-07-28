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
    public partial class QueryTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private Query query { get; set; }
        #endregion Properties

        #region Constructors
        public QueryTest()
        {
            query = new Query();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void Query_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ModelType", "Language", "Lang", "Skip", "Take", "Order", "Where", "EntityQueryDetailType", "EntityQueryType", "OrderList", "WhereInfoList", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(Query).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void Query_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(Query).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void Query_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.QueryModelType);
               Assert.IsNotNull(CSSPModelsRes.QueryLanguage);
               Assert.IsNotNull(CSSPModelsRes.QueryLang);
               Assert.IsNotNull(CSSPModelsRes.QuerySkip);
               Assert.IsNotNull(CSSPModelsRes.QueryTake);
               Assert.IsNotNull(CSSPModelsRes.QueryOrder);
               Assert.IsNotNull(CSSPModelsRes.QueryWhere);
               Assert.IsNotNull(CSSPModelsRes.QueryEntityQueryDetailType);
               Assert.IsNotNull(CSSPModelsRes.QueryEntityQueryType);
               Assert.IsNotNull(CSSPModelsRes.QueryOrderList);
               Assert.IsNotNull(CSSPModelsRes.QueryWhereInfoList);
               Assert.IsNotNull(CSSPModelsRes.QueryHasErrors);
        }
        [TestMethod]
        public void Query_Every_Property_Has_Get_Set_Test()
        {
               Type val1 = typeof(Query); 
               query.ModelType = val1;
               Assert.AreEqual(val1, query.ModelType);
               LanguageEnum val2 = (LanguageEnum)3;
               query.Language = val2;
               Assert.AreEqual(val2, query.Language);
               string val3 = "Some text";
               query.Lang = val3;
               Assert.AreEqual(val3, query.Lang);
               int val4 = 45;
               query.Skip = val4;
               Assert.AreEqual(val4, query.Skip);
               int val5 = 45;
               query.Take = val5;
               Assert.AreEqual(val5, query.Take);
               string val6 = "Some text";
               query.Order = val6;
               Assert.AreEqual(val6, query.Order);
               string val7 = "Some text";
               query.Where = val7;
               Assert.AreEqual(val7, query.Where);
               EntityQueryDetailTypeEnum val8 = (EntityQueryDetailTypeEnum)3;
               query.EntityQueryDetailType = val8;
               Assert.AreEqual(val8, query.EntityQueryDetailType);
               EntityQueryTypeEnum val9 = (EntityQueryTypeEnum)3;
               query.EntityQueryType = val9;
               Assert.AreEqual(val9, query.EntityQueryType);
               bool val12 = true;
               query.HasErrors = val12;
               Assert.AreEqual(val12, query.HasErrors);
               List<String> val23 = new List<String>();
               query.OrderList = val23;
               Assert.AreEqual(val23, query.OrderList);
               List<WhereInfo> val24 = new List<WhereInfo>();
               query.WhereInfoList = val24;
               Assert.AreEqual(val24, query.WhereInfoList);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>().AsEnumerable();
               query.ValidationResults = val39;
               Assert.AreEqual(val39, query.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
