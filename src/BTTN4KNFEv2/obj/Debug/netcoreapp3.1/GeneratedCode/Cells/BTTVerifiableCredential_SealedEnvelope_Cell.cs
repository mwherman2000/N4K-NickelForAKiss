#pragma warning disable 162,168,649,660,661,1522
using System;
using System.Text;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.InteropServices;
using System.Data;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.ExceptionServices;
using System.Security;
using Trinity;
using Trinity.Core.Lib;
using Trinity.Storage;
using Trinity.Utilities;
using Trinity.TSL.Lib;
using Trinity.Network;
using Trinity.Network.Sockets;
using Trinity.Network.Messaging;
using Trinity.TSL;
using System.Runtime.CompilerServices;
using Trinity.Storage.Transaction;
using Microsoft.Extensions.ObjectPool;
namespace BTTN4KNFE
{
    
    /// <summary>
    /// A .NET runtime object representation of BTTVerifiableCredential_SealedEnvelope_Cell defined in TSL.
    /// </summary>
    public partial struct BTTVerifiableCredential_SealedEnvelope_Cell : ICell
    {
        ///<summary>
        ///The id of the cell.
        ///</summary>
        public long CellId;
        ///<summary>
        ///Initializes a new instance of BTTVerifiableCredential_SealedEnvelope_Cell with the specified parameters.
        ///</summary>
        public BTTVerifiableCredential_SealedEnvelope_Cell(long cell_id , BTTVerifiableCredential_SealedEnvelope signedenvelope = default(BTTVerifiableCredential_SealedEnvelope))
        {
            
            this.signedenvelope = signedenvelope;
            
            CellId = cell_id;
        }
        
        ///<summary>
        ///Initializes a new instance of BTTVerifiableCredential_SealedEnvelope_Cell with the specified parameters.
        ///</summary>
        public BTTVerifiableCredential_SealedEnvelope_Cell( BTTVerifiableCredential_SealedEnvelope signedenvelope = default(BTTVerifiableCredential_SealedEnvelope))
        {
            
            this.signedenvelope = signedenvelope;
            
            CellId = CellIdFactory.NewCellId();
        }
        
        public BTTVerifiableCredential_SealedEnvelope signedenvelope;
        
