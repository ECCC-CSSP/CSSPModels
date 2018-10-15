/*
 * Auto generated from the CSSPCodeWriter.proj by clicking on the [\srcWithDoc\[ModelClassName]Generated.cs] button
 *
 * Do not edit this file.
 *
 */ 
using CSSPEnums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace CSSPModels
{
    /// <summary>
    /// > [!NOTE]
    /// > 
    /// > <para>**DB properties for table BoxModelResults** : [BoxModelResultID](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_BoxModelResultID), [BoxModelID](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_BoxModelID), [BoxModelResultType](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_BoxModelResultType), [Volume_m3](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_Volume_m3), [Surface_m2](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_Surface_m2), [Radius_m](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_Radius_m), [LeftSideDiameterLineAngle_deg](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LeftSideDiameterLineAngle_deg), [CircleCenterLatitude](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_CircleCenterLatitude), [CircleCenterLongitude](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_CircleCenterLongitude), [FixLength](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_FixLength), [FixWidth](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_FixWidth), [RectLength_m](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_RectLength_m), [RectWidth_m](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_RectWidth_m), [LeftSideLineAngle_deg](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LeftSideLineAngle_deg), [LeftSideLineStartLatitude](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LeftSideLineStartLatitude), [LeftSideLineStartLongitude](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LeftSideLineStartLongitude), [LastUpdateDate_UTC](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LastUpdateDate_UTC), [LastUpdateContactTVItemID](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_LastUpdateContactTVItemID), </para>
    /// > <para>**Other properties** : [HasErrors](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_HasErrors), [ValidationResults](CSSPModels.BoxModelResult.html#CSSPModels_BoxModelResult_ValidationResults), </para>
    /// > 
    /// > <para>**Used by [CSSPServices](CSSPServices.html)** : [BoxModelResultService](CSSPServices.BoxModelResultService.html)</para>
    /// > <para>**Requires [CSSPEnums](CSSPEnums.html)** : [BoxModelResultTypeEnum](CSSPEnums.BoxModelResultTypeEnum.html)</para>
    /// > <para>**Return to [CSSPModels](CSSPModels.html)**</para>
    /// </summary>
    public partial class BoxModelResult : LastUpdate
    {
        #region Properties in DB
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "BoxModelResult ID")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "BoxModelResult ID")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Contains the unique "identifier on each row of the BoxModelResults table")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Contient l'identifiant unique sur chaque ligne de la table BoxModelResults")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- BoxModelResult ID
        /// 
        /// **Display (fr)** --- BoxModelResult ID
        /// 
        /// **Description (en)** --- Contains the unique "identifier on each row of the BoxModelResults table
        /// 
        /// **Description (fr)** --- Contient l'identifiant unique sur chaque ligne de la table BoxModelResults
        /// </returns>
        [Key]
        [CSSPDisplayEN(DisplayEN = "BoxModelResult ID")]
        [CSSPDisplayFR(DisplayFR = "BoxModelResult ID")]
        [CSSPDescriptionEN(DescriptionEN = @"Contains the unique ""identifier on each row of the BoxModelResults table")]
        [CSSPDescriptionFR(DescriptionFR = @"Contient l'identifiant unique sur chaque ligne de la table BoxModelResults")]
        public int BoxModelResultID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPExist](CSSPModels.CSSPExistAttribute.html)(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "BoxModel link")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Lien BoxModel")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "BoxModel link to parent BoxModels table item")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Lien au parent BoxModel à l'item de la table BoxModels")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- BoxModel link
        /// 
        /// **Display (fr)** --- Lien BoxModel
        /// 
        /// **Description (en)** --- BoxModel link to parent BoxModels table item
        /// 
        /// **Description (fr)** --- Lien au parent BoxModel à l'item de la table BoxModels
        /// </returns>
        [CSSPExist(ExistTypeName = "BoxModel", ExistPlurial = "s", ExistFieldID = "BoxModelID")]
        [CSSPDisplayEN(DisplayEN = "BoxModel link")]
        [CSSPDisplayFR(DisplayFR = "Lien BoxModel")]
        [CSSPDescriptionEN(DescriptionEN = @"BoxModel link to parent BoxModels table item")]
        [CSSPDescriptionFR(DescriptionFR = @"Lien au parent BoxModel à l'item de la table BoxModels")]
        public int BoxModelID { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumType](CSSPModels.CSSPEnumTypeAttribute.html)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Result type")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Type de résultats")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Result type")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Type de résultats")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Result type
        /// 
        /// **Display (fr)** --- Type de résultats
        /// 
        /// **Description (en)** --- Result type
        /// 
        /// **Description (fr)** --- Type de résultats
        /// </returns>
        [CSSPEnumType]
        [CSSPDisplayEN(DisplayEN = "Result type")]
        [CSSPDisplayFR(DisplayFR = "Type de résultats")]
        [CSSPDescriptionEN(DescriptionEN = @"Result type")]
        [CSSPDescriptionFR(DescriptionFR = @"Type de résultats")]
        public BoxModelResultTypeEnum BoxModelResultType { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Volume (m3)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Volume (m3)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Volume (m3) of estuary water required to uptain the expected fecal coliform concentration")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Volume (m3) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Volume (m3)
        /// 
        /// **Display (fr)** --- Volume (m3)
        /// 
        /// **Description (en)** --- Volume (m3) of estuary water required to uptain the expected fecal coliform concentration
        /// 
        /// **Description (fr)** --- Volume (m3) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue
        /// </returns>
        [Range(0.0D, -1.0D)]
        [CSSPDisplayEN(DisplayEN = "Volume (m3)")]
        [CSSPDisplayFR(DisplayFR = "Volume (m3)")]
        [CSSPDescriptionEN(DescriptionEN = @"Volume (m3) of estuary water required to uptain the expected fecal coliform concentration")]
        [CSSPDescriptionFR(DescriptionFR = @"Volume (m3) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]
        public double Volume_m3 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Surface (m2)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Surface (m2)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Surface (m2) of estuary water required to uptain the expected fecal coliform concentration")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Surface (m2) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Surface (m2)
        /// 
        /// **Display (fr)** --- Surface (m2)
        /// 
        /// **Description (en)** --- Surface (m2) of estuary water required to uptain the expected fecal coliform concentration
        /// 
        /// **Description (fr)** --- Surface (m2) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue
        /// </returns>
        [Range(0.0D, -1.0D)]
        [CSSPDisplayEN(DisplayEN = "Surface (m2)")]
        [CSSPDisplayFR(DisplayFR = "Surface (m2)")]
        [CSSPDescriptionEN(DescriptionEN = @"Surface (m2) of estuary water required to uptain the expected fecal coliform concentration")]
        [CSSPDescriptionFR(DescriptionFR = @"Surface (m2) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]
        public double Surface_m2 { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Half circle radius (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Rayon d'un demi cercle (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Half circle radius (m) of estuary water required to uptain the expected fecal coliform concentration")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Rayon d'un demi cercle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Half circle radius (m)
        /// 
        /// **Display (fr)** --- Rayon d'un demi cercle (m)
        /// 
        /// **Description (en)** --- Half circle radius (m) of estuary water required to uptain the expected fecal coliform concentration
        /// 
        /// **Description (fr)** --- Rayon d'un demi cercle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue
        /// </returns>
        [Range(0.0D, 100000.0D)]
        [CSSPDisplayEN(DisplayEN = "Half circle radius (m)")]
        [CSSPDisplayFR(DisplayFR = "Rayon d'un demi cercle (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Half circle radius (m) of estuary water required to uptain the expected fecal coliform concentration")]
        [CSSPDescriptionFR(DescriptionFR = @"Rayon d'un demi cercle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]
        public double Radius_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Left side diameter line angle (deg)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Angle de ligne du diamètre du côté gauche (deg)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Left side diameter line angle (deg) used to draw helf circle on a map")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Angle de ligne du diamètre du côté gauche (deg) utilisé pour dessiner un demi-cercle sur une carte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Left side diameter line angle (deg)
        /// 
        /// **Display (fr)** --- Angle de ligne du diamètre du côté gauche (deg)
        /// 
        /// **Description (en)** --- Left side diameter line angle (deg) used to draw helf circle on a map
        /// 
        /// **Description (fr)** --- Angle de ligne du diamètre du côté gauche (deg) utilisé pour dessiner un demi-cercle sur une carte
        /// </returns>
        [Range(0.0D, 360.0D)]
        [CSSPDisplayEN(DisplayEN = "Left side diameter line angle (deg)")]
        [CSSPDisplayFR(DisplayFR = "Angle de ligne du diamètre du côté gauche (deg)")]
        [CSSPDescriptionEN(DescriptionEN = @"Left side diameter line angle (deg) used to draw helf circle on a map")]
        [CSSPDescriptionFR(DescriptionFR = @"Angle de ligne du diamètre du côté gauche (deg) utilisé pour dessiner un demi-cercle sur une carte")]
        public double? LeftSideDiameterLineAngle_deg { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Circle center latitude (deg)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Latitude du centre du cercle (deg)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Circle center latitude (deg) used to draw half circle on a map")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Latitude du centre du cercle (deg) utilisé pour dessiner un demi-cercle sur une carte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Circle center latitude (deg)
        /// 
        /// **Display (fr)** --- Latitude du centre du cercle (deg)
        /// 
        /// **Description (en)** --- Circle center latitude (deg) used to draw half circle on a map
        /// 
        /// **Description (fr)** --- Latitude du centre du cercle (deg) utilisé pour dessiner un demi-cercle sur une carte
        /// </returns>
        [Range(-90.0D, 90.0D)]
        [CSSPDisplayEN(DisplayEN = "Circle center latitude (deg)")]
        [CSSPDisplayFR(DisplayFR = "Latitude du centre du cercle (deg)")]
        [CSSPDescriptionEN(DescriptionEN = @"Circle center latitude (deg) used to draw half circle on a map")]
        [CSSPDescriptionFR(DescriptionFR = @"Latitude du centre du cercle (deg) utilisé pour dessiner un demi-cercle sur une carte")]
        public double? CircleCenterLatitude { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Circle center longitude (deg)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Longitude du centre du cercle (deg)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Circle center longitude (deg) used to draw half circle on a map")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Longitude du centre du cercle (deg) utilisé pour dessiner un demi-cercle sur une carte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Circle center longitude (deg)
        /// 
        /// **Display (fr)** --- Longitude du centre du cercle (deg)
        /// 
        /// **Description (en)** --- Circle center longitude (deg) used to draw half circle on a map
        /// 
        /// **Description (fr)** --- Longitude du centre du cercle (deg) utilisé pour dessiner un demi-cercle sur une carte
        /// </returns>
        [Range(-180.0D, 180.0D)]
        [CSSPDisplayEN(DisplayEN = "Circle center longitude (deg)")]
        [CSSPDisplayFR(DisplayFR = "Longitude du centre du cercle (deg)")]
        [CSSPDescriptionEN(DescriptionEN = @"Circle center longitude (deg) used to draw half circle on a map")]
        [CSSPDescriptionFR(DescriptionFR = @"Longitude du centre du cercle (deg) utilisé pour dessiner un demi-cercle sur une carte")]
        public double? CircleCenterLongitude { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Fix length")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Longueur fixe")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Fix length is used to indicate we want the rectangle length to be fix a certain length. Only the width of the rectangle will redimensioned in order to find the rectangle size  to uptain the expected fecal coliform concentration")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "La longueur fixe est utilisée pour indiquer que la longueur du rectangle doit être fixée sur une certaine longueur. Seule la largeur du rectangle sera redimensionnée afin de trouver la taille du rectangle pour obtenir la concentration de coliform fécaux attendue")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Fix length
        /// 
        /// **Display (fr)** --- Longueur fixe
        /// 
        /// **Description (en)** --- Fix length is used to indicate we want the rectangle length to be fix a certain length. Only the width of the rectangle will redimensioned in order to find the rectangle size  to uptain the expected fecal coliform concentration
        /// 
        /// **Description (fr)** --- La longueur fixe est utilisée pour indiquer que la longueur du rectangle doit être fixée sur une certaine longueur. Seule la largeur du rectangle sera redimensionnée afin de trouver la taille du rectangle pour obtenir la concentration de coliform fécaux attendue
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Fix length")]
        [CSSPDisplayFR(DisplayFR = "Longueur fixe")]
        [CSSPDescriptionEN(DescriptionEN = @"Fix length is used to indicate we want the rectangle length to be fix a certain length. Only the width of the rectangle will redimensioned in order to find the rectangle size  to uptain the expected fecal coliform concentration")]
        [CSSPDescriptionFR(DescriptionFR = @"La longueur fixe est utilisée pour indiquer que la longueur du rectangle doit être fixée sur une certaine longueur. Seule la largeur du rectangle sera redimensionnée afin de trouver la taille du rectangle pour obtenir la concentration de coliform fécaux attendue")]
        public bool FixLength { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Fix width")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Largeur fixe")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Fix width is used to indicate we want the rectangle width to be fix a certain width. Only the length of the rectangle will redimensioned in order to find the rectangle size  to uptain the expected fecal coliform concentration")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "La largeur fixe est utilisée pour indiquer que la largeur du rectangle doit être fixée sur une certaine largeur. Seule la longueur du rectangle sera redimensionnée afin de trouver la taille du rectangle pour obtenir la concentration de coliform fécaux attendue")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Fix width
        /// 
        /// **Display (fr)** --- Largeur fixe
        /// 
        /// **Description (en)** --- Fix width is used to indicate we want the rectangle width to be fix a certain width. Only the length of the rectangle will redimensioned in order to find the rectangle size  to uptain the expected fecal coliform concentration
        /// 
        /// **Description (fr)** --- La largeur fixe est utilisée pour indiquer que la largeur du rectangle doit être fixée sur une certaine largeur. Seule la longueur du rectangle sera redimensionnée afin de trouver la taille du rectangle pour obtenir la concentration de coliform fécaux attendue
        /// </returns>
        [CSSPDisplayEN(DisplayEN = "Fix width")]
        [CSSPDisplayFR(DisplayFR = "Largeur fixe")]
        [CSSPDescriptionEN(DescriptionEN = @"Fix width is used to indicate we want the rectangle width to be fix a certain width. Only the length of the rectangle will redimensioned in order to find the rectangle size  to uptain the expected fecal coliform concentration")]
        [CSSPDescriptionFR(DescriptionFR = @"La largeur fixe est utilisée pour indiquer que la largeur du rectangle doit être fixée sur une certaine largeur. Seule la longueur du rectangle sera redimensionnée afin de trouver la taille du rectangle pour obtenir la concentration de coliform fécaux attendue")]
        public bool FixWidth { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Rectangle length (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Longueur du rectangle (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Rectangle length (m) of estuary water required to uptain the expected fecal coliform concentration")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Longueur du rectangle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Rectangle length (m)
        /// 
        /// **Display (fr)** --- Longueur du rectangle (m)
        /// 
        /// **Description (en)** --- Rectangle length (m) of estuary water required to uptain the expected fecal coliform concentration
        /// 
        /// **Description (fr)** --- Longueur du rectangle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue
        /// </returns>
        [Range(0.0D, 100000.0D)]
        [CSSPDisplayEN(DisplayEN = "Rectangle length (m)")]
        [CSSPDisplayFR(DisplayFR = "Longueur du rectangle (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Rectangle length (m) of estuary water required to uptain the expected fecal coliform concentration")]
        [CSSPDescriptionFR(DescriptionFR = @"Longueur du rectangle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]
        public double RectLength_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Rectangle width (m)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Largeur du rectangle (m)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Rectangle width (m) of estuary water required to uptain the expected fecal coliform concentration")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Largeur du rectangle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Rectangle width (m)
        /// 
        /// **Display (fr)** --- Largeur du rectangle (m)
        /// 
        /// **Description (en)** --- Rectangle width (m) of estuary water required to uptain the expected fecal coliform concentration
        /// 
        /// **Description (fr)** --- Largeur du rectangle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue
        /// </returns>
        [Range(0.0D, 100000.0D)]
        [CSSPDisplayEN(DisplayEN = "Rectangle width (m)")]
        [CSSPDisplayFR(DisplayFR = "Largeur du rectangle (m)")]
        [CSSPDescriptionEN(DescriptionEN = @"Rectangle width (m) of estuary water required to uptain the expected fecal coliform concentration")]
        [CSSPDescriptionFR(DescriptionFR = @"Largeur du rectangle (m) d'eau de l'estuaire nécessaire pour obtenir la concentration de coliform fécaux attendue")]
        public double RectWidth_m { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Left side rectangle line angle (deg)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Angle de ligne du côté gauche du rectangle (deg)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Left side rectangle line angle (deg) used to draw rectangle on a map")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Angle de ligne du côté gauche du rectangle (deg) utilisé pour dessiner un rectangle sur une carte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Left side rectangle line angle (deg)
        /// 
        /// **Display (fr)** --- Angle de ligne du côté gauche du rectangle (deg)
        /// 
        /// **Description (en)** --- Left side rectangle line angle (deg) used to draw rectangle on a map
        /// 
        /// **Description (fr)** --- Angle de ligne du côté gauche du rectangle (deg) utilisé pour dessiner un rectangle sur une carte
        /// </returns>
        [Range(0.0D, 360.0D)]
        [CSSPDisplayEN(DisplayEN = "Left side rectangle line angle (deg)")]
        [CSSPDisplayFR(DisplayFR = "Angle de ligne du côté gauche du rectangle (deg)")]
        [CSSPDescriptionEN(DescriptionEN = @"Left side rectangle line angle (deg) used to draw rectangle on a map")]
        [CSSPDescriptionFR(DescriptionFR = @"Angle de ligne du côté gauche du rectangle (deg) utilisé pour dessiner un rectangle sur une carte")]
        public double? LeftSideLineAngle_deg { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Left side line start latitude (deg)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Latitude de départ de la ligne latérale gauche (deg)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Left side line start latitude (deg) used to draw half circle on a map")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Latitude de départ de la ligne latérale gauche (deg) utilisé pour dessiner un demi-cercle sur une carte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Left side line start latitude (deg)
        /// 
        /// **Display (fr)** --- Latitude de départ de la ligne latérale gauche (deg)
        /// 
        /// **Description (en)** --- Left side line start latitude (deg) used to draw half circle on a map
        /// 
        /// **Description (fr)** --- Latitude de départ de la ligne latérale gauche (deg) utilisé pour dessiner un demi-cercle sur une carte
        /// </returns>
        [Range(-90.0D, 90.0D)]
        [CSSPDisplayEN(DisplayEN = "Left side line start latitude (deg)")]
        [CSSPDisplayFR(DisplayFR = "Latitude de départ de la ligne latérale gauche (deg)")]
        [CSSPDescriptionEN(DescriptionEN = @"Left side line start latitude (deg) used to draw half circle on a map")]
        [CSSPDescriptionFR(DescriptionFR = @"Latitude de départ de la ligne latérale gauche (deg) utilisé pour dessiner un demi-cercle sur une carte")]
        public double? LeftSideLineStartLatitude { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Left side line start longitude (deg)")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Longitude de départ de la ligne latérale gauche (deg)")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Left side line start longitude (deg) used to draw half circle on a map")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Longitude de départ de la ligne latérale gauche (deg) utilisé pour dessiner un demi-cercle sur une carte")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Left side line start longitude (deg)
        /// 
        /// **Display (fr)** --- Longitude de départ de la ligne latérale gauche (deg)
        /// 
        /// **Description (en)** --- Left side line start longitude (deg) used to draw half circle on a map
        /// 
        /// **Description (fr)** --- Longitude de départ de la ligne latérale gauche (deg) utilisé pour dessiner un demi-cercle sur une carte
        /// </returns>
        [Range(-180.0D, 180.0D)]
        [CSSPDisplayEN(DisplayEN = "Left side line start longitude (deg)")]
        [CSSPDisplayFR(DisplayFR = "Longitude de départ de la ligne latérale gauche (deg)")]
        [CSSPDescriptionEN(DescriptionEN = @"Left side line start longitude (deg) used to draw half circle on a map")]
        [CSSPDescriptionFR(DescriptionFR = @"Longitude de départ de la ligne latérale gauche (deg) utilisé pour dessiner un demi-cercle sur une carte")]
        public double? LeftSideLineStartLongitude { get; set; }
        #endregion Properties in DB

        #region Constructors
        public BoxModelResult() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelResultExtraA : BoxModelResult
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Last update contact TVItemLanguage")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Last update contact TVItemLanguage DB object")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Object BD TVItemLanguage du contact ayant fait le dernière changement")]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Last update contact TVItemLanguage
        /// 
        /// **Display (fr)** --- TVItemLanguage du contact ayant fait le dernière changement
        /// 
        /// **Description (en)** --- Last update contact TVItemLanguage DB object
        /// 
        /// **Description (fr)** --- Object BD TVItemLanguage du contact ayant fait le dernière changement
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "", FillNeedLanguage = true, FillIsList = false)]
        [CSSPDisplayEN(DisplayEN = "Last update contact TVItemLanguage")]
        [CSSPDisplayFR(DisplayFR = "TVItemLanguage du contact ayant fait le dernière changement")]
        [CSSPDescriptionEN(DescriptionEN = @"Last update contact TVItemLanguage DB object")]
        [CSSPDescriptionFR(DescriptionFR = @"Object BD TVItemLanguage du contact ayant fait le dernière changement")]
        public TVItemLanguage LastUpdateContactTVItemLanguage { get; set; }
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPEnumTypeText](CSSPModels.CSSPEnumTypeTextAttribute.html)(EnumTypeName = "BoxModelResultTypeEnum", EnumType = "BoxModelResultType")]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Result type text")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Texte du type de résultats")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Result type text")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Texte du type de résultats")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Result type text
        /// 
        /// **Display (fr)** --- Texte du type de résultats
        /// 
        /// **Description (en)** --- Result type text
        /// 
        /// **Description (fr)** --- Texte du type de résultats
        /// </returns>
        [CSSPEnumTypeText(EnumTypeName = "BoxModelResultTypeEnum", EnumType = "BoxModelResultType")]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Result type text")]
        [CSSPDisplayFR(DisplayFR = "Texte du type de résultats")]
        [CSSPDescriptionEN(DescriptionEN = @"Result type text")]
        [CSSPDescriptionFR(DescriptionFR = @"Texte du type de résultats")]
        public string BoxModelResultTypeText { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelResultExtraA() : base()
        {
        }
        #endregion Constructors
    }
    [NotMapped]
    public partial class BoxModelResultExtraB : BoxModelResultExtraA
    {
        #region Properties
        /// <summary>
        /// > [!NOTE]
        /// > <para>**Other custom attributes**</para>
        /// > <para>[[CSSPFill](CSSPModels.CSSPFillAttribute.html)(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]</para>
        /// > <para>[[CSSPDisplayEN](CSSPModels.CSSPDisplayEN.html)(DisplayEN = "Report test")]</para>
        /// > <para>[[CSSPDisplayFR](CSSPModels.CSSPDisplayFR.html)(DisplayFR = "Test report")]</para>
        /// > <para>[[CSSPDescriptionEN](CSSPModels.CSSPDescriptionEN.html)(DescriptionEN = "Report test description")]</para>
        /// > <para>[[CSSPDescriptionFR](CSSPModels.CSSPDescriptionFR.html)(DescriptionFR = "Description de test report")]</para>
        /// > <para>[[CSSPAllowNull](CSSPModels.CSSPAllowNullAttribute.html)]</para>
        /// </summary>
        /// <returns>
        /// 
        /// **Display (en)** --- Report test
        /// 
        /// **Display (fr)** --- Test report
        /// 
        /// **Description (en)** --- Report test description
        /// 
        /// **Description (fr)** --- Description de test report
        /// </returns>
        [CSSPFill(FillTypeName = "TVItemLanguage", FillPlurial = "s", FillFieldID = "TVItemID", FillEqualField = "LastUpdateContactTVItemID", FillReturnField = "TVText", FillNeedLanguage = true, FillIsList = false)]
        [CSSPAllowNull]
        [CSSPDisplayEN(DisplayEN = "Report test")]
        [CSSPDisplayFR(DisplayFR = "Test report")]
        [CSSPDescriptionEN(DescriptionEN = @"Report test description")]
        [CSSPDescriptionFR(DescriptionFR = @"Description de test report")]
        public string BoxModelResultReportTest { get; set; }
        #endregion Properties

        #region Constructors
        public BoxModelResultExtraB() : base()
        {
        }
        #endregion Constructors
    }
}
