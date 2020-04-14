using IVT.Objects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace IVT.Xml
{
    public static class XmlEditor
    {
        public static Dictionary<string, Verb> ReadDictionnaryInFile(string path)
        {
            try
            {
                Dictionary<string, Verb> dict = new Dictionary<string, Verb>();

                XmlDocument doc = new XmlDocument();
                doc.Load(path);

                foreach (XmlNode node in doc.DocumentElement.SelectSingleNode("//verbs"))
                {
                    if (node.Attributes == null || node.Attributes.Count != 1)
                    {
                        continue;
                    }

                    Verb nodeVerb = new Verb(node.Attributes["infinitive"].Value.ToString(),
                        node["preterit"].InnerText,
                        node["presentPerfect"].InnerText,
                        node["translation"].InnerText);

                    dict.Add(nodeVerb.Infinitive, nodeVerb);
                }

                return dict;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while attempting to read the file." + Environment.NewLine + "Details: " + ex.Message,
                    "File reading error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        public static bool SaveDictionaryInFile(Dictionary<string, Verb> dict, string path)
        {
            try
            {
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                StringBuilder stringBuilder = new StringBuilder();

                var settings = new XmlWriterSettings()
                {
                    Indent = true,
                    NewLineOnAttributes = true,
                    ConformanceLevel = ConformanceLevel.Auto,
                    Encoding = Encoding.UTF8
                };
                using (XmlWriter writer = XmlWriter.Create(stringBuilder, settings))
                {
                    writer.WriteStartDocument();

                    writer.WriteStartElement("verbs");

                    foreach (KeyValuePair<string, Verb> entry in dict)
                    {
                        // Create the start element
                        writer.WriteStartElement("verb");
                        writer.WriteAttributeString("infinitive", entry.Value.Infinitive);

                        // Create elements
                        writer.WriteElementString("preterit", entry.Value.Preterit);

                        writer.WriteElementString("presentPerfect", entry.Value.PresentPerfect);

                        writer.WriteElementString("translation", entry.Value.Translation);

                        // Close element
                        writer.WriteEndElement();
                    }

                    writer.WriteEndDocument();
                    writer.Flush();
                }

                stringBuilder.Replace("<?xml version=\"1.0\" encoding=\"utf-16\"?>", "<?xml version=\"1.0\" encoding=\"utf-8\"?>");

                using (StreamWriter sr = new StreamWriter(path))
                {
                    sr.WriteLine(stringBuilder);
                }

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured while attempting to save the file." + Environment.NewLine + "Details: " + ex.Message,
                    "File saving error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}