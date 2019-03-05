using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api.ASL
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IAuSedeAslControllerApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// estrai indirizzo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>List&lt;Indirizzo&gt;</returns>
        List<Indirizzo> EstraiIndirizzoUsingGET1 (string codiceSede);

        /// <summary>
        /// estrai indirizzo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>ApiResponse of List&lt;Indirizzo&gt;</returns>
        ApiResponse<List<Indirizzo>> EstraiIndirizzoUsingGET1WithHttpInfo (string codiceSede);
        /// <summary>
        /// estrai mail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>List&lt;Mail&gt;</returns>
        List<Mail> EstraiMailUsingGET1 (string codiceSede);

        /// <summary>
        /// estrai mail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>ApiResponse of List&lt;Mail&gt;</returns>
        ApiResponse<List<Mail>> EstraiMailUsingGET1WithHttpInfo (string codiceSede);
        /// <summary>
        /// estrai telefono
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>List&lt;Telefono&gt;</returns>
        List<Telefono> EstraiTelefonoUsingGET1 (string codiceSede);

        /// <summary>
        /// estrai telefono
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>ApiResponse of List&lt;Telefono&gt;</returns>
        ApiResponse<List<Telefono>> EstraiTelefonoUsingGET1WithHttpInfo (string codiceSede);
        /// <summary>
        /// Ricerca Sede Asl
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="istatComuneCompetenza">istatComuneCompetenza</param>
        /// <returns>List&lt;SedeAsl&gt;</returns>
        List<SedeAsl> GetSedeAslUsingGET1 (string istatComuneCompetenza);

        /// <summary>
        /// Ricerca Sede Asl
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="istatComuneCompetenza">istatComuneCompetenza</param>
        /// <returns>ApiResponse of List&lt;SedeAsl&gt;</returns>
        ApiResponse<List<SedeAsl>> GetSedeAslUsingGET1WithHttpInfo (string istatComuneCompetenza);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// estrai indirizzo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of List&lt;Indirizzo&gt;</returns>
        System.Threading.Tasks.Task<List<Indirizzo>> EstraiIndirizzoUsingGET1Async (string codiceSede);

        /// <summary>
        /// estrai indirizzo
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of ApiResponse (List&lt;Indirizzo&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Indirizzo>>> EstraiIndirizzoUsingGET1AsyncWithHttpInfo (string codiceSede);
        /// <summary>
        /// estrai mail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of List&lt;Mail&gt;</returns>
        System.Threading.Tasks.Task<List<Mail>> EstraiMailUsingGET1Async (string codiceSede);

        /// <summary>
        /// estrai mail
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of ApiResponse (List&lt;Mail&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Mail>>> EstraiMailUsingGET1AsyncWithHttpInfo (string codiceSede);
        /// <summary>
        /// estrai telefono
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of List&lt;Telefono&gt;</returns>
        System.Threading.Tasks.Task<List<Telefono>> EstraiTelefonoUsingGET1Async (string codiceSede);

        /// <summary>
        /// estrai telefono
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of ApiResponse (List&lt;Telefono&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<Telefono>>> EstraiTelefonoUsingGET1AsyncWithHttpInfo (string codiceSede);
        /// <summary>
        /// Ricerca Sede Asl
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="istatComuneCompetenza">istatComuneCompetenza</param>
        /// <returns>Task of List&lt;SedeAsl&gt;</returns>
        System.Threading.Tasks.Task<List<SedeAsl>> GetSedeAslUsingGET1Async (string istatComuneCompetenza);

        /// <summary>
        /// Ricerca Sede Asl
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="istatComuneCompetenza">istatComuneCompetenza</param>
        /// <returns>Task of ApiResponse (List&lt;SedeAsl&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<SedeAsl>>> GetSedeAslUsingGET1AsyncWithHttpInfo (string istatComuneCompetenza);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class AuSedeAslControllerApi : IAuSedeAslControllerApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="AuSedeAslControllerApi"/> class.
        /// </summary>
        /// <returns></returns>
        public AuSedeAslControllerApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuSedeAslControllerApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public AuSedeAslControllerApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// estrai indirizzo 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>List&lt;Indirizzo&gt;</returns>
        public List<Indirizzo> EstraiIndirizzoUsingGET1 (string codiceSede)
        {
             ApiResponse<List<Indirizzo>> localVarResponse = EstraiIndirizzoUsingGET1WithHttpInfo(codiceSede);
             return localVarResponse.Data;
        }

        /// <summary>
        /// estrai indirizzo 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>ApiResponse of List&lt;Indirizzo&gt;</returns>
        public ApiResponse< List<Indirizzo> > EstraiIndirizzoUsingGET1WithHttpInfo (string codiceSede)
        {
            // verify the required parameter 'codiceSede' is set
            if (codiceSede == null)
                throw new ApiException(400, "Missing required parameter 'codiceSede' when calling AuSedeAslControllerApi->EstraiIndirizzoUsingGET1");

            var localVarPath = "/1.0/au/sedeasl/estrai-indirizzo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (codiceSede != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "codiceSede", codiceSede)); // query parameter

            // authentication (INAIL_API_GATEWAY_JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EstraiIndirizzoUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Indirizzo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Indirizzo>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Indirizzo>)));
        }

        /// <summary>
        /// estrai indirizzo 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of List&lt;Indirizzo&gt;</returns>
        public async System.Threading.Tasks.Task<List<Indirizzo>> EstraiIndirizzoUsingGET1Async (string codiceSede)
        {
             ApiResponse<List<Indirizzo>> localVarResponse = await EstraiIndirizzoUsingGET1AsyncWithHttpInfo(codiceSede);
             return localVarResponse.Data;

        }

        /// <summary>
        /// estrai indirizzo 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of ApiResponse (List&lt;Indirizzo&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Indirizzo>>> EstraiIndirizzoUsingGET1AsyncWithHttpInfo (string codiceSede)
        {
            // verify the required parameter 'codiceSede' is set
            if (codiceSede == null)
                throw new ApiException(400, "Missing required parameter 'codiceSede' when calling AuSedeAslControllerApi->EstraiIndirizzoUsingGET1");

            var localVarPath = "/1.0/au/sedeasl/estrai-indirizzo";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (codiceSede != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "codiceSede", codiceSede)); // query parameter

            // authentication (INAIL_API_GATEWAY_JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EstraiIndirizzoUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Indirizzo>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Indirizzo>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Indirizzo>)));
        }

        /// <summary>
        /// estrai mail 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>List&lt;Mail&gt;</returns>
        public List<Mail> EstraiMailUsingGET1 (string codiceSede)
        {
             ApiResponse<List<Mail>> localVarResponse = EstraiMailUsingGET1WithHttpInfo(codiceSede);
             return localVarResponse.Data;
        }

        /// <summary>
        /// estrai mail 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>ApiResponse of List&lt;Mail&gt;</returns>
        public ApiResponse< List<Mail> > EstraiMailUsingGET1WithHttpInfo (string codiceSede)
        {
            // verify the required parameter 'codiceSede' is set
            if (codiceSede == null)
                throw new ApiException(400, "Missing required parameter 'codiceSede' when calling AuSedeAslControllerApi->EstraiMailUsingGET1");

            var localVarPath = "/1.0/au/sedeasl/estrai-mail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (codiceSede != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "codiceSede", codiceSede)); // query parameter

            // authentication (INAIL_API_GATEWAY_JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EstraiMailUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Mail>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Mail>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Mail>)));
        }

        /// <summary>
        /// estrai mail 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of List&lt;Mail&gt;</returns>
        public async System.Threading.Tasks.Task<List<Mail>> EstraiMailUsingGET1Async (string codiceSede)
        {
             ApiResponse<List<Mail>> localVarResponse = await EstraiMailUsingGET1AsyncWithHttpInfo(codiceSede);
             return localVarResponse.Data;

        }

        /// <summary>
        /// estrai mail 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of ApiResponse (List&lt;Mail&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Mail>>> EstraiMailUsingGET1AsyncWithHttpInfo (string codiceSede)
        {
            // verify the required parameter 'codiceSede' is set
            if (codiceSede == null)
                throw new ApiException(400, "Missing required parameter 'codiceSede' when calling AuSedeAslControllerApi->EstraiMailUsingGET1");

            var localVarPath = "/1.0/au/sedeasl/estrai-mail";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (codiceSede != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "codiceSede", codiceSede)); // query parameter

            // authentication (INAIL_API_GATEWAY_JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EstraiMailUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Mail>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Mail>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Mail>)));
        }

        /// <summary>
        /// estrai telefono 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>List&lt;Telefono&gt;</returns>
        public List<Telefono> EstraiTelefonoUsingGET1 (string codiceSede)
        {
             ApiResponse<List<Telefono>> localVarResponse = EstraiTelefonoUsingGET1WithHttpInfo(codiceSede);
             return localVarResponse.Data;
        }

        /// <summary>
        /// estrai telefono 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>ApiResponse of List&lt;Telefono&gt;</returns>
        public ApiResponse< List<Telefono> > EstraiTelefonoUsingGET1WithHttpInfo (string codiceSede)
        {
            // verify the required parameter 'codiceSede' is set
            if (codiceSede == null)
                throw new ApiException(400, "Missing required parameter 'codiceSede' when calling AuSedeAslControllerApi->EstraiTelefonoUsingGET1");

            var localVarPath = "/1.0/au/sedeasl/estrai-telefono";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (codiceSede != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "codiceSede", codiceSede)); // query parameter

            // authentication (INAIL_API_GATEWAY_JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EstraiTelefonoUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Telefono>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Telefono>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Telefono>)));
        }

        /// <summary>
        /// estrai telefono 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of List&lt;Telefono&gt;</returns>
        public async System.Threading.Tasks.Task<List<Telefono>> EstraiTelefonoUsingGET1Async (string codiceSede)
        {
             ApiResponse<List<Telefono>> localVarResponse = await EstraiTelefonoUsingGET1AsyncWithHttpInfo(codiceSede);
             return localVarResponse.Data;

        }

        /// <summary>
        /// estrai telefono 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="codiceSede">codiceSede</param>
        /// <returns>Task of ApiResponse (List&lt;Telefono&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<Telefono>>> EstraiTelefonoUsingGET1AsyncWithHttpInfo (string codiceSede)
        {
            // verify the required parameter 'codiceSede' is set
            if (codiceSede == null)
                throw new ApiException(400, "Missing required parameter 'codiceSede' when calling AuSedeAslControllerApi->EstraiTelefonoUsingGET1");

            var localVarPath = "/1.0/au/sedeasl/estrai-telefono";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (codiceSede != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "codiceSede", codiceSede)); // query parameter

            // authentication (INAIL_API_GATEWAY_JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("EstraiTelefonoUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<Telefono>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<Telefono>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<Telefono>)));
        }

        /// <summary>
        /// Ricerca Sede Asl 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="istatComuneCompetenza">istatComuneCompetenza</param>
        /// <returns>List&lt;SedeAsl&gt;</returns>
        public List<SedeAsl> GetSedeAslUsingGET1 (string istatComuneCompetenza)
        {
             ApiResponse<List<SedeAsl>> localVarResponse = GetSedeAslUsingGET1WithHttpInfo(istatComuneCompetenza);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Ricerca Sede Asl 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="istatComuneCompetenza">istatComuneCompetenza</param>
        /// <returns>ApiResponse of List&lt;SedeAsl&gt;</returns>
        public ApiResponse< List<SedeAsl> > GetSedeAslUsingGET1WithHttpInfo (string istatComuneCompetenza)
        {
            // verify the required parameter 'istatComuneCompetenza' is set
            if (istatComuneCompetenza == null)
                throw new ApiException(400, "Missing required parameter 'istatComuneCompetenza' when calling AuSedeAslControllerApi->GetSedeAslUsingGET1");

            var localVarPath = "/1.0/au/sedeasl/estrai-sede-asl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (istatComuneCompetenza != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "istatComuneCompetenza", istatComuneCompetenza)); // query parameter

            // authentication (INAIL_API_GATEWAY_JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSedeAslUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SedeAsl>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SedeAsl>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SedeAsl>)));
        }

        /// <summary>
        /// Ricerca Sede Asl 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="istatComuneCompetenza">istatComuneCompetenza</param>
        /// <returns>Task of List&lt;SedeAsl&gt;</returns>
        public async System.Threading.Tasks.Task<List<SedeAsl>> GetSedeAslUsingGET1Async (string istatComuneCompetenza)
        {
             ApiResponse<List<SedeAsl>> localVarResponse = await GetSedeAslUsingGET1AsyncWithHttpInfo(istatComuneCompetenza);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Ricerca Sede Asl 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="istatComuneCompetenza">istatComuneCompetenza</param>
        /// <returns>Task of ApiResponse (List&lt;SedeAsl&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<SedeAsl>>> GetSedeAslUsingGET1AsyncWithHttpInfo (string istatComuneCompetenza)
        {
            // verify the required parameter 'istatComuneCompetenza' is set
            if (istatComuneCompetenza == null)
                throw new ApiException(400, "Missing required parameter 'istatComuneCompetenza' when calling AuSedeAslControllerApi->GetSedeAslUsingGET1");

            var localVarPath = "/1.0/au/sedeasl/estrai-sede-asl";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (istatComuneCompetenza != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "istatComuneCompetenza", istatComuneCompetenza)); // query parameter

            // authentication (INAIL_API_GATEWAY_JWT) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetSedeAslUsingGET1", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<SedeAsl>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<SedeAsl>) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<SedeAsl>)));
        }

    }
}
