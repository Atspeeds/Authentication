using _01_Framework.Application;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;

namespace ServiceHost
{
    public class FileUplouder : IFileUploader
    {
        private readonly IWebHostEnvironment _webHostEnvironment;

        public FileUplouder(IWebHostEnvironment contextAccessor)
        {
            _webHostEnvironment = contextAccessor;
        }

        public string Upload(IFormFile file, string path)
        {

            if (file == null) return null;
            var pathDirectory = $"{_webHostEnvironment.WebRootPath}//Picturesapp//{path}";

            if (!Directory.Exists(pathDirectory))
                Directory.CreateDirectory(pathDirectory);

            var filename = $"{DateTime.Now.ToFileName()}-{file.FileName}";

            var filepath = $"{pathDirectory}///{filename}";

            using var output = System.IO.File.Create(filepath);
            file.CopyTo(output);

            return $"{path}/{filename}";
        }
    }

}