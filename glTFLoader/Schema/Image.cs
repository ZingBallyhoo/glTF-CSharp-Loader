//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace glTFLoader.Schema {
    using System.Linq;
    using System.Runtime.Serialization;
    
    
    public class Image {
        
        /// <summary>
        /// Backing field for Uri.
        /// </summary>
        private string m_uri;
        
        /// <summary>
        /// Backing field for MimeType.
        /// </summary>
        private System.Nullable<MimeTypeEnum> m_mimeType;
        
        /// <summary>
        /// Backing field for BufferView.
        /// </summary>
        private System.Nullable<int> m_bufferView;
        
        /// <summary>
        /// Backing field for Name.
        /// </summary>
        private string m_name;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> m_extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras m_extras;
        
        /// <summary>
        /// The URI (or IRI) of the image.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("uri")]
        public string Uri {
            get {
                return this.m_uri;
            }
            set {
                this.m_uri = value;
            }
        }
        
        /// <summary>
        /// The image's media type. This field **MUST** be defined when `bufferView` is defined.
        /// </summary>
        [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<MimeTypeEnum>))]
        [System.Text.Json.Serialization.JsonPropertyName("mimeType")]
        public System.Nullable<MimeTypeEnum> MimeType {
            get {
                return this.m_mimeType;
            }
            set {
                this.m_mimeType = value;
            }
        }
        
        /// <summary>
        /// The index of the bufferView that contains the image. This field **MUST NOT** be defined when `uri` is defined.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("bufferView")]
        public System.Nullable<int> BufferView {
            get {
                return this.m_bufferView;
            }
            set {
                if ((value < 0)) {
                    throw new System.ArgumentOutOfRangeException("BufferView", value, "Expected value to be greater than or equal to 0");
                }
                this.m_bufferView = value;
            }
        }
        
        /// <summary>
        /// The user-defined name of this object.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("name")]
        public string Name {
            get {
                return this.m_name;
            }
            set {
                this.m_name = value;
            }
        }
        
        /// <summary>
        /// JSON object with extension-specific objects.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("extensions")]
        public System.Collections.Generic.Dictionary<string, object> Extensions {
            get {
                return this.m_extensions;
            }
            set {
                this.m_extensions = value;
            }
        }
        
        /// <summary>
        /// Application-specific data.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("extras")]
        public Extras Extras {
            get {
                return this.m_extras;
            }
            set {
                this.m_extras = value;
            }
        }
        
        public bool ShouldSerializeUri() {
            return ((m_uri == null) 
                        == false);
        }
        
        public bool ShouldSerializeMimeType() {
            return ((m_mimeType == null) 
                        == false);
        }
        
        public bool ShouldSerializeBufferView() {
            return ((m_bufferView == null) 
                        == false);
        }
        
        public bool ShouldSerializeName() {
            return ((m_name == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtensions() {
            return ((m_extensions == null) 
                        == false);
        }
        
        public bool ShouldSerializeExtras() {
            return ((m_extras == null) 
                        == false);
        }
        
        public enum MimeTypeEnum {
            
            [EnumMember(Value="image/jpeg")]
            image_jpeg,
            
            [EnumMember(Value="image/png")]
            image_png,
        }
    }
}