        public static bool operator ==(BTTVerifiableCredential_SealedEnvelope_Cell a, BTTVerifiableCredential_SealedEnvelope_Cell b)
        {
            if (System.Object.ReferenceEquals(a, b))
            {
                return true;
            }
            if (((object)a == null) || ((object)b == null))
            {
                return false;
            }
            
            return
                
                (a.signedenvelope == b.signedenvelope)
                
                ;
            
        }
        public static bool operator !=(BTTVerifiableCredential_SealedEnvelope_Cell a, BTTVerifiableCredential_SealedEnvelope_Cell b)
        {
            return !(a == b);
        }
        #region Text processing
        /// <summary>
        /// Converts the string representation of a BTTVerifiableCredential_SealedEnvelope_Cell to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(BTTVerifiableCredential_SealedEnvelope_Cell) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        /// True if input was converted successfully; otherwise, false.
        /// </returns>
        public static bool TryParse(string input, out BTTVerifiableCredential_SealedEnvelope_Cell value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<BTTVerifiableCredential_SealedEnvelope_Cell>(input);
                return true;
            }
            catch { value = default(BTTVerifiableCredential_SealedEnvelope_Cell); return false; }
        }
        public static BTTVerifiableCredential_SealedEnvelope_Cell Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BTTVerifiableCredential_SealedEnvelope_Cell>(input);
        }
        ///<summary>Converts a BTTVerifiableCredential_SealedEnvelope_Cell to its string representation, in JSON format.</summary>
        ///<returns>A string representation of the BTTVerifiableCredential_SealedEnvelope_Cell.</returns>
        public override string ToString()
        {
            return Serializer.ToString(this);
        }
        #endregion
        #region Lookup tables
        internal static StringLookupTable FieldLookupTable = new StringLookupTable(
            
            "signedenvelope"
            
            );
        internal static HashSet<string> AppendToFieldRerouteSet = new HashSet<string>()
        {
            
            "signedenvelope"
            ,
        };
        #endregion
        #region ICell implementation
        /// <summary>
        /// Get the field of the specified name in the cell.
        /// </summary>
        /// <typeparam name="T">
        /// The desired type that the field is supposed 
        /// to be interpreted as. Automatic type casting 
        /// will be attempted if the desired type is not 
        /// implicitly convertible from the type of the field.
        /// </typeparam>
        /// <param name="fieldName">The name of the target field.</param>
        /// <returns>The value of the field.</returns>
        public T GetField<T>(string fieldName)
        {
            switch (FieldLookupTable.Lookup(fieldName))
            {
                case -1:
                Throw.undefined_field();
                break;
                
                case 0:
                return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5005");
        }
        /// <summary>
        /// Set the value of the target field.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the value.
        /// </typeparam>
        /// <param name="fieldName">The name of the target field.</param>
        /// <param name="value">
        /// The value of the field. Automatic type casting 
        /// will be attempted if the desired type is not 
        /// implicitly convertible from the type of the field.
        /// </param>
        public void SetField<T>(string fieldName, T value)
        {
            switch (FieldLookupTable.Lookup(fieldName))
            {
                case -1:
                Throw.undefined_field();
                break;
                
                case 0:
                this.signedenvelope = TypeConverter<T>.ConvertTo_BTTVerifiableCredential_SealedEnvelope(value);
                break;
                
                default:
                Throw.data_type_incompatible_with_field(typeof(T).ToString());
                break;
            }
        }
        /// <summary>
        /// Tells if a field with the given name exists in the current cell.
        /// </summary>
        /// <param name="fieldName">The name of the field.</param>
        /// <returns>The existence of the field.</returns>
        public bool ContainsField(string fieldName)
        {
            switch (FieldLookupTable.Lookup(fieldName))
            {
                
                case 0:
                
                return true;
                
                default:
                return false;
            }
        }
        /// <summary>
        /// Append <paramref name="value"/> to the target field. Note that if the target field
        /// is not appendable(string or list), calling this method is equivalent to <see cref="BTTN4KNFE.GenericCellAccessor.SetField(string, T)"/>.
        /// </summary>
        /// <typeparam name="T">
        /// The type of the value.
        /// </typeparam>
        /// <param name="fieldName">The name of the target field.</param>
        /// <param name="value">The value to be appended. 
        /// If the value is incompatible with the element 
        /// type of the field, automatic type casting will be attempted.
        /// </param>
        public void AppendToField<T>(string fieldName, T value)
        {
            if (AppendToFieldRerouteSet.Contains(fieldName))
            {
                SetField(fieldName, value);
                return;
            }
            switch (FieldLookupTable.Lookup(fieldName))
            {
                case -1:
                Throw.undefined_field();
                break;
                
                default:
                Throw.target__field_not_list();
                break;
            }
        }
        long ICell.CellId { get { return CellId; } set { CellId = value; } }
        public IEnumerable<KeyValuePair<string, T>> SelectFields<T>(string attributeKey, string attributeValue)
        {
            switch (TypeConverter<T>.type_id)
            {
                
                case 5:
                
                if (StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.check_attribute(StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.signedenvelope, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("signedenvelope", TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope));
                
                break;
                
                case 8:
                
                if (StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.check_attribute(StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.signedenvelope, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("signedenvelope", TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope));
                
                break;
                
                case 21:
                
                if (StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.check_attribute(StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.signedenvelope, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("signedenvelope", TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope));
                
                break;
                
                case 29:
                
                if (StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.check_attribute(StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.signedenvelope, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("signedenvelope", TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope));
                
                break;
                
                default:
                Throw.incompatible_with_cell();
                break;
            }
            yield break;
        }
        #region enumerate value constructs
        
        private IEnumerable<T> _enumerate_from_signedenvelope<T>()
        {
            
            switch (TypeConverter<T>.type_id)
            {
                
                case 5:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                        
                    }
                    break;
                
                case 8:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                        
                    }
                    break;
                
                case 21:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                        
                    }
                    break;
                
                case 29:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                        
                    }
                    break;
                
                default:
                    Throw.incompatible_with_cell();
                    break;
            }
            yield break;
            
        }
        
        private static StringLookupTable s_field_attribute_id_table = new StringLookupTable(
            
            );
        #endregion
        public IEnumerable<T> EnumerateField<T>(string fieldName)
        {
            switch (FieldLookupTable.Lookup(fieldName))
            {
                
                case 0:
                return _enumerate_from_signedenvelope<T>();
                
                default:
                Throw.undefined_field();
                return null;
            }
        }
        public IEnumerable<T> EnumerateValues<T>(string attributeKey, string attributeValue)
        {
            int attr_id;
            if (attributeKey == null)
            {
                
                foreach (var val in _enumerate_from_signedenvelope<T>())
                    yield return val;
                
            }
            else if (-1 != (attr_id = s_field_attribute_id_table.Lookup(attributeKey)))
            {
                switch (attr_id)
                {
                    
                }
            }
            yield break;
        }
        public ICellAccessor Serialize()
        {
            return (BTTVerifiableCredential_SealedEnvelope_Cell_Accessor)this;
        }
        #endregion
        #region Other interfaces
        string ITypeDescriptor.TypeName
        {
            get { return StorageSchema.s_cellTypeName_BTTVerifiableCredential_SealedEnvelope_Cell; }
        }
        Type ITypeDescriptor.Type
        {
            get { return StorageSchema.s_cellType_BTTVerifiableCredential_SealedEnvelope_Cell; }
        }
        bool ITypeDescriptor.IsOfType<T>()
        {
            return typeof(T) == StorageSchema.s_cellType_BTTVerifiableCredential_SealedEnvelope_Cell;
        }
        bool ITypeDescriptor.IsList()
        {
            return false;
        }
        IEnumerable<IFieldDescriptor> ICellDescriptor.GetFieldDescriptors()
        {
            return StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell.GetFieldDescriptors();
        }
        IAttributeCollection ICellDescriptor.GetFieldAttributes(string fieldName)
        {
            return StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell.GetFieldAttributes(fieldName);
        }
        string IAttributeCollection.GetAttributeValue(string attributeKey)
        {
            return StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell.GetAttributeValue(attributeKey);
        }
        IReadOnlyDictionary<string, string> IAttributeCollection.Attributes
        {
            get { return StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell.Attributes; }
        }
        IEnumerable<string> ICellDescriptor.GetFieldNames()
        {
            
            {
                yield return "signedenvelope";
            }
            
        }
        ushort ICellDescriptor.CellType
        {
            get
            {
                return (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell;
            }
        }
        #endregion
    }
    /// <summary>
    /// Provides in-place operations of BTTVerifiableCredential_SealedEnvelope_Cell defined in TSL.
    /// </summary>
    public unsafe class BTTVerifiableCredential_SealedEnvelope_Cell_Accessor : ICellAccessor
    {
        #region Fields
        internal   long                    m_cellId;
        /// <summary>
        /// A pointer to the underlying raw binary blob. Take caution when accessing data with
        /// the raw pointer, as no boundary checks are employed, and improper operations will cause data corruption and/or system crash.
        /// </summary>
        internal byte*                   m_ptr;
        internal LocalTransactionContext m_tx;
        internal int                     m_cellEntryIndex;
        internal CellAccessOptions       m_options;
        internal bool                    m_IsIterator;
        private  const CellAccessOptions c_WALFlags = CellAccessOptions.StrongLogAhead | CellAccessOptions.WeakLogAhead;
        #endregion
        #region Constructors
        private unsafe BTTVerifiableCredential_SealedEnvelope_Cell_Accessor()
        {
                    signedenvelope_Accessor_Field = new BTTVerifiableCredential_SealedEnvelope_Accessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });
        }
        #endregion
        
        internal static string[] optional_field_names = null;
        ///<summary>
        ///Get an array of the names of all optional fields for object type t_struct_name.
        ///</summary>
        public static string[] GetOptionalFieldNames()
        {
            if (optional_field_names == null)
                optional_field_names = new string[]
                {
                    
                };
            return optional_field_names;
        }
        ///<summary>
        ///Get a list of the names of available optional fields in the object being operated by this accessor.
        ///</summary>
        internal List<string> GetNotNullOptionalFields()
        {
            List<string> list = new List<string>();
            BitArray ba = new BitArray(GetOptionalFieldMap());
            string[] optional_fields = GetOptionalFieldNames();
            for (int i = 0; i < ba.Count; i++)
            {
                if (ba[i])
                    list.Add(optional_fields[i]);
            }
            return list;
        }
        internal unsafe byte[] GetOptionalFieldMap()
        {
            
            return new byte[0];
            
        }
        
        #region IAccessor Implementation
        public byte[] ToByteArray()
        {
            byte* targetPtr = m_ptr;
            {{{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_6 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_6 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_6 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_6 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_6 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_6 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_6 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}{            byte* optheader_4 = targetPtr;
            targetPtr += 1;

                if ((0 != (*(optheader_4 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_4 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_4 + 0) & 0x04)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_4 + 0) & 0x08)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}}
            int size = (int)(targetPtr - m_ptr);
            byte[] ret = new byte[size];
            Memory.Copy(m_ptr, 0, ret, 0, size);
            return ret;
        }
        public unsafe byte* GetUnderlyingBufferPointer()
        {
            return m_ptr;
        }
        public unsafe int GetBufferLength()
        {
            byte* targetPtr = m_ptr;
            {{{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_6 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_6 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_6 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_6 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_6 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_6 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_6 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}{            byte* optheader_4 = targetPtr;
            targetPtr += 1;

                if ((0 != (*(optheader_4 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_4 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_4 + 0) & 0x04)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_4 + 0) & 0x08)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}}
            int size = (int)(targetPtr - m_ptr);
            return size;
        }
        public ResizeFunctionDelegate ResizeFunction { get; set; }
        #endregion
        private static byte[] s_default_content = null;
        private static unsafe byte[] construct( BTTVerifiableCredential_SealedEnvelope signedenvelope = default(BTTVerifiableCredential_SealedEnvelope) )
        {
            if (s_default_content != null) return s_default_content;
            
            byte* targetPtr;
            
            targetPtr = null;
            
            {

            {

            {

        if(signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = signedenvelope.envelope.udid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.types[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            targetPtr += 1;
            targetPtr += 8;
            targetPtr += 1;
            targetPtr += 1;

        if(signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.notaryudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.label.name!= null)
            {

        if(signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.name.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.label.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            {
            targetPtr += 1;

        if(signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.udid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.context[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            targetPtr += 1;

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

        }
    }

}

            }

            }
        }
    }

}

            }
            if( signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            }

            }
            }
            {
            targetPtr += 1;
            if( signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = signedenvelope.proof.hashedThumbprint64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.signedHashSignature64!= null)
            {

        if(signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = signedenvelope.proof.signedHashSignature64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.notaryStamp!= null)
            {

        if(signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = signedenvelope.proof.notaryStamp.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = signedenvelope.proof.comments[iterator_4].Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            }
            }
            byte[] tmpcell = new byte[(int)(targetPtr)];
            fixed (byte* _tmpcellptr = tmpcell)
            {
                targetPtr = _tmpcellptr;
                
            {

            {

            {

        if(signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = signedenvelope.envelope.udid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.envelope.udid)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.types[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.label.types[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            *(BTTGenericCredentialType*)targetPtr = signedenvelope.envelope.label.credtype;
            targetPtr += 1;
            *(long*)targetPtr = signedenvelope.envelope.label.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = signedenvelope.envelope.label.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = signedenvelope.envelope.label.encryptionFlag;
            targetPtr += 1;

        if(signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.label.notaryudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.label.name!= null)
            {

        if(signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.name.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.label.name)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.label.comments!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.label.comments[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }

            }
            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

        if(signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.udid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.content.udid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.context[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.context[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            if( signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.content.credentialsubjectudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            byte* optheader_6 = targetPtr;
            *(optheader_6 + 0) = 0x00;            targetPtr += 1;

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_6 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x02;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{
byte *storedPtr_8 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_8 = (int)(targetPtr - storedPtr_8 - 4);

}

        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x04;
            }

            }
        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }
            if( signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.key)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_4 + 0) |= 0x04;
            }

            }
            }
            {
            byte* optheader_3 = targetPtr;
            *(optheader_3 + 0) = 0x00;            targetPtr += 1;
            if( signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = signedenvelope.proof.hashedThumbprint64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.hashedThumbprint64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x01;
            }
            if( signedenvelope.proof.signedHashSignature64!= null)
            {

        if(signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = signedenvelope.proof.signedHashSignature64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.signedHashSignature64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x02;
            }
            if( signedenvelope.proof.notaryStamp!= null)
            {

        if(signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = signedenvelope.proof.notaryStamp.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.notaryStamp)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x04;
            }
            if( signedenvelope.proof.comments!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = signedenvelope.proof.comments[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.proof.comments[iterator_4])
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_4 = (int)(targetPtr - storedPtr_4 - 4);

}
*(optheader_3 + 0) |= 0x08;
            }

            }
            }
            }
            }
            
            s_default_content = tmpcell;
            return tmpcell;
        }
        BTTVerifiableCredential_SealedEnvelope_Accessor signedenvelope_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field signedenvelope.
        ///</summary>
        public unsafe BTTVerifiableCredential_SealedEnvelope_Accessor signedenvelope
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {}signedenvelope_Accessor_Field.m_ptr = targetPtr;
                signedenvelope_Accessor_Field.m_cellId = this.m_cellId;
                return signedenvelope_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                signedenvelope_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {}
                int offset = (int)(targetPtr - m_ptr);
                byte* oldtargetPtr = targetPtr;
                int oldlength = (int)(targetPtr - oldtargetPtr);
                targetPtr = value.m_ptr;
                int newlength = (int)(targetPtr - value.m_ptr);
                if (newlength != oldlength)
                {
                    if (value.m_cellId != this.m_cellId)
                    {
                        this.m_ptr = this.ResizeFunction(this.m_ptr, offset, newlength - oldlength);
                        Memory.Copy(value.m_ptr, this.m_ptr + offset, newlength);
                    }
                    else
                    {
                        byte[] tmpcell = new byte[newlength];
                        fixed(byte* tmpcellptr = tmpcell)
                        {
                            Memory.Copy(value.m_ptr, tmpcellptr, newlength);
                            this.m_ptr = this.ResizeFunction(this.m_ptr, offset, newlength - oldlength);
                            Memory.Copy(tmpcellptr, this.m_ptr + offset, newlength);
                        }
                    }
                }
                else
                {
                    Memory.Copy(value.m_ptr, oldtargetPtr, oldlength);
                }
            }
        }
        
        public static unsafe implicit operator BTTVerifiableCredential_SealedEnvelope_Cell(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor accessor)
        {
            
            return new BTTVerifiableCredential_SealedEnvelope_Cell(accessor.CellId
            
            ,
            
                    accessor.signedenvelope
            );
        }
        
        public unsafe static implicit operator BTTVerifiableCredential_SealedEnvelope_Cell_Accessor(BTTVerifiableCredential_SealedEnvelope_Cell field)
        {
            byte* targetPtr = null;
            
            {

            {

            {

        if(field.signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = field.signedenvelope.envelope.udid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(field.signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.label.types[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            targetPtr += 1;
            targetPtr += 8;
            targetPtr += 1;
            targetPtr += 1;

        if(field.signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = field.signedenvelope.envelope.label.notaryudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( field.signedenvelope.envelope.label.name!= null)
            {

        if(field.signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = field.signedenvelope.envelope.label.name.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.signedenvelope.envelope.label.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(field.signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            {
            targetPtr += 1;

        if(field.signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = field.signedenvelope.envelope.content.udid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(field.signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.content.context[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( field.signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(field.signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = field.signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            targetPtr += 1;

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

            }
            if( field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

        }
    }

}

            }

            }
        }
    }

}

            }
            if( field.signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(field.signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            }

            }
            }
            {
            targetPtr += 1;
            if( field.signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(field.signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = field.signedenvelope.proof.hashedThumbprint64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.signedenvelope.proof.signedHashSignature64!= null)
            {

        if(field.signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = field.signedenvelope.proof.signedHashSignature64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.signedenvelope.proof.notaryStamp!= null)
            {

        if(field.signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = field.signedenvelope.proof.notaryStamp.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.signedenvelope.proof.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(field.signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = field.signedenvelope.proof.comments[iterator_4].Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            }
            }
            byte* tmpcellptr = BufferAllocator.AllocBuffer((int)targetPtr);
            Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
            targetPtr = tmpcellptr;
            
            {

            {

            {

        if(field.signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = field.signedenvelope.envelope.udid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.signedenvelope.envelope.udid)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(field.signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.label.types[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.signedenvelope.envelope.label.types[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            *(BTTGenericCredentialType*)targetPtr = field.signedenvelope.envelope.label.credtype;
            targetPtr += 1;
            *(long*)targetPtr = field.signedenvelope.envelope.label.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = field.signedenvelope.envelope.label.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = field.signedenvelope.envelope.label.encryptionFlag;
            targetPtr += 1;

        if(field.signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = field.signedenvelope.envelope.label.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.signedenvelope.envelope.label.notaryudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( field.signedenvelope.envelope.label.name!= null)
            {

        if(field.signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = field.signedenvelope.envelope.label.name.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.signedenvelope.envelope.label.name)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( field.signedenvelope.envelope.label.comments!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(field.signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.signedenvelope.envelope.label.comments[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }

            }
            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

        if(field.signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = field.signedenvelope.envelope.content.udid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.signedenvelope.envelope.content.udid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(field.signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.content.context[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.signedenvelope.envelope.content.context[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            if( field.signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(field.signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = field.signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.signedenvelope.envelope.content.credentialsubjectudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( field.signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            byte* optheader_6 = targetPtr;
            *(optheader_6 + 0) = 0x00;            targetPtr += 1;

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_6 + 0) |= 0x01;
            }
            if( field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x02;
            }
            if( field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{
byte *storedPtr_8 = targetPtr;

    targetPtr += sizeof(int);
    if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = field.signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_8 = (int)(targetPtr - storedPtr_8 - 4);

}

        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x04;
            }

            }
        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }
            if( field.signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(field.signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.signedenvelope.envelope.content.encryptedclaims.Value.key)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_4 + 0) |= 0x04;
            }

            }
            }
            {
            byte* optheader_3 = targetPtr;
            *(optheader_3 + 0) = 0x00;            targetPtr += 1;
            if( field.signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(field.signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = field.signedenvelope.proof.hashedThumbprint64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.signedenvelope.proof.hashedThumbprint64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x01;
            }
            if( field.signedenvelope.proof.signedHashSignature64!= null)
            {

        if(field.signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = field.signedenvelope.proof.signedHashSignature64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.signedenvelope.proof.signedHashSignature64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x02;
            }
            if( field.signedenvelope.proof.notaryStamp!= null)
            {

        if(field.signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = field.signedenvelope.proof.notaryStamp.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.signedenvelope.proof.notaryStamp)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x04;
            }
            if( field.signedenvelope.proof.comments!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(field.signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(field.signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = field.signedenvelope.proof.comments[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.signedenvelope.proof.comments[iterator_4])
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_4 = (int)(targetPtr - storedPtr_4 - 4);

}
*(optheader_3 + 0) |= 0x08;
            }

            }
            }
            }BTTVerifiableCredential_SealedEnvelope_Cell_Accessor ret;
            
            ret = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Setup(field.CellId, tmpcellptr, -1, 0, null);
            ret.m_cellId = field.CellId;
            
            return ret;
        }
        
        public static bool operator ==(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor a, BTTVerifiableCredential_SealedEnvelope_Cell_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {{{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_7 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_7 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_7 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_7 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_7 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_7 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_7 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}{            byte* optheader_5 = targetPtr;
            targetPtr += 1;

                if ((0 != (*(optheader_5 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x04)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x08)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {{{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_7 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_7 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_7 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_7 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_7 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_7 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_7 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}{            byte* optheader_5 = targetPtr;
            targetPtr += 1;

                if ((0 != (*(optheader_5 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x04)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x08)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (BTTVerifiableCredential_SealedEnvelope_Cell_Accessor a, BTTVerifiableCredential_SealedEnvelope_Cell_Accessor b)
        {
            return !(a == b);
        }
        
        public static bool operator ==(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor a, BTTVerifiableCredential_SealedEnvelope_Cell b)
        {
            BTTVerifiableCredential_SealedEnvelope_Cell_Accessor bb = b;
            return (a == bb);
        }
        public static bool operator !=(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor a, BTTVerifiableCredential_SealedEnvelope_Cell b)
        {
            return !(a == b);
        }
        /// <summary>
        /// Get the size of the cell content, in bytes.
        /// </summary>
        public int CellSize { get { int size; Global.LocalStorage.LockedGetCellSize(this.CellId, this.m_cellEntryIndex, out size); return size; } }
        #region Internal
        private unsafe byte* _Resize_NonTx(byte* ptr, int ptr_offset, int delta)
        {
            int offset = (int)(ptr - m_ptr) + ptr_offset;
            m_ptr = Global.LocalStorage.ResizeCell((long)CellId, m_cellEntryIndex, offset, delta);
            return m_ptr + (offset - ptr_offset);
        }
        private unsafe byte* _Resize_Tx(byte* ptr, int ptr_offset, int delta)
        {
            int offset = (int)(ptr - m_ptr) + ptr_offset;
            m_ptr = Global.LocalStorage.ResizeCell(m_tx, (long)CellId, m_cellEntryIndex, offset, delta);
            return m_ptr + (offset - ptr_offset);
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal unsafe BTTVerifiableCredential_SealedEnvelope_Cell_Accessor _Lock(long cellId, CellAccessOptions options)
        {
            ushort cellType;
            this.CellId = cellId;
            this.m_options = options;
            this.ResizeFunction = _Resize_NonTx;
            TrinityErrorCode eResult = Global.LocalStorage.GetLockedCellInfo(cellId, out _, out cellType, out this.m_ptr, out this.m_cellEntryIndex);
            switch (eResult)
            {
                case TrinityErrorCode.E_SUCCESS:
                {
                    if (cellType != (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell)
                    {
                        Global.LocalStorage.ReleaseCellLock(cellId, this.m_cellEntryIndex);
                        _put(this);
                        Throw.wrong_cell_type();
                    }
                    break;
                }
                case TrinityErrorCode.E_CELL_NOT_FOUND:
                {
                    if ((options & CellAccessOptions.ThrowExceptionOnCellNotFound) != 0)
                    {
                        _put(this);
                        Throw.cell_not_found(cellId);
                    }
                    else if ((options & CellAccessOptions.CreateNewOnCellNotFound) != 0)
                    {
                        byte[]  defaultContent = construct();
                        int     size           = defaultContent.Length;
                        eResult                = Global.LocalStorage.AddOrUse(cellId, defaultContent, ref size, (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell, out this.m_ptr, out this.m_cellEntryIndex);
                        if (eResult == TrinityErrorCode.E_WRONG_CELL_TYPE)
                        {
                            _put(this);
                            Throw.wrong_cell_type();
                        }
                    }
                    else if ((options & CellAccessOptions.ReturnNullOnCellNotFound) != 0)
                    {
                        _put(this);
                        return null;
                    }
                    else
                    {
                        _put(this);
                        Throw.cell_not_found(cellId);
                    }
                    break;
                }
                default:
                _put(this);
                throw new NotImplementedException();
            }
            return this;
        }
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal unsafe BTTVerifiableCredential_SealedEnvelope_Cell_Accessor _Lock(long cellId, CellAccessOptions options, LocalTransactionContext tx)
        {
            ushort cellType;
            this.CellId = cellId;
            this.m_options = options;
            this.m_tx = tx;
            this.ResizeFunction = _Resize_Tx;
            TrinityErrorCode eResult = Global.LocalStorage.GetLockedCellInfo(tx, cellId, out _, out cellType, out this.m_ptr, out this.m_cellEntryIndex);
            switch (eResult)
            {
                case TrinityErrorCode.E_SUCCESS:
                {
                    if (cellType != (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell)
                    {
                        Global.LocalStorage.ReleaseCellLock(tx, cellId, this.m_cellEntryIndex);
                        _put(this);
                        Throw.wrong_cell_type();
                    }
                    break;
                }
                case TrinityErrorCode.E_CELL_NOT_FOUND:
                {
                    if ((options & CellAccessOptions.ThrowExceptionOnCellNotFound) != 0)
                    {
                        _put(this);
                        Throw.cell_not_found(cellId);
                    }
                    else if ((options & CellAccessOptions.CreateNewOnCellNotFound) != 0)
                    {
                        byte[]  defaultContent = construct();
                        int     size           = defaultContent.Length;
                        eResult                = Global.LocalStorage.AddOrUse(tx, cellId, defaultContent, ref size, (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell, out this.m_ptr, out this.m_cellEntryIndex);
                        if (eResult == TrinityErrorCode.E_WRONG_CELL_TYPE)
                        {
                            _put(this);
                            Throw.wrong_cell_type();
                        }
                    }
                    else if ((options & CellAccessOptions.ReturnNullOnCellNotFound) != 0)
                    {
                        _put(this);
                        return null;
                    }
                    else
                    {
                        _put(this);
                        Throw.cell_not_found(cellId);
                    }
                    break;
                }
                default:
                _put(this);
                throw new NotImplementedException();
            }
            return this;
        }
        private class PoolPolicy : IPooledObjectPolicy<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>
        {
            public BTTVerifiableCredential_SealedEnvelope_Cell_Accessor Create()
            {
                return new BTTVerifiableCredential_SealedEnvelope_Cell_Accessor();
            }
            public bool Return(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor obj)
            {
                return !obj.m_IsIterator;
            }
        }
        private static DefaultObjectPool<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor> s_accessor_pool = new DefaultObjectPool<BTTVerifiableCredential_SealedEnvelope_Cell_Accessor>(new PoolPolicy());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static BTTVerifiableCredential_SealedEnvelope_Cell_Accessor _get() => s_accessor_pool.Get();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void _put(BTTVerifiableCredential_SealedEnvelope_Cell_Accessor item) => s_accessor_pool.Return(item);
        /// <summary>
        /// For internal use only.
        /// Caller guarantees that entry lock is obtained.
        /// Does not handle CellAccessOptions. Only copy to the accessor.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal BTTVerifiableCredential_SealedEnvelope_Cell_Accessor _Setup(long CellId, byte* cellPtr, int entryIndex, CellAccessOptions options)
        {
            this.CellId      = CellId;
            m_cellEntryIndex = entryIndex;
            m_options        = options;
            m_ptr            = cellPtr;
            m_tx             = null;
            this.ResizeFunction = _Resize_NonTx;
            return this;
        }
        /// <summary>
        /// For internal use only.
        /// Caller guarantees that entry lock is obtained.
        /// Does not handle CellAccessOptions. Only copy to the accessor.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal BTTVerifiableCredential_SealedEnvelope_Cell_Accessor _Setup(long CellId, byte* cellPtr, int entryIndex, CellAccessOptions options, LocalTransactionContext tx)
        {
            this.CellId      = CellId;
            m_cellEntryIndex = entryIndex;
            m_options        = options;
            m_ptr            = cellPtr;
            m_tx             = tx;
            this.ResizeFunction = _Resize_Tx;
            return this;
        }
        /// <summary>
        /// For internal use only.
        /// </summary>
        internal static BTTVerifiableCredential_SealedEnvelope_Cell_Accessor AllocIterativeAccessor(CellInfo info, LocalTransactionContext tx)
        {
            BTTVerifiableCredential_SealedEnvelope_Cell_Accessor accessor = new BTTVerifiableCredential_SealedEnvelope_Cell_Accessor();
            accessor.m_IsIterator = true;
            if (tx != null) accessor._Setup(info.CellId, info.CellPtr, info.CellEntryIndex, 0, tx);
            else accessor._Setup(info.CellId, info.CellPtr, info.CellEntryIndex, 0);
            return accessor;
        }
        #endregion
        #region Public
        /// <summary>
        /// Dispose the accessor.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// the cell lock will be released.
        /// If write-ahead-log behavior is specified on <see cref="BTTN4KNFE.StorageExtension_BTTVerifiableCredential_SealedEnvelope_Cell.UseBTTVerifiableCredential_SealedEnvelope_Cell"/>,
        /// the changes will be committed to the write-ahead log.
        /// </summary>
        public void Dispose()
        {
            if (m_cellEntryIndex >= 0)
            {
                if ((m_options & c_WALFlags) != 0)
                {
                    LocalMemoryStorage.CWriteAheadLog(this.CellId, this.m_ptr, this.CellSize, (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell, m_options);
                }
                if (!m_IsIterator)
                {
                    if (m_tx == null) Global.LocalStorage.ReleaseCellLock(CellId, m_cellEntryIndex);
                    else Global.LocalStorage.ReleaseCellLock(m_tx, CellId, m_cellEntryIndex);
                }
            }
            _put(this);
        }
        /// <summary>
        /// Get the cell type id.
        /// </summary>
        /// <returns>A 16-bit unsigned integer representing the cell type id.</returns>
        public ushort GetCellType()
        {
            ushort cellType;
            if (Global.LocalStorage.GetCellType(CellId, out cellType) == TrinityErrorCode.E_CELL_NOT_FOUND)
            {
                Throw.cell_not_found();
            }
            return cellType;
        }
        /// <summary>Converts a BTTVerifiableCredential_SealedEnvelope_Cell_Accessor to its string representation, in JSON format.</summary>
        /// <returns>A string representation of the BTTVerifiableCredential_SealedEnvelope_Cell.</returns>
        public override string ToString()
        {
            return Serializer.ToString(this);
        }
        #endregion
        #region Lookup tables
        internal static StringLookupTable FieldLookupTable = new StringLookupTable(
            
            "signedenvelope"
            
            );
        static HashSet<string> AppendToFieldRerouteSet = new HashSet<string>()
        {
            
            "signedenvelope"
            ,
        };
        #endregion
        #region ICell implementation
        public T GetField<T>(string fieldName)
        {
            int field_divider_idx = fieldName.IndexOf('.');
            if (-1 != field_divider_idx)
            {
                string field_name_string = fieldName.Substring(0, field_divider_idx);
                switch (FieldLookupTable.Lookup(field_name_string))
                {
                    case -1:
                    Throw.undefined_field();
                    break;
                    
                    case 0:
                    return GenericFieldAccessor.GetField<T>(this.signedenvelope, fieldName, field_divider_idx + 1);
                    
                    default:
                    Throw.member_access_on_non_struct__field(field_name_string);
                    break;
                }
            }
            switch (FieldLookupTable.Lookup(fieldName))
            {
                case -1:
                Throw.undefined_field();
                break;
                
                case 0:
                return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5005");
        }
        public void SetField<T>(string fieldName, T value)
        {
            int field_divider_idx = fieldName.IndexOf('.');
            if (-1 != field_divider_idx)
            {
                string field_name_string = fieldName.Substring(0, field_divider_idx);
                switch (FieldLookupTable.Lookup(field_name_string))
                {
                    case -1:
                    Throw.undefined_field();
                    break;
                    
                    case 0:
                    GenericFieldAccessor.SetField(this.signedenvelope, fieldName, field_divider_idx + 1, value);
                    break;
                    
                    default:
                    Throw.member_access_on_non_struct__field(field_name_string);
                    break;
                }
                return;
            }
            switch (FieldLookupTable.Lookup(fieldName))
            {
                case -1:
                Throw.undefined_field();
                break;
                
                case 0:
                {
                    BTTVerifiableCredential_SealedEnvelope conversion_result = TypeConverter<T>.ConvertTo_BTTVerifiableCredential_SealedEnvelope(value);
                    
            {
                this.signedenvelope = conversion_result;
            }
            
                }
                break;
                
            }
        }
        /// <summary>
        /// Tells if a field with the given name exists in the current cell.
        /// </summary>
        /// <param name="fieldName">The name of the field.</param>
        /// <returns>The existence of the field.</returns>
        public bool ContainsField(string fieldName)
        {
            switch (FieldLookupTable.Lookup(fieldName))
            {
                
                case 0:
                
                return true;
                
                default:
                return false;
            }
        }
        public void AppendToField<T>(string fieldName, T value)
        {
            if (AppendToFieldRerouteSet.Contains(fieldName))
            {
                SetField(fieldName, value);
                return;
            }
            switch (FieldLookupTable.Lookup(fieldName))
            {
                case -1:
                Throw.undefined_field();
                break;
                
                default:
                Throw.target__field_not_list();
                break;
            }
        }
        public long CellId { get { return m_cellId; } set { m_cellId = value; } }
        IEnumerable<KeyValuePair<string, T>> ICell.SelectFields<T>(string attributeKey, string attributeValue)
        {
            switch (TypeConverter<T>.type_id)
            {
                
                case 5:
                
                if (StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.check_attribute(StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.signedenvelope, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("signedenvelope", TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope));
                
                break;
                
                case 8:
                
                if (StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.check_attribute(StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.signedenvelope, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("signedenvelope", TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope));
                
                break;
                
                case 21:
                
                if (StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.check_attribute(StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.signedenvelope, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("signedenvelope", TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope));
                
                break;
                
                case 29:
                
                if (StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.check_attribute(StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell_descriptor.signedenvelope, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("signedenvelope", TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope));
                
                break;
                
                default:
                Throw.incompatible_with_cell();
                break;
            }
            yield break;
        }
        #region enumerate value methods
        
        private IEnumerable<T> _enumerate_from_signedenvelope<T>()
        {
            
            switch (TypeConverter<T>.type_id)
            {
                
                case 5:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                        
                    }
                    break;
                
                case 8:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                        
                    }
                    break;
                
                case 21:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                        
                    }
                    break;
                
                case 29:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_BTTVerifiableCredential_SealedEnvelope(this.signedenvelope);
                        
                    }
                    break;
                
                default:
                    Throw.incompatible_with_cell();
                    break;
            }
            yield break;
            
        }
        
        private static StringLookupTable s_field_attribute_id_table = new StringLookupTable(
            
            );
        #endregion
        public IEnumerable<T> EnumerateField<T>(string fieldName)
        {
            switch (FieldLookupTable.Lookup(fieldName))
            {
                
                case 0:
                return _enumerate_from_signedenvelope<T>();
                
                default:
                Throw.undefined_field();
                return null;
            }
        }
        IEnumerable<T> ICell.EnumerateValues<T>(string attributeKey, string attributeValue)
        {
            int attr_id;
            if (attributeKey == null)
            {
                
                foreach (var val in _enumerate_from_signedenvelope<T>())
                    yield return val;
                
            }
            else if (-1 != (attr_id = s_field_attribute_id_table.Lookup(attributeKey)))
            {
                switch (attr_id)
                {
                    
                }
            }
            yield break;
        }
        IEnumerable<string> ICellDescriptor.GetFieldNames()
        {
            
            {
                yield return "signedenvelope";
            }
            
        }
        IAttributeCollection ICellDescriptor.GetFieldAttributes(string fieldName)
        {
            return StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell.GetFieldAttributes(fieldName);
        }
        IEnumerable<IFieldDescriptor> ICellDescriptor.GetFieldDescriptors()
        {
            return StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell.GetFieldDescriptors();
        }
        string ITypeDescriptor.TypeName
        {
            get { return StorageSchema.s_cellTypeName_BTTVerifiableCredential_SealedEnvelope_Cell; }
        }
        Type ITypeDescriptor.Type
        {
            get { return StorageSchema.s_cellType_BTTVerifiableCredential_SealedEnvelope_Cell; }
        }
        bool ITypeDescriptor.IsOfType<T>()
        {
            return typeof(T) == StorageSchema.s_cellType_BTTVerifiableCredential_SealedEnvelope_Cell;
        }
        bool ITypeDescriptor.IsList()
        {
            return false;
        }
        IReadOnlyDictionary<string, string> IAttributeCollection.Attributes
        {
            get { return StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell.Attributes; }
        }
        string IAttributeCollection.GetAttributeValue(string attributeKey)
        {
            return StorageSchema.BTTVerifiableCredential_SealedEnvelope_Cell.GetAttributeValue(attributeKey);
        }
        ushort ICellDescriptor.CellType
        {
            get
            {
                return (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell;
            }
        }
        public ICellAccessor Serialize()
        {
            return this;
        }
        #endregion
        public ICell Deserialize()
        {
            return (BTTVerifiableCredential_SealedEnvelope_Cell)this;
        }
    }
    ///<summary>
    ///Provides interfaces for accessing BTTVerifiableCredential_SealedEnvelope_Cell cells
    ///on <see cref="Trinity.Storage.LocalMemorySotrage"/>.
    static public class StorageExtension_BTTVerifiableCredential_SealedEnvelope_Cell
    {
        #region IKeyValueStore non logging
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The value of the cell is specified in the method parameters.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.IKeyValueStore"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this IKeyValueStore storage, long cellId, BTTVerifiableCredential_SealedEnvelope signedenvelope = default(BTTVerifiableCredential_SealedEnvelope))
        {
            
            byte* targetPtr;
            
            targetPtr = null;
            
            {

            {

            {

        if(signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = signedenvelope.envelope.udid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.types[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            targetPtr += 1;
            targetPtr += 8;
            targetPtr += 1;
            targetPtr += 1;

        if(signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.notaryudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.label.name!= null)
            {

        if(signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.name.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.label.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            {
            targetPtr += 1;

        if(signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.udid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.context[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            targetPtr += 1;

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

        }
    }

}

            }

            }
        }
    }

}

            }
            if( signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            }

            }
            }
            {
            targetPtr += 1;
            if( signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = signedenvelope.proof.hashedThumbprint64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.signedHashSignature64!= null)
            {

        if(signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = signedenvelope.proof.signedHashSignature64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.notaryStamp!= null)
            {

        if(signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = signedenvelope.proof.notaryStamp.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = signedenvelope.proof.comments[iterator_4].Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            }
            }
            byte[] tmpcell = new byte[(int)(targetPtr)];
            fixed (byte* _tmpcellptr = tmpcell)
            {
                targetPtr = _tmpcellptr;
                
            {

            {

            {

        if(signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = signedenvelope.envelope.udid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.envelope.udid)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.types[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.label.types[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            *(BTTGenericCredentialType*)targetPtr = signedenvelope.envelope.label.credtype;
            targetPtr += 1;
            *(long*)targetPtr = signedenvelope.envelope.label.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = signedenvelope.envelope.label.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = signedenvelope.envelope.label.encryptionFlag;
            targetPtr += 1;

        if(signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.label.notaryudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.label.name!= null)
            {

        if(signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.name.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.label.name)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.label.comments!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.label.comments[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }

            }
            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

        if(signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.udid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.content.udid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.context[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.context[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            if( signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.content.credentialsubjectudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            byte* optheader_6 = targetPtr;
            *(optheader_6 + 0) = 0x00;            targetPtr += 1;

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_6 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x02;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{
byte *storedPtr_8 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_8 = (int)(targetPtr - storedPtr_8 - 4);

}

        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x04;
            }

            }
        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }
            if( signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.key)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_4 + 0) |= 0x04;
            }

            }
            }
            {
            byte* optheader_3 = targetPtr;
            *(optheader_3 + 0) = 0x00;            targetPtr += 1;
            if( signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = signedenvelope.proof.hashedThumbprint64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.hashedThumbprint64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x01;
            }
            if( signedenvelope.proof.signedHashSignature64!= null)
            {

        if(signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = signedenvelope.proof.signedHashSignature64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.signedHashSignature64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x02;
            }
            if( signedenvelope.proof.notaryStamp!= null)
            {

        if(signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = signedenvelope.proof.notaryStamp.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.notaryStamp)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x04;
            }
            if( signedenvelope.proof.comments!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = signedenvelope.proof.comments[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.proof.comments[iterator_4])
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_4 = (int)(targetPtr - storedPtr_4 - 4);

}
*(optheader_3 + 0) |= 0x08;
            }

            }
            }
            }
            }
            
            return storage.SaveCell(cellId, tmpcell, (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell) == TrinityErrorCode.E_SUCCESS;
        }
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The parameter <paramref name="cellId"/> overrides the cell id in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.IKeyValueStore"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this IKeyValueStore storage, long cellId, BTTVerifiableCredential_SealedEnvelope_Cell cellContent)
        {
            return SaveBTTVerifiableCredential_SealedEnvelope_Cell(storage, cellId  , cellContent.signedenvelope );
        }
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. Cell Id is specified by the CellId field in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.IKeyValueStore"/> instance.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this IKeyValueStore storage, BTTVerifiableCredential_SealedEnvelope_Cell cellContent)
        {
            return SaveBTTVerifiableCredential_SealedEnvelope_Cell(storage, cellContent.CellId  , cellContent.signedenvelope );
        }
        /// <summary>
        /// Loads the content of the specified cell. Any changes done to this object are not written to the store, unless
        /// the content object is saved back into the storage.
        /// <param name="storage"/>A <see cref="Trinity.Storage.IKeyValueStore"/> instance.</param>
        /// </summary>
        public unsafe static BTTVerifiableCredential_SealedEnvelope_Cell LoadBTTVerifiableCredential_SealedEnvelope_Cell(this IKeyValueStore storage, long cellId)
        {
            if (TrinityErrorCode.E_SUCCESS == storage.LoadCell(cellId, out var buff))
            {
                fixed (byte* p = buff)
                {
                    return BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Setup(cellId, p, -1, 0);
                }
            }
            else
            {
                Throw.cell_not_found();
                throw new Exception();
            }
        }
        #endregion
        #region LocalMemoryStorage Non-Tx accessors
        /// <summary>
        /// Allocate a cell accessor on the specified cell, which interprets
        /// the cell as a BTTVerifiableCredential_SealedEnvelope_Cell. Any changes done to the accessor
        /// are written to the storage immediately.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// on calling this method, it attempts to acquire the lock of the cell,
        /// and blocks until it gets the lock. Otherwise this method is wait-free.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">The id of the specified cell.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <returns>A <see cref="BTTN4KNFE.BTTVerifiableCredential_SealedEnvelope_Cell"/> instance.</returns>
        public unsafe static BTTVerifiableCredential_SealedEnvelope_Cell_Accessor UseBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, long cellId, CellAccessOptions options)
        {
            return BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Lock(cellId, options);
        }
        /// <summary>
        /// Allocate a cell accessor on the specified cell, which interprets
        /// the cell as a BTTVerifiableCredential_SealedEnvelope_Cell. Any changes done to the accessor
        /// are written to the storage immediately.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// on calling this method, it attempts to acquire the lock of the cell,
        /// and blocks until it gets the lock.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">The id of the specified cell.</param>
        /// <returns>A <see cref="" + script.RootNamespace + ".BTTVerifiableCredential_SealedEnvelope_Cell"/> instance.</returns>
        public unsafe static BTTVerifiableCredential_SealedEnvelope_Cell_Accessor UseBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, long cellId)
        {
            return BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Lock(cellId, CellAccessOptions.ThrowExceptionOnCellNotFound);
        }
        #endregion
        #region LocalStorage Non-Tx logging
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The value of the cell is specified in the method parameters.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, CellAccessOptions options, long cellId, BTTVerifiableCredential_SealedEnvelope signedenvelope = default(BTTVerifiableCredential_SealedEnvelope))
        {
            
            byte* targetPtr;
            
            targetPtr = null;
            
            {

            {

            {

        if(signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = signedenvelope.envelope.udid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.types[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            targetPtr += 1;
            targetPtr += 8;
            targetPtr += 1;
            targetPtr += 1;

        if(signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.notaryudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.label.name!= null)
            {

        if(signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.name.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.label.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            {
            targetPtr += 1;

        if(signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.udid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.context[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            targetPtr += 1;

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

        }
    }

}

            }

            }
        }
    }

}

            }
            if( signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            }

            }
            }
            {
            targetPtr += 1;
            if( signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = signedenvelope.proof.hashedThumbprint64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.signedHashSignature64!= null)
            {

        if(signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = signedenvelope.proof.signedHashSignature64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.notaryStamp!= null)
            {

        if(signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = signedenvelope.proof.notaryStamp.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = signedenvelope.proof.comments[iterator_4].Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            }
            }
            byte[] tmpcell = new byte[(int)(targetPtr)];
            fixed (byte* _tmpcellptr = tmpcell)
            {
                targetPtr = _tmpcellptr;
                
            {

            {

            {

        if(signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = signedenvelope.envelope.udid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.envelope.udid)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.types[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.label.types[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            *(BTTGenericCredentialType*)targetPtr = signedenvelope.envelope.label.credtype;
            targetPtr += 1;
            *(long*)targetPtr = signedenvelope.envelope.label.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = signedenvelope.envelope.label.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = signedenvelope.envelope.label.encryptionFlag;
            targetPtr += 1;

        if(signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.label.notaryudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.label.name!= null)
            {

        if(signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.name.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.label.name)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.label.comments!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.label.comments[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }

            }
            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

        if(signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.udid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.content.udid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.context[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.context[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            if( signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.content.credentialsubjectudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            byte* optheader_6 = targetPtr;
            *(optheader_6 + 0) = 0x00;            targetPtr += 1;

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_6 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x02;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{
byte *storedPtr_8 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_8 = (int)(targetPtr - storedPtr_8 - 4);

}

        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x04;
            }

            }
        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }
            if( signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.key)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_4 + 0) |= 0x04;
            }

            }
            }
            {
            byte* optheader_3 = targetPtr;
            *(optheader_3 + 0) = 0x00;            targetPtr += 1;
            if( signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = signedenvelope.proof.hashedThumbprint64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.hashedThumbprint64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x01;
            }
            if( signedenvelope.proof.signedHashSignature64!= null)
            {

        if(signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = signedenvelope.proof.signedHashSignature64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.signedHashSignature64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x02;
            }
            if( signedenvelope.proof.notaryStamp!= null)
            {

        if(signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = signedenvelope.proof.notaryStamp.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.notaryStamp)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x04;
            }
            if( signedenvelope.proof.comments!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = signedenvelope.proof.comments[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.proof.comments[iterator_4])
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_4 = (int)(targetPtr - storedPtr_4 - 4);

}
*(optheader_3 + 0) |= 0x08;
            }

            }
            }
            }
            }
            
            return storage.SaveCell(options, cellId, tmpcell, 0, tmpcell.Length, (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell) == TrinityErrorCode.E_SUCCESS;
        }
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The parameter <paramref name="cellId"/> overrides the cell id in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, CellAccessOptions options, long cellId, BTTVerifiableCredential_SealedEnvelope_Cell cellContent)
        {
            return SaveBTTVerifiableCredential_SealedEnvelope_Cell(storage, options, cellId  , cellContent.signedenvelope );
        }
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. Cell Id is specified by the CellId field in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, CellAccessOptions options, BTTVerifiableCredential_SealedEnvelope_Cell cellContent)
        {
            return SaveBTTVerifiableCredential_SealedEnvelope_Cell(storage, options, cellContent.CellId  , cellContent.signedenvelope );
        }
        /// <summary>
        /// Loads the content of the specified cell. Any changes done to this object are not written to the store, unless
        /// the content object is saved back into the storage.
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// </summary>
        public unsafe static BTTVerifiableCredential_SealedEnvelope_Cell LoadBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, long cellId)
        {
            using (var cell = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Lock(cellId, CellAccessOptions.ThrowExceptionOnCellNotFound))
            {
                return cell;
            }
        }
        #endregion
        #region LocalMemoryStorage Tx accessors
        /// <summary>
        /// Allocate a cell accessor on the specified cell, which interprets
        /// the cell as a BTTVerifiableCredential_SealedEnvelope_Cell. Any changes done to the accessor
        /// are written to the storage immediately.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// on calling this method, it attempts to acquire the lock of the cell,
        /// and blocks until it gets the lock. Otherwise this method is wait-free.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">The id of the specified cell.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <returns>A <see cref="BTTN4KNFE.BTTVerifiableCredential_SealedEnvelope_Cell"/> instance.</returns>
        public unsafe static BTTVerifiableCredential_SealedEnvelope_Cell_Accessor UseBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, long cellId, CellAccessOptions options)
        {
            return BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Lock(cellId, options, tx);
        }
        /// <summary>
        /// Allocate a cell accessor on the specified cell, which interprets
        /// the cell as a BTTVerifiableCredential_SealedEnvelope_Cell. Any changes done to the accessor
        /// are written to the storage immediately.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// on calling this method, it attempts to acquire the lock of the cell,
        /// and blocks until it gets the lock.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">The id of the specified cell.</param>
        /// <returns>A <see cref="" + script.RootNamespace + ".BTTVerifiableCredential_SealedEnvelope_Cell"/> instance.</returns>
        public unsafe static BTTVerifiableCredential_SealedEnvelope_Cell_Accessor UseBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, long cellId)
        {
            return BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Lock(cellId, CellAccessOptions.ThrowExceptionOnCellNotFound, tx);
        }
        #endregion
        #region LocalStorage Tx logging
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The value of the cell is specified in the method parameters.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, CellAccessOptions options, long cellId, BTTVerifiableCredential_SealedEnvelope signedenvelope = default(BTTVerifiableCredential_SealedEnvelope))
        {
            
            byte* targetPtr;
            
            targetPtr = null;
            
            {

            {

            {

        if(signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = signedenvelope.envelope.udid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.types[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            targetPtr += 1;
            targetPtr += 8;
            targetPtr += 1;
            targetPtr += 1;

        if(signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.notaryudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.label.name!= null)
            {

        if(signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.name.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.label.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            {
            targetPtr += 1;

        if(signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.udid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.context[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            targetPtr += 1;

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            targetPtr += strlen_10+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

        }
    }

}

            }

            }
        }
    }

}

            }
            if( signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            }

            }
            }
            {
            targetPtr += 1;
            if( signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = signedenvelope.proof.hashedThumbprint64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.signedHashSignature64!= null)
            {

        if(signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = signedenvelope.proof.signedHashSignature64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.notaryStamp!= null)
            {

        if(signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = signedenvelope.proof.notaryStamp.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( signedenvelope.proof.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = signedenvelope.proof.comments[iterator_4].Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}

            }

            }
            }
            }
            byte[] tmpcell = new byte[(int)(targetPtr)];
            fixed (byte* _tmpcellptr = tmpcell)
            {
                targetPtr = _tmpcellptr;
                
            {

            {

            {

        if(signedenvelope.envelope.udid!= null)
        {
            int strlen_4 = signedenvelope.envelope.udid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.envelope.udid)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.types.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.types[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.label.types[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            *(BTTGenericCredentialType*)targetPtr = signedenvelope.envelope.label.credtype;
            targetPtr += 1;
            *(long*)targetPtr = signedenvelope.envelope.label.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = signedenvelope.envelope.label.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = signedenvelope.envelope.label.encryptionFlag;
            targetPtr += 1;

        if(signedenvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.label.notaryudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.label.name!= null)
            {

        if(signedenvelope.envelope.label.name!= null)
        {
            int strlen_5 = signedenvelope.envelope.label.name.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.label.name)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.label.comments!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(signedenvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.label.comments[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.label.comments[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }

            }
            {
            byte* optheader_4 = targetPtr;
            *(optheader_4 + 0) = 0x00;            targetPtr += 1;

        if(signedenvelope.envelope.content.udid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.udid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.content.udid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.context.Count;++iterator_5)
        {

        if(signedenvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.context[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.context[iterator_5])
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
            if( signedenvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = signedenvelope.envelope.content.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.envelope.content.credentialsubjectudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_4 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_5 = 0;iterator_5<signedenvelope.envelope.content.credentialsubjectclaims.Count;++iterator_5)
        {

            {
            byte* optheader_6 = targetPtr;
            *(optheader_6 + 0) = 0x00;            targetPtr += 1;

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].key)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value!= null)
        {
            int strlen_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].value)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_6 + 0) |= 0x01;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute.Count;++iterator_7)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].key)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value!= null)
        {
            int strlen_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attribute[iterator_7].value)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x02;
            }
            if( signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
            {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes!= null)
    {
        for(int iterator_7 = 0;iterator_7<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes.Count;++iterator_7)
        {

{
byte *storedPtr_8 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7]!= null)
    {
        for(int iterator_8 = 0;iterator_8<signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7].Count;++iterator_8)
        {

            {

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].key)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value!= null)
        {
            int strlen_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value.Length * 2;
            *(int*)targetPtr = strlen_10;
            targetPtr += sizeof(int);
            fixed(char* pstr_10 = signedenvelope.envelope.content.credentialsubjectclaims[iterator_5].attributes[iterator_7][iterator_8].value)
            {
                Memory.Copy(pstr_10, targetPtr, strlen_10);
                targetPtr += strlen_10;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_8 = (int)(targetPtr - storedPtr_8 - 4);

}

        }
    }
*(int*)storedPtr_7 = (int)(targetPtr - storedPtr_7 - 4);

}
*(optheader_6 + 0) |= 0x04;
            }

            }
        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}
*(optheader_4 + 0) |= 0x02;
            }
            if( signedenvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(signedenvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = signedenvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = signedenvelope.envelope.content.encryptedclaims.Value.key)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_4 + 0) |= 0x04;
            }

            }
            }
            {
            byte* optheader_3 = targetPtr;
            *(optheader_3 + 0) = 0x00;            targetPtr += 1;
            if( signedenvelope.proof.hashedThumbprint64!= null)
            {

        if(signedenvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = signedenvelope.proof.hashedThumbprint64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.hashedThumbprint64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x01;
            }
            if( signedenvelope.proof.signedHashSignature64!= null)
            {

        if(signedenvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = signedenvelope.proof.signedHashSignature64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.signedHashSignature64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x02;
            }
            if( signedenvelope.proof.notaryStamp!= null)
            {

        if(signedenvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = signedenvelope.proof.notaryStamp.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = signedenvelope.proof.notaryStamp)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_3 + 0) |= 0x04;
            }
            if( signedenvelope.proof.comments!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(signedenvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<signedenvelope.proof.comments.Count;++iterator_4)
        {

        if(signedenvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = signedenvelope.proof.comments[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = signedenvelope.proof.comments[iterator_4])
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_4 = (int)(targetPtr - storedPtr_4 - 4);

}
*(optheader_3 + 0) |= 0x08;
            }

            }
            }
            }
            }
            
            return storage.SaveCell(tx, options, cellId, tmpcell, 0, tmpcell.Length, (ushort)CellType.BTTVerifiableCredential_SealedEnvelope_Cell) == TrinityErrorCode.E_SUCCESS;
        }
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The parameter <paramref name="cellId"/> overrides the cell id in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, CellAccessOptions options, long cellId, BTTVerifiableCredential_SealedEnvelope_Cell cellContent)
        {
            return SaveBTTVerifiableCredential_SealedEnvelope_Cell(storage, tx, options, cellId  , cellContent.signedenvelope );
        }
        /// <summary>
        /// Adds a new cell of type BTTVerifiableCredential_SealedEnvelope_Cell to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. Cell Id is specified by the CellId field in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, CellAccessOptions options, BTTVerifiableCredential_SealedEnvelope_Cell cellContent)
        {
            return SaveBTTVerifiableCredential_SealedEnvelope_Cell(storage, tx, options, cellContent.CellId  , cellContent.signedenvelope );
        }
        /// <summary>
        /// Loads the content of the specified cell. Any changes done to this object are not written to the store, unless
        /// the content object is saved back into the storage.
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// </summary>
        public unsafe static BTTVerifiableCredential_SealedEnvelope_Cell LoadBTTVerifiableCredential_SealedEnvelope_Cell(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, long cellId)
        {
            using (var cell = BTTVerifiableCredential_SealedEnvelope_Cell_Accessor._get()._Lock(cellId, CellAccessOptions.ThrowExceptionOnCellNotFound, tx))
            {
                return cell;
            }
        }
        #endregion
    }
}

#pragma warning restore 162,168,649,660,661,1522
