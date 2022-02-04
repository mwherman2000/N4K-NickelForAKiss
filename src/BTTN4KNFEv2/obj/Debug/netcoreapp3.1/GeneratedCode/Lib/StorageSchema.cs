#pragma warning disable 162,168,649,660,661,1522
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinity.Storage;
using Trinity.TSL;
namespace BTTN4KNFE
{
    /// <summary>
    /// Exposes the data modeling schema defined in the TSL.
    /// </summary>
    public class StorageSchema : IStorageSchema
    {
        #region CellType lookup table
        internal static Dictionary<string, CellType> cellTypeLookupTable = new Dictionary<string, CellType>()
        {
            
            {"BTTN4KNFEDirectory", global::BTTN4KNFE.CellType.BTTN4KNFEDirectory}
            ,
            {"BTTNFE_N4K_SealedEnvelope_Cell", global::BTTN4KNFE.CellType.BTTNFE_N4K_SealedEnvelope_Cell}
            ,
            {"BTTVerifiableCredential_SealedEnvelope_Cell", global::BTTN4KNFE.CellType.BTTVerifiableCredential_SealedEnvelope_Cell}
            
        };
        #endregion
        
        internal static readonly Type   s_cellType_BTTN4KNFEDirectory       = typeof(global::BTTN4KNFE.BTTN4KNFEDirectory);
        internal static readonly string s_cellTypeName_BTTN4KNFEDirectory   = "BTTN4KNFEDirectory";
        internal class BTTN4KNFEDirectory_descriptor : ICellDescriptor
        {
            private static IReadOnlyDictionary<string, string> s_attributes = new Dictionary<string, string>
            {
                
            };
            internal static bool check_attribute(IAttributeCollection attributes, string attributeKey, string attributeValue)
            {
                if (attributeKey == null)
                    return true;
                if (attributeValue == null)
                    return attributes.Attributes.ContainsKey(attributeKey);
                else
                    return attributes.Attributes.ContainsKey(attributeKey) && attributes.Attributes[attributeKey] == attributeValue;
            }
            
            internal class count_descriptor : IFieldDescriptor
            {
                private static IReadOnlyDictionary<string, string> s_attributes = new Dictionary<string, string>
                {
                    
                };
                private static string s_typename = "int";
                private static Type   s_type     = typeof(int);
                public string Name
                {
                    get { return "count"; }
                }
                public bool Optional
                {
                    get
                    {
                        
                        return false;
                        
                    }
                }
                public bool IsOfType<T>()
                {
                    return typeof(T) == Type;
                }
                public bool IsList()
                {
                    
                    return false;
                    
                }
                public string TypeName
                {
                    get { return s_typename; }
                }
                public Type Type
                {
                    get { return s_type; }
                }
                public IReadOnlyDictionary<string, string> Attributes
                {
                    get { return s_attributes; }
                }
                public string GetAttributeValue(string attributeKey)
                {
                    string ret = null;
                    s_attributes.TryGetValue(attributeKey, out ret);
                    return ret;
                }
            }
            internal static count_descriptor count = new count_descriptor();
            
            internal class ids_descriptor : IFieldDescriptor
            {
                private static IReadOnlyDictionary<string, string> s_attributes = new Dictionary<string, string>
                {
                    
                };
                private static string s_typename = "List<long>";
                private static Type   s_type     = typeof(List<long>);
                public string Name
                {
                    get { return "ids"; }
                }
                public bool Optional
                {
                    get
                    {
                        
                        return false;
                        
                    }
                }
                public bool IsOfType<T>()
                {
                    return typeof(T) == Type;
                }
                public bool IsList()
                {
                    
                    return true;
                    
                }
                public string TypeName
                {
                    get { return s_typename; }
                }
                public Type Type
                {
                    get { return s_type; }
                }
                public IReadOnlyDictionary<string, string> Attributes
                {
                    get { return s_attributes; }
                }
                public string GetAttributeValue(string attributeKey)
                {
                    string ret = null;
                    s_attributes.TryGetValue(attributeKey, out ret);
                    return ret;
                }
            }
            internal static ids_descriptor ids = new ids_descriptor();
            
