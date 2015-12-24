using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using getBing;
//using BingDictUWP.Fundamental.Utilities;

namespace getBing
{
    public class QueryEngine
    {

        private IQueryEngineListener _listener;
      //  private DictionaryManager _dictionaryManager;
        private static QueryEngine _instance = new QueryEngine();

        public static QueryEngine GetInstance()
        {
            //if (_instance == null)
            //    _instance = new QueryEngine();
            return _instance;
        }

        public void SetQueryEngineListener(IQueryEngineListener listener)
        {
            _listener = listener;
        }

        //get http response according to network preference which is set in app settings
        public static async Task<String> GetHttpResponseAsString(String url, bool checkNetworkPreference)
        {
        //    CacheManager cacheManager = CacheManager.GetInstance();
        //    if (cacheManager.Contains(url))
        //        return cacheManager.Get(url) as String;
        
            HttpClient httpClient = new HttpClient();
            Uri uri = new Uri(url);
            HttpResponseMessage httpResponse = new HttpResponseMessage();
            String httpResponseBody = "";
            try
            {
                httpResponse = await httpClient.GetAsync(uri);
                httpResponse.EnsureSuccessStatusCode();
                httpResponseBody = await httpResponse.Content.ReadAsStringAsync();
                httpClient.Dispose();
        //        cacheManager.Put(url, httpResponseBody);
            }
            catch (Exception e)
            {
                throw e;
            }
            return httpResponseBody;
        }

        public static async Task<QueryResult> GetHttpResponseAsQueryResult(String url)
        {
            return await GetHttpResponseAsQueryResult(url, true);
        }


        public static async Task<QueryResult> GetHttpResponseAsQueryResult(String url, bool checkNetworkPreference)
        {
            String httpResponseBody = await GetHttpResponseAsString(url, checkNetworkPreference);
            if (String.IsNullOrEmpty(httpResponseBody) == true)
                return null;
            QueryResult result = null;
            try
            {
                using (var memStream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(httpResponseBody)))
                {
                  //  byte[] a = memStream.ToArray();
                    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(QueryResult));
                    result = serializer.ReadObject(memStream) as QueryResult;
                   
                }
            }
            catch (Exception e)
            {
                throw e;
            }
            return result;
        }
    }



    public interface IQueryEngineListener
    {
        void OnQueryStart();
        void OnLexiconQueryFinish(string result);
        void OnQueryFinish(bool isDataFromInternet);
    }
}
