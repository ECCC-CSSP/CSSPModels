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
    public partial class MWQMRunWebTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MWQMRunWeb mWQMRunWeb { get; set; }
        #endregion Properties

        #region Constructors
        public MWQMRunWebTest()
        {
            mWQMRunWeb = new MWQMRunWeb();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void MWQMRunWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "SubsectorTVText", "MWQMRunTVText", "LabSampleApprovalContactTVText", "LastUpdateContactTVText", "RunSampleTypeText", "SeaStateAtStart_BeaufortScaleText", "SeaStateAtEnd_BeaufortScaleText", "AnalyzeMethodText", "SampleMatrixText", "LaboratoryText", "SampleStatusText", "Tide_StartText", "Tide_EndText",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MWQMRunWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                Assert.AreEqual(propertyInfo.Name, propNameList[index]);
                index += 1;
            }

            Assert.AreEqual(propNameList.Count, index);
        }
        [TestMethod]
        public void MWQMRunWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MWQMRunWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MWQMRunWeb_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebSubsectorTVText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebMWQMRunTVText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebLabSampleApprovalContactTVText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebLastUpdateContactTVText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebRunSampleTypeText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebSeaStateAtStart_BeaufortScaleText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebSeaStateAtEnd_BeaufortScaleText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebAnalyzeMethodText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebSampleMatrixText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebLaboratoryText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebSampleStatusText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebTide_StartText);
               Assert.IsNotNull(CSSPModelsRes.MWQMRunWebTide_EndText);
        }
        [TestMethod]
        public void MWQMRunWeb_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mWQMRunWeb.SubsectorTVText = val1;
               Assert.AreEqual(val1, mWQMRunWeb.SubsectorTVText);
               string val2 = "Some text";
               mWQMRunWeb.MWQMRunTVText = val2;
               Assert.AreEqual(val2, mWQMRunWeb.MWQMRunTVText);
               string val3 = "Some text";
               mWQMRunWeb.LabSampleApprovalContactTVText = val3;
               Assert.AreEqual(val3, mWQMRunWeb.LabSampleApprovalContactTVText);
               string val4 = "Some text";
               mWQMRunWeb.LastUpdateContactTVText = val4;
               Assert.AreEqual(val4, mWQMRunWeb.LastUpdateContactTVText);
               string val5 = "Some text";
               mWQMRunWeb.RunSampleTypeText = val5;
               Assert.AreEqual(val5, mWQMRunWeb.RunSampleTypeText);
               string val6 = "Some text";
               mWQMRunWeb.SeaStateAtStart_BeaufortScaleText = val6;
               Assert.AreEqual(val6, mWQMRunWeb.SeaStateAtStart_BeaufortScaleText);
               string val7 = "Some text";
               mWQMRunWeb.SeaStateAtEnd_BeaufortScaleText = val7;
               Assert.AreEqual(val7, mWQMRunWeb.SeaStateAtEnd_BeaufortScaleText);
               string val8 = "Some text";
               mWQMRunWeb.AnalyzeMethodText = val8;
               Assert.AreEqual(val8, mWQMRunWeb.AnalyzeMethodText);
               string val9 = "Some text";
               mWQMRunWeb.SampleMatrixText = val9;
               Assert.AreEqual(val9, mWQMRunWeb.SampleMatrixText);
               string val10 = "Some text";
               mWQMRunWeb.LaboratoryText = val10;
               Assert.AreEqual(val10, mWQMRunWeb.LaboratoryText);
               string val11 = "Some text";
               mWQMRunWeb.SampleStatusText = val11;
               Assert.AreEqual(val11, mWQMRunWeb.SampleStatusText);
               string val12 = "Some text";
               mWQMRunWeb.Tide_StartText = val12;
               Assert.AreEqual(val12, mWQMRunWeb.Tide_StartText);
               string val13 = "Some text";
               mWQMRunWeb.Tide_EndText = val13;
               Assert.AreEqual(val13, mWQMRunWeb.Tide_EndText);
        }
        #endregion Tests
    }
}