            #region ICellDescriptor
            public IEnumerable<string> GetFieldNames()
            {
                
                yield return "count";
                
                yield return "ids";
                
            }
            public IAttributeCollection GetFieldAttributes(string fieldName)
            {
                int field_id = global::BTTN4KNFE.BTTN4KNFEDirectory.FieldLookupTable.Lookup(fieldName);
                if (field_id == -1)
                    Throw.undefined_field();
                switch (field_id)
                {
                    
                    case 0:
                        return count;
                    
                    case 1:
                        return ids;
                    
                }
                /* Should not reach here */
                throw new Exception("Internal error T6001");
            }
            public IEnumerable<IFieldDescriptor> GetFieldDescriptors()
            {
                
                yield return count;
                
                yield return ids;
                
            }
            ushort ICellDescriptor.CellType
            {
                get { return (ushort)CellType.BTTN4KNFEDirectory; }
            }
            #endregion
            #region ITypeDescriptor
            public string TypeName
            {
                get { return s_cellTypeName_BTTN4KNFEDirectory; }
            }
            public Type Type
            {
                get { return s_cellType_BTTN4KNFEDirectory; }
            }
            public bool IsOfType<T>()
            {
                return typeof(T) == s_cellType_BTTN4KNFEDirectory;
            }
            public bool IsList()
            {
                return false;
            }
            #endregion
            #region IAttributeCollection
            public IReadOnlyDictionary<string, string> Attributes
            {
                get { return s_attributes; }
            }
            public string GetAttributeValue(string attributeKey)
            {
                string ret = null;
                s_attributes.TryGetValue(attributeKey, out ret);
                return ret;
            }
            #endregion
        }
        internal static readonly BTTN4KNFEDirectory_descriptor s_cellDescriptor_BTTN4KNFEDirectory = new BTTN4KNFEDirectory_descriptor();
        /// <summary>
        /// Get the cell descriptor for BTTN4KNFEDirectory.
        /// </summary>
        public static ICellDescriptor BTTN4KNFEDirectory { get { return s_cellDescriptor_BTTN4KNFEDirectory; } }
        
        internal static readonly Type   s_cellType_BTTNFE_N4K_SealedEnvelope_Cell       = typeof(global::BTTN4KNFE.BTTNFE_N4K_SealedEnvelope_Cell);
        internal static readonly string s_cellTypeName_BTTNFE_N4K_SealedEnvelope_Cell   = "BTTNFE_N4K_SealedEnvelope_Cell";
        internal class BTTNFE_N4K_SealedEnvelope_Cell_descriptor : ICellDescriptor
        {
            private static IReadOnlyDictionary<string, string> s_attributes = new Dictionary<string, string>
            {
                
            };
            internal static bool check_attribute(IAttributeCollection attributes, string attributeKey, string attributeValue)
            {
                if (attributeKey == null)
                    return true;
                if (attributeValue == null)
                    return attributes.Attributes.ContainsKey(attributeKey);
                else
                    return attributes.Attributes.ContainsKey(attributeKey) && attributes.Attributes[attributeKey] == attributeValue;
            }
            
            internal class sealedenvelope_descriptor : IFieldDescriptor
            {
                private static IReadOnlyDictionary<string, string> s_attributes = new Dictionary<string, string>
                {
                    
                };
                private static string s_typename = "BTTNFE_N4K_SealedEnvelope";
                private static Type   s_type     = typeof(BTTNFE_N4K_SealedEnvelope);
                public string Name
                {
                    get { return "sealedenvelope"; }
                }
                public bool Optional
                {
                    get
                    {
                        
                        return false;
                        
                    }
                }
                public bool IsOfType<T>()
                {
                    return typeof(T) == Type;
                }
                public bool IsList()
                {
                    
                    return false;
                    
                }
                public string TypeName
                {
                    get { return s_typename; }
                }
                public Type Type
                {
                    get { return s_type; }
                }
                public IReadOnlyDictionary<string, string> Attributes
                {
                    get { return s_attributes; }
                }
                public string GetAttributeValue(string attributeKey)
                {
                    string ret = null;
                    s_attributes.TryGetValue(attributeKey, out ret);
                    return ret;
                }
            }
            internal static sealedenvelope_descriptor sealedenvelope = new sealedenvelope_descriptor();
            
