namespace Umbraco.Cms.Core;

public static partial class Constants
{
    public static class Telemetry
    {
        public static string RootCount = "RootCount";
        public static string DomainCount = "DomainCount";
        public static string ExamineIndexCount = "ExamineIndexCount";
        public static string LanguageCount = "LanguageCount";
        public static string MediaCount = "MediaCount";
        public static string MemberCount = "MemberCount";
        public static string TemplateCount = "TemplateCount";
        public static string ContentCount = "ContentCount";
        public static string DocumentTypeCount = "DocumentTypeCount";
        public static string Properties = "Properties";
        public static string UserCount = "UserCount";
        public static string UserGroupCount = "UserGroupCount";
        public static string ServerOs = "ServerOs";
        public static string ServerFramework = "ServerFramework";
        public static string OsLanguage = "OsLanguage";
        public static string WebServer = "WebServer";
        public static string ModelsBuilderMode = "ModelBuilderMode";
        [Obsolete($"UmbracoPath is no longer configurable, scheduled for removal in V12")]
        public static string CustomUmbracoPath = "CustomUmbracoPath";
        public static string AspEnvironment = "AspEnvironment";
        public static string IsDebug = "IsDebug";
        public static string DatabaseProvider = "DatabaseProvider";
        public static string CurrentServerRole = "CurrentServerRole";
        public static string RuntimeMode = "RuntimeMode";
        public static string BackofficeExternalLoginProviderCount = "BackofficeExternalLoginProviderCount";
        public static string DeliverApiEnabled = "DeliverApiEnabled";
        public static string DeliveryApiPublicAccess = "DeliveryApiPublicAccess";
        public static string WebhookPrefix = "WebhookCount_";
        public static string WebhookTotal = $"{WebhookPrefix}Total";
        public static string WebhookCustomHeaders = $"{WebhookPrefix}CustomHeaders";
        public static string WebhookCustomEvent = $"{WebhookPrefix}CustomEvent";
    }
}
