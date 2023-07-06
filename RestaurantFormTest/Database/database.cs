using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantFormTest.Tables;
using RestaurantFormTest.Menu;
using System.Xml.Serialization;
using System.IO;

namespace RestaurantFormTest.Database
{
    class database
    {
        public database()
        {
            if (instance == null)
                instance = this;
        }

        public static database instance;

        public List<db_menu> menus = new List<db_menu>();
        public List<db_table> tables = new List<db_table>();

        #region Save operations
        public void SaveTables()
        {
            WriteToXmlFile(Properties.Settings.Default.Save_location + "/tables.xml", tables);
            Console.WriteLine("Tables saved!");
        }

        public void SaveMenus()
        {
            WriteToXmlFile(Properties.Settings.Default.Save_location + "/menus.xml", menus);
            Console.WriteLine("Menus saved!");
        }
        #endregion
        #region Load operations
        public db_table[] LoadTables()
        {
            if (System.IO.File.Exists(Properties.Settings.Default.Save_location + "/tables.xml"))
            {
                tables = ReadFromXmlFile<List<db_table>>(Properties.Settings.Default.Save_location + "/tables.xml");
                return tables.ToArray();
            }
            else
                return null;
        }

        public db_menu[] LoadMenus()
        {
            if (System.IO.File.Exists(Properties.Settings.Default.Save_location + "/menus.xml"))
            {
                menus = ReadFromXmlFile<List<db_menu>>(Properties.Settings.Default.Save_location + "/menus.xml");
                return menus.ToArray();
            }
            else
                return null;
        }
        #endregion

        /// <summary>
        /// Writes the given object instance to an XML file.
        /// <para>Only Public properties and variables will be written to the file. These can be any type though, even other classes.</para>
        /// <para>If there are public properties/variables that you do not want written to the file, decorate them with the [XmlIgnore] attribute.</para>
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object being written to the file.</typeparam>
        /// <param name="filePath">The file path to write the object instance to.</param>
        /// <param name="objectToWrite">The object instance to write to the file.</param>
        /// <param name="append">If false the file will be overwritten if it already exists. If true the contents will be appended to the file.</param>
        public static void WriteToXmlFile<T>(string filePath, T objectToWrite, bool append = false) where T : new()
        {
            TextWriter writer = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                writer = new StreamWriter(filePath, append);
                serializer.Serialize(writer, objectToWrite);
            }
            finally
            {
                if (writer != null)
                    writer.Close();
            }
        }

        /// <summary>
        /// Reads an object instance from an XML file.
        /// <para>Object type must have a parameterless constructor.</para>
        /// </summary>
        /// <typeparam name="T">The type of object to read from the file.</typeparam>
        /// <param name="filePath">The file path to read the object instance from.</param>
        /// <returns>Returns a new instance of the object read from the XML file.</returns>
        public static T ReadFromXmlFile<T>(string filePath) where T : new()
        {
            TextReader reader = null;
            try
            {
                var serializer = new XmlSerializer(typeof(T));
                reader = new StreamReader(filePath);
                return (T)serializer.Deserialize(reader);
            }
            finally
            {
                if (reader != null)
                    reader.Close();
            }
        }

    }
}
