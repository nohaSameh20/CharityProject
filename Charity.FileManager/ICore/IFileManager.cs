using CharityProject.FileManager.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace CharityProject.FileManager.ICore
{
    public interface IFileManagerService
    {
        bool DeleteFile(string path);

        bool CreateDirectory(string path);
        bool DeleteDirectory(string path);
        bool DeleteFolder(string path);

        bool FileExist(string path);
        string GetPath(string path);
        string UploadImage(string pathContainName, byte[] imageByte);
        string UploadImage(string name, string extension, string image, string path = null);
        string ResizeAndSaveImage(string pathContainName, ImageType type, int maxWeightInKB, int maxHeight, int maxWidth, Byte[] imageByte, long compressionRete = 100L);
    }
}
