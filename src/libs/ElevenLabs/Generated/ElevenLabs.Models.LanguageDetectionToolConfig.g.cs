
#nullable enable

namespace ElevenLabs
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class LanguageDetectionToolConfig
    {
        /// <summary>
        /// Default Value: language_detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("system_tool_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::ElevenLabs.JsonConverters.LanguageDetectionToolConfigSystemToolTypeJsonConverter))]
        public global::ElevenLabs.LanguageDetectionToolConfigSystemToolType? SystemToolType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionToolConfig" /> class.
        /// </summary>
        /// <param name="systemToolType">
        /// Default Value: language_detection
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LanguageDetectionToolConfig(
            global::ElevenLabs.LanguageDetectionToolConfigSystemToolType? systemToolType)
        {
            this.SystemToolType = systemToolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LanguageDetectionToolConfig" /> class.
        /// </summary>
        public LanguageDetectionToolConfig()
        {
        }
    }
}