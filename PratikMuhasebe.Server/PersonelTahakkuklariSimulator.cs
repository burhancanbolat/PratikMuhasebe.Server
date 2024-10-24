using System;
using System.Collections.Generic;

namespace PratikMuhasebe.Server;

public partial class PersonelTahakkuklariSimulator
{
    public Guid PtGuid { get; set; }

    public short PtDbcno { get; set; }

    public int? PtSpecRecno { get; set; }

    public bool? PtIptal { get; set; }

    public short? PtFileid { get; set; }

    public bool? PtHidden { get; set; }

    public bool? PtKilitli { get; set; }

    public bool? PtDegisti { get; set; }

    public int? PtChecksum { get; set; }

    public short? PtCreateUser { get; set; }

    public DateTime PtCreateDate { get; set; }

    public short? PtLastupUser { get; set; }

    public DateTime? PtLastupDate { get; set; }

    public string? PtSpecial1 { get; set; }

    public string? PtSpecial2 { get; set; }

    public string? PtSpecial3 { get; set; }

    public string? PtPkod { get; set; }

    public int? PtMaliyil { get; set; }

    public short? PtTahAy { get; set; }

    public short? PtTahno { get; set; }

    public short? PtKayit { get; set; }

    public bool? PtKesin { get; set; }

    public byte? PtUcrettipi { get; set; }

    public double? PtBrutucret { get; set; }

    public short? PtKazanc1Tkgun { get; set; }

    public double? PtKazanc1Tksaat { get; set; }

    public short? PtKazanc1TkyarimIsgunu { get; set; }

    public double? PtKazanc1TkyarimIsgunSaat { get; set; }

    public double? PtKazanc1Tktutar { get; set; }

    public short? PtKazanc2Tkgun { get; set; }

    public double? PtKazanc2Tksaat { get; set; }

    public short? PtKazanc2TkyarimIsgunu { get; set; }

    public double? PtKazanc2TkyarimIsgunSaat { get; set; }

    public double? PtKazanc2Tktutar { get; set; }

    public short? PtKazanc3Tkgun { get; set; }

    public double? PtKazanc3Tksaat { get; set; }

    public short? PtKazanc3TkyarimIsgunu { get; set; }

    public double? PtKazanc3TkyarimIsgunSaat { get; set; }

    public double? PtKazanc3Tktutar { get; set; }

    public short? PtKazanc4Tkgun { get; set; }

    public double? PtKazanc4Tksaat { get; set; }

    public short? PtKazanc4TkyarimIsgunu { get; set; }

    public double? PtKazanc4TkyarimIsgunSaat { get; set; }

    public double? PtKazanc4Tktutar { get; set; }

    public short? PtKazanc5Tkgun { get; set; }

    public double? PtKazanc5Tksaat { get; set; }

    public short? PtKazanc5TkyarimIsgunu { get; set; }

    public double? PtKazanc5TkyarimIsgunSaat { get; set; }

    public double? PtKazanc5Tktutar { get; set; }

    public short? PtKazanc6Tkgun { get; set; }

    public double? PtKazanc6Tksaat { get; set; }

    public short? PtKazanc6TkyarimIsgunu { get; set; }

    public double? PtKazanc6TkyarimIsgunSaat { get; set; }

    public double? PtKazanc6Tktutar { get; set; }

    public short? PtKazanc7Tkgun { get; set; }

    public double? PtKazanc7Tksaat { get; set; }

    public short? PtKazanc7TkyarimIsgunu { get; set; }

    public double? PtKazanc7TkyarimIsgunSaat { get; set; }

    public double? PtKazanc7Tktutar { get; set; }

    public double? PtKazancBncarpan { get; set; }

    public short? PtEkkazanc1Tkgun { get; set; }

    public double? PtEkkazanc1Tksaat { get; set; }

    public double? PtEkkazanc1Tktutar { get; set; }

