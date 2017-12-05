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
    public partial class MWQMAnalysisReportParameterWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMAnalysisReportParameterWeb mWQMAnalysisReportParameterWeb { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMAnalysisReportParameterWebTest()
        {
            mWQMAnalysisReportParameterWeb = new MWQMAnalysisReportParameterWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void MWQMAnalysisReportParameterWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ExcelTVFileTVText", "CommandText", "LastUpdateContactTVText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMAnalysisReportParameterWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void MWQMAnalysisReportParameterWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMAnalysisReportParameterWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMAnalysisReportParameterWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterWebExcelTVFileTVText);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterWebCommandText);
               Assert.IsNotNull(CSSPModelsRes.MWQMAnalysisReportParameterWebLastUpdateContactTVText);
        }
        [TestMethod]
        public void MWQMAnalysisReportParameterWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMAnalysisReportParameterWeb.ExcelTVFileTVText = val1;
               Assert.AreEqual(val1, mWQMAnalysisReportParameterWeb.ExcelTVFileTVText);
               string val2 = "Some text";
               mWQMAnalysisReportParameterWeb.CommandText = val2;
               Assert.AreEqual(val2, mWQMAnalysisReportParameterWeb.CommandText);
               string val3 = "Some text";
               mWQMAnalysisReportParameterWeb.LastUpdateContactTVText = val3;
               Assert.AreEqual(val3, mWQMAnalysisReportParameterWeb.LastUpdateContactTVText);
        }
        #endregion Tests
    }
}
