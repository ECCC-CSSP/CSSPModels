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
    public partial class CSSPWQInputParamTest
    {
        [TestMethod]
        public void CSSPWQInputParam_Properties_OK()
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
        public void CSSPWQInputParam_Has_ValidationResults_OK()
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
    }
}
