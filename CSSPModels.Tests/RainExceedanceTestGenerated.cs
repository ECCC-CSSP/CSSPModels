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
    public partial class RainExceedanceTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private RainExceedance rainExceedance { get; set; }
        #endregion Properties

        #region Constructors
        public RainExceedanceTest()
        {
            rainExceedance = new RainExceedance();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void RainExceedance_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "RainExceedanceID", "YearRound", "StartDate_Local", "EndDate_Local", "RainMaximum_mm", "RainExtreme_mm", "DaysPriorToStart", "RepeatEveryYear", "ProvinceTVItemIDs", "SubsectorTVItemIDs", "ClimateSiteTVItemIDs", "EmailDistributionListIDs", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "RainExceedanceWeb", "RainExceedanceReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.RainExceedance).GetProperties().OrderBy(c => c.Name))
            {
                if (!propertyInfo.GetGetMethod().IsVirtual
                    && propertyInfo.Name != "ValidationResults"
                    && !propertyInfo.CustomAttributes.Where(c => c.AttributeType.Name.Contains("NotMappedAttribute")).Any())
                {
                    Assert.AreEqual(propNameList[index], propertyInfo.Name);
                    index += 1;
                }
            }

            Assert.AreEqual(propNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RainExceedance).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                foreach (CustomAttributeData customAttributeData in propertyInfo.CustomAttributes)
                {
                    if (customAttributeData.AttributeType.Name == "NotMappedAttribute")
                    {
                        Assert.AreEqual(propertyInfo.Name, propNameNotMappedList[index]);
                        index += 1;
                    }
                }
            }

            Assert.AreEqual(propNameNotMappedList.Count, index);

        }
        [TestMethod]
        public void RainExceedance_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RainExceedance).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(RainExceedance).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
            {
                if (propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameCollectionList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameCollectionList.Count, index);

        }
        [TestMethod]
        public void RainExceedance_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(RainExceedance).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void RainExceedance_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceRainExceedanceID);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceYearRound);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceStartDate_Local);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceEndDate_Local);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceRainMaximum_mm);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceRainExtreme_mm);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceDaysPriorToStart);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceRepeatEveryYear);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceProvinceTVItemIDs);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceSubsectorTVItemIDs);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceClimateSiteTVItemIDs);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceEmailDistributionListIDs);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.RainExceedanceHasErrors);
        }
        [TestMethod]
        public void RainExceedance_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               rainExceedance.RainExceedanceID = val1;
               Assert.AreEqual(val1, rainExceedance.RainExceedanceID);
               bool val2 = true;
               rainExceedance.YearRound = val2;
               Assert.AreEqual(val2, rainExceedance.YearRound);
               DateTime val3 = new DateTime(2010, 3, 4);
               rainExceedance.StartDate_Local = val3;
               Assert.AreEqual(val3, rainExceedance.StartDate_Local);
               DateTime val4 = new DateTime(2010, 3, 4);
               rainExceedance.EndDate_Local = val4;
               Assert.AreEqual(val4, rainExceedance.EndDate_Local);
               double val5 = 87.9D;
               rainExceedance.RainMaximum_mm = val5;
               Assert.AreEqual(val5, rainExceedance.RainMaximum_mm);
               double val6 = 87.9D;
               rainExceedance.RainExtreme_mm = val6;
               Assert.AreEqual(val6, rainExceedance.RainExtreme_mm);
               int val7 = 45;
               rainExceedance.DaysPriorToStart = val7;
               Assert.AreEqual(val7, rainExceedance.DaysPriorToStart);
               bool val8 = true;
               rainExceedance.RepeatEveryYear = val8;
               Assert.AreEqual(val8, rainExceedance.RepeatEveryYear);
               string val9 = "Some text";
               rainExceedance.ProvinceTVItemIDs = val9;
               Assert.AreEqual(val9, rainExceedance.ProvinceTVItemIDs);
               string val10 = "Some text";
               rainExceedance.SubsectorTVItemIDs = val10;
               Assert.AreEqual(val10, rainExceedance.SubsectorTVItemIDs);
               string val11 = "Some text";
               rainExceedance.ClimateSiteTVItemIDs = val11;
               Assert.AreEqual(val11, rainExceedance.ClimateSiteTVItemIDs);
               string val12 = "Some text";
               rainExceedance.EmailDistributionListIDs = val12;
               Assert.AreEqual(val12, rainExceedance.EmailDistributionListIDs);
               DateTime val13 = new DateTime(2010, 3, 4);
               rainExceedance.LastUpdateDate_UTC = val13;
               Assert.AreEqual(val13, rainExceedance.LastUpdateDate_UTC);
               int val14 = 45;
               rainExceedance.LastUpdateContactTVItemID = val14;
               Assert.AreEqual(val14, rainExceedance.LastUpdateContactTVItemID);
               bool val15 = true;
               rainExceedance.HasErrors = val15;
               Assert.AreEqual(val15, rainExceedance.HasErrors);
               IEnumerable<ValidationResult> val52 = new List<ValidationResult>().AsEnumerable();
               rainExceedance.ValidationResults = val52;
               Assert.AreEqual(val52, rainExceedance.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
