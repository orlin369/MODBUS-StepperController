using System.Xml.Serialization;
using System.IO;

namespace StepperControl.Commands
{
    /// <summary>
    /// Serialize command lists and store it to the files.
    /// </summary>
    static class CommandsStore
    {

        /// <summary>
        /// Save commmands to XML.
        /// </summary>
        /// <remarks>
        /// @"c:\temp\SerializationOverview.xml"
        /// </remarks>
        /// <param name="commands">Commands</param>
        /// <param name="path">File</param>
        public static void Save(MotionCommands commands, string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(MotionCommands));
            StreamWriter file = new System.IO.StreamWriter(path);
            writer.Serialize(file, commands);
            file.Close();
        }

        /// <summary>
        /// Read commands from XML.
        /// </summary>
        /// <remarks>@"c:\temp\SerializationOverview.xml"</remarks>
        /// <param name="path">File</param>
        /// <returns>Commands</returns>
        public static MotionCommands Load(string path)
        {
            XmlSerializer reader = new XmlSerializer(typeof(MotionCommands));
            MotionCommands commands = new MotionCommands();
            StreamReader file = new StreamReader(path);
            commands = (MotionCommands)reader.Deserialize(file);
            file.Close();

            return commands;
        }

    }
}
