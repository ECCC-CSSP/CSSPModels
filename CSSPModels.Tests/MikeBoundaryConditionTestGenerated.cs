/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by Charles on CHARLES-PC machine
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
    public partial class MikeBoundaryConditionTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private MikeBoundaryCondition mikeBoundaryCondition { get; set; }
        private MikeBoundaryConditionWeb mikeBoundaryConditionWeb { get; set; }
        private MikeBoundaryConditionReport mikeBoundaryConditionReport { get; set; }
        #endregion Properties

        #region Constructors
        public MikeBoundaryConditionTest()
        {
            mikeBoundaryCondition = new MikeBoundaryCondition();
            mikeBoundaryConditionWeb = new MikeBoundaryConditionWeb();
            mikeBoundaryConditionReport = new MikeBoundaryConditionReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void MikeBoundaryCondition_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeBoundaryConditionID", "MikeBoundaryConditionTVItemID", "MikeBoundaryConditionCode", "MikeBoundaryConditionName", "MikeBoundaryConditionLength_m", "MikeBoundaryConditionFormat", "MikeBoundaryConditionLevelOrVelocity", "WebTideDataSet", "NumberOfWebTideNodes", "WebTideDataFromStartToEndDate", "TVType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryCondition).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryCondition).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeBoundaryConditionWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeBoundaryConditionTVItemLanguage", "LastUpdateContactTVItemLanguage", "MikeBoundaryConditionLevelOrVelocityText", "WebTideDataSetText", "TVTypeText", "MikeBoundaryConditionID", "MikeBoundaryConditionTVItemID", "MikeBoundaryConditionCode", "MikeBoundaryConditionName", "MikeBoundaryConditionLength_m", "MikeBoundaryConditionFormat", "MikeBoundaryConditionLevelOrVelocity", "WebTideDataSet", "NumberOfWebTideNodes", "WebTideDataFromStartToEndDate", "TVType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryConditionWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryConditionWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeBoundaryConditionReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "MikeBoundaryConditionReportTest", "MikeBoundaryConditionTVItemLanguage", "LastUpdateContactTVItemLanguage", "MikeBoundaryConditionLevelOrVelocityText", "WebTideDataSetText", "TVTypeText", "MikeBoundaryConditionID", "MikeBoundaryConditionTVItemID", "MikeBoundaryConditionCode", "MikeBoundaryConditionName", "MikeBoundaryConditionLength_m", "MikeBoundaryConditionFormat", "MikeBoundaryConditionLevelOrVelocity", "WebTideDataSet", "NumberOfWebTideNodes", "WebTideDataFromStartToEndDate", "TVType", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryConditionReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryConditionReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeBoundaryCondition_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryCondition).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryCondition).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeBoundaryConditionWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryConditionWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryConditionWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeBoundaryConditionReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryConditionReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(MikeBoundaryConditionReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void MikeBoundaryCondition_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeBoundaryCondition).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeBoundaryConditionWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeBoundaryConditionWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeBoundaryConditionReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(MikeBoundaryConditionReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void MikeBoundaryCondition_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               mikeBoundaryCondition.MikeBoundaryConditionID = val1;
               Assert.AreEqual(val1, mikeBoundaryCondition.MikeBoundaryConditionID);
               int val2 = 45;
               mikeBoundaryCondition.MikeBoundaryConditionTVItemID = val2;
               Assert.AreEqual(val2, mikeBoundaryCondition.MikeBoundaryConditionTVItemID);
               string val3 = "Some text";
               mikeBoundaryCondition.MikeBoundaryConditionCode = val3;
               Assert.AreEqual(val3, mikeBoundaryCondition.MikeBoundaryConditionCode);
               string val4 = "Some text";
               mikeBoundaryCondition.MikeBoundaryConditionName = val4;
               Assert.AreEqual(val4, mikeBoundaryCondition.MikeBoundaryConditionName);
               double val5 = 87.9D;
               mikeBoundaryCondition.MikeBoundaryConditionLength_m = val5;
               Assert.AreEqual(val5, mikeBoundaryCondition.MikeBoundaryConditionLength_m);
               string val6 = "Some text";
               mikeBoundaryCondition.MikeBoundaryConditionFormat = val6;
               Assert.AreEqual(val6, mikeBoundaryCondition.MikeBoundaryConditionFormat);
               MikeBoundaryConditionLevelOrVelocityEnum val7 = (MikeBoundaryConditionLevelOrVelocityEnum)3;
               mikeBoundaryCondition.MikeBoundaryConditionLevelOrVelocity = val7;
               Assert.AreEqual(val7, mikeBoundaryCondition.MikeBoundaryConditionLevelOrVelocity);
               WebTideDataSetEnum val8 = (WebTideDataSetEnum)3;
               mikeBoundaryCondition.WebTideDataSet = val8;
               Assert.AreEqual(val8, mikeBoundaryCondition.WebTideDataSet);
               int val9 = 45;
               mikeBoundaryCondition.NumberOfWebTideNodes = val9;
               Assert.AreEqual(val9, mikeBoundaryCondition.NumberOfWebTideNodes);
               string val10 = "Some text";
               mikeBoundaryCondition.WebTideDataFromStartToEndDate = val10;
               Assert.AreEqual(val10, mikeBoundaryCondition.WebTideDataFromStartToEndDate);
               TVTypeEnum val11 = (TVTypeEnum)3;
               mikeBoundaryCondition.TVType = val11;
               Assert.AreEqual(val11, mikeBoundaryCondition.TVType);
               DateTime val12 = new DateTime(2010, 3, 4);
               mikeBoundaryCondition.LastUpdateDate_UTC = val12;
               Assert.AreEqual(val12, mikeBoundaryCondition.LastUpdateDate_UTC);
               int val13 = 45;
               mikeBoundaryCondition.LastUpdateContactTVItemID = val13;
               Assert.AreEqual(val13, mikeBoundaryCondition.LastUpdateContactTVItemID);
               bool val14 = true;
               mikeBoundaryCondition.HasErrors = val14;
               Assert.AreEqual(val14, mikeBoundaryCondition.HasErrors);
               IEnumerable<ValidationResult> val45 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeBoundaryCondition.ValidationResults = val45;
               Assert.AreEqual(val45, mikeBoundaryCondition.ValidationResults);
        }
        [TestMethod]
        public void MikeBoundaryConditionWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               mikeBoundaryConditionWeb.MikeBoundaryConditionTVItemLanguage = val1;
               Assert.AreEqual(val1, mikeBoundaryConditionWeb.MikeBoundaryConditionTVItemLanguage);
               TVItemLanguage val2 = new TVItemLanguage();
               mikeBoundaryConditionWeb.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, mikeBoundaryConditionWeb.LastUpdateContactTVItemLanguage);
               string val3 = "Some text";
               mikeBoundaryConditionWeb.MikeBoundaryConditionLevelOrVelocityText = val3;
               Assert.AreEqual(val3, mikeBoundaryConditionWeb.MikeBoundaryConditionLevelOrVelocityText);
               string val4 = "Some text";
               mikeBoundaryConditionWeb.WebTideDataSetText = val4;
               Assert.AreEqual(val4, mikeBoundaryConditionWeb.WebTideDataSetText);
               string val5 = "Some text";
               mikeBoundaryConditionWeb.TVTypeText = val5;
               Assert.AreEqual(val5, mikeBoundaryConditionWeb.TVTypeText);
               int val6 = 45;
               mikeBoundaryConditionWeb.MikeBoundaryConditionID = val6;
               Assert.AreEqual(val6, mikeBoundaryConditionWeb.MikeBoundaryConditionID);
               int val7 = 45;
               mikeBoundaryConditionWeb.MikeBoundaryConditionTVItemID = val7;
               Assert.AreEqual(val7, mikeBoundaryConditionWeb.MikeBoundaryConditionTVItemID);
               string val8 = "Some text";
               mikeBoundaryConditionWeb.MikeBoundaryConditionCode = val8;
               Assert.AreEqual(val8, mikeBoundaryConditionWeb.MikeBoundaryConditionCode);
               string val9 = "Some text";
               mikeBoundaryConditionWeb.MikeBoundaryConditionName = val9;
               Assert.AreEqual(val9, mikeBoundaryConditionWeb.MikeBoundaryConditionName);
               double val10 = 87.9D;
               mikeBoundaryConditionWeb.MikeBoundaryConditionLength_m = val10;
               Assert.AreEqual(val10, mikeBoundaryConditionWeb.MikeBoundaryConditionLength_m);
               string val11 = "Some text";
               mikeBoundaryConditionWeb.MikeBoundaryConditionFormat = val11;
               Assert.AreEqual(val11, mikeBoundaryConditionWeb.MikeBoundaryConditionFormat);
               MikeBoundaryConditionLevelOrVelocityEnum val12 = (MikeBoundaryConditionLevelOrVelocityEnum)3;
               mikeBoundaryConditionWeb.MikeBoundaryConditionLevelOrVelocity = val12;
               Assert.AreEqual(val12, mikeBoundaryConditionWeb.MikeBoundaryConditionLevelOrVelocity);
               WebTideDataSetEnum val13 = (WebTideDataSetEnum)3;
               mikeBoundaryConditionWeb.WebTideDataSet = val13;
               Assert.AreEqual(val13, mikeBoundaryConditionWeb.WebTideDataSet);
               int val14 = 45;
               mikeBoundaryConditionWeb.NumberOfWebTideNodes = val14;
               Assert.AreEqual(val14, mikeBoundaryConditionWeb.NumberOfWebTideNodes);
               string val15 = "Some text";
               mikeBoundaryConditionWeb.WebTideDataFromStartToEndDate = val15;
               Assert.AreEqual(val15, mikeBoundaryConditionWeb.WebTideDataFromStartToEndDate);
               TVTypeEnum val16 = (TVTypeEnum)3;
               mikeBoundaryConditionWeb.TVType = val16;
               Assert.AreEqual(val16, mikeBoundaryConditionWeb.TVType);
               DateTime val17 = new DateTime(2010, 3, 4);
               mikeBoundaryConditionWeb.LastUpdateDate_UTC = val17;
               Assert.AreEqual(val17, mikeBoundaryConditionWeb.LastUpdateDate_UTC);
               int val18 = 45;
               mikeBoundaryConditionWeb.LastUpdateContactTVItemID = val18;
               Assert.AreEqual(val18, mikeBoundaryConditionWeb.LastUpdateContactTVItemID);
               bool val19 = true;
               mikeBoundaryConditionWeb.HasErrors = val19;
               Assert.AreEqual(val19, mikeBoundaryConditionWeb.HasErrors);
               IEnumerable<ValidationResult> val60 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeBoundaryConditionWeb.ValidationResults = val60;
               Assert.AreEqual(val60, mikeBoundaryConditionWeb.ValidationResults);
        }
        [TestMethod]
        public void MikeBoundaryConditionReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               mikeBoundaryConditionReport.MikeBoundaryConditionReportTest = val1;
               Assert.AreEqual(val1, mikeBoundaryConditionReport.MikeBoundaryConditionReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               mikeBoundaryConditionReport.MikeBoundaryConditionTVItemLanguage = val2;
               Assert.AreEqual(val2, mikeBoundaryConditionReport.MikeBoundaryConditionTVItemLanguage);
               TVItemLanguage val3 = new TVItemLanguage();
               mikeBoundaryConditionReport.LastUpdateContactTVItemLanguage = val3;
               Assert.AreEqual(val3, mikeBoundaryConditionReport.LastUpdateContactTVItemLanguage);
               string val4 = "Some text";
               mikeBoundaryConditionReport.MikeBoundaryConditionLevelOrVelocityText = val4;
               Assert.AreEqual(val4, mikeBoundaryConditionReport.MikeBoundaryConditionLevelOrVelocityText);
               string val5 = "Some text";
               mikeBoundaryConditionReport.WebTideDataSetText = val5;
               Assert.AreEqual(val5, mikeBoundaryConditionReport.WebTideDataSetText);
               string val6 = "Some text";
               mikeBoundaryConditionReport.TVTypeText = val6;
               Assert.AreEqual(val6, mikeBoundaryConditionReport.TVTypeText);
               int val7 = 45;
               mikeBoundaryConditionReport.MikeBoundaryConditionID = val7;
               Assert.AreEqual(val7, mikeBoundaryConditionReport.MikeBoundaryConditionID);
               int val8 = 45;
               mikeBoundaryConditionReport.MikeBoundaryConditionTVItemID = val8;
               Assert.AreEqual(val8, mikeBoundaryConditionReport.MikeBoundaryConditionTVItemID);
               string val9 = "Some text";
               mikeBoundaryConditionReport.MikeBoundaryConditionCode = val9;
               Assert.AreEqual(val9, mikeBoundaryConditionReport.MikeBoundaryConditionCode);
               string val10 = "Some text";
               mikeBoundaryConditionReport.MikeBoundaryConditionName = val10;
               Assert.AreEqual(val10, mikeBoundaryConditionReport.MikeBoundaryConditionName);
               double val11 = 87.9D;
               mikeBoundaryConditionReport.MikeBoundaryConditionLength_m = val11;
               Assert.AreEqual(val11, mikeBoundaryConditionReport.MikeBoundaryConditionLength_m);
               string val12 = "Some text";
               mikeBoundaryConditionReport.MikeBoundaryConditionFormat = val12;
               Assert.AreEqual(val12, mikeBoundaryConditionReport.MikeBoundaryConditionFormat);
               MikeBoundaryConditionLevelOrVelocityEnum val13 = (MikeBoundaryConditionLevelOrVelocityEnum)3;
               mikeBoundaryConditionReport.MikeBoundaryConditionLevelOrVelocity = val13;
               Assert.AreEqual(val13, mikeBoundaryConditionReport.MikeBoundaryConditionLevelOrVelocity);
               WebTideDataSetEnum val14 = (WebTideDataSetEnum)3;
               mikeBoundaryConditionReport.WebTideDataSet = val14;
               Assert.AreEqual(val14, mikeBoundaryConditionReport.WebTideDataSet);
               int val15 = 45;
               mikeBoundaryConditionReport.NumberOfWebTideNodes = val15;
               Assert.AreEqual(val15, mikeBoundaryConditionReport.NumberOfWebTideNodes);
               string val16 = "Some text";
               mikeBoundaryConditionReport.WebTideDataFromStartToEndDate = val16;
               Assert.AreEqual(val16, mikeBoundaryConditionReport.WebTideDataFromStartToEndDate);
               TVTypeEnum val17 = (TVTypeEnum)3;
               mikeBoundaryConditionReport.TVType = val17;
               Assert.AreEqual(val17, mikeBoundaryConditionReport.TVType);
               DateTime val18 = new DateTime(2010, 3, 4);
               mikeBoundaryConditionReport.LastUpdateDate_UTC = val18;
               Assert.AreEqual(val18, mikeBoundaryConditionReport.LastUpdateDate_UTC);
               int val19 = 45;
               mikeBoundaryConditionReport.LastUpdateContactTVItemID = val19;
               Assert.AreEqual(val19, mikeBoundaryConditionReport.LastUpdateContactTVItemID);
               bool val20 = true;
               mikeBoundaryConditionReport.HasErrors = val20;
               Assert.AreEqual(val20, mikeBoundaryConditionReport.HasErrors);
               IEnumerable<ValidationResult> val63 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               mikeBoundaryConditionReport.ValidationResults = val63;
               Assert.AreEqual(val63, mikeBoundaryConditionReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
