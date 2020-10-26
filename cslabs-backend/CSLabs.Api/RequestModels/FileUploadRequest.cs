using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace CSLabs.Api.RequestModels
{
    public class FileUploadRequest
    {
        public IFormFile File { get; set; }
        [Required]
        [MinLength(3)]
        public string Name { get; set; }
    }
}