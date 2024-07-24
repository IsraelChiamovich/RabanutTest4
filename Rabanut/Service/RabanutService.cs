using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using static Rabanut.Configuration.RabanutConfiguration;
using Rabanut.Model;

namespace Rabanut.Service
{
    internal class RabanutService
    {
        public static void CreateXmlIfNotExists()
        {
            if (!File.Exists(rabanutPath))
            {
                XDocument document = new XDocument(new XElement("Queries"));
                document.Save(rabanutPath);
            }
        }

        public static string Rday(string day)
        {
            string dayStr = day switch
            {
                "" => "",
                "ראשון" => "אחד",
                "שני" => "שני",
                "שלישי" => "שלישי",
                "רביעי" => "רביעי",
                "חמישי" => "חמישי",
                "שישי" => "ששי",
            };
            return $"ב{dayStr} בשבת";
        }

        public static string RDaymanth(int dayManth)
        {
            string dayStr;
            if (dayManth < 2)
            {
                dayStr = dayManth switch
                {
                    0 => "",
                    1 => "אחד",
                };
                return $"יום {dayStr}";
            }
            else if (dayManth < 11)
            {
                dayStr = dayManth switch
                {
                    2 => "שני",
                    3 => "שלשה",
                    4 => "ארבעה",
                    5 => "חמשה",
                    6 => "ששה",
                    7 => "שבעה",
                    8 => "שמנה",
                    9 => "תשעה",
                    10 => "עשרה",
                };
                return $"{dayStr} ימים";
            }
            else if (dayManth < 30)
            {
                dayStr = dayManth switch
                {
                    11 => "אחד עשר",
                    12 => "שנים עשר",
                    13 => "שלשה עשר",
                    14 => "ארבעה עשר",
                    15 => "חמשה עשר",
                    16 => "ששה עשר",
                    17 => "שבעה עשר",
                    18 => "שמנה עשר",
                    19 => "תשעה עשר",
                    20 => "עשרים",
                    21 => "אחד ועשרים",
                    22 => "שנים ועשרים",
                    23 => "שלשה ועשרים",
                    24 => "ארבעה ועשרים",
                    25 => "חמשה ועשרים",
                    26 => "ששה ועשרים",
                    27 => "שבעה ועשרים",
                    28 => "שמנה ועשרים",
                    29 => "תשעה ועשרים",
                };
                return $"{dayStr} יום";
            }
            else
            {
                dayStr = "שלשים";

                return $"{dayStr} יום";
            }
        }

        public static string Rmanth(string manth)
        {
            string nextManth = Shloshim(manth);
            return $"לירח {manth} שהוא ראש חודש {nextManth}";
        }

        public static string Shloshim(string manth)
        {
            List<string> listManth = new List<string> { "תשרי", "חשוון", "כסליו", "טבת", "שבט", "אדר הראשון", "אדר השני", "ניסן", "אייר", "סיוון", "תמוז", "אב", "אלול" };
            string nextM = "";
            for (int i = 0; i < listManth.Count; i++)
            {
                if (manth == listManth[i])
                {
                    nextM = listManth[i + 1];
                }
            }
            return nextM;
        }

        public static string Ryear(string year)
        {
            string yearStr = year switch
            {
                "תשפד" => "שמנים וארבע",
                "תשפה" => "שמנים וחמש",
                "תשפו" => "שמנים ושש",
                "תשפז" => "שמנים ושבע",
                "תשפח" => "שמנים ושמנה",
                "תשפט" => "שמנים ותשעה",
                "תשצ" => "תשעים",
                "תשצא" => "תשעים ואחת",
                "תשצב" => "תשעים ושתים",
                "תשצג" => "תשעים ושלשה",
                "תשצד" => "תשעים וארבעה",
            };
            return $"שנת חמשת אלפים ושבע מאות ו{yearStr} לבריאת העולם";
        }

        public static string StrResult(string day, int dayManth, string manth, string year)
        {
            string dayStr = Rday(day);
            string dayManthStr = RDaymanth(dayManth);
            string manthStr = Rmanth(manth);
            string yearStr = Ryear(year);
            return $"{dayStr} {dayManthStr} {manthStr} {yearStr}";
        }

        public static void CreateQuery(string day, int dayManth, string manth, string year)
        {
            CreateXmlIfNotExists();

            string result = StrResult(day, dayManth, manth, year);

            Query query = new Query(day, dayManth, manth, year, result);

            XDocument document = XDocument.Load(rabanutPath);

            XElement? queries = document.Descendants("Queries").FirstOrDefault();

            if (queries == null)
            {
                return;
            }

            XElement newQuery = new XElement("Query",
                new XElement("day", query.Day),
                new XElement("dayManth", query.DayManth),
                new XElement("manth", query.Manth),
                new XElement("year", query.Year),
                new XElement("result", query.Result));

            queries.Add(newQuery);

            document.Save(rabanutPath);
        }
    }
}