    public short? PtEkkazanc2Tkgun { get; set; }

    public double? PtEkkazanc2Tksaat { get; set; }

    public double? PtEkkazanc2Tktutar { get; set; }

    public short? PtEkkazanc3Tkgun { get; set; }

    public double? PtEkkazanc3Tksaat { get; set; }

    public double? PtEkkazanc3Tktutar { get; set; }

    public short? PtEkkazanc4Tkgun { get; set; }

    public double? PtEkkazanc4Tksaat { get; set; }

    public double? PtEkkazanc4Tktutar { get; set; }

    public short? PtEkkazanc5Tkgun { get; set; }

    public double? PtEkkazanc5Tksaat { get; set; }

    public double? PtEkkazanc5Tktutar { get; set; }

    public short? PtEkkazanc6Tkgun { get; set; }

    public double? PtEkkazanc6Tksaat { get; set; }

    public double? PtEkkazanc6Tktutar { get; set; }

    public short? PtEkkazanc7Tkgun { get; set; }

    public double? PtEkkazanc7Tksaat { get; set; }

    public double? PtEkkazanc7Tktutar { get; set; }

    public short? PtEkkazanc8Tkgun { get; set; }

    public double? PtEkkazanc8Tksaat { get; set; }

    public double? PtEkkazanc8Tktutar { get; set; }

    public short? PtEkkazanc9Tkgun { get; set; }

    public double? PtEkkazanc9Tksaat { get; set; }

    public double? PtEkkazanc9Tktutar { get; set; }

    public short? PtEkkazanc10Tkgun { get; set; }

    public double? PtEkkazanc10Tksaat { get; set; }

    public double? PtEkkazanc10Tktutar { get; set; }

    public short? PtEkkazanc11Tkgun { get; set; }

    public double? PtEkkazanc11Tksaat { get; set; }

    public double? PtEkkazanc11Tktutar { get; set; }

    public double? PtEkKazancBncarpan1 { get; set; }

    public double? PtEkKazancBncarpan2 { get; set; }

    public double? PtEkKazancBncarpan3 { get; set; }

    public double? PtEkKazancBncarpan4 { get; set; }

    public double? PtEkKazancBncarpan5 { get; set; }

    public double? PtEkKazancBncarpan6 { get; set; }

    public double? PtEkKazancBncarpan7 { get; set; }

    public double? PtEkKazancBncarpan8 { get; set; }

    public double? PtEkKazancBncarpan9 { get; set; }

    public double? PtEkKazancBncarpan10 { get; set; }

    public double? PtEkKazancBncarpan11 { get; set; }

    public short? PtSosyolgun { get; set; }

    public short? PtSosyemekgun { get; set; }

    public double? PtSosyrdm1 { get; set; }

    public double? PtSosyrdm2 { get; set; }

    public double? PtSosyrdm3 { get; set; }

    public double? PtSosyrdm4 { get; set; }

    public double? PtSosyrdm5 { get; set; }

    public double? PtSosyrdm6 { get; set; }

    public double? PtSosyrdm7 { get; set; }

    public double? PtSosyrdm8 { get; set; }

    public double? PtSosyrdm9 { get; set; }

    public double? PtSosyrdm10 { get; set; }

    public double? PtSosyrdm11 { get; set; }

    public double? PtSosyrdm12 { get; set; }

    public double? PtSosyrdm13 { get; set; }

    public double? PtSosyrdm14 { get; set; }

    public double? PtSosyrdm15 { get; set; }

    public double? PtSosyrdm16 { get; set; }

    public double? PtSosyrdm17 { get; set; }

    public double? PtSosyrdm18 { get; set; }

    public double? PtSosyrdm19 { get; set; }

    public double? PtSosyrdm20 { get; set; }

    public double? PtSosyrdm21 { get; set; }

    public double? PtSosyrdm22 { get; set; }

    public double? PtSosyrdm23 { get; set; }

    public double? PtSosyrdm24 { get; set; }

    public double? PtSosyrdm25 { get; set; }

    public double? PtSosyrdm26 { get; set; }

    public double? PtSosyrdm27 { get; set; }

    public double? PtSosyrdm28 { get; set; }

    public double? PtSosyrdm29 { get; set; }

    public double? PtSosyrdm30 { get; set; }

    public double? PtSosyrdm31 { get; set; }

    public double? PtSosyrdm32 { get; set; }

    public double? PtSosYardBncarpan1 { get; set; }

    public double? PtSosYardBncarpan2 { get; set; }

    public double? PtSosYardBncarpan3 { get; set; }

    public double? PtSosYardBncarpan4 { get; set; }

    public double? PtSosYardBncarpan5 { get; set; }

    public double? PtSosYardBncarpan6 { get; set; }

    public double? PtSosYardBncarpan7 { get; set; }

    public double? PtSosYardBncarpan8 { get; set; }

    public double? PtSosYardBncarpan9 { get; set; }

    public double? PtSosYardBncarpan10 { get; set; }

    public double? PtSosYardBncarpan11 { get; set; }

    public double? PtSosYardBncarpan12 { get; set; }

    public double? PtSosYardBncarpan13 { get; set; }

    public double? PtSosYardBncarpan14 { get; set; }

    public double? PtSosYardBncarpan15 { get; set; }

    public double? PtSosYardBncarpan16 { get; set; }

    public double? PtSosYardBncarpan17 { get; set; }

    public double? PtSosYardBncarpan18 { get; set; }

    public double? PtSosYardBncarpan19 { get; set; }

    public double? PtSosYardBncarpan20 { get; set; }

    public double? PtSosYardBncarpan21 { get; set; }

    public double? PtSosYardBncarpan22 { get; set; }

    public double? PtSosYardBncarpan23 { get; set; }

    public double? PtSosYardBncarpan24 { get; set; }

    public double? PtSosYardBncarpan25 { get; set; }

    public double? PtSosYardBncarpan26 { get; set; }

    public double? PtSosYardBncarpan27 { get; set; }

    public double? PtSosYardBncarpan28 { get; set; }

    public double? PtSosYardBncarpan29 { get; set; }

    public double? PtSosYardBncarpan30 { get; set; }

    public double? PtSosYardBncarpan31 { get; set; }

    public double? PtSosYardBncarpan32 { get; set; }

    public double? PtOzksnt1 { get; set; }

    public double? PtOzksnt2 { get; set; }

    public double? PtOzksnt3 { get; set; }

    public double? PtOzksnt4 { get; set; }

    public double? PtOzksnt5 { get; set; }

    public double? PtOzksnt6 { get; set; }

    public double? PtOzksnt7 { get; set; }

    public double? PtOzksnt8 { get; set; }

    public double? PtOzksnt9 { get; set; }

    public double? PtOzksnt10 { get; set; }

    public double? PtOzksnt11 { get; set; }

    public double? PtOzksnt12 { get; set; }

    public double? PtOzksnt13 { get; set; }

    public double? PtOzksnt14 { get; set; }

    public double? PtOzksnt15 { get; set; }

    public double? PtOzksnt16 { get; set; }

    public double? PtOzksnt17 { get; set; }

    public double? PtOzksnt18 { get; set; }

    public double? PtOzksnt19 { get; set; }

    public double? PtOzksnt20 { get; set; }

    public double? PtOzksnt21 { get; set; }

    public double? PtOzksnt22 { get; set; }

    public double? PtOzksnt23 { get; set; }

    public double? PtOzksnt24 { get; set; }

    public double? PtSskprimi { get; set; }

    public double? PtGv { get; set; }

    public double? PtDv { get; set; }

    public double? PtNormalkazanc { get; set; }

    public double? PtEkkazanc { get; set; }

    public double? PtSosyrdm { get; set; }

    public double? PtYasksnt { get; set; }

    public double? PtOzksnt { get; set; }

    public double? PtKazanc { get; set; }

    public double? PtKesinti { get; set; }

    public double? PtNet { get; set; }

    public short? PtSskgunu { get; set; }

    public double? PtSskbrut { get; set; }

    public short? PtIzingunu { get; set; }

    public double? PtIzinmatrah { get; set; }

    public double? PtTersbakiye { get; set; }

    public double? PtYuvfarki { get; set; }

    public double? PtSskisvhis { get; set; }

    public double? PtSskkonfon { get; set; }

    public short? PtGayrisafikaz { get; set; }

    public double? PtGs { get; set; }

    public double? PtVerind { get; set; }

    public double? PtGocverind { get; set; }

    public double? PtSakverind { get; set; }

    public double? PtDigverindgv { get; set; }

    public double? PtDigverindssk { get; set; }

    public double? PtToplamind { get; set; }

    public double? PtDevsskmatrah { get; set; }

    public double? PtDevgvmatrah { get; set; }

    public double? PtSskbrutmatrah { get; set; }

    public double? PtGvmatrah { get; set; }

    public double? PtGvbrut { get; set; }

    public double? PtArge5746gvmuafiyeti { get; set; }

    public double? PtVergiIadesi { get; set; }

    public double? PtDigverinddv { get; set; }

    public short? PtDsiz { get; set; }

    public double? PtVidv { get; set; }

    public double? PtNetvergiiadesi { get; set; }

    public double? PtDvmatrah { get; set; }

    public byte? PtTahakkuklog { get; set; }

    public byte? PtSskkonutfonukad { get; set; }

    public double? PtHayatsigortasi { get; set; }

    public double? PtSsdfonu { get; set; }

    public byte? PtHesapTipi { get; set; }

    public double? PtIszlksigperpayi { get; set; }

    public double? PtIszlksigisvpayi { get; set; }

    public double? PtIszlksigmatrah { get; set; }

    public double? PtIszlksigbrut { get; set; }

    public double? PtDigersigortaIsveren { get; set; }

    public double? PtDigersigortaCalisan { get; set; }

    public double? PtBireyselsigortaIsveren { get; set; }

    public double? PtBireyselsigortaCalisan { get; set; }

    public string? PtEksikCalismaNedeni { get; set; }

    public byte? PtEksikcalismanedensecimli { get; set; }

    public double? PtAskerBorclanmasi { get; set; }

    public double? PtIsvHisTesvInd { get; set; }

    public DateTime? PtKurTarihi { get; set; }

    public string? PtDepartmanKodu { get; set; }

    public string? PtGorevKodu { get; set; }

    public string? PtBolgeKodu { get; set; }

    public double? PtAsgarigecimindirimi { get; set; }

    public double? PtSonrayadevredensskmatrahi { get; set; }

    public double? PtGecenaylardankullanilanssk { get; set; }

    public double? PtSgkyatabiitopkazanc { get; set; }

    public double? PtSgkyatabiitopekkazanc { get; set; }

    public double? PtSgkyatabiitopsosyalyardim { get; set; }

    public double? PtSgkpriminetabiikazanc { get; set; }

    public double? PtSgkpriminetabiiekkazanc { get; set; }

    public double? PtSgkpriminetabiisosyalyardim { get; set; }

    public double? PtSgkprimikazanctan { get; set; }

    public double? PtSgkprimiekkazanctan { get; set; }

    public double? PtSgkprimisosyalyardimdan { get; set; }

    public byte? PtTabiioldugukanun { get; set; }

    public byte? PtTabiioldugukanun2 { get; set; }

    public double? PtKultur5225gvmuafiyeti { get; set; }

    public double? PtHazinekanunugvindirimi { get; set; }

    public byte? PtDovizcins { get; set; }

    public double? PtDovizkur { get; set; }

    public double? PtAltdovizkur { get; set; }

    public double? PtBagkurprimi { get; set; }

    public byte? PtTabiioldugubelgeturu { get; set; }

    public byte? PtTabiioldugukanun3 { get; set; }

    public double? PtAz102KanunVergiIndirimi { get; set; }

    public double? PtAzHastalikUcretFarki { get; set; }

    public double? PtAzHastalikUcretFarkVergisi { get; set; }

    public double? PtBrutlesmeyenodeme { get; set; }

    public double? PtSanalgvmatrah { get; set; }

    public double? PtSanalgv { get; set; }

    public double? PtSanaldvmatrah { get; set; }

    public double? PtSanaldv { get; set; }

    public double? PtPerskgtesvikind { get; set; }

    public double? PtPerisssigtesvikind { get; set; }

    public short? PtIzin1Tkgun { get; set; }

    public double? PtIzin1Tksaat { get; set; }

    public short? PtIzin1TkyarimIsgunu { get; set; }

    public double? PtIzin1TkyarimIsgunSaat { get; set; }

    public double? PtIzin1Tktutar { get; set; }

    public short? PtIzin2Tkgun { get; set; }

    public double? PtIzin2Tksaat { get; set; }

    public short? PtIzin2TkyarimIsgunu { get; set; }

    public double? PtIzin2TkyarimIsgunSaat { get; set; }

    public double? PtIzin2Tktutar { get; set; }

    public short? PtIzin3Tkgun { get; set; }

    public double? PtIzin3Tksaat { get; set; }

    public short? PtIzin3TkyarimIsgunu { get; set; }

    public double? PtIzin3TkyarimIsgunSaat { get; set; }

    public double? PtIzin3Tktutar { get; set; }

    public short? PtIzin4Tkgun { get; set; }

    public double? PtIzin4Tksaat { get; set; }

    public short? PtIzin4TkyarimIsgunu { get; set; }

    public double? PtIzin4TkyarimIsgunSaat { get; set; }

    public double? PtIzin4Tktutar { get; set; }

    public short? PtIzin5Tkgun { get; set; }

    public double? PtIzin5Tksaat { get; set; }

    public short? PtIzin5TkyarimIsgunu { get; set; }

    public double? PtIzin5TkyarimIsgunSaat { get; set; }

    public double? PtIzin5Tktutar { get; set; }

    public short? PtIzin6Tkgun { get; set; }

    public double? PtIzin6Tksaat { get; set; }

    public short? PtIzin6TkyarimIsgunu { get; set; }

    public double? PtIzin6TkyarimIsgunSaat { get; set; }

    public double? PtIzin6Tktutar { get; set; }

    public short? PtIzin7Tkgun { get; set; }

    public double? PtIzin7Tksaat { get; set; }

    public short? PtIzin7TkyarimIsgunu { get; set; }

    public double? PtIzin7TkyarimIsgunSaat { get; set; }

    public double? PtIzin7Tktutar { get; set; }

    public short? PtIzin8Tkgun { get; set; }

    public double? PtIzin8Tksaat { get; set; }

    public short? PtIzin8TkyarimIsgunu { get; set; }

    public double? PtIzin8TkyarimIsgunSaat { get; set; }

    public double? PtIzin8Tktutar { get; set; }

    public short? PtIzin9Tkgun { get; set; }

    public double? PtIzin9Tksaat { get; set; }

    public short? PtIzin9TkyarimIsgunu { get; set; }

    public double? PtIzin9TkyarimIsgunSaat { get; set; }

    public double? PtIzin9Tktutar { get; set; }

    public short? PtIzin10Tkgun { get; set; }

    public double? PtIzin10Tksaat { get; set; }

    public short? PtIzin10TkyarimIsgunu { get; set; }

    public double? PtIzin10TkyarimIsgunSaat { get; set; }

    public double? PtIzin10Tktutar { get; set; }

    public short? PtIzin11Tkgun { get; set; }

    public double? PtIzin11Tksaat { get; set; }

    public short? PtIzin11TkyarimIsgunu { get; set; }

    public double? PtIzin11TkyarimIsgunSaat { get; set; }

    public double? PtIzin11Tktutar { get; set; }

    public short? PtIzin12Tkgun { get; set; }

    public double? PtIzin12Tksaat { get; set; }

    public short? PtIzin12TkyarimIsgunu { get; set; }

    public double? PtIzin12TkyarimIsgunSaat { get; set; }

    public double? PtIzin12Tktutar { get; set; }

    public short? PtIzin13Tkgun { get; set; }

    public double? PtIzin13Tksaat { get; set; }

    public short? PtIzin13TkyarimIsgunu { get; set; }

    public double? PtIzin13TkyarimIsgunSaat { get; set; }

    public double? PtIzin13Tktutar { get; set; }

    public short? PtIzin14Tkgun { get; set; }

    public double? PtIzin14Tksaat { get; set; }

    public short? PtIzin14TkyarimIsgunu { get; set; }

    public double? PtIzin14TkyarimIsgunSaat { get; set; }

    public double? PtIzin14Tktutar { get; set; }

    public short? PtIzin15Tkgun { get; set; }

    public double? PtIzin15Tksaat { get; set; }

    public short? PtIzin15TkyarimIsgunu { get; set; }

    public double? PtIzin15TkyarimIsgunSaat { get; set; }

    public double? PtIzin15Tktutar { get; set; }

    public short? PtIzin16Tkgun { get; set; }

    public double? PtIzin16Tksaat { get; set; }

    public short? PtIzin16TkyarimIsgunu { get; set; }

    public double? PtIzin16TkyarimIsgunSaat { get; set; }

    public double? PtIzin16Tktutar { get; set; }

    public double? PtHayatsigortaIsveren { get; set; }

    public double? PtHayatsigortaCalisan { get; set; }

    public double? PtKanungvindirimi { get; set; }

    public double? PtKanundvindirimi { get; set; }

    public double? PtIsssigisvpayiTesvind { get; set; }

    public bool? PtHazineDestegineTabiFl { get; set; }

    public int? PtHazineDestegiGunu { get; set; }

    public double? PtIlaveAgi { get; set; }

    public double? PtSaatlikIzinSuresi { get; set; }

    public double? PtSaatlikIzinTutari { get; set; }

    public double? PtOtobesTutari { get; set; }

    public double? PtHazinekanunudvindirimi { get; set; }

    public double? PtDigersigortaIsverenEscocuk { get; set; }

    public double? PtMeslekgvmatrahindirimi { get; set; }

    public short? PtSosyrdmgun23 { get; set; }

    public short? PtSosyrdmgun24 { get; set; }

    public short? PtSosyrdmgun25 { get; set; }

    public short? PtSosyrdmgun26 { get; set; }

    public short? PtSosyrdmgun27 { get; set; }

    public short? PtSosyrdmgun28 { get; set; }

    public short? PtSosyrdmgun29 { get; set; }

    public short? PtSosyrdmgun30 { get; set; }

    public short? PtSosyrdmgun31 { get; set; }

    public short? PtSosyrdmgun32 { get; set; }

    public double? PtVergidenmuafodenek { get; set; }

    public byte? Pt7252OrtalamaGun { get; set; }

    public double? PtIsvHisTesvIndGenkan { get; set; }

    public double? PtIsssigisvpayiTesvindGenkan { get; set; }

    public double? PtPerskgtesvikindGenkan { get; set; }

    public double? PtPerisssigtesvikindGenkan { get; set; }

    public short? PtUzaktancalismagunu { get; set; }

    public double? PtUzaktancalismasaati { get; set; }

    public double? PtAsgariucretGvindirimi { get; set; }

    public double? PtAsgariucretDvindirimi { get; set; }
}
