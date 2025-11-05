using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using ABS.UVPlans;

[assembly: WorkflowRunnerServiceAttribute(typeof(ABS.UVPlans.WorkflowRunnerService))]
namespace ABS.UVPlans
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Formatting/FormatOutput.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void FormatOutput(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Formatting\FormatOutput.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Formatting/FormatOutput.xaml
        /// </summary>
        public void FormatOutput()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Formatting\FormatOutput.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Plans/GetAllCategoryListPaginationUrls.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetAllCategoryListPaginationUrls(string in_LanguageCode, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetAllCategoryListPaginationUrls.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Plans/GetAllCategoryListPaginationUrls.xaml
        /// </summary>
        public void GetAllCategoryListPaginationUrls(string in_LanguageCode)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetAllCategoryListPaginationUrls.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Processes/GetAllLanguageCodes.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public Newtonsoft.Json.Linq.JArray GetAllLanguageCodes(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Processes\GetAllLanguageCodes.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_LanguagesJA"];
        }

        /// <summary>
        /// Invokes the Processes/GetAllLanguageCodes.xaml
        /// </summary>
        public Newtonsoft.Json.Linq.JArray GetAllLanguageCodes()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Processes\GetAllLanguageCodes.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_LanguagesJA"];
        }

        /// <summary>
        /// Invokes the Processes/GetAllPlansMetadata.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetAllPlansMetadata(string in_LanguageCode, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Processes\GetAllPlansMetadata.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Processes/GetAllPlansMetadata.xaml
        /// </summary>
        public void GetAllPlansMetadata(string in_LanguageCode)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Processes\GetAllPlansMetadata.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Plans/GetCategoryListPaginationUrls.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.List<string> GetCategoryListPaginationUrls(string in_CategoryPageUrl, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetCategoryListPaginationUrls.xaml", new Dictionary<string, object> { { "in_CategoryPageUrl", in_CategoryPageUrl } }, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.List<string>)result["out_CategoryListPaginationUrls"];
        }

        /// <summary>
        /// Invokes the Plans/GetCategoryListPaginationUrls.xaml
        /// </summary>
        public System.Collections.Generic.List<string> GetCategoryListPaginationUrls(string in_CategoryPageUrl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetCategoryListPaginationUrls.xaml", new Dictionary<string, object> { { "in_CategoryPageUrl", in_CategoryPageUrl } }, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.List<string>)result["out_CategoryListPaginationUrls"];
        }

        /// <summary>
        /// Invokes the Plans/GetCategoryListUrls.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public Newtonsoft.Json.Linq.JArray GetCategoryListUrls(string in_LanguageCode, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetCategoryListUrls.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, isolated, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_CategoryListUrlsJA"];
        }

        /// <summary>
        /// Invokes the Plans/GetCategoryListUrls.xaml
        /// </summary>
        public Newtonsoft.Json.Linq.JArray GetCategoryListUrls(string in_LanguageCode)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetCategoryListUrls.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, default, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_CategoryListUrlsJA"];
        }

        /// <summary>
        /// Invokes the Plans/GetDestinctLanguagePlanUrls.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public Newtonsoft.Json.Linq.JArray GetDestinctLanguagePlanUrls(string in_LanguageCode, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetDestinctLanguagePlanUrls.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, isolated, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_DestinctLangaugePlanUrlsJA"];
        }

        /// <summary>
        /// Invokes the Plans/GetDestinctLanguagePlanUrls.xaml
        /// </summary>
        public Newtonsoft.Json.Linq.JArray GetDestinctLanguagePlanUrls(string in_LanguageCode)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetDestinctLanguagePlanUrls.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, default, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_DestinctLangaugePlanUrlsJA"];
        }

        /// <summary>
        /// Invokes the GetDevotionalContent.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string GetDevotionalContent(int in_DaysInPlan, string in_PlanFirstPageUrl, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetDevotionalContent.xaml", new Dictionary<string, object> { { "in_DaysInPlan", in_DaysInPlan }, { "in_PlanFirstPageUrl", in_PlanFirstPageUrl } }, default, isolated, default, GetAssemblyName());
            return (string)result["out_DevotionalContent"];
        }

        /// <summary>
        /// Invokes the GetDevotionalContent.xaml
        /// </summary>
        public string GetDevotionalContent(int in_DaysInPlan, string in_PlanFirstPageUrl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetDevotionalContent.xaml", new Dictionary<string, object> { { "in_DaysInPlan", in_DaysInPlan }, { "in_PlanFirstPageUrl", in_PlanFirstPageUrl } }, default, default, default, GetAssemblyName());
            return (string)result["out_DevotionalContent"];
        }

        /// <summary>
        /// Invokes the Util/GetLanguageCodeFromUrl.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string GetLanguageCodeFromUrl(string in_Url, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Util\GetLanguageCodeFromUrl.xaml", new Dictionary<string, object> { { "in_Url", in_Url } }, default, isolated, default, GetAssemblyName());
            return (string)result["out_LanguageCode"];
        }

        /// <summary>
        /// Invokes the Util/GetLanguageCodeFromUrl.xaml
        /// </summary>
        public string GetLanguageCodeFromUrl(string in_Url)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Util\GetLanguageCodeFromUrl.xaml", new Dictionary<string, object> { { "in_Url", in_Url } }, default, default, default, GetAssemblyName());
            return (string)result["out_LanguageCode"];
        }

        /// <summary>
        /// Invokes the Plans/GetLanguagePlanUrls.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public Newtonsoft.Json.Linq.JArray GetLanguagePlanUrls(string in_LanguageCode, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetLanguagePlanUrls.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, isolated, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_AllLanguagePlanUrlsJA"];
        }

        /// <summary>
        /// Invokes the Plans/GetLanguagePlanUrls.xaml
        /// </summary>
        public Newtonsoft.Json.Linq.JArray GetLanguagePlanUrls(string in_LanguageCode)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetLanguagePlanUrls.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode } }, default, default, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_AllLanguagePlanUrlsJA"];
        }

        /// <summary>
        /// Invokes the Plans/GetPlanMetadata.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public Newtonsoft.Json.Linq.JObject GetPlanMetadata(string in_PlanInfoUrl, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetPlanMetadata.xaml", new Dictionary<string, object> { { "in_PlanInfoUrl", in_PlanInfoUrl } }, default, isolated, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JObject)result["out_PlanMetadataJO"];
        }

        /// <summary>
        /// Invokes the Plans/GetPlanMetadata.xaml
        /// </summary>
        public Newtonsoft.Json.Linq.JObject GetPlanMetadata(string in_PlanInfoUrl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetPlanMetadata.xaml", new Dictionary<string, object> { { "in_PlanInfoUrl", in_PlanInfoUrl } }, default, default, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JObject)result["out_PlanMetadataJO"];
        }

        /// <summary>
        /// Invokes the Plans/GetPlanPaginationUrls.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Collections.Generic.List<string> GetPlanPaginationUrls(string in_PlanUrl, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetPlanPaginationUrls.xaml", new Dictionary<string, object> { { "in_PlanUrl", in_PlanUrl } }, default, isolated, default, GetAssemblyName());
            return (System.Collections.Generic.List<string>)result["out_PlanPaginationUrls"];
        }

        /// <summary>
        /// Invokes the Plans/GetPlanPaginationUrls.xaml
        /// </summary>
        public System.Collections.Generic.List<string> GetPlanPaginationUrls(string in_PlanUrl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetPlanPaginationUrls.xaml", new Dictionary<string, object> { { "in_PlanUrl", in_PlanUrl } }, default, default, default, GetAssemblyName());
            return (System.Collections.Generic.List<string>)result["out_PlanPaginationUrls"];
        }

        /// <summary>
        /// Invokes the Plans/GetPlanUrlsFromPaginationUrl.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public Newtonsoft.Json.Linq.JArray GetPlanUrlsFromPaginationUrl(string in_CategoryPaginationUrl, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetPlanUrlsFromPaginationUrl.xaml", new Dictionary<string, object> { { "in_CategoryPaginationUrl", in_CategoryPaginationUrl } }, default, isolated, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_PlanUrlsJA"];
        }

        /// <summary>
        /// Invokes the Plans/GetPlanUrlsFromPaginationUrl.xaml
        /// </summary>
        public Newtonsoft.Json.Linq.JArray GetPlanUrlsFromPaginationUrl(string in_CategoryPaginationUrl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Plans\GetPlanUrlsFromPaginationUrl.xaml", new Dictionary<string, object> { { "in_CategoryPaginationUrl", in_CategoryPaginationUrl } }, default, default, default, GetAssemblyName());
            return (Newtonsoft.Json.Linq.JArray)result["out_PlanUrlsJA"];
        }

        /// <summary>
        /// Invokes the GetSearchResultInfo.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetSearchResultInfo(string in_OutputJsonFile, string in_SearchTitlePattern, string in_SearchResultUrl, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetSearchResultInfo.xaml", new Dictionary<string, object> { { "in_OutputJsonFile", in_OutputJsonFile }, { "in_SearchTitlePattern", in_SearchTitlePattern }, { "in_SearchResultUrl", in_SearchResultUrl } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GetSearchResultInfo.xaml
        /// </summary>
        public void GetSearchResultInfo(string in_OutputJsonFile, string in_SearchTitlePattern, string in_SearchResultUrl)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetSearchResultInfo.xaml", new Dictionary<string, object> { { "in_OutputJsonFile", in_OutputJsonFile }, { "in_SearchTitlePattern", in_SearchTitlePattern }, { "in_SearchResultUrl", in_SearchResultUrl } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GetUrls.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void GetUrls(string in_destinationJsonFileName, string in_sourceJsonFileName, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetUrls.xaml", new Dictionary<string, object> { { "in_destinationJsonFileName", in_destinationJsonFileName }, { "in_sourceJsonFileName", in_sourceJsonFileName } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the GetUrls.xaml
        /// </summary>
        public void GetUrls(string in_destinationJsonFileName, string in_sourceJsonFileName)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"GetUrls.xaml", new Dictionary<string, object> { { "in_destinationJsonFileName", in_destinationJsonFileName }, { "in_sourceJsonFileName", in_sourceJsonFileName } }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Util/KillAllChromeProcesses.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void KillAllChromeProcesses(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Util\KillAllChromeProcesses.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Util/KillAllChromeProcesses.xaml
        /// </summary>
        public void KillAllChromeProcesses()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Util\KillAllChromeProcesses.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Formatting/NextStepOutput.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void NextStepOutput(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Formatting\NextStepOutput.cs", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Formatting/NextStepOutput.cs
        /// </summary>
        public void NextStepOutput()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Formatting\NextStepOutput.cs", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Util/StripPublisherNameMoreFrom.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public string StripPublisherNameMoreFrom(string in_LanguageCode, string in_PublisherNameWithMoreFrom, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Util\StripPublisherNameMoreFrom.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode }, { "in_PublisherNameWithMoreFrom", in_PublisherNameWithMoreFrom } }, default, isolated, default, GetAssemblyName());
            return (string)result["out_PublisherName"];
        }

        /// <summary>
        /// Invokes the Util/StripPublisherNameMoreFrom.xaml
        /// </summary>
        public string StripPublisherNameMoreFrom(string in_LanguageCode, string in_PublisherNameWithMoreFrom)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Util\StripPublisherNameMoreFrom.xaml", new Dictionary<string, object> { { "in_LanguageCode", in_LanguageCode }, { "in_PublisherNameWithMoreFrom", in_PublisherNameWithMoreFrom } }, default, default, default, GetAssemblyName());
            return (string)result["out_PublisherName"];
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}