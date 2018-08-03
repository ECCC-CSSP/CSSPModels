/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
 *
 * Last generated by leblancc on WMON01DTCHLEBL2 machine
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
    public partial class ResetPasswordTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ResetPassword resetPassword { get; set; }
        private ResetPasswordWeb resetPasswordWeb { get; set; }
        private ResetPasswordReport resetPasswordReport { get; set; }
        #endregion Properties

        #region Constructors
        public ResetPasswordTest()
        {
            resetPassword = new ResetPassword();
            resetPasswordWeb = new ResetPasswordWeb();
            resetPasswordReport = new ResetPasswordReport();
        }
        #endregion Constructors

        #region Tests Functions public
        [TestMethod]
        public void ResetPassword_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ResetPasswordID", "Email", "ExpireDate_Local", "Code", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPassword).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ResetPassword).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPasswordWeb_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactTVItemLanguage", "ResetPasswordID", "Email", "ExpireDate_Local", "Code", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordWeb).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPasswordReport_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ResetPasswordReportTest", "LastUpdateContactTVItemLanguage", "ResetPasswordID", "Email", "ExpireDate_Local", "Code", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordReport).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPassword_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPassword).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPassword).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPasswordWeb_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordWeb).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordWeb).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPasswordReport_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordReport).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordReport).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPassword_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ResetPassword).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ResetPasswordWeb_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ResetPasswordWeb).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ResetPasswordReport_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ResetPasswordReport).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ResetPassword_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               resetPassword.ResetPasswordID = val1;
               Assert.AreEqual(val1, resetPassword.ResetPasswordID);
               string val2 = "Some text";
               resetPassword.Email = val2;
               Assert.AreEqual(val2, resetPassword.Email);
               DateTime val3 = new DateTime(2010, 3, 4);
               resetPassword.ExpireDate_Local = val3;
               Assert.AreEqual(val3, resetPassword.ExpireDate_Local);
               string val4 = "Some text";
               resetPassword.Code = val4;
               Assert.AreEqual(val4, resetPassword.Code);
               DateTime val5 = new DateTime(2010, 3, 4);
               resetPassword.LastUpdateDate_UTC = val5;
               Assert.AreEqual(val5, resetPassword.LastUpdateDate_UTC);
               int val6 = 45;
               resetPassword.LastUpdateContactTVItemID = val6;
               Assert.AreEqual(val6, resetPassword.LastUpdateContactTVItemID);
               bool val7 = true;
               resetPassword.HasErrors = val7;
               Assert.AreEqual(val7, resetPassword.HasErrors);
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               resetPassword.ValidationResults = val24;
               Assert.AreEqual(val24, resetPassword.ValidationResults);
        }
        [TestMethod]
        public void ResetPasswordWeb_Every_Property_Has_Get_Set_Test()
        {
               TVItemLanguage val1 = new TVItemLanguage();
               resetPasswordWeb.LastUpdateContactTVItemLanguage = val1;
               Assert.AreEqual(val1, resetPasswordWeb.LastUpdateContactTVItemLanguage);
               int val2 = 45;
               resetPasswordWeb.ResetPasswordID = val2;
               Assert.AreEqual(val2, resetPasswordWeb.ResetPasswordID);
               string val3 = "Some text";
               resetPasswordWeb.Email = val3;
               Assert.AreEqual(val3, resetPasswordWeb.Email);
               DateTime val4 = new DateTime(2010, 3, 4);
               resetPasswordWeb.ExpireDate_Local = val4;
               Assert.AreEqual(val4, resetPasswordWeb.ExpireDate_Local);
               string val5 = "Some text";
               resetPasswordWeb.Code = val5;
               Assert.AreEqual(val5, resetPasswordWeb.Code);
               DateTime val6 = new DateTime(2010, 3, 4);
               resetPasswordWeb.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, resetPasswordWeb.LastUpdateDate_UTC);
               int val7 = 45;
               resetPasswordWeb.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, resetPasswordWeb.LastUpdateContactTVItemID);
               bool val8 = true;
               resetPasswordWeb.HasErrors = val8;
               Assert.AreEqual(val8, resetPasswordWeb.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               resetPasswordWeb.ValidationResults = val27;
               Assert.AreEqual(val27, resetPasswordWeb.ValidationResults);
        }
        [TestMethod]
        public void ResetPasswordReport_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               resetPasswordReport.ResetPasswordReportTest = val1;
               Assert.AreEqual(val1, resetPasswordReport.ResetPasswordReportTest);
               TVItemLanguage val2 = new TVItemLanguage();
               resetPasswordReport.LastUpdateContactTVItemLanguage = val2;
               Assert.AreEqual(val2, resetPasswordReport.LastUpdateContactTVItemLanguage);
               int val3 = 45;
               resetPasswordReport.ResetPasswordID = val3;
               Assert.AreEqual(val3, resetPasswordReport.ResetPasswordID);
               string val4 = "Some text";
               resetPasswordReport.Email = val4;
               Assert.AreEqual(val4, resetPasswordReport.Email);
               DateTime val5 = new DateTime(2010, 3, 4);
               resetPasswordReport.ExpireDate_Local = val5;
               Assert.AreEqual(val5, resetPasswordReport.ExpireDate_Local);
               string val6 = "Some text";
               resetPasswordReport.Code = val6;
               Assert.AreEqual(val6, resetPasswordReport.Code);
               DateTime val7 = new DateTime(2010, 3, 4);
               resetPasswordReport.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, resetPasswordReport.LastUpdateDate_UTC);
               int val8 = 45;
               resetPasswordReport.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, resetPasswordReport.LastUpdateContactTVItemID);
               bool val9 = true;
               resetPasswordReport.HasErrors = val9;
               Assert.AreEqual(val9, resetPasswordReport.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First Error Message") }.AsEnumerable();
               resetPasswordReport.ValidationResults = val30;
               Assert.AreEqual(val30, resetPasswordReport.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
