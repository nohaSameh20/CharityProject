using CharityProject.FileManager.ICore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using CharityProject.FileManager.Core;

namespace CharityProject.FileManager.Core
{
    public class FileManagerService : IFileManagerService
    {

        private IFileManagerConfiguration configuration;
        public FileManagerService(IFileManagerConfiguration config)
        {
            this.configuration = config;
        }
        public bool CreateDirectory(string path)
        {
            string pathOfDirec = configuration.Container + path;

            if (!Directory.Exists(pathOfDirec))
            {
                Directory.CreateDirectory(pathOfDirec);
                return true;
            }
            else
                return false;
        }

        public bool DeleteDirectory(string path)
        {
            string pathOfDirec = configuration.Container + path;

            if (Directory.Exists(path))
            {
                Directory.Delete(path);
                return true;
            }
            return false;
        }

        public bool DeleteFile(string path)
        {
            try
            {
                File.Delete(configuration.Container + path);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteFolder(string path)
        {
            string pathOfDirec = configuration.Container + path;

            if (Directory.Exists(pathOfDirec))
            {
                Directory.Delete(pathOfDirec, true);
                return true;
            }
            return false;
        }

        public bool FileExist(string path)
        {
            string pathOfDirec = configuration.Container + path;

            bool res = File.Exists(pathOfDirec);

            return res;
        }

        public string GetPath(string path)
        {
            string res = null;

            if (!string.IsNullOrWhiteSpace(path))
                res = configuration.HostingPath + configuration.Container + path;

            return res;
        }

        public string ResizeAndSaveImage(string pathContainName, ImageType type, int maxWeightInKB, int maxHeight, int maxWidth, byte[] imageByte, long compressionRete = 100)
        {
            throw new NotImplementedException();
        }

        public string UploadImage(string pathContainName, byte[] imageByte)
        {
            try
            {
                string savePath = $"{configuration.Container}{pathContainName}";

                File.WriteAllBytes(savePath, imageByte);

                string res = null;
                if (FileExist(pathContainName))
                    res = configuration.ServerUrl + savePath;

                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public string UploadImage(string name, string extension, string image, string path)
        {
            StringBuilder fullName = new StringBuilder(200);
            if (!string.IsNullOrWhiteSpace(path))
                fullName.Append($"{path}/");

            string newPath = fullName.Append($"{name}{extension}").ToString();
            File.WriteAllBytes(configuration.Container + newPath, Convert.FromBase64String(image));

            return newPath;
        }
        public string UploadImg(string name, string extension, string image, string path)
        {
            StringBuilder fullName = new StringBuilder(200);
            if (!string.IsNullOrWhiteSpace(path))
                fullName.Append($"{path}/");

            string newPath = fullName.Append($"{name}.{extension}").ToString();
            File.WriteAllBytes(configuration.Container + newPath, Convert.FromBase64String(image));

            return newPath;
        }

    }
}
