using System.Text.RegularExpressions;

namespace DS_Game_Maker
{
    public static class Program
    {
        public static GlobalFormsClass Forms;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            ApplicationConfiguration.Initialize();

            Forms = new GlobalFormsClass();
            Forms.Initialize(args);

            
            Application.ThreadException += (sender, e) =>
            {
                Exception ex = e.Exception;

                string logPath = "crash_intercepted_log.txt";

            // 1. Get the raw string representations
            string fullDetails = ex.ToString();
            string stackTrace = ex.StackTrace ?? "No stack trace available.";

            // 2. Define the pattern to find your local dev path
            // This matches everything from the start of a path up to 'dsgamemaker_csharp\'
            string pathPattern = @"[a-zA-Z]:\\.*\\dsgamemaker_csharp\\";
            string replacement = @"<ProjectRoot>\";

            // 3. Clean both strings
            string cleanDetails = Regex.Replace(fullDetails, pathPattern, replacement, RegexOptions.IgnoreCase);
            string cleanStackTrace = Regex.Replace(stackTrace, pathPattern, replacement, RegexOptions.IgnoreCase);

            // 4. Remove the annoying build artifacts noise (Debug/x64/etc)
            cleanDetails = cleanDetails.Replace(@"bin\x64\Debug\", "").Replace(@"bin\Release\", "");
            cleanStackTrace = cleanStackTrace.Replace(@"bin\x64\Debug\", "").Replace(@"bin\Release\", "");


                string errorReport = $@"
===========================================================
CRASH INTERCEPTED - {DateTime.Now}
===========================================================
Message: {ex.Message}

Full Details:
{ex.ToString()} 

Stack Trace:
{ex.StackTrace}
===========================================================";

                File.AppendAllText(Constants.AppDirectory +  logPath, errorReport);
            };

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.Run(Forms.main_Form);
        }
    }
}