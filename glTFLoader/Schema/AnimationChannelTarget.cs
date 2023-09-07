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
    
    
    public class AnimationChannelTarget {
        
        /// <summary>
        /// Backing field for Node.
        /// </summary>
        private System.Nullable<int> m_node;
        
        /// <summary>
        /// Backing field for Path.
        /// </summary>
        private PathEnum m_path;
        
        /// <summary>
        /// Backing field for Extensions.
        /// </summary>
        private System.Collections.Generic.Dictionary<string, object> m_extensions;
        
        /// <summary>
        /// Backing field for Extras.
        /// </summary>
        private Extras m_extras;
        
        /// <summary>
        /// The index of the node to animate. When undefined, the animated object **MAY** be defined by an extension.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("node")]
        public System.Nullable<int> Node {
            get {
                return this.m_node;
            }
            set {
                if ((value < 0)) {
                    throw new System.ArgumentOutOfRangeException("Node", value, "Expected value to be greater than or equal to 0");
                }
                this.m_node = value;
            }
        }
        
        /// <summary>
        /// The name of the node's TRS property to animate, or the `"weights"` of the Morph Targets it instantiates. For the `"translation"` property, the values that are provided by the sampler are the translation along the X, Y, and Z axes. For the `"rotation"` property, the values are a quaternion in the order (x, y, z, w), where w is the scalar. For the `"scale"` property, the values are the scaling factors along the X, Y, and Z axes.
        /// </summary>
        [System.Text.Json.Serialization.JsonConverter(typeof(JsonStringEnumConverterWithEnumMemberAttrSupport<PathEnum>))]
        [System.Text.Json.Serialization.JsonRequired()]
        [System.Text.Json.Serialization.JsonPropertyName("path")]
        public PathEnum Path {
            get {
                return this.m_path;
            }
            set {
                this.m_path = value;
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
        
        public bool ShouldSerializeNode() {
            return ((m_node == null) 
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
        
        public enum PathEnum {
            
            translation,
            
            rotation,
            
            scale,
            
            weights,
        }
    }
}
