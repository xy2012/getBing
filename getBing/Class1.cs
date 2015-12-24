using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;

namespace getBing
{
    public class LexiconQuery
    {

        private static String QUERY_URL_LEXICON = "http://dict.bing.com.cn/api/http/v2/{0}/{1}/lexicon/?q={2}&format=application/json";
        private static String QUERY_LANG_EN_TO_CN = "en-us/zh-cn";
        private static String QUERY_LANG_CN_TO_EN = "zh-cn/en-us";

        public static async Task<string> GetLexicon(String query)
        {
            if (query == "")
            {
                return "01";

            }
            if (query.IndexOf(" ") > -1)
            {
                return "02";
            }

          //  bool _isDataFromInternet = true;
            //Set netword access mode.
                ContentAccessPattern pattern = AppSettings.GetInstance().ContentAccessPattern;
                if (ContentAccessPattern.Offline == pattern)
                    return "13";
                if (ContentAccessPattern.OnlineOnlyWifi == pattern && NetworkUtils.IsInternetConnectedByWWAN())
                    return "23"; 
         
    
            QueryResult result = null;
            String encodedQuery = WebUtility.HtmlEncode(query);
            String url = String.Format(QUERY_URL_LEXICON, Constants.UWP_API_ID,
                Extension.ContainsChinese(query) ? QUERY_LANG_CN_TO_EN : QUERY_LANG_EN_TO_CN, encodedQuery);
            try
            {

                result = await QueryEngine.GetHttpResponseAsQueryResult(url);
            }
            catch (Exception e) { }
            if (result == null)
            {
                return "03";
            }
            int count = result.LexiconEntry.CrossLangDef.Count;
            if (count - 1 == 0)
                return "03";
            string S;
            if(result.LexiconEntry.Pronunciations!=null)
              S = "00"+result.QueryString+" /"+result.LexiconEntry.Pronunciations[0].Value+'/';// +result.LexiconEntry.Headword.Definition;
            else
                S = "00" + result.QueryString;
            string flags;
            int re_0 = 0;
            int test_f = 0;
            for (int i = 0; i < count-1; i++)
            {
                switch (result.LexiconEntry.CrossLangDef[i].POS)
                {
                    case "prop":
                        flags = "&1";
                        break;
                    case "int":
                        flags = "&2";
                        break;
                    case "abbr":
                        flags = "&3";
                        break;
                    case "n":
                        flags = "&4";
                        break;
                    case "v":
                        flags = "&5";
                        break;
                    case "adj":
                        flags = "&6";
                        break;
                    case "pron":
                        flags = "&7";
                        break;
                    case "art":
                        flags = "&8";
                        break;
                    case "na":
                        flags = "&9";
                        break;
                    default:
                        flags = "&0";
                        test_f = 1;
                        re_0 = re_0+1;
                        break;
                }
                if (test_f == 0)
                {
                    S = S + flags + result.LexiconEntry.CrossLangDef[i].Definition;
                }
                else if (re_0 == 1)
                {
                    S = S + flags + result.LexiconEntry.CrossLangDef[i].Definition;
                   
                }
                test_f = 0;

            }
            return S+'E';
        }
    }


}
