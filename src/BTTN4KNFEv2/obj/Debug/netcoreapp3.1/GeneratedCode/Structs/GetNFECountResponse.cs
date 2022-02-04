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
    /// A .NET runtime object representation of GetNFECountResponse defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct GetNFECountResponse
    {
        
        ///<summary>
        ///Initializes a new instance of GetNFECountResponse with the specified parameters.
        ///</summary>
        public GetNFECountResponse(long count = default(long),long rc = default(long))
        {
            
            this.count = count;
            
            this.rc = rc;
            
        }
        
        public static bool operator ==(GetNFECountResponse a, GetNFECountResponse b)
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
                (a.rc == b.rc)
                
                ;
            
        }
        public static bool operator !=(GetNFECountResponse a, GetNFECountResponse b)
        {
            return !(a == b);
        }
        
        public long count;
        
        public long rc;
        
        /// <summary>
        /// Converts the string representation of a GetNFECountResponse to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(GetNFECountResponse) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out GetNFECountResponse value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<GetNFECountResponse>(input);
                return true;
            }
            catch { value = default(GetNFECountResponse); return false; }
        }
        public static GetNFECountResponse Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<GetNFECountResponse>(input);
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
    /// Provides in-place operations of GetNFECountResponse defined in TSL.
    /// </summary>
    public unsafe partial class GetNFECountResponse_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe GetNFECountResponse_Accessor(byte* _CellPtr
            )
        {
            m_ptr = _CellPtr;
            
            ResizeFunction = (a,b,c) => { return Throw.invalid_resize_on_fixed_struct(); };
            
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
            {            targetPtr += 16;
}
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
            {            targetPtr += 16;
}
            int size = (int)(targetPtr - m_ptr);
            return size;
        }
        public ResizeFunctionDelegate ResizeFunction { get; set; }
        #endregion
        
        ///<summary>
        ///Provides in-place access to the object field count.
        ///</summary>
        public unsafe long count
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {}
                return *(long*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {}                *(long*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field rc.
        ///</summary>
        public unsafe long rc
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            targetPtr += 8;
}
                return *(long*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {            targetPtr += 8;
}                *(long*)targetPtr = value;
            }
        }
        
        public static unsafe implicit operator GetNFECountResponse(GetNFECountResponse_Accessor accessor)
        {
            
            return new GetNFECountResponse(
                
                        accessor.count,
                        accessor.rc
                );
        }
        
        public unsafe static implicit operator GetNFECountResponse_Accessor(GetNFECountResponse field)
        {
            byte* targetPtr = null;
            targetPtr += 16;

            byte* tmpcellptr = BufferAllocator.AllocBuffer((int)targetPtr);
            Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
            targetPtr = tmpcellptr;
            
            {
            *(long*)targetPtr = field.count;
            targetPtr += 8;
            *(long*)targetPtr = field.rc;
            targetPtr += 8;

            }GetNFECountResponse_Accessor ret;
            
            ret = new GetNFECountResponse_Accessor(tmpcellptr);
            
            return ret;
        }
        
        public static bool operator ==(GetNFECountResponse_Accessor a, GetNFECountResponse_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {            targetPtr += 16;
}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {            targetPtr += 16;
}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (GetNFECountResponse_Accessor a, GetNFECountResponse_Accessor b)
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
