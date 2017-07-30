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
    public partial class TVFileTest : SetupData
    {
        [TestMethod]
        public void TVFile_Properties_Test()
        {
            List<string> propNameList = new List<string>() { "TVFileID", "TVFileTVItemID", "TemplateTVType", "Language", "FilePurpose", "FileType", "FileSize_kb", "FileInfo", "FileCreatedDate_UTC", "FromWater", "ClientFilePath", "ServerFileName", "ServerFilePath", "LastUpdateDate_UTC", "LastUpdateContactTVItemID",  }.OrderBy(c => c).ToList();
            List<string> propNameNotMappedList = new List<string>() {  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(CSSPModels.TVFile).GetProperties().OrderBy(c => c.Name))
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
            foreach (PropertyInfo propertyInfo in typeof(TVFile).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVFile_Navigation_Test()
        {
            List<string> foreignNameList = new List<string>() { "TVFileTVItem",  }.OrderBy(c => c).ToList();
            List<string> foreignNameCollectionList = new List<string>() { "TVFileLanguages",  }.OrderBy(c => c).ToList();

            int index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVFile).GetProperties())
            {
                if (propertyInfo.GetGetMethod().IsVirtual && !propertyInfo.GetGetMethod().ReturnType.Name.StartsWith("ICollection"))
                {
                    Assert.IsTrue(foreignNameList.Contains(propertyInfo.Name));
                    index += 1;
                }
            }

            Assert.AreEqual(foreignNameList.Count, index);

            index = 0;
            foreach (PropertyInfo propertyInfo in typeof(TVFile).GetProperties().Where(c => c.Name != "ValidationResults").OrderBy(c => c.Name).ToList())
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
        public void TVFile_Has_ValidationResults_Test()
        {
             Assert.IsTrue(typeof(TVFile).GetProperties().Where(c => c.Name == "ValidationResults").Any());
        }
        [TestMethod]
        public void TVFile_Every_Property_Has_A_Resource_OK()
        {
               Assert.IsNotNull(ModelsRes.TVFileTVFileID);
               Assert.IsNotNull(ModelsRes.TVFileTVFileTVItemID);
               Assert.IsNotNull(ModelsRes.TVFileTemplateTVType);
               Assert.IsNotNull(ModelsRes.TVFileLanguage);
               Assert.IsNotNull(ModelsRes.TVFileFilePurpose);
               Assert.IsNotNull(ModelsRes.TVFileFileType);
               Assert.IsNotNull(ModelsRes.TVFileFileSize_kb);
               Assert.IsNotNull(ModelsRes.TVFileFileInfo);
               Assert.IsNotNull(ModelsRes.TVFileFileCreatedDate_UTC);
               Assert.IsNotNull(ModelsRes.TVFileFromWater);
               Assert.IsNotNull(ModelsRes.TVFileClientFilePath);
               Assert.IsNotNull(ModelsRes.TVFileServerFileName);
               Assert.IsNotNull(ModelsRes.TVFileServerFilePath);
               Assert.IsNotNull(ModelsRes.TVFileLastUpdateDate_UTC);
               Assert.IsNotNull(ModelsRes.TVFileLastUpdateContactTVItemID);
               Assert.IsNotNull(ModelsRes.TVFileTVFileLanguages);
               Assert.IsNotNull(ModelsRes.TVFileTVFileTVItem);
        }
        [TestMethod]
        public void TVFile_Every_Property_Has_Get_Set_Test()
        {
               int val1 = 45;
               tVFile.TVFileID = val1;
               Assert.AreEqual(val1, tVFile.TVFileID);
               int val2 = 45;
               tVFile.TVFileTVItemID = val2;
               Assert.AreEqual(val2, tVFile.TVFileTVItemID);
               TVTypeEnum val3 = (TVTypeEnum)3;
               tVFile.TemplateTVType = val3;
               Assert.AreEqual(val3, tVFile.TemplateTVType);
               LanguageEnum val4 = (LanguageEnum)3;
               tVFile.Language = val4;
               Assert.AreEqual(val4, tVFile.Language);
               FilePurposeEnum val5 = (FilePurposeEnum)3;
               tVFile.FilePurpose = val5;
               Assert.AreEqual(val5, tVFile.FilePurpose);
               FileTypeEnum val6 = (FileTypeEnum)3;
               tVFile.FileType = val6;
               Assert.AreEqual(val6, tVFile.FileType);
               int val7 = 45;
               tVFile.FileSize_kb = val7;
               Assert.AreEqual(val7, tVFile.FileSize_kb);
               string val8 = "Some text";
               tVFile.FileInfo = val8;
               Assert.AreEqual(val8, tVFile.FileInfo);
               DateTime val9 = new DateTime(2010, 3, 4);
               tVFile.FileCreatedDate_UTC = val9;
               Assert.AreEqual(val9, tVFile.FileCreatedDate_UTC);
               bool val10 = true;
               tVFile.FromWater = val10;
               Assert.AreEqual(val10, tVFile.FromWater);
               string val11 = "Some text";
               tVFile.ClientFilePath = val11;
               Assert.AreEqual(val11, tVFile.ClientFilePath);
               string val12 = "Some text";
               tVFile.ServerFileName = val12;
               Assert.AreEqual(val12, tVFile.ServerFileName);
               string val13 = "Some text";
               tVFile.ServerFilePath = val13;
               Assert.AreEqual(val13, tVFile.ServerFilePath);
               DateTime val14 = new DateTime(2010, 3, 4);
               tVFile.LastUpdateDate_UTC = val14;
               Assert.AreEqual(val14, tVFile.LastUpdateDate_UTC);
               int val15 = 45;
               tVFile.LastUpdateContactTVItemID = val15;
               Assert.AreEqual(val15, tVFile.LastUpdateContactTVItemID);
               ICollection<TVFileLanguage> val34 = new List<TVFileLanguage>();
               tVFile.TVFileLanguages = val34;
               Assert.AreEqual(val34, tVFile.TVFileLanguages);
               TVItem val35 = new TVItem();
               tVFile.TVFileTVItem = val35;
               Assert.AreEqual(val35, tVFile.TVFileTVItem);
               IEnumerable<ValidationResult> val54 = new List<ValidationResult>().AsEnumerable();
               tVFile.ValidationResults = val54;
               Assert.AreEqual(val54, tVFile.ValidationResults);
        }
    }
}
