using Google.Apis.Auth.OAuth2;
using Google.Apis.Auth.OAuth2.Flows;
using Google.Apis.Auth.OAuth2.Responses;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.Drive.v3.Data;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public sealed class GoogleDriveConnector
    {
        private static readonly GoogleDriveConnector instance = new GoogleDriveConnector();
        private DriveService service;

        private GoogleDriveConnector()
        {
            // Ganti dengan nilai yang sesuai dengan kredensial Anda
            Initialize();
        }

        private void Initialize()
        {
            string ClientId = AppConfig.Instance.GetSetting("GDRIVE:GOOGLE_CLIENTID");
            string ClienSecret = AppConfig.Instance.GetSetting("GDRIVE:GOOGLE_CLIENT_SECRET");
            string RefreshToken = AppConfig.Instance.GetSetting("GDRIVE:GOOGLE_REFRESH_TOKEN");
            string AccessToken = AppConfig.Instance.GetSetting("GDRIVE:GOGLE_ACCESS_TOKEN");

            var tokenResponse = new TokenResponse
            {
                AccessToken = AccessToken,
                RefreshToken = RefreshToken
            };

            var applicationName = "Lustrum DTETI XII 2023";
            var username = "muhamadfarreladrian@mail.ugm.ac.id";

            var credential = GetCredentials(applicationName, tokenResponse, username);

            service = new DriveService(new BaseClientService.Initializer
            {
                HttpClientInitializer = credential,
                ApplicationName = applicationName
            });
        }

        private UserCredential GetCredentials(string applicationName, TokenResponse tokenResponse, string username)
        {
            string ClientId = AppConfig.Instance.GetSetting("GDRIVE:GOOGLE_CLIENTID");
            string ClientSecret = AppConfig.Instance.GetSetting("GDRIVE:GOOGLE_CLIENT_SECRET");

            var clientSecrets = new ClientSecrets
            {
                ClientId = ClientId,
                ClientSecret = ClientSecret
            };

            var apiCodeFlow = new GoogleAuthorizationCodeFlow(new GoogleAuthorizationCodeFlow.Initializer
            {
                ClientSecrets = clientSecrets,
                Scopes = new[] { DriveService.Scope.Drive },
                DataStore = new FileDataStore(applicationName)
            });

            var credential = new UserCredential(apiCodeFlow, username, tokenResponse);

            return credential;
        }

        public string UploadFile(string filePath, string fileNameOnDrive)
        {
            string folderId = "1FpD-C0Al7OIP1Cf1HwHt4aGoOx_WewwY";
            string fileMime = GetMimeType(filePath);

            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                var driveFile = new Google.Apis.Drive.v3.Data.File
                {
                    Name = fileNameOnDrive,
                    MimeType = fileMime,
                    Parents = new[] { folderId }
                };

                var request = service.Files.Create(driveFile, fileStream, fileMime);
                request.Fields = "id";

                try
                {
                    var response = request.Upload();
                    if (response.Status != Google.Apis.Upload.UploadStatus.Completed)
                        throw response.Exception;

                    var permission = new Google.Apis.Drive.v3.Data.Permission
                    {
                        Type = "anyone",
                        Role = "reader"
                    };

                    service.Permissions.Create(permission, request.ResponseBody.Id).Execute();

                    return request.ResponseBody.Id;
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            }
        }

        public static GoogleDriveConnector Instance
        {
            get
            {
                return instance;
            }
        }

        public DriveService Service
        {
            get
            {
                return service;
            }
        }

        private string GetMimeType(string filePath)
        {
            string mimeType;
            switch (Path.GetExtension(filePath).ToLower())
            {
                case ".jpg":
                case ".jpeg":
                    mimeType = "image/jpeg";
                    break;
                case ".png":
                    mimeType = "image/png";
                    break;
                default:
                    mimeType = "application/octet-stream";
                    break;
            }
            return mimeType;
        }
    }
}