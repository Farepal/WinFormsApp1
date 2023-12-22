using Google.Apis.Drive.v3;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using MongoDB.Driver;
using System.Drawing.Text;
using System.Reflection.Metadata;

namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            {
                var Singleton1 = MongoDBContext.Instance;
                var Singleton2 = AppConfig.Instance;
                var Singleton3 = TeachersCollection.Instance;
                var Singleton4 = StudentsCollection.Instance;
                var Singleon5 = GoogleDriveConnector.Instance;
            }

            // penting
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}

// Arial Rounded MT Bold; 10,8pt
// InactiveCaption
// 26; 26; 26
// 100; 154; 255

// Form1 form login
// Form2 form register
// Form3 form all teacher
// Form4 form profile teacher
// form5 form update profile teacher
// form6 form profile student
// form7 form update profile student
// form8 form all student
// form9 form order teacher
// form10 form student order status
// form11 form mata pelajaran
// form12 form teacher untuk melihat siapa yang order dia sekaligus home
