using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Charity.Persistence.Models
{
    public class ConstData
    {
        public List<CountrySD> COUNTRIES
        {
            get
            {
                {
                    var countries = new List<CountrySD>();
                    countries.Add(new CountrySD("eg", "20", "Egypt", "مصر", "Egyption", "مصري") { InScope = true });
                    countries.Add(new CountrySD("ae", "971", "United Arab Emirates (UAE)", "الإمارات العربية المتحدة", "Emirati", "إماراتي"));
                    countries.Add(new CountrySD("lb", "961", "Lebanon", "لبنان", "Lebanese", "لبناني"));
                    countries.Add(new CountrySD("us", "1", "United States", "الولايات المتحدة الأمريكية", "American", "أمريكي"));
                    countries.Add(new CountrySD("de", "49", "Germany", "ألمانيا", "German", "ألماني"));
                    countries.Add(new CountrySD("cn", "86", "China", "الصين", "Chinese", "صينى"));
                    countries.Add(new CountrySD("br", "55", "Brazil", "البرازيل", "Brazilian", "برازيلي"));
                    countries.Add(new CountrySD("ye", "967", "Yemen", "اليمن", "Yemeni", "يمني"));
                    countries.Add(new CountrySD("za", "27", "South Africa", "جنوب أفريقيا", "African", "افريقي"));
                    countries.Add(new CountrySD("ca", "1", "Canada", "كندا", "Canadian", "كندي"));
                    countries.Add(new CountrySD("it", "39", "Italy", "إيطاليا", "Italian", "إيطالي"));
                    countries.Add(new CountrySD("jm", "1", "Jamaica", "جامايكا", "Jamaican", "جامايكي"));
                    countries.Add(new CountrySD("jo", "962", "Jordan", "الأردن", "Jordanian", "أردني"));
                    countries.Add(new CountrySD("at", "43", "Austria", "النمسا", "Austrian", "نمساوي"));
                    countries.Add(new CountrySD("au", "61", "Australia", "أستراليا", "Australian", "أسترالي"));
                    countries.Add(new CountrySD("om", "968", "Oman", "سلطنة عمان", "Omani", "عماني"));
                    countries.Add(new CountrySD("dk", "45", "Denmark", "الدنمارك", "Danish", "دانماركي"));
                    countries.Add(new CountrySD("fr", "33", "France", "فرنسا", "French", "فرنسي"));
                    countries.Add(new CountrySD("jp", "81", "Japan", "اليابان", "Japanese", "ياباني"));
                    countries.Add(new CountrySD("gb", "44", "United Kingdom", "المملكة المتحدة", "British", "بريطاني"));
                    countries.Add(new CountrySD("es", "34", "Spain", "إسبانيا", "Spanish", "أسباني"));
                    countries.Add(new CountrySD("tr", "90", "Turkey", "تركيا", "Turkish", "تركي"));
                    countries.Add(new CountrySD("ru", "7", "Russia", "روسيا", "Russian", "روسي"));
                    countries.Add(new CountrySD("sa", "966", "Saudi Arabia", "المملكة العربية السعودية", "Saudi", "سعودي"));
                    countries.Add(new CountrySD("my", "60", "Malaysia", "ماليزيا", "Malaysian", "ماليزي"));
                    countries.Add(new CountrySD("ua", "380", "Ukraine", "أوكرانيا", "Ukrainian", "أوكراني"));
                    countries.Add(new CountrySD("th", "66", "Thailand", "تايلاند", "Thai", "تايلاندي"));
                    countries.Add(new CountrySD("in", "91", "India", "الهند", "Indian", "هندي"));
                    countries.Add(new CountrySD("se", "46", "Sweden", "السويد", "Swedish", "سويدي"));
                    countries.Add(new CountrySD("sd", "249", "Sudan", "السودان", "Sudanese", "سوداني"));
                    countries.Add(new CountrySD("ly", "218", "Libya", "ليبيا", "Libyan", "ليبي"));
                    countries.Add(new CountrySD("ps", "970", "Palestine", "فلسطين", "Palestinian", "فلسطيني"));
                    countries.Add(new CountrySD("aw", "297", "Aruba", "أروبا", "Dutch", "هولندي"));
                    countries.Add(new CountrySD("bh", "973", "Bahrain", "البحرين", "Bahraini", "بحريني"));
                    countries.Add(new CountrySD("qa", "974", "Qatar", "دولة قطر", "Qatari", "قطري"));
                    countries.Add(new CountrySD("kw", "965", "Kuwait", "الكويت", "Kuwaiti", "كويتي"));
                    countries.Add(new CountrySD("ma", "212", "Morocco", "المغرب", "Moroccan", "مغربي"));
                    countries.Add(new CountrySD("tn", "216", "Tunisia", "تونس", "Tunisian", "تونسي"));
                    countries.Add(new CountrySD("sy", "963", "Syria", "سوريا", "Syrian", "سوري"));
                    countries.Add(new CountrySD("iq", "964", "Iraq", "العراق", "Iraqi", "عراقي"));
                    countries.Add(new CountrySD("mr", "222", "Mauritania", "موريتانيا", "Mauritanian", "موريتاني"));
                    countries.Add(new CountrySD("so", "252", "Somalia", "الصومال", "Somali", "صومالي"));
                    countries.Add(new CountrySD("dj", "253", "Djibouti", "جيبوتي", "Djiboutian", "جيبوتي"));

 

                    countries = countries.OrderBy(obj => obj.Name).ToList();
                    return countries;
                }
            }
        }
        public List<KeyValuePair<string, string>> EGYPTCITIES => new List<KeyValuePair<string, string>>()
           {
               new KeyValuePair<string, string>("Cairo","القاهرة"),
               new KeyValuePair<string, string>("Giza","الجيزة"),
               new KeyValuePair<string, string>("Alexandria","الأسكندرية"),
               new KeyValuePair<string, string>("Dakahlia","الدقهلية"),
               new KeyValuePair<string, string>("Red Sea","البحر الأحمر"),
               new KeyValuePair<string, string>("Beheira","البحيرة"),
               new KeyValuePair<string, string>("Fayoum","الفيوم"),
               new KeyValuePair<string, string>("Gharbiya","الغربية"),
               new KeyValuePair<string, string>("Ismailia","الإسماعلية"),
               new KeyValuePair<string, string>("Monofia","المنوفية"),
               new KeyValuePair<string, string>("Minya","المنيا"),
               new KeyValuePair<string, string>("Qaliubiya","القليوبية"),
               new KeyValuePair<string, string>("New Valley","الوادي الجديد"),
               new KeyValuePair<string, string>("Suez","السويس"),
               new KeyValuePair<string, string>("Aswan","اسوان"),
               new KeyValuePair<string, string>("Assiut","اسيوط"),
               new KeyValuePair<string, string>("Beni Suef","بني سويف"),
               new KeyValuePair<string, string>("Port Said","بورسعيد"),
               new KeyValuePair<string, string>("Damietta","دمياط"),
               new KeyValuePair<string, string>("Sharkia","الشرقية"),
               new KeyValuePair<string, string>("South Sinai","جنوب سيناء"),
               new KeyValuePair<string, string>("Kafr Al sheikh","كفر الشيخ"),
               new KeyValuePair<string, string>("Matrouh","مطروح"),
               new KeyValuePair<string, string>("Luxor","الأقصر"),
               new KeyValuePair<string, string>("Qena","قنا"),
               new KeyValuePair<string, string>("North Sinai","شمال سيناء"),
               new KeyValuePair<string, string>("Sohag","سوهاج"),
           };
         

    }
}
