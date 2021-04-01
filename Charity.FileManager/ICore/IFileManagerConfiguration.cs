using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.FileManager.ICore
{
    public interface IFileManagerConfiguration
    {
        string Container { get; set; }
        string HostingPath { set; get; }

        string ServerUrl { set; get; }
    }
}