            #region ICellDescriptor
            public IEnumerable<string> GetFieldNames()
            {
                
                yield return "sealedenvelope";
                
            }
            public IAttributeCollection GetFieldAttributes(string fieldName)
            {
                int field_id = global::BTTN4KNFE.BTTNFE_N4K_SealedEnvelope_Cell.FieldLookupTable.Lookup(fieldName);
                if (field_id == -1)
                    Throw.undefined_field();
                switch (field_id)
                {
                    
                    case 0:
                        return sealedenvelope;
                    
                }
                /* Should not reach here */
                throw new Exception("Internal error T6001");
            }
            public IEnumerable<IFieldDescriptor> GetFieldDescriptors()
            {
                
                yield return sealedenvelope;
                
            }
            ushort ICellDescriptor.CellType
            {
                get { return (ushort)CellType.BTTNFE_N4K_SealedEnvelope_Cell; }
            }
            #endregion
            #region ITypeDescriptor
            public string TypeName
            {
                get { return s_cellTypeName_BTTNFE_N4K_SealedEnvelope_Cell; }
            }
            public Type Type
            {
                get { return s_cellType_BTTNFE_N4K_SealedEnvelope_Cell; }
            }
            public bool IsOfType<T>()
            {
                return typeof(T) == s_cellType_BTTNFE_N4K_SealedEnvelope_Cell;
            }
            public bool IsList()
            {
                return false;
            }
            #endregion
            #region IAttributeCollection
            public IReadOnlyDictionary<string, string> Attributes
            {
                get { return s_attributes; }
            }
            public string GetAttributeValue(string attributeKey)
            {
                string ret = null;
                s_attributes.TryGetValue(attributeKey, out ret);
                return ret;
            }
            #endregion
        }
        internal static readonly BTTNFE_N4K_SealedEnvelope_Cell_descriptor s_cellDescriptor_BTTNFE_N4K_SealedEnvelope_Cell = new BTTNFE_N4K_SealedEnvelope_Cell_descriptor();
        /// <summary>
        /// Get the cell descriptor for BTTNFE_N4K_SealedEnvelope_Cell.
        /// </summary>
        public static ICellDescriptor BTTNFE_N4K_SealedEnvelope_Cell { get { return s_cellDescriptor_BTTNFE_N4K_SealedEnvelope_Cell; } }
        
        internal static readonly Type   s_cellType_BTTVerifiableCredential_SealedEnvelope_Cell       = typeof(global::BTTN4KNFE.BTTVerifiableCredential_SealedEnvelope_Cell);
        internal static readonly string s_cellTypeName_BTTVerifiableCredential_SealedEnvelope_Cell   = "BTTVerifiableCredential_SealedEnvelope_Cell";
        internal class BTTVerifiableCredential_SealedEnvelope_Cell_descriptor : ICellDescriptor
        {
            private static IReadOnlyDictionary<string, string> s_attributes = new Dictionary<string, string>
            {
                
            };
            internal static bool check_attribute(IAttributeCollection attributes, string attributeKey, string attributeValue)
            {
                if (attributeKey == null)
                    return true;
                if (attributeValue == null)
                    return attributes.Attributes.ContainsKey(attributeKey);
                else
                    return attributes.Attributes.ContainsKey(attributeKey) && attributes.Attributes[attributeKey] == attributeValue;
            }
            
            internal class signedenvelope_descriptor : IFieldDescriptor
            {
                private static IReadOnlyDictionary<string, string> s_attributes = new Dictionary<string, string>
                {
                    
                };
                private static string s_typename = "BTTVerifiableCredential_SealedEnvelope";
                private static Type   s_type     = typeof(BTTVerifiableCredential_SealedEnvelope);
                public string Name
                {
                    get { return "signedenvelope"; }
                }
                public bool Optional
                {
                    get
                    {
                        
                        return false;
                        
                    }
                }
                public bool IsOfType<T>()
                {
                    return typeof(T) == Type;
                }
                public bool IsList()
                {
                    
                    return false;
                    
                }
                public string TypeName
                {
                    get { return s_typename; }
                }
                public Type Type
                {
                    get { return s_type; }
                }
                public IReadOnlyDictionary<string, string> Attributes
                {
                    get { return s_attributes; }
                }
                public string GetAttributeValue(string attributeKey)
                {
                    string ret = null;
                    s_attributes.TryGetValue(attributeKey, out ret);
                    return ret;
                }
            }
            internal static signedenvelope_descriptor signedenvelope = new signedenvelope_descriptor();
            
