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
using Trinity.Storage;
using Trinity.Utilities;
using Trinity.TSL.Lib;
using Trinity.Network;
using Trinity.Network.Sockets;
using Trinity.Network.Messaging;
using Trinity.TSL;
using System.Text.RegularExpressions;
using Trinity.Core.Lib;
namespace BTTN4KNFE
{
    
    /// <summary>
    /// A .NET runtime object representation of GetNFEBatchResponse defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct GetNFEBatchResponse
    {
        
        ///<summary>
        ///Initializes a new instance of GetNFEBatchResponse with the specified parameters.
        ///</summary>
        public GetNFEBatchResponse(List<long> udids = default(List<long>))
        {
            
            this.udids = udids;
            
        }
        
        public static bool operator ==(GetNFEBatchResponse a, GetNFEBatchResponse b)
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
                
                (a.udids == b.udids)
                
                ;
            
        }
        public static bool operator !=(GetNFEBatchResponse a, GetNFEBatchResponse b)
        {
            return !(a == b);
        }
        
        public List<long> udids;
        
        /// <summary>
        /// Converts the string representation of a GetNFEBatchResponse to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(GetNFEBatchResponse) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out GetNFEBatchResponse value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<GetNFEBatchResponse>(input);
                return true;
            }
            catch { value = default(GetNFEBatchResponse); return false; }
        }
        public static GetNFEBatchResponse Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetNFEBatchResponse>(input);
        }
        /// <summary>
        /// Serializes this object to a Json string.
        /// </summary>
        /// <returns>The Json string serialized.</returns>
        public override string ToString()
        {
            return Serializer.ToString(this);
        }
    }
    /// <summary>
    /// Provides in-place operations of GetNFEBatchResponse defined in TSL.
    /// </summary>
    public unsafe partial class GetNFEBatchResponse_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe GetNFEBatchResponse_Accessor(byte* _CellPtr
            
            , ResizeFunctionDelegate func
            )
        {
            m_ptr = _CellPtr;
            
            ResizeFunction = func;
                    udids_Accessor_Field = new longListAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });
        }
        
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
        
        ///<summary>
        ///Copies the struct content into a byte array.
        ///</summary>
        public byte[] ToByteArray()
        {
            byte* targetPtr = m_ptr;
            {targetPtr += *(int*)targetPtr + sizeof(int);}
            int size = (int)(targetPtr - m_ptr);
            byte[] ret = new byte[size];
            Memory.Copy(m_ptr, 0, ret, 0, size);
            return ret;
        }
        #region IAccessor
        public unsafe byte* GetUnderlyingBufferPointer()
        {
            return m_ptr;
        }
        public unsafe int GetBufferLength()
        {
            byte* targetPtr = m_ptr;
            {targetPtr += *(int*)targetPtr + sizeof(int);}
            int size = (int)(targetPtr - m_ptr);
            return size;
        }
        public ResizeFunctionDelegate ResizeFunction { get; set; }
        #endregion
        longListAccessor udids_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field udids.
        ///</summary>
        public unsafe longListAccessor udids
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {}udids_Accessor_Field.m_ptr = targetPtr + 4;
                udids_Accessor_Field.m_cellId = this.m_cellId;
                return udids_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                udids_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != udids_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    udids_Accessor_Field.m_ptr = udids_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, udids_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        udids_Accessor_Field.m_ptr = udids_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, udids_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        
        public static unsafe implicit operator GetNFEBatchResponse(GetNFEBatchResponse_Accessor accessor)
        {
            
            return new GetNFEBatchResponse(
                
                        accessor.udids
                );
        }
        
        public unsafe static implicit operator GetNFEBatchResponse_Accessor(GetNFEBatchResponse field)
        {
            byte* targetPtr = null;
            
            {

if(field.udids!= null)
{
    targetPtr += field.udids.Count*8+sizeof(int);
}else
{
    targetPtr += sizeof(int);
}

            }
            byte* tmpcellptr = BufferAllocator.AllocBuffer((int)targetPtr);
            Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
            targetPtr = tmpcellptr;
            
            {

if(field.udids!= null)
{
    *(int*)targetPtr = field.udids.Count*8;
    targetPtr += sizeof(int);
    for(int iterator_2 = 0;iterator_2<field.udids.Count;++iterator_2)
    {
            *(long*)targetPtr = field.udids[iterator_2];
            targetPtr += 8;

    }

}else
{
    *(int*)targetPtr = 0;
    targetPtr += sizeof(int);
}

            }GetNFEBatchResponse_Accessor ret;
            
            ret = new GetNFEBatchResponse_Accessor(tmpcellptr, null);
            
            return ret;
        }
        
        public static bool operator ==(GetNFEBatchResponse_Accessor a, GetNFEBatchResponse_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {targetPtr += *(int*)targetPtr + sizeof(int);}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {targetPtr += *(int*)targetPtr + sizeof(int);}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (GetNFEBatchResponse_Accessor a, GetNFEBatchResponse_Accessor b)
        {
            return !(a == b);
        }
        
        /// <summary>
        /// Serializes this object to a Json string.
        /// </summary>
        /// <returns>The Json string serialized.</returns>
        public override string ToString()
        {
            return Serializer.ToString(this);
        }
        
    }
}

#pragma warning restore 162,168,649,660,661,1522
