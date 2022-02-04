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
    /// A .NET runtime object representation of BTTN4KNFEDirectory defined in TSL.
    /// </summary>
    public partial struct BTTN4KNFEDirectory : ICell
    {
        ///<summary>
        ///The id of the cell.
        ///</summary>
        public long CellId;
        ///<summary>
        ///Initializes a new instance of BTTN4KNFEDirectory with the specified parameters.
        ///</summary>
        public BTTN4KNFEDirectory(long cell_id , int count = default(int), List<long> ids = default(List<long>))
        {
            
            this.count = count;
            
            this.ids = ids;
            
            CellId = cell_id;
        }
        
        ///<summary>
        ///Initializes a new instance of BTTN4KNFEDirectory with the specified parameters.
        ///</summary>
        public BTTN4KNFEDirectory( int count = default(int), List<long> ids = default(List<long>))
        {
            
            this.count = count;
            
            this.ids = ids;
            
            CellId = CellIdFactory.NewCellId();
        }
        
        public int count;
        
        public List<long> ids;
        
        public static bool operator ==(BTTN4KNFEDirectory a, BTTN4KNFEDirectory b)
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
                
                (a.count == b.count)
                &&
                (a.ids == b.ids)
                
                ;
            
        }
        public static bool operator !=(BTTN4KNFEDirectory a, BTTN4KNFEDirectory b)
        {
            return !(a == b);
        }
        #region Text processing
        /// <summary>
        /// Converts the string representation of a BTTN4KNFEDirectory to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(BTTN4KNFEDirectory) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized.
        /// </param>
        /// <returns>
        /// True if input was converted successfully; otherwise, false.
        /// </returns>
        public static bool TryParse(string input, out BTTN4KNFEDirectory value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<BTTN4KNFEDirectory>(input);
                return true;
            }
            catch { value = default(BTTN4KNFEDirectory); return false; }
        }
        public static BTTN4KNFEDirectory Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BTTN4KNFEDirectory>(input);
        }
        ///<summary>Converts a BTTN4KNFEDirectory to its string representation, in JSON format.</summary>
        ///<returns>A string representation of the BTTN4KNFEDirectory.</returns>
        public override string ToString()
        {
            return Serializer.ToString(this);
        }
        #endregion
        #region Lookup tables
        internal static StringLookupTable FieldLookupTable = new StringLookupTable(
            
            "count"
            ,
            "ids"
            
            );
        internal static HashSet<string> AppendToFieldRerouteSet = new HashSet<string>()
        {
            
            "count"
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
                return TypeConverter<T>.ConvertFrom_int(this.count);
                
                case 1:
                return TypeConverter<T>.ConvertFrom_List_long(this.ids);
                
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
                this.count = TypeConverter<T>.ConvertTo_int(value);
                break;
                
                case 1:
                this.ids = TypeConverter<T>.ConvertTo_List_long(value);
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
                
                case 1:
                
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
                
                case 1:
                
                {
                    if (this.ids == null)
                        this.ids = new List<long>();
                    switch (TypeConverter<T>.GetConversionActionTo_List_long())
                    {
                        case TypeConversionAction.TC_ASSIGN:
                        foreach (var element in value as List<long>)
                            this.ids.Add(element);
                        break;
                        case TypeConversionAction.TC_CONVERTLIST:
                        case TypeConversionAction.TC_ARRAYTOLIST:
                        foreach (var element in TypeConverter<T>.Enumerate_long(value))
                            this.ids.Add(element);
                        break;
                        case TypeConversionAction.TC_WRAPINLIST:
                        case TypeConversionAction.TC_PARSESTRING:
                        this.ids.Add(TypeConverter<T>.ConvertTo_long(value));
                        break;
                        default:
                        Throw.data_type_incompatible_with_list(typeof(T).ToString());
                        break;
                    }
                }
                
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
                
                case 0:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                break;
                
                case 1:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                break;
                
                case 2:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                break;
                
                case 4:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.ids, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("ids", TypeConverter<T>.ConvertFrom_List_long(this.ids));
                
                break;
                
                case 6:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.ids, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("ids", TypeConverter<T>.ConvertFrom_List_long(this.ids));
                
                break;
                
                case 7:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.ids, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("ids", TypeConverter<T>.ConvertFrom_List_long(this.ids));
                
                break;
                
                case 25:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.ids, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("ids", TypeConverter<T>.ConvertFrom_List_long(this.ids));
                
                break;
                
                default:
                Throw.incompatible_with_cell();
                break;
            }
            yield break;
        }
        #region enumerate value constructs
        
        private IEnumerable<T> _enumerate_from_count<T>()
        {
            
            switch (TypeConverter<T>.type_id)
            {
                
                case 0:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 1:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 2:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 4:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 6:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 7:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 25:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                default:
                    Throw.incompatible_with_cell();
                    break;
            }
            yield break;
            
        }
        
        private IEnumerable<T> _enumerate_from_ids<T>()
        {
            
            switch (TypeConverter<T>.type_id)
            {
                
                case 0:
                    {
                        
                        {
                            
                            var element0 = this.ids;
                            
                            foreach (var element1 in  element0)
                            
                            {
                                yield return TypeConverter<T>.ConvertFrom_long(element1);
                            }
                        }
                        
                    }
                    break;
                
                case 2:
                    {
                        
                        {
                            
                            var element0 = this.ids;
                            
                            foreach (var element1 in  element0)
                            
                            {
                                yield return TypeConverter<T>.ConvertFrom_long(element1);
                            }
                        }
                        
                    }
                    break;
                
                case 4:
                    {
                        
                        {
                            
                            var element0 = this.ids;
                            
                            foreach (var element1 in  element0)
                            
                            {
                                yield return TypeConverter<T>.ConvertFrom_long(element1);
                            }
                        }
                        
                    }
                    break;
                
                case 6:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_List_long(this.ids);
                        
                    }
                    break;
                
                case 7:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_List_long(this.ids);
                        
                    }
                    break;
                
                case 25:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_List_long(this.ids);
                        
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
                return _enumerate_from_count<T>();
                
                case 1:
                return _enumerate_from_ids<T>();
                
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
                
                foreach (var val in _enumerate_from_count<T>())
                    yield return val;
                
                foreach (var val in _enumerate_from_ids<T>())
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
            return (BTTN4KNFEDirectory_Accessor)this;
        }
        #endregion
        #region Other interfaces
        string ITypeDescriptor.TypeName
        {
            get { return StorageSchema.s_cellTypeName_BTTN4KNFEDirectory; }
        }
        Type ITypeDescriptor.Type
        {
            get { return StorageSchema.s_cellType_BTTN4KNFEDirectory; }
        }
        bool ITypeDescriptor.IsOfType<T>()
        {
            return typeof(T) == StorageSchema.s_cellType_BTTN4KNFEDirectory;
        }
        bool ITypeDescriptor.IsList()
        {
            return false;
        }
        IEnumerable<IFieldDescriptor> ICellDescriptor.GetFieldDescriptors()
        {
            return StorageSchema.BTTN4KNFEDirectory.GetFieldDescriptors();
        }
        IAttributeCollection ICellDescriptor.GetFieldAttributes(string fieldName)
        {
            return StorageSchema.BTTN4KNFEDirectory.GetFieldAttributes(fieldName);
        }
        string IAttributeCollection.GetAttributeValue(string attributeKey)
        {
            return StorageSchema.BTTN4KNFEDirectory.GetAttributeValue(attributeKey);
        }
        IReadOnlyDictionary<string, string> IAttributeCollection.Attributes
        {
            get { return StorageSchema.BTTN4KNFEDirectory.Attributes; }
        }
        IEnumerable<string> ICellDescriptor.GetFieldNames()
        {
            
            {
                yield return "count";
            }
            
            {
                yield return "ids";
            }
            
        }
        ushort ICellDescriptor.CellType
        {
            get
            {
                return (ushort)CellType.BTTN4KNFEDirectory;
            }
        }
        #endregion
    }
    /// <summary>
    /// Provides in-place operations of BTTN4KNFEDirectory defined in TSL.
    /// </summary>
    public unsafe class BTTN4KNFEDirectory_Accessor : ICellAccessor
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
        private unsafe BTTN4KNFEDirectory_Accessor()
        {
                    ids_Accessor_Field = new longListAccessor(null,
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
            {            targetPtr += 4;
targetPtr += *(int*)targetPtr + sizeof(int);}
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
            {            targetPtr += 4;
targetPtr += *(int*)targetPtr + sizeof(int);}
            int size = (int)(targetPtr - m_ptr);
            return size;
        }
        public ResizeFunctionDelegate ResizeFunction { get; set; }
        #endregion
        private static byte[] s_default_content = null;
        private static unsafe byte[] construct( int count = default(int) , List<long> ids = default(List<long>) )
        {
            if (s_default_content != null) return s_default_content;
            
            byte* targetPtr;
            
            targetPtr = null;
            
            {
            targetPtr += 4;

if(ids!= null)
{
    targetPtr += ids.Count*8+sizeof(int);
}else
{
    targetPtr += sizeof(int);
}

            }
            byte[] tmpcell = new byte[(int)(targetPtr)];
            fixed (byte* _tmpcellptr = tmpcell)
            {
                targetPtr = _tmpcellptr;
                
            {
            *(int*)targetPtr = count;
            targetPtr += 4;

if(ids!= null)
{
    *(int*)targetPtr = ids.Count*8;
    targetPtr += sizeof(int);
    for(int iterator_2 = 0;iterator_2<ids.Count;++iterator_2)
    {
            *(long*)targetPtr = ids[iterator_2];
            targetPtr += 8;

    }

}else
{
    *(int*)targetPtr = 0;
    targetPtr += sizeof(int);
}

            }
            }
            
            s_default_content = tmpcell;
            return tmpcell;
        }
        
        ///<summary>
        ///Provides in-place access to the object field count.
        ///</summary>
        public unsafe int count
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {}                *(int*)targetPtr = value;
            }
        }
        longListAccessor ids_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field ids.
        ///</summary>
        public unsafe longListAccessor ids
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            targetPtr += 4;
}ids_Accessor_Field.m_ptr = targetPtr + 4;
                ids_Accessor_Field.m_cellId = this.m_cellId;
                return ids_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                ids_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            targetPtr += 4;
}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != ids_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    ids_Accessor_Field.m_ptr = ids_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, ids_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        ids_Accessor_Field.m_ptr = ids_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, ids_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        
        public static unsafe implicit operator BTTN4KNFEDirectory(BTTN4KNFEDirectory_Accessor accessor)
        {
            
            return new BTTN4KNFEDirectory(accessor.CellId
            
            ,
            
                    accessor.count
            ,
            
                    accessor.ids
            );
        }
        
        public unsafe static implicit operator BTTN4KNFEDirectory_Accessor(BTTN4KNFEDirectory field)
        {
            byte* targetPtr = null;
            
            {
            targetPtr += 4;

if(field.ids!= null)
{
    targetPtr += field.ids.Count*8+sizeof(int);
}else
{
    targetPtr += sizeof(int);
}

            }
            byte* tmpcellptr = BufferAllocator.AllocBuffer((int)targetPtr);
            Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
            targetPtr = tmpcellptr;
            
            {
            *(int*)targetPtr = field.count;
            targetPtr += 4;

if(field.ids!= null)
{
    *(int*)targetPtr = field.ids.Count*8;
    targetPtr += sizeof(int);
    for(int iterator_2 = 0;iterator_2<field.ids.Count;++iterator_2)
    {
            *(long*)targetPtr = field.ids[iterator_2];
            targetPtr += 8;

    }

}else
{
    *(int*)targetPtr = 0;
    targetPtr += sizeof(int);
}

            }BTTN4KNFEDirectory_Accessor ret;
            
            ret = BTTN4KNFEDirectory_Accessor._get()._Setup(field.CellId, tmpcellptr, -1, 0, null);
            ret.m_cellId = field.CellId;
            
            return ret;
        }
        
        public static bool operator ==(BTTN4KNFEDirectory_Accessor a, BTTN4KNFEDirectory_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {            targetPtr += 4;
targetPtr += *(int*)targetPtr + sizeof(int);}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {            targetPtr += 4;
targetPtr += *(int*)targetPtr + sizeof(int);}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (BTTN4KNFEDirectory_Accessor a, BTTN4KNFEDirectory_Accessor b)
        {
            return !(a == b);
        }
        
        public static bool operator ==(BTTN4KNFEDirectory_Accessor a, BTTN4KNFEDirectory b)
        {
            BTTN4KNFEDirectory_Accessor bb = b;
            return (a == bb);
        }
        public static bool operator !=(BTTN4KNFEDirectory_Accessor a, BTTN4KNFEDirectory b)
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
        internal unsafe BTTN4KNFEDirectory_Accessor _Lock(long cellId, CellAccessOptions options)
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
                    if (cellType != (ushort)CellType.BTTN4KNFEDirectory)
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
                        eResult                = Global.LocalStorage.AddOrUse(cellId, defaultContent, ref size, (ushort)CellType.BTTN4KNFEDirectory, out this.m_ptr, out this.m_cellEntryIndex);
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
        internal unsafe BTTN4KNFEDirectory_Accessor _Lock(long cellId, CellAccessOptions options, LocalTransactionContext tx)
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
                    if (cellType != (ushort)CellType.BTTN4KNFEDirectory)
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
                        eResult                = Global.LocalStorage.AddOrUse(tx, cellId, defaultContent, ref size, (ushort)CellType.BTTN4KNFEDirectory, out this.m_ptr, out this.m_cellEntryIndex);
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
        private class PoolPolicy : IPooledObjectPolicy<BTTN4KNFEDirectory_Accessor>
        {
            public BTTN4KNFEDirectory_Accessor Create()
            {
                return new BTTN4KNFEDirectory_Accessor();
            }
            public bool Return(BTTN4KNFEDirectory_Accessor obj)
            {
                return !obj.m_IsIterator;
            }
        }
        private static DefaultObjectPool<BTTN4KNFEDirectory_Accessor> s_accessor_pool = new DefaultObjectPool<BTTN4KNFEDirectory_Accessor>(new PoolPolicy());
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static BTTN4KNFEDirectory_Accessor _get() => s_accessor_pool.Get();
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal static void _put(BTTN4KNFEDirectory_Accessor item) => s_accessor_pool.Return(item);
        /// <summary>
        /// For internal use only.
        /// Caller guarantees that entry lock is obtained.
        /// Does not handle CellAccessOptions. Only copy to the accessor.
        /// </summary>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        internal BTTN4KNFEDirectory_Accessor _Setup(long CellId, byte* cellPtr, int entryIndex, CellAccessOptions options)
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
        internal BTTN4KNFEDirectory_Accessor _Setup(long CellId, byte* cellPtr, int entryIndex, CellAccessOptions options, LocalTransactionContext tx)
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
        internal static BTTN4KNFEDirectory_Accessor AllocIterativeAccessor(CellInfo info, LocalTransactionContext tx)
        {
            BTTN4KNFEDirectory_Accessor accessor = new BTTN4KNFEDirectory_Accessor();
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
        /// If write-ahead-log behavior is specified on <see cref="BTTN4KNFE.StorageExtension_BTTN4KNFEDirectory.UseBTTN4KNFEDirectory"/>,
        /// the changes will be committed to the write-ahead log.
        /// </summary>
        public void Dispose()
        {
            if (m_cellEntryIndex >= 0)
            {
                if ((m_options & c_WALFlags) != 0)
                {
                    LocalMemoryStorage.CWriteAheadLog(this.CellId, this.m_ptr, this.CellSize, (ushort)CellType.BTTN4KNFEDirectory, m_options);
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
        /// <summary>Converts a BTTN4KNFEDirectory_Accessor to its string representation, in JSON format.</summary>
        /// <returns>A string representation of the BTTN4KNFEDirectory.</returns>
        public override string ToString()
        {
            return Serializer.ToString(this);
        }
        #endregion
        #region Lookup tables
        internal static StringLookupTable FieldLookupTable = new StringLookupTable(
            
            "count"
            ,
            "ids"
            
            );
        static HashSet<string> AppendToFieldRerouteSet = new HashSet<string>()
        {
            
            "count"
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
                return TypeConverter<T>.ConvertFrom_int(this.count);
                
                case 1:
                return TypeConverter<T>.ConvertFrom_List_long(this.ids);
                
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
                    int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                    
            {
                this.count = conversion_result;
            }
            
                }
                break;
                
                case 1:
                {
                    List<long> conversion_result = TypeConverter<T>.ConvertTo_List_long(value);
                    
            {
                this.ids = conversion_result;
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
                
                case 1:
                
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
                
                case 1:
                
                {
                    
                    switch (TypeConverter<T>.GetConversionActionTo_List_long())
                    {
                        case TypeConversionAction.TC_ASSIGN:
                        foreach (var element in value as List<long>)
                            this.ids.Add(element);
                        break;
                        case TypeConversionAction.TC_CONVERTLIST:
                        case TypeConversionAction.TC_ARRAYTOLIST:
                        foreach (var element in TypeConverter<T>.Enumerate_long(value))
                            this.ids.Add(element);
                        break;
                        case TypeConversionAction.TC_WRAPINLIST:
                        case TypeConversionAction.TC_PARSESTRING:
                        this.ids.Add(TypeConverter<T>.ConvertTo_long(value));
                        break;
                        default:
                        Throw.data_type_incompatible_with_list(typeof(T).ToString());
                        break;
                    }
                }
                
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
                
                case 0:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                break;
                
                case 1:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                break;
                
                case 2:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                break;
                
                case 4:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.ids, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("ids", TypeConverter<T>.ConvertFrom_List_long(this.ids));
                
                break;
                
                case 6:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.ids, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("ids", TypeConverter<T>.ConvertFrom_List_long(this.ids));
                
                break;
                
                case 7:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.ids, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("ids", TypeConverter<T>.ConvertFrom_List_long(this.ids));
                
                break;
                
                case 25:
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.count, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("count", TypeConverter<T>.ConvertFrom_int(this.count));
                
                if (StorageSchema.BTTN4KNFEDirectory_descriptor.check_attribute(StorageSchema.BTTN4KNFEDirectory_descriptor.ids, attributeKey, attributeValue))
                    
                        yield return new KeyValuePair<string, T>("ids", TypeConverter<T>.ConvertFrom_List_long(this.ids));
                
                break;
                
                default:
                Throw.incompatible_with_cell();
                break;
            }
            yield break;
        }
        #region enumerate value methods
        
        private IEnumerable<T> _enumerate_from_count<T>()
        {
            
            switch (TypeConverter<T>.type_id)
            {
                
                case 0:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 1:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 2:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 4:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 6:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 7:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                case 25:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_int(this.count);
                        
                    }
                    break;
                
                default:
                    Throw.incompatible_with_cell();
                    break;
            }
            yield break;
            
        }
        
        private IEnumerable<T> _enumerate_from_ids<T>()
        {
            
            switch (TypeConverter<T>.type_id)
            {
                
                case 0:
                    {
                        
                        {
                            
                            var element0 = this.ids;
                            
                            foreach (var element1 in  element0)
                            
                            {
                                yield return TypeConverter<T>.ConvertFrom_long(element1);
                            }
                        }
                        
                    }
                    break;
                
                case 2:
                    {
                        
                        {
                            
                            var element0 = this.ids;
                            
                            foreach (var element1 in  element0)
                            
                            {
                                yield return TypeConverter<T>.ConvertFrom_long(element1);
                            }
                        }
                        
                    }
                    break;
                
                case 4:
                    {
                        
                        {
                            
                            var element0 = this.ids;
                            
                            foreach (var element1 in  element0)
                            
                            {
                                yield return TypeConverter<T>.ConvertFrom_long(element1);
                            }
                        }
                        
                    }
                    break;
                
                case 6:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_List_long(this.ids);
                        
                    }
                    break;
                
                case 7:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_List_long(this.ids);
                        
                    }
                    break;
                
                case 25:
                    {
                        
                        yield return TypeConverter<T>.ConvertFrom_List_long(this.ids);
                        
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
                return _enumerate_from_count<T>();
                
                case 1:
                return _enumerate_from_ids<T>();
                
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
                
                foreach (var val in _enumerate_from_count<T>())
                    yield return val;
                
                foreach (var val in _enumerate_from_ids<T>())
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
                yield return "count";
            }
            
            {
                yield return "ids";
            }
            
        }
        IAttributeCollection ICellDescriptor.GetFieldAttributes(string fieldName)
        {
            return StorageSchema.BTTN4KNFEDirectory.GetFieldAttributes(fieldName);
        }
        IEnumerable<IFieldDescriptor> ICellDescriptor.GetFieldDescriptors()
        {
            return StorageSchema.BTTN4KNFEDirectory.GetFieldDescriptors();
        }
        string ITypeDescriptor.TypeName
        {
            get { return StorageSchema.s_cellTypeName_BTTN4KNFEDirectory; }
        }
        Type ITypeDescriptor.Type
        {
            get { return StorageSchema.s_cellType_BTTN4KNFEDirectory; }
        }
        bool ITypeDescriptor.IsOfType<T>()
        {
            return typeof(T) == StorageSchema.s_cellType_BTTN4KNFEDirectory;
        }
        bool ITypeDescriptor.IsList()
        {
            return false;
        }
        IReadOnlyDictionary<string, string> IAttributeCollection.Attributes
        {
            get { return StorageSchema.BTTN4KNFEDirectory.Attributes; }
        }
        string IAttributeCollection.GetAttributeValue(string attributeKey)
        {
            return StorageSchema.BTTN4KNFEDirectory.GetAttributeValue(attributeKey);
        }
        ushort ICellDescriptor.CellType
        {
            get
            {
                return (ushort)CellType.BTTN4KNFEDirectory;
            }
        }
        public ICellAccessor Serialize()
        {
            return this;
        }
        #endregion
        public ICell Deserialize()
        {
            return (BTTN4KNFEDirectory)this;
        }
    }
    ///<summary>
    ///Provides interfaces for accessing BTTN4KNFEDirectory cells
    ///on <see cref="Trinity.Storage.LocalMemorySotrage"/>.
    static public class StorageExtension_BTTN4KNFEDirectory
    {
        #region IKeyValueStore non logging
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The value of the cell is specified in the method parameters.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.IKeyValueStore"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this IKeyValueStore storage, long cellId, int count = default(int), List<long> ids = default(List<long>))
        {
            
            byte* targetPtr;
            
            targetPtr = null;
            
            {
            targetPtr += 4;

if(ids!= null)
{
    targetPtr += ids.Count*8+sizeof(int);
}else
{
    targetPtr += sizeof(int);
}

            }
            byte[] tmpcell = new byte[(int)(targetPtr)];
            fixed (byte* _tmpcellptr = tmpcell)
            {
                targetPtr = _tmpcellptr;
                
            {
            *(int*)targetPtr = count;
            targetPtr += 4;

if(ids!= null)
{
    *(int*)targetPtr = ids.Count*8;
    targetPtr += sizeof(int);
    for(int iterator_2 = 0;iterator_2<ids.Count;++iterator_2)
    {
            *(long*)targetPtr = ids[iterator_2];
            targetPtr += 8;

    }

}else
{
    *(int*)targetPtr = 0;
    targetPtr += sizeof(int);
}

            }
            }
            
            return storage.SaveCell(cellId, tmpcell, (ushort)CellType.BTTN4KNFEDirectory) == TrinityErrorCode.E_SUCCESS;
        }
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The parameter <paramref name="cellId"/> overrides the cell id in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.IKeyValueStore"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this IKeyValueStore storage, long cellId, BTTN4KNFEDirectory cellContent)
        {
            return SaveBTTN4KNFEDirectory(storage, cellId  , cellContent.count  , cellContent.ids );
        }
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. Cell Id is specified by the CellId field in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.IKeyValueStore"/> instance.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this IKeyValueStore storage, BTTN4KNFEDirectory cellContent)
        {
            return SaveBTTN4KNFEDirectory(storage, cellContent.CellId  , cellContent.count  , cellContent.ids );
        }
        /// <summary>
        /// Loads the content of the specified cell. Any changes done to this object are not written to the store, unless
        /// the content object is saved back into the storage.
        /// <param name="storage"/>A <see cref="Trinity.Storage.IKeyValueStore"/> instance.</param>
        /// </summary>
        public unsafe static BTTN4KNFEDirectory LoadBTTN4KNFEDirectory(this IKeyValueStore storage, long cellId)
        {
            if (TrinityErrorCode.E_SUCCESS == storage.LoadCell(cellId, out var buff))
            {
                fixed (byte* p = buff)
                {
                    return BTTN4KNFEDirectory_Accessor._get()._Setup(cellId, p, -1, 0);
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
        /// the cell as a BTTN4KNFEDirectory. Any changes done to the accessor
        /// are written to the storage immediately.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// on calling this method, it attempts to acquire the lock of the cell,
        /// and blocks until it gets the lock. Otherwise this method is wait-free.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">The id of the specified cell.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <returns>A <see cref="BTTN4KNFE.BTTN4KNFEDirectory"/> instance.</returns>
        public unsafe static BTTN4KNFEDirectory_Accessor UseBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, long cellId, CellAccessOptions options)
        {
            return BTTN4KNFEDirectory_Accessor._get()._Lock(cellId, options);
        }
        /// <summary>
        /// Allocate a cell accessor on the specified cell, which interprets
        /// the cell as a BTTN4KNFEDirectory. Any changes done to the accessor
        /// are written to the storage immediately.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// on calling this method, it attempts to acquire the lock of the cell,
        /// and blocks until it gets the lock.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">The id of the specified cell.</param>
        /// <returns>A <see cref="" + script.RootNamespace + ".BTTN4KNFEDirectory"/> instance.</returns>
        public unsafe static BTTN4KNFEDirectory_Accessor UseBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, long cellId)
        {
            return BTTN4KNFEDirectory_Accessor._get()._Lock(cellId, CellAccessOptions.ThrowExceptionOnCellNotFound);
        }
        #endregion
        #region LocalStorage Non-Tx logging
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The value of the cell is specified in the method parameters.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, CellAccessOptions options, long cellId, int count = default(int), List<long> ids = default(List<long>))
        {
            
            byte* targetPtr;
            
            targetPtr = null;
            
            {
            targetPtr += 4;

if(ids!= null)
{
    targetPtr += ids.Count*8+sizeof(int);
}else
{
    targetPtr += sizeof(int);
}

            }
            byte[] tmpcell = new byte[(int)(targetPtr)];
            fixed (byte* _tmpcellptr = tmpcell)
            {
                targetPtr = _tmpcellptr;
                
            {
            *(int*)targetPtr = count;
            targetPtr += 4;

if(ids!= null)
{
    *(int*)targetPtr = ids.Count*8;
    targetPtr += sizeof(int);
    for(int iterator_2 = 0;iterator_2<ids.Count;++iterator_2)
    {
            *(long*)targetPtr = ids[iterator_2];
            targetPtr += 8;

    }

}else
{
    *(int*)targetPtr = 0;
    targetPtr += sizeof(int);
}

            }
            }
            
            return storage.SaveCell(options, cellId, tmpcell, 0, tmpcell.Length, (ushort)CellType.BTTN4KNFEDirectory) == TrinityErrorCode.E_SUCCESS;
        }
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The parameter <paramref name="cellId"/> overrides the cell id in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, CellAccessOptions options, long cellId, BTTN4KNFEDirectory cellContent)
        {
            return SaveBTTN4KNFEDirectory(storage, options, cellId  , cellContent.count  , cellContent.ids );
        }
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. Cell Id is specified by the CellId field in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, CellAccessOptions options, BTTN4KNFEDirectory cellContent)
        {
            return SaveBTTN4KNFEDirectory(storage, options, cellContent.CellId  , cellContent.count  , cellContent.ids );
        }
        /// <summary>
        /// Loads the content of the specified cell. Any changes done to this object are not written to the store, unless
        /// the content object is saved back into the storage.
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// </summary>
        public unsafe static BTTN4KNFEDirectory LoadBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, long cellId)
        {
            using (var cell = BTTN4KNFEDirectory_Accessor._get()._Lock(cellId, CellAccessOptions.ThrowExceptionOnCellNotFound))
            {
                return cell;
            }
        }
        #endregion
        #region LocalMemoryStorage Tx accessors
        /// <summary>
        /// Allocate a cell accessor on the specified cell, which interprets
        /// the cell as a BTTN4KNFEDirectory. Any changes done to the accessor
        /// are written to the storage immediately.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// on calling this method, it attempts to acquire the lock of the cell,
        /// and blocks until it gets the lock. Otherwise this method is wait-free.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">The id of the specified cell.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <returns>A <see cref="BTTN4KNFE.BTTN4KNFEDirectory"/> instance.</returns>
        public unsafe static BTTN4KNFEDirectory_Accessor UseBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, long cellId, CellAccessOptions options)
        {
            return BTTN4KNFEDirectory_Accessor._get()._Lock(cellId, options, tx);
        }
        /// <summary>
        /// Allocate a cell accessor on the specified cell, which interprets
        /// the cell as a BTTN4KNFEDirectory. Any changes done to the accessor
        /// are written to the storage immediately.
        /// If <c><see cref="Trinity.TrinityConfig.ReadOnly"/> == false</c>,
        /// on calling this method, it attempts to acquire the lock of the cell,
        /// and blocks until it gets the lock.
        /// </summary>
        /// <param name="storage">A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">The id of the specified cell.</param>
        /// <returns>A <see cref="" + script.RootNamespace + ".BTTN4KNFEDirectory"/> instance.</returns>
        public unsafe static BTTN4KNFEDirectory_Accessor UseBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, long cellId)
        {
            return BTTN4KNFEDirectory_Accessor._get()._Lock(cellId, CellAccessOptions.ThrowExceptionOnCellNotFound, tx);
        }
        #endregion
        #region LocalStorage Tx logging
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The value of the cell is specified in the method parameters.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, CellAccessOptions options, long cellId, int count = default(int), List<long> ids = default(List<long>))
        {
            
            byte* targetPtr;
            
            targetPtr = null;
            
            {
            targetPtr += 4;

if(ids!= null)
{
    targetPtr += ids.Count*8+sizeof(int);
}else
{
    targetPtr += sizeof(int);
}

            }
            byte[] tmpcell = new byte[(int)(targetPtr)];
            fixed (byte* _tmpcellptr = tmpcell)
            {
                targetPtr = _tmpcellptr;
                
            {
            *(int*)targetPtr = count;
            targetPtr += 4;

if(ids!= null)
{
    *(int*)targetPtr = ids.Count*8;
    targetPtr += sizeof(int);
    for(int iterator_2 = 0;iterator_2<ids.Count;++iterator_2)
    {
            *(long*)targetPtr = ids[iterator_2];
            targetPtr += 8;

    }

}else
{
    *(int*)targetPtr = 0;
    targetPtr += sizeof(int);
}

            }
            }
            
            return storage.SaveCell(tx, options, cellId, tmpcell, 0, tmpcell.Length, (ushort)CellType.BTTN4KNFEDirectory) == TrinityErrorCode.E_SUCCESS;
        }
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. The parameter <paramref name="cellId"/> overrides the cell id in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="cellId">A 64-bit cell Id.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, CellAccessOptions options, long cellId, BTTN4KNFEDirectory cellContent)
        {
            return SaveBTTN4KNFEDirectory(storage, tx, options, cellId  , cellContent.count  , cellContent.ids );
        }
        /// <summary>
        /// Adds a new cell of type BTTN4KNFEDirectory to the key-value store if the cell Id does not exist, or updates an existing cell in the key-value store if the cell Id already exists. Cell Id is specified by the CellId field in the content object.
        /// </summary>
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// <param name="options">Specifies write-ahead logging behavior. Valid values are CellAccessOptions.StrongLogAhead(default) and CellAccessOptions.WeakLogAhead. Other values are ignored.</param>
        /// <param name="cellContent">The content of the cell.</param>
        /// <returns>true if saving succeeds; otherwise, false.</returns>
        public unsafe static bool SaveBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, CellAccessOptions options, BTTN4KNFEDirectory cellContent)
        {
            return SaveBTTN4KNFEDirectory(storage, tx, options, cellContent.CellId  , cellContent.count  , cellContent.ids );
        }
        /// <summary>
        /// Loads the content of the specified cell. Any changes done to this object are not written to the store, unless
        /// the content object is saved back into the storage.
        /// <param name="storage"/>A <see cref="Trinity.Storage.LocalMemoryStorage"/> instance.</param>
        /// </summary>
        public unsafe static BTTN4KNFEDirectory LoadBTTN4KNFEDirectory(this Trinity.Storage.LocalMemoryStorage storage, LocalTransactionContext tx, long cellId)
        {
            using (var cell = BTTN4KNFEDirectory_Accessor._get()._Lock(cellId, CellAccessOptions.ThrowExceptionOnCellNotFound, tx))
            {
                return cell;
            }
        }
        #endregion
    }
}

#pragma warning restore 162,168,649,660,661,1522
