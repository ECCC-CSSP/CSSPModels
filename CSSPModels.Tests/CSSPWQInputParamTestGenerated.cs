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
    public partial class CSSPWQInputParamTest : SetupData
    {
        [TestMethod]
        public void CSSPWQInputParam_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "CSSPWQInputType", "Name", "TVItemID", "CSSPWQInputTypeText", "sidList", "MWQMSiteList", "MWQMSiteTVItemIDList", "DailyDuplicateMWQMSiteList", "DailyDuplicateMWQMSiteTVItemIDList", "InfrastructureList", "InfrastructureTVItemIDList", "HasErrors",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPWQInputParam).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void CSSPWQInputParam_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(CSSPWQInputParam).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void CSSPWQInputParam_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamCSSPWQInputType);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamName);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamTVItemID);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamCSSPWQInputTypeText);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamsidList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamMWQMSiteList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamMWQMSiteTVItemIDList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamDailyDuplicateMWQMSiteList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamDailyDuplicateMWQMSiteTVItemIDList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamInfrastructureList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamInfrastructureTVItemIDList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamHasErrors);
        }
        [TestMethod]
        public void CSSPWQInputParam_Every_Property_Has_Get_Set_Test()
        {
               CSSPWQInputTypeEnum val1 = (CSSPWQInputTypeEnum)3;
               cSSPWQInputParam.CSSPWQInputType = val1;
               Assert.AreEqual(val1, cSSPWQInputParam.CSSPWQInputType);
               string val2 = "Some text";
               cSSPWQInputParam.Name = val2;
               Assert.AreEqual(val2, cSSPWQInputParam.Name);
               int val3 = 45;
               cSSPWQInputParam.TVItemID = val3;
               Assert.AreEqual(val3, cSSPWQInputParam.TVItemID);
               string val4 = "Some text";
               cSSPWQInputParam.CSSPWQInputTypeText = val4;
               Assert.AreEqual(val4, cSSPWQInputParam.CSSPWQInputTypeText);
               bool val12 = true;
               cSSPWQInputParam.HasErrors = val12;
               Assert.AreEqual(val12, cSSPWQInputParam.HasErrors);
               List<String> val18 = new List<String>();
               cSSPWQInputParam.sidList = val18;
               Assert.AreEqual(val18, cSSPWQInputParam.sidList);
               List<String> val19 = new List<String>();
               cSSPWQInputParam.MWQMSiteList = val19;
               Assert.AreEqual(val19, cSSPWQInputParam.MWQMSiteList);
               List<Int32> val20 = new List<Int32>();
               cSSPWQInputParam.MWQMSiteTVItemIDList = val20;
               Assert.AreEqual(val20, cSSPWQInputParam.MWQMSiteTVItemIDList);
               List<String> val21 = new List<String>();
               cSSPWQInputParam.DailyDuplicateMWQMSiteList = val21;
               Assert.AreEqual(val21, cSSPWQInputParam.DailyDuplicateMWQMSiteList);
               List<Int32> val22 = new List<Int32>();
               cSSPWQInputParam.DailyDuplicateMWQMSiteTVItemIDList = val22;
               Assert.AreEqual(val22, cSSPWQInputParam.DailyDuplicateMWQMSiteTVItemIDList);
               List<String> val23 = new List<String>();
               cSSPWQInputParam.InfrastructureList = val23;
               Assert.AreEqual(val23, cSSPWQInputParam.InfrastructureList);
               List<Int32> val24 = new List<Int32>();
               cSSPWQInputParam.InfrastructureTVItemIDList = val24;
               Assert.AreEqual(val24, cSSPWQInputParam.InfrastructureTVItemIDList);
               IEnumerable<ValidationResult> val39 = new List<ValidationResult>().AsEnumerable();
               cSSPWQInputParam.ValidationResults = val39;
               Assert.AreEqual(val39, cSSPWQInputParam.ValidationResults);
        }
    }
}
