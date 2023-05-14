using Microsoft.AspNetCore.Http;

namespace _01_Framework.Application
{
    public interface IFileUploader
    {
        string Upload(IFormFile form,string path);
    }
}
