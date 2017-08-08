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
    public partial class ResetPasswordTest : SetupData
    {
        [TestMethod]
        public void ResetPassword_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "ResetPasswordID", "Email", "ExpireDate_Local", "Code", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() { "LastUpdateContactTVText", "Password", "ConfirmPassword",  }.OrderBy(c => c).ToList();

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
               Assert.IsNotNull(ModelsRes.ResetPasswordResetPasswordID);
               Assert.IsNotNull(ModelsRes.ResetPasswordEmail);
               Assert.IsNotNull(ModelsRes.ResetPasswordExpireDate_Local);
               Assert.IsNotNull(ModelsRes.ResetPasswordCode);
               Assert.IsNotNull(ModelsRes.ResetPasswordLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.ResetPasswordLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.ResetPasswordLastUpdateContactTVText);
               Assert.IsNotNull(ModelsRes.ResetPasswordPassword);
               Assert.IsNotNull(ModelsRes.ResetPasswordConfirmPassword);
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
               string val7 = "Some text";
               resetPassword.LastUpdateContactTVText = val7;
               Assert.AreEqual(val7, resetPassword.LastUpdateContactTVText);
               string val8 = "Some text";
               resetPassword.Password = val8;
               Assert.AreEqual(val8, resetPassword.Password);
               string val9 = "Some text";
               resetPassword.ConfirmPassword = val9;
               Assert.AreEqual(val9, resetPassword.ConfirmPassword);
               IEnumerable<ValidationResult> val30 = new List<ValidationResult>().AsEnumerable();
               resetPassword.ValidationResults = val30;
               Assert.AreEqual(val30, resetPassword.ValidationResults);
        }
    }
}
