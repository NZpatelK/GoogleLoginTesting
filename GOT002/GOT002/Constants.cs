using System;
using System.Collections.Generic;
using System.Text;

namespace GOT002
{
    class Constants
    {
        public static string AppName = "OAuthNativeFlow";

        //For Google login confiugre at https://console.developers.google.com/
        public static string iOSClientId = "<insert IOS client ID here>";
        public static string AndroidClientId = "613198778395-c8he66gr40rbbato7j9hh91ikj7qpfre.apps.googleusercontent.com";

        public static string Scope = "https://www.googleapis.com/auth/userinfo.email";
        public static string AuthorizeUrl = "https://accounts.google.com/o/oauth2/auth";
        public static string AccessTokenUrl = "https://www.googleapis.com/oauth2/v4/token";
        public static string UserInfoUrl = "https://www.googleapis.com/oauth2/v2/userinfo";

        public static string iOSRedirectUrl = "<insert IOS redirect URL here>:/oauth2redirect";
        public static string AndroidRedirectUrl = "com.googleusercontent.apps.613198778395-c8he66gr40rbbato7j9hh91ikj7qpfre:/oauth2redirect";


    }
}
