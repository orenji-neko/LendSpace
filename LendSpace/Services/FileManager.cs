using Microsoft.AspNetCore.Components.Forms;

namespace LendSpace.Services
{
    public class FileManager
    {
        private readonly IWebHostEnvironment _environment;

        public FileManager(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        /// <summary>
        /// Saves files to the server and returns a list of saved file names.
        /// </summary>
        public async Task<List<string>> UploadFiles(IEnumerable<IBrowserFile> files)
        {
            var fileNames = new List<string>();

            // Use WebRootPath to point directly to wwwroot.
            var uploadsFolder = Path.Combine(_environment.WebRootPath, "uploads");

            // Ensure the uploads folder exists.
            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }

            foreach (var file in files)
            {
                try
                {
                    var filePath = Path.Combine(uploadsFolder, file.Name);

                    await using (var fs = new FileStream(filePath, FileMode.Create))
                    {
                        await file.OpenReadStream(file.Size).CopyToAsync(fs);
                    }
                    fileNames.Add(file.Name);
                }
                catch (Exception ex)
                {

                }
            }

            return fileNames;
        }
    }
}