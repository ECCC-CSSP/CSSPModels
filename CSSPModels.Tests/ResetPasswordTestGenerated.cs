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
    public partial class ResetPasswordTest
    {
        #region Variables
        #endregion Variables

        #region Properties
        private ResetPassword resetPassword { get; set; }
        #endregion Properties

        #region Constructors
        public ResetPasswordTest()
        {
            resetPassword = new ResetPassword();
        }
        #endregion Constructors

        #region Tests
        [TestMethod]
        public void ResetPassword_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ResetPasswordID", "Email", "ExpireDate_Local", "Code", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "ResetPasswordWeb", "ResetPasswordReport", "HasErrors",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.ResetPassword).GetProperties().OrderBy(c => c.Name))
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
        public void ResetPassword_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(ResetPassword).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void ResetPassword_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(CSSPModelsRes.ResetPasswordResetPasswordID);
               Assert.IsNotNull(CSSPModelsRes.ResetPasswordEmail);
               Assert.IsNotNull(CSSPModelsRes.ResetPasswordExpireDate_Local);
               Assert.IsNotNull(CSSPModelsRes.ResetPasswordCode);
               Assert.IsNotNull(CSSPModelsRes.ResetPasswordLastUpdateDate_UTC);
               Assert.IsNotNull(CSSPModelsRes.ResetPasswordLastUpdateContactTVItemID);
               Assert.IsNotNull(CSSPModelsRes.ResetPasswordHasErrors);
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
               IEnumerable<ValidationResult> val28 = new List<ValidationResult>().AsEnumerable();
               resetPassword.ValidationResults = val28;
               Assert.AreEqual(val28, resetPassword.ValidationResults);
        }
        #endregion Tests
    }
}
