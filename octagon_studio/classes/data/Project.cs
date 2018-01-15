﻿using System;
using System.Collections.Generic;
using Octagon.Workers;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace Octagon
{
    // Class: Project
    public class OMSProject
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public OMSPlatform Platform { get; set; }
        public List<string> Authors { get; set; }
        public List<string> DevFolders { get; set; }

        // Empty constructor
        public OMSProject() {
            Name = null;
            Id = null;
            Platform = null;
            Authors = null;
            DevFolders = null;
        }

        // Full constructor
        public OMSProject(string name, string id, OMSPlatform platform, List<string> authors, List<string> devFolders)
        {
            Name = name;
            Id = id;
            Platform = platform;
            Authors = authors;
            DevFolders = devFolders;
        }

        // Creating new project in some folder
        public void CreateNew(string folder)
        {
            OMSFile.CheckCapacity(folder.Substring(0, 3), (long) 100);

            string octagonDir = folder + @"\.octagon\";
            Directory.CreateDirectory(octagonDir);

            string projectXML = octagonDir + @"\Project.xml";
            OMSXml.CreateXml(projectXML, "Project");

            XDocument projectXMLDoc = XDocument.Load(projectXML);

            XElement inXmlProject = projectXMLDoc.Element("Project");

            inXmlProject.Add(new XElement("Name", Name));
            inXmlProject.Add(new XElement("WorkID", Id));
            inXmlProject.Add(new XElement("Platform", Platform.Type));
            inXmlProject.Add(new XElement("Version", Platform.Version));

            XElement inXmlAuthors = new XElement("Authors");

            for (int i = 0; i < Authors.Count; i++)
            {
                inXmlAuthors.Add(new XElement("Author", Authors[i]));
            }

            inXmlProject.Add(inXmlAuthors);

            inXmlProject.Add(new XAttribute("OctagonVersion", octagon_studio.App.octagon.Version));
            inXmlProject.Add(new XAttribute("OctagonLang", octagon_studio.App.octagon.Lang));

            projectXMLDoc.Save(projectXML);
        }
    }
}
