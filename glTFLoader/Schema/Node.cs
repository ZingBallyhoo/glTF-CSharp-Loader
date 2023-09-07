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
    
    
    public class Node {
        
        /// <summary>
        /// Backing field for Camera.
        /// </summary>
        private System.Nullable<int> m_camera;
        
        /// <summary>
        /// Backing field for Children.
        /// </summary>
        private int[] m_children;
        
        /// <summary>
        /// Backing field for Skin.
        /// </summary>
        private System.Nullable<int> m_skin;
        
        /// <summary>
        /// Backing field for Matrix.
        /// </summary>
        private float[] m_matrix = new float[] {
                1F,
                0F,
                0F,
                0F,
                0F,
                1F,
                0F,
                0F,
                0F,
                0F,
                1F,
                0F,
                0F,
                0F,
                0F,
                1F};
        
        /// <summary>
        /// Backing field for Mesh.
        /// </summary>
        private System.Nullable<int> m_mesh;
        
        /// <summary>
        /// Backing field for Rotation.
        /// </summary>
        private float[] m_rotation = new float[] {
                0F,
                0F,
                0F,
                1F};
        
        /// <summary>
        /// Backing field for Scale.
        /// </summary>
        private float[] m_scale = new float[] {
                1F,
                1F,
                1F};
        
        /// <summary>
        /// Backing field for Translation.
        /// </summary>
        private float[] m_translation = new float[] {
                0F,
                0F,
                0F};
        
        /// <summary>
        /// Backing field for Weights.
        /// </summary>
        private float[] m_weights;
        
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
        /// The index of the camera referenced by this node.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("camera")]
        public System.Nullable<int> Camera {
            get {
                return this.m_camera;
            }
            set {
                if ((value < 0)) {
                    throw new System.ArgumentOutOfRangeException("Camera", value, "Expected value to be greater than or equal to 0");
                }
                this.m_camera = value;
            }
        }
        
        /// <summary>
        /// The indices of this node's children.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("children")]
        public int[] Children {
            get {
                return this.m_children;
            }
            set {
                if ((value == null)) {
                    this.m_children = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                int index = 0;
                for (index = 0; (index < value.Length); index = (index + 1)) {
                    if ((value[index] < 0)) {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                this.m_children = value;
            }
        }
        
        /// <summary>
        /// The index of the skin referenced by this node.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("skin")]
        public System.Nullable<int> Skin {
            get {
                return this.m_skin;
            }
            set {
                if ((value < 0)) {
                    throw new System.ArgumentOutOfRangeException("Skin", value, "Expected value to be greater than or equal to 0");
                }
                this.m_skin = value;
            }
        }
        
        /// <summary>
        /// A floating-point 4x4 transformation matrix stored in column-major order.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("matrix")]
        public float[] Matrix {
            get {
                return this.m_matrix;
            }
            set {
                if ((value.Length < 16u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                if ((value.Length > 16u)) {
                    throw new System.ArgumentException("Array too long");
                }
                this.m_matrix = value;
            }
        }
        
        /// <summary>
        /// The index of the mesh in this node.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("mesh")]
        public System.Nullable<int> Mesh {
            get {
                return this.m_mesh;
            }
            set {
                if ((value < 0)) {
                    throw new System.ArgumentOutOfRangeException("Mesh", value, "Expected value to be greater than or equal to 0");
                }
                this.m_mesh = value;
            }
        }
        
        /// <summary>
        /// The node's unit quaternion rotation in the order (x, y, z, w), where w is the scalar.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("rotation")]
        public float[] Rotation {
            get {
                return this.m_rotation;
            }
            set {
                if ((value.Length < 4u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                if ((value.Length > 4u)) {
                    throw new System.ArgumentException("Array too long");
                }
                int index = 0;
                for (index = 0; (index < value.Length); index = (index + 1)) {
                    if ((value[index] < -1D)) {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                for (index = 0; (index < value.Length); index = (index + 1)) {
                    if ((value[index] > 1D)) {
                        throw new System.ArgumentOutOfRangeException();
                    }
                }
                this.m_rotation = value;
            }
        }
        
        /// <summary>
        /// The node's non-uniform scale, given as the scaling factors along the x, y, and z axes.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("scale")]
        public float[] Scale {
            get {
                return this.m_scale;
            }
            set {
                if ((value.Length < 3u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                if ((value.Length > 3u)) {
                    throw new System.ArgumentException("Array too long");
                }
                this.m_scale = value;
            }
        }
        
        /// <summary>
        /// The node's translation along the x, y, and z axes.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("translation")]
        public float[] Translation {
            get {
                return this.m_translation;
            }
            set {
                if ((value.Length < 3u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                if ((value.Length > 3u)) {
                    throw new System.ArgumentException("Array too long");
                }
                this.m_translation = value;
            }
        }
        
        /// <summary>
        /// The weights of the instantiated morph target. The number of array elements **MUST** match the number of morph targets of the referenced mesh. When defined, `mesh` **MUST** also be defined.
        /// </summary>
        [System.Text.Json.Serialization.JsonPropertyName("weights")]
        public float[] Weights {
            get {
                return this.m_weights;
            }
            set {
                if ((value == null)) {
                    this.m_weights = value;
                    return;
                }
                if ((value.Length < 1u)) {
                    throw new System.ArgumentException("Array not long enough");
                }
                this.m_weights = value;
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
        
        public bool ShouldSerializeCamera() {
            return ((m_camera == null) 
                        == false);
        }
        
        public bool ShouldSerializeChildren() {
            return ((m_children == null) 
                        == false);
        }
        
        public bool ShouldSerializeSkin() {
            return ((m_skin == null) 
                        == false);
        }
        
        public bool ShouldSerializeMatrix() {
            return (m_matrix.SequenceEqual(new float[] {
                        1F,
                        0F,
                        0F,
                        0F,
                        0F,
                        1F,
                        0F,
                        0F,
                        0F,
                        0F,
                        1F,
                        0F,
                        0F,
                        0F,
                        0F,
                        1F}) == false);
        }
        
        public bool ShouldSerializeMesh() {
            return ((m_mesh == null) 
                        == false);
        }
        
        public bool ShouldSerializeRotation() {
            return (m_rotation.SequenceEqual(new float[] {
                        0F,
                        0F,
                        0F,
                        1F}) == false);
        }
        
        public bool ShouldSerializeScale() {
            return (m_scale.SequenceEqual(new float[] {
                        1F,
                        1F,
                        1F}) == false);
        }
        
        public bool ShouldSerializeTranslation() {
            return (m_translation.SequenceEqual(new float[] {
                        0F,
                        0F,
                        0F}) == false);
        }
        
        public bool ShouldSerializeWeights() {
            return ((m_weights == null) 
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
    }
}
