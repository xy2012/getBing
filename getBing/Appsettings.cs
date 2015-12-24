using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace getBing
{

    public enum ContentAccessPattern
    {

        OnlineOnlyWifi = 0,
        Online = 1,
        Offline = 2
    }

    public enum Language
    {
        English = 0,
        SimplifiedChinese
    }

    public class AppSettings
    {

        public const String APP_UNIQUE_ID = "AppUniqueID";

        private static AppSettings _appSettings = new AppSettings();

        private ApplicationDataContainer _localSettings;

        private AppSettings()
        {
            _localSettings = ApplicationData.Current.LocalSettings;
        }

        public static AppSettings GetInstance()
        {
            return _appSettings;
        }

        public object GetValue(string key)
        {
            return _localSettings.Values[key];
        }

        public bool IsValueExisted(string key)
        {
            return _localSettings.Values.ContainsKey(key);
        }

        public void SetLanguage(Language lan)
        {
            switch (lan)
            {
                case Language.English:
                    Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "en-US";
                    break;
                case Language.SimplifiedChinese:
                    Windows.Globalization.ApplicationLanguages.PrimaryLanguageOverride = "zh-CN";
                    break;
                default:
                    break;
            }
        }

        public void SetValue(string key, object value)
        {
            _localSettings.Values[key] = value;
        }

        public ContentAccessPattern ContentAccessPattern
        {
            get
            {
                if (!IsValueExisted("ContentAccessPattern"))
                {
                    SetValue("ContentAccessPattern", (int)ContentAccessPattern.Online);
                }
                return (ContentAccessPattern)GetValue("ContentAccessPattern");
            }
            set
            {
                SetValue("ContentAccessPattern", (int)value);
            }
        }
    }
}
