/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [[ModelClassName]TestGenerated.cs] button
 *
 * Do not edit this file.
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
        private ResetPasswordExtraA resetPasswordExtraA { get; set; }
        private ResetPasswordExtraB resetPasswordExtraB { get; set; }
        #endregion Properties

        #region Constructors
        public ResetPasswordTest()
        {
            resetPassword = new ResetPassword();
            resetPasswordExtraA = new ResetPasswordExtraA();
            resetPasswordExtraB = new ResetPasswordExtraB();
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
        public void ResetPasswordExtraA_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "LastUpdateContactText", "ResetPasswordID", "Email", "ExpireDate_Local", "Code", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordExtraA).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPasswordExtraB_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ResetPasswordReportTest", "LastUpdateContactText", "ResetPasswordID", "Email", "ExpireDate_Local", "Code", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordExtraB).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPasswordExtraA_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordExtraA).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordExtraA).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPasswordExtraB_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() {  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordExtraB).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(ResetPasswordExtraB).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void ResetPasswordExtraA_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ResetPasswordExtraA).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ResetPasswordExtraB_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ResetPasswordExtraB).GetProperties().Where(c => c.Name == "ValidationResults").Any());
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
               IEnumerable<ValidationResult> val24 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               resetPassword.ValidationResults = val24;
               Assert.AreEqual(val24, resetPassword.ValidationResults);
        }
        [TestMethod]
        public void ResetPasswordExtraA_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               resetPasswordExtraA.LastUpdateContactText = val1;
               Assert.AreEqual(val1, resetPasswordExtraA.LastUpdateContactText);
               int val2 = 45;
               resetPasswordExtraA.ResetPasswordID = val2;
               Assert.AreEqual(val2, resetPasswordExtraA.ResetPasswordID);
               string val3 = "Some text";
               resetPasswordExtraA.Email = val3;
               Assert.AreEqual(val3, resetPasswordExtraA.Email);
               DateTime val4 = new DateTime(2010, 3, 4);
               resetPasswordExtraA.ExpireDate_Local = val4;
               Assert.AreEqual(val4, resetPasswordExtraA.ExpireDate_Local);
               string val5 = "Some text";
               resetPasswordExtraA.Code = val5;
               Assert.AreEqual(val5, resetPasswordExtraA.Code);
               DateTime val6 = new DateTime(2010, 3, 4);
               resetPasswordExtraA.LastUpdateDate_UTC = val6;
               Assert.AreEqual(val6, resetPasswordExtraA.LastUpdateDate_UTC);
               int val7 = 45;
               resetPasswordExtraA.LastUpdateContactTVItemID = val7;
               Assert.AreEqual(val7, resetPasswordExtraA.LastUpdateContactTVItemID);
               bool val8 = true;
               resetPasswordExtraA.HasErrors = val8;
               Assert.AreEqual(val8, resetPasswordExtraA.HasErrors);
               IEnumerable<ValidationResult> val27 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               resetPasswordExtraA.ValidationResults = val27;
               Assert.AreEqual(val27, resetPasswordExtraA.ValidationResults);
        }
        [TestMethod]
        public void ResetPasswordExtraB_Every_Property_Has_Get_Set_Test()
        {
               string val1 = "Some text";
               resetPasswordExtraB.ResetPasswordReportTest = val1;
               Assert.AreEqual(val1, resetPasswordExtraB.ResetPasswordReportTest);
               string val2 = "Some text";
               resetPasswordExtraB.LastUpdateContactText = val2;
               Assert.AreEqual(val2, resetPasswordExtraB.LastUpdateContactText);
               int val3 = 45;
               resetPasswordExtraB.ResetPasswordID = val3;
               Assert.AreEqual(val3, resetPasswordExtraB.ResetPasswordID);
               string val4 = "Some text";
               resetPasswordExtraB.Email = val4;
               Assert.AreEqual(val4, resetPasswordExtraB.Email);
               DateTime val5 = new DateTime(2010, 3, 4);
               resetPasswordExtraB.ExpireDate_Local = val5;
               Assert.AreEqual(val5, resetPasswordExtraB.ExpireDate_Local);
               string val6 = "Some text";
               resetPasswordExtraB.Code = val6;
               Assert.AreEqual(val6, resetPasswordExtraB.Code);
               DateTime val7 = new DateTime(2010, 3, 4);
               resetPasswordExtraB.LastUpdateDate_UTC = val7;
               Assert.AreEqual(val7, resetPasswordExtraB.LastUpdateDate_UTC);
               int val8 = 45;
               resetPasswordExtraB.LastUpdateContactTVItemID = val8;
               Assert.AreEqual(val8, resetPasswordExtraB.LastUpdateContactTVItemID);
               bool val9 = true;
               resetPasswordExtraB.HasErrors = val9;
               Assert.AreEqual(val9, resetPasswordExtraB.HasErrors);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>() { new ValidationResult("First CSSPError Message") }.AsEnumerable();
               resetPasswordExtraB.ValidationResults = val30;
               Assert.AreEqual(val30, resetPasswordExtraB.ValidationResults);
        }
        #endregion Tests Functions public
    }
}
