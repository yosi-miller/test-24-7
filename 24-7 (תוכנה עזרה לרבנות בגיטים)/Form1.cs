using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace _24_7__תוכנה_עזרה_לרבנות_בגיטים_
{
    public partial class Form1 : Form
    {
        // מה שנמצא על רמי הדייג על החכה
        XmlDocument xmlDocument;
        // נתיב לקובץ המקומי
        string pathName = Directory.GetCurrentDirectory() + "\\quriesData.xml";
        public Form1()
        {
            InitializeComponent();
            xmlDocument = new XmlDocument();

            // check if the file is created
            if (File.Exists(pathName))
            {
                // if the file is created load the xml file
                try
                {
                    // open the xml file
                    xmlDocument.Load(pathName);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading XML file " + ex.Message);
                }
            }
            else
            {
                XmlNode root = xmlDocument.CreateElement("Quries");

                xmlDocument.AppendChild(root);
                xmlDocument.Save(pathName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string result;
            string dayWeak = dayOfWeak(cbmDayOfWeak.Text);
            string dayMonth = dayOfMonth(cbmDayOfMonth.Text, cbmMonth.Text);
            string month = month1(cbmMonth.Text);
            string year = year1(cbmYear.Text);


            if (cbmDayOfMonth.Text == "30")
            {
                result = dayWeak + dayMonth + year;
            }
            else 
            { 
                result = dayWeak + dayMonth + month + year; 
            }

            XmlNode query = xmlDocument.CreateElement("Query");

            query.AppendChild(xmlDocument.CreateElement("Day")).InnerText = cbmDayOfWeak.Text;
            query.AppendChild(xmlDocument.CreateElement("DayMonth")).InnerText = cbmDayOfMonth.Text;
            query.AppendChild(xmlDocument.CreateElement("Month")).InnerText = cbmMonth.Text;
            query.AppendChild(xmlDocument.CreateElement("Year")).InnerText = cbmYear.Text;
            query.AppendChild(xmlDocument.CreateElement("Result")).InnerText = dayWeak + dayMonth + month + year;
            xmlDocument.FirstChild.AppendChild(query);
            xmlDocument.Save(pathName);
            MessageBox.Show("נוסף בהצלחה");
            lblResult.Text = result;
        }

        private string dayOfWeak(string dayWeak)
        {
            string result = "";

            switch (dayWeak)
            {
                case "ראשון":
                    result = " באחד בשבת";
                    break;
                case "שני":
                    result = " בשני בשבת";
                    break;
                case "שלישי":
                    result = "בשלישי בשבת ";
                    break;
                case "רביעי":
                    result = " ברביעי בשבת";
                    break;
                case "חמישי":
                    result = " בחמישי בשבת";
                    break;
                case "ששי":
                    result = " בששי בשבת";
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }

        private string dayOfMonth(string dayMonth, string month)
        {
            string result = "";

            switch (dayMonth)
            {
                case "1":
                    result = " יום אחד לירח";
                    break;
                case "2":
                    result = " שני ימים לירח";
                    break;
                case "3":
                    result = " שלשה ימים לירח";
                    break;
                case "4":
                    result = " ארבעה ימים לירח";
                    break;
                case "5":
                    result = " חמשה ימים לירח";
                    break;
                case "6":
                    result = " ששה ימים לירח";
                    break;
                case "7":
                    result = " שבעה ימים לירח";
                    break;
                case "8":
                    result = " שמנה ימים לירח";
                    break;
                case "9":
                    result = " תשעה ימים לירח";
                    break;
                case "10":
                    result = "עשרה ימים לירח ";
                    break;
                case "11":
                    result = " אחד עשר יום לירח";
                    break;
                case "12":
                    result = " שנים עשר יום לירח";
                    break;
                case "13":
                    result = " שלשה עשר יום לירח";
                    break;
                case "14":
                    result = " ארבעה עשר יום לירח";
                    break;
                case "15":
                    result = " חמשה עשר יום לירח";
                    break;
                case "16":
                    result = " ששה עשר יום לירח";
                    break;
                case "17":
                    result = " שבעה עשר יום לירח";
                    break;
                case "18":
                    result = "שמנה עשר יום לירח ";
                    break;
                case "19":
                    result = " תשעה עשר יום לירח";
                    break;
                case "20":
                    result = "עשרים יום לירח ";
                    break;
                case "21":
                    result = "אחד ועשרים יום לירח";
                    break;
                case "22":
                    result = " שנים ועשרים יום לירח";
                    break;
                case "23":
                    result = " שלשה ועשרים יום לירח";
                    break;
                case "24":
                    result = " ארבעה ועשרים יום לירח";
                    break;
                case "25":
                    result = " חמשה ועשרים יום לירח";
                    break;
                case "26":
                    result = " ששה ועשרים יום לירח";
                    break;
                case "27":
                    result = " שבעה ועשרים יום לירח";
                    break;
                case "28":
                    result = " שמנה ועשרים יום לירח";
                    break;
                case "29":
                    result = " תשעה ועשרים יום לירח";
                    break;
                case "30":
                    switch (month)
                    {
                        case "תשרי":
                            result = "יום שלשים לחודש תשרי שהוא ראש חודש מרחשון ";
                            break;
                        case "מרחשון":
                            result = " יום שלשים לחודש מרחשון שהוא ראש חודש כסלו";
                            break;
                        case "כסלו":
                            result = " יום שלשים לחודש כסלו שהוא ראש חודש טבת";
                            break;
                        case "טבת":
                            result = " יום שלשים לחודש טבת שהוא ראש חודש שבט";
                            break;
                        case "שבט":
                            result = " יום שלשים לחודש טבת שהוא ראש חודש אדר";
                            break;
                        case "אדר":
                            result = " יום שלשים לחודש אדר שהוא ראש חודש ניסן";
                            break;
                        case "אדר א":
                            result = " יום שלשים לחודש אדר הראשון שהוא ראש חודש אדר השני";
                            break;
                        case "אדר ב":
                            result = " יום שלשים לחודש אדר השני שהוא ראש חודש ניסן";
                            break;
                        case "ניסן":
                            result = " יום שלשים לחודש ניסן שהוא ראש חודש אייר";
                            break;
                        case "אייר":
                            result = "יום שלשים לחודש אייר שהוא ראש חודש סיון ";
                            break;
                        case "סיון":
                            result = " יום שלשים לחודש סיון שהוא ראש חודש תמוז";
                            break;
                        case "תמוז":
                            result = " יום שלשים לחודש תמוז שהוא ראש חודש אב";
                            break;
                        case "אב":
                            result = " יום שלשים לחודש אב שהוא ראש חודש אלול";
                            break;
                        case "אלול":
                            result = " יום שלשים לחודש אלול שהוא ראש חודש תשרי";
                            break;
                        default:
                            result = "";
                            break;
                    }
                    break;
                default:
                    result = "";
                    break;

            }
            return result;
        }

        private string month1(string month)
        {
            string result = "";

            switch (month)
            {
                case "תשרי":
                    result = "תשרי ";
                    break;
                case "מרחשון":
                    result = " מרחשון";
                    break;
                case "כסלו":
                    result = " כסלו";
                    break;
                case "טבת":
                    result = " טבת";
                    break;
                case "שבט":
                    result = " שבט";
                    break;
                case "אדר":
                    result = " אדר";
                    break;
                case "אדר א":
                    result = " אדר הראשון";
                    break;
                case "אדר ב":
                    result = " אדר השני";
                    break;
                case "ניסן":
                    result = "ניסן ";
                    break;
                case "אייר":
                    result = " אייר";
                    break;
                case "סיון":
                    result = " סיון";
                    break;
                case "תמוז":
                    result = " תמוז";
                    break;
                case "אב":
                    result = " אב";
                    break;
                case "אלול":
                    result = "אלול";
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }
        private string year1(string year)
        {
            string result = "";
            switch (year)
            {
                case "תשפ\"ד":
                    result = " בשנת חמשת אלפים ושבע מאות ושמונים וארבע לבריאת העולם";
                    break;
                case "תשפ\"ה":
                    result = " בשנת חמשת אלפים ושבע מאות ושמונים וחמש לבריאת העולם";
                    break;
                case "תשפ\"ו":
                    result = " בשנת חמשת אלפים ושבע מאות ושמונים ושש לבריאת העולם";
                    break;
                case "תשפ\"ז":
                    result = " בשנת חמשת אלפים ושבע מאות ושמונים ושבע לבריאת העולם";
                    break;
                case "תשפ\"ח":
                    result = " בשנת חמשת אלפים ושבע מאות ושמונים ושמנה לבריאת העולם";
                    break;
                case "תשפ\"ט":
                    result = " בשנת חמשת אלפים ושבע מאות ושמונים ותשע לבריאת העולם";
                    break;
                case "תש\"צ":
                    result = "בשנת חמשת אלפים ושבע מאות ותשעים לבריאת העולם ";
                    break;
                case "תשצ\"א":
                    result = "בשנת חמשת אלפים ושבע מאות ותשעים ואחת לבריאת העולם ";
                    break;
                case "תשצ\"ב":
                    result = " בשנת חמשת אלפים ושבע מאות ותשעים ושנים לבריאת העולם";
                    break;
                case "תשצ\"ג":
                    result = " בשנת חמשת אלפים ושבע מאות ותשעים ושלש לבריאת העולם";
                    break;
                default:
                    result = "";
                    break;
            }
            return result;
        }
    }
}
