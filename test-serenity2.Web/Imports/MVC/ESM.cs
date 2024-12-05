namespace test_serenity2;

public static partial class ESM
{
    public const string GamesPage = "~/esm/Modules/Games/Games/GamesPage.js";
    public const string LanguagePage = "~/esm/Modules/Administration/Language/LanguagePage.js";
    public const string LoginPage = "~/esm/Modules/Membership/Account/Login/LoginPage.js";
    public const string LogsPage = "~/esm/Modules/Games/Logs/LogsPage.js";
    public const string MoviePage = "~/esm/Modules/Default/Movie/MoviePage.js";
    public const string PlatformsPage = "~/esm/Modules/Games/Platforms/PlatformsPage.js";
    public const string RolePage = "~/esm/Modules/Administration/Role/RolePage.js";
    public const string ScriptInit = "~/esm/Modules/Common/ScriptInit.js";
    public const string SignUpPage = "~/esm/Modules/Membership/Account/SignUp/SignUpPage.js";
    public const string TranslationPage = "~/esm/Modules/Administration/Translation/TranslationPage.js";
    public const string UserPage = "~/esm/Modules/Administration/User/UserPage.js";

    public static partial class Modules
    {
        public static partial class Administration
        {
            public static partial class Language
            {
                public const string LanguagePage = "~/esm/Modules/Administration/Language/LanguagePage.js";
            }

            public static partial class Role
            {
                public const string RolePage = "~/esm/Modules/Administration/Role/RolePage.js";
            }

            public static partial class Translation
            {
                public const string TranslationPage = "~/esm/Modules/Administration/Translation/TranslationPage.js";
            }

            public static partial class User
            {
                public const string UserPage = "~/esm/Modules/Administration/User/UserPage.js";
            }
        }

        public static partial class Common
        {
            public const string ScriptInit = "~/esm/Modules/Common/ScriptInit.js";
        }

        public static partial class Default
        {
            public static partial class Movie
            {
                public const string MoviePage = "~/esm/Modules/Default/Movie/MoviePage.js";
            }
        }

        public static partial class Games
        {
            public static partial class Games_
            {
                public const string GamesPage = "~/esm/Modules/Games/Games/GamesPage.js";
            }

            public static partial class Logs
            {
                public const string LogsPage = "~/esm/Modules/Games/Logs/LogsPage.js";
            }

            public static partial class Platforms
            {
                public const string PlatformsPage = "~/esm/Modules/Games/Platforms/PlatformsPage.js";
            }
        }

        public static partial class Membership
        {
            public static partial class Account
            {
                public static partial class Login
                {
                    public const string LoginPage = "~/esm/Modules/Membership/Account/Login/LoginPage.js";
                }

                public static partial class SignUp
                {
                    public const string SignUpPage = "~/esm/Modules/Membership/Account/SignUp/SignUpPage.js";
                }
            }
        }
    }
}