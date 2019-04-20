using System.IO;

namespace FP.DockerTraining.Secrets.Business
{
public class SecretHelper
    {
        private const string defaultPath = "/run/secrets/";

        public static string GetSecret(string fileName)
        {
            var filePath = Path.Combine(defaultPath, fileName);

#if DEBUG
            filePath = Path.Combine(Directory.GetCurrentDirectory(), fileName);
#endif

            if (File.Exists(filePath))
            {
                return File.ReadAllText(filePath);
            }
            return string.Empty;
        }
    }
}