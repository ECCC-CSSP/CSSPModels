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
            List<string> propNameList = new List<string>() { "CSSPWQInputType", "Name", "TVItemID", "sidList", "MWQMSiteList", "MWQMSiteTVItemIDList", "DailyDuplicateMWQMSiteList", "DailyDuplicateMWQMSiteTVItemIDList", "InfrastructureList", "InfrastructureTVItemIDList",  }.OrderBy(c => c).ToList();
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
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamsidList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamMWQMSiteList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamMWQMSiteTVItemIDList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamDailyDuplicateMWQMSiteList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamDailyDuplicateMWQMSiteTVItemIDList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamInfrastructureList);
               Assert.IsNotNull(ModelsRes.CSSPWQInputParamInfrastructureTVItemIDList);
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
               List<String> val15 = new List<String>();
               cSSPWQInputParam.sidList = val15;
               Assert.AreEqual(val15, cSSPWQInputParam.sidList);
               List<String> val16 = new List<String>();
               cSSPWQInputParam.MWQMSiteList = val16;
               Assert.AreEqual(val16, cSSPWQInputParam.MWQMSiteList);
               List<Int32> val17 = new List<Int32>();
               cSSPWQInputParam.MWQMSiteTVItemIDList = val17;
               Assert.AreEqual(val17, cSSPWQInputParam.MWQMSiteTVItemIDList);
               List<String> val18 = new List<String>();
               cSSPWQInputParam.DailyDuplicateMWQMSiteList = val18;
               Assert.AreEqual(val18, cSSPWQInputParam.DailyDuplicateMWQMSiteList);
               List<Int32> val19 = new List<Int32>();
               cSSPWQInputParam.DailyDuplicateMWQMSiteTVItemIDList = val19;
               Assert.AreEqual(val19, cSSPWQInputParam.DailyDuplicateMWQMSiteTVItemIDList);
               List<String> val20 = new List<String>();
               cSSPWQInputParam.InfrastructureList = val20;
               Assert.AreEqual(val20, cSSPWQInputParam.InfrastructureList);
               List<Int32> val21 = new List<Int32>();
               cSSPWQInputParam.InfrastructureTVItemIDList = val21;
               Assert.AreEqual(val21, cSSPWQInputParam.InfrastructureTVItemIDList);
               IEnumerable<ValidationResult> val33 = new List<ValidationResult>().AsEnumerable();
               cSSPWQInputParam.ValidationResults = val33;
               Assert.AreEqual(val33, cSSPWQInputParam.ValidationResults);
        }
    }
}
