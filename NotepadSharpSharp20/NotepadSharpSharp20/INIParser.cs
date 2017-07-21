using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IniParser;
using IniParser.Model;
using System.IO;
using System.Windows.Forms;

namespace NotepadSharpSharp20
{
    class INIParser
    {
        //Builds the INI file as well as reads from it when needed.
        public static void checkINI()
        {
            // Checks to see if an ini file is present
            // Builds config.ini with default settings if no config is found.
            if (File.Exists("config.ini"))
            {
                Console.WriteLine("Config file found. Using settings from config...");
                readINI();
            }
            else
            {
                Console.WriteLine("No config file found. Generating new config.");
                genINI(Options.fileLocation);
            }
        }

        public static void genINI(string fileLocation)
        {
            //Switch over to Try Catch blocks to see if file exists.
            if (!File.Exists("config.ini"))
            {
                IniData data = new IniData();
                FileIniDataParser parser = new FileIniDataParser();
                Console.WriteLine("No config file found. Creating file...");
                data["General"]["fileLocation"] = fileLocation;
                data["General"]["refreshRate"] = "5000";
                data.Sections.GetSectionData("General").Keys.GetKeyData("fileLocation").Comments.Add("Last file location used. Default is blank.");
                data.Sections.GetSectionData("General").Keys.GetKeyData("refreshRate").Comments.Add("Time in ms between refresh times of the notepad.");

                parser.WriteFile("config.ini", data);
            }
        }

        public static void readINI()
        {
            if (File.Exists("config.ini"))
            {
                IniData data = new IniData();
                FileIniDataParser parser = new FileIniDataParser();
                string fileLocation;

                data = parser.ReadFile("config.ini");
                fileLocation = data["General"]["fileLocation"];
                if (!String.IsNullOrWhiteSpace(fileLocation))
                {
                    Console.WriteLine("Config file found with fileLocation previously set. Launching notepad.");
                    //Launcher.forms[1].Show();
                }
                else
                {
                    Console.WriteLine("Error with config file. fileLocation key may be blank, or config.ini was recently generated but not modified.");
                }
            }
        }

        public static void editINI(string fileLocation)
        {
            IniData modifiedIniData = new IniData();
            FileIniDataParser parser = new FileIniDataParser();
            modifiedIniData = parser.ReadFile("config.ini");
            modifiedIniData["General"]["fileLocation"] = fileLocation;

            parser.WriteFile("config.ini", modifiedIniData);
        }
    }
}