            #region ICellDescriptor
            public IEnumerable<string> GetFieldNames()
            {
                
                yield return "signedenvelope";
                
            }
            public IAttributeCollection GetFieldAttributes(string fieldName)
            {
                int field_id = global::BTTN4KNFE.BTTVerifiableCredential_SealedEnvelope_Cell.FieldLookupTable.Lookup(fieldName);
                if (field_id == -1)
                    Throw.undefined_field();
                switch (field_id)
                {
                    
                    case 0:
                        return signedenvelope;
                    
                }
                /* Should not reach here */
                throw new Exception("Internal error T6001");
            }
            public IEnumerable<IFieldDescriptor> GetFieldDescriptors()
            {
                
                yield return signedenvelope;
                
            }
            ushort ICellDescriptor.CellType
            {
                get { return (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell; }
            }
            #endregion
            #region ITypeDescriptor
            public string TypeName
            {
                get { return s_cellTypeName_BTTVerifiableCredential_SealedEnvelope_Cell; }
            }
            public Type Type
            {
                get { return s_cellType_BTTVerifiableCredential_SealedEnvelope_Cell; }
            }
            public bool IsOfType<T>()
            {
                return typeof(T) == s_cellType_BTTVerifiableCredential_SealedEnvelope_Cell;
            }
            public bool IsList()
            {
                return false;
            }
            #endregion
            #region IAttributeCollection
            public IReadOnlyDictionary<string, string> Attributes
            {
                get { return s_attributes; }
            }
            public string GetAttributeValue(string attributeKey)
            {
                string ret = null;
                s_attributes.TryGetValue(attributeKey, out ret);
                return ret;
            }
            #endregion
        }
        internal static readonly BTTVerifiableCredential_SealedEnvelope_Cell_descriptor s_cellDescriptor_BTTVerifiableCredential_SealedEnvelope_Cell = new BTTVerifiableCredential_SealedEnvelope_Cell_descriptor();
        /// <summary>
        /// Get the cell descriptor for BTTVerifiableCredential_SealedEnvelope_Cell.
        /// </summary>
        public static ICellDescriptor BTTVerifiableCredential_SealedEnvelope_Cell { get { return s_cellDescriptor_BTTVerifiableCredential_SealedEnvelope_Cell; } }
        
        /// <summary>
        /// Enumerates descriptors for all cells defined in the TSL.
        /// </summary>
        public static IEnumerable<ICellDescriptor> CellDescriptors
        {
            get
            {
                
                yield return BTTN4KNFEDirectory;
                
                yield return BTTNFE_N4K_SealedEnvelope_Cell;
                
                yield return BTTVerifiableCredential_SealedEnvelope_Cell;
                
                yield break;
            }
        }
        /// <summary>
        /// Converts a type string to <see cref="BTTN4KNFE.CellType"/>.
        /// </summary>
        /// <param name="cellTypeString">The type string to be converted.</param>
        /// <returns>The converted cell type.</returns>
        public static CellType GetCellType(string cellTypeString)
        {
            CellType ret;
            if (!cellTypeLookupTable.TryGetValue(cellTypeString, out ret))
                throw new Exception("Unrecognized cell type string.");
            return ret;
        }
        #region IStorageSchema implementation
        IEnumerable<ICellDescriptor> IStorageSchema.CellDescriptors
        {
            get { return StorageSchema.CellDescriptors; }
        }
        ushort IStorageSchema.GetCellType(string cellTypeString)
        {
            return (ushort)StorageSchema.GetCellType(cellTypeString);
        }
        IEnumerable<string> IStorageSchema.CellTypeSignatures
        {
            get
            {
                
                yield return "{int|List<long>}";
                
                yield return "{{{string|{List<string>|BTTGenericCredentialType|long|BTTTrustLevel|BTTEncryptionFlag|string|optional string|optional List<string>}|{string|List<string>|optional string|optional {string|DateTime|DateTime|DateTime|DateTime|DateTime|DateTime|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|int|bool|BTTNFEBodyPart|BTTNFEBodyPart|int[150]|int[150]|int[150]|int[150]|int[150]|string|string|string|string|string}|optional {string|string|string}}}|{optional string|optional string|optional string|optional List<string>}}}";
                
                yield return "{{{string|{List<string>|BTTGenericCredentialType|long|BTTTrustLevel|BTTEncryptionFlag|string|optional string|optional List<string>}|{string|List<string>|optional string|optional List<{string|optional string|optional List<{string|string}>|optional List<List<{string|string}>>}>|optional {string|string|string}}}|{optional string|optional string|optional string|optional List<string>}}}";
                
                yield break;
            }
        }
        #endregion
    }
}

#pragma warning restore 162,168,649,660,661,1522
