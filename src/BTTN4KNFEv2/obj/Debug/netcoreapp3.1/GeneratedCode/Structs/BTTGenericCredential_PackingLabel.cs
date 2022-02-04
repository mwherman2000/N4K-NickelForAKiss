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
    /// A .NET runtime object representation of BTTGenericCredential_PackingLabel defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct BTTGenericCredential_PackingLabel
    {
        
        ///<summary>
        ///Initializes a new instance of BTTGenericCredential_PackingLabel with the specified parameters.
        ///</summary>
        public BTTGenericCredential_PackingLabel(List<string> types = default(List<string>),BTTGenericCredentialType credtype = default(BTTGenericCredentialType),long version = default(long),BTTTrustLevel trustLevel = default(BTTTrustLevel),BTTEncryptionFlag encryptionFlag = default(BTTEncryptionFlag),string notaryudid = default(string),string name = default(string),List<string> comments = default(List<string>))
        {
            
            this.types = types;
            
            this.credtype = credtype;
            
            this.version = version;
            
            this.trustLevel = trustLevel;
            
            this.encryptionFlag = encryptionFlag;
            
            this.notaryudid = notaryudid;
            
            this.name = name;
            
            this.comments = comments;
            
        }
        
        public static bool operator ==(BTTGenericCredential_PackingLabel a, BTTGenericCredential_PackingLabel b)
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
                
                (a.types == b.types)
                &&
                (a.credtype == b.credtype)
                &&
                (a.version == b.version)
                &&
                (a.trustLevel == b.trustLevel)
                &&
                (a.encryptionFlag == b.encryptionFlag)
                &&
                (a.notaryudid == b.notaryudid)
                &&
                (a.name == b.name)
                &&
                (a.comments == b.comments)
                
                ;
            
        }
        public static bool operator !=(BTTGenericCredential_PackingLabel a, BTTGenericCredential_PackingLabel b)
        {
            return !(a == b);
        }
        
        public List<string> types;
        
        public BTTGenericCredentialType credtype;
        
        public long version;
        
        public BTTTrustLevel trustLevel;
        
        public BTTEncryptionFlag encryptionFlag;
        
        public string notaryudid;
        
        public string name;
        
        public List<string> comments;
        
        /// <summary>
        /// Converts the string representation of a BTTGenericCredential_PackingLabel to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(BTTGenericCredential_PackingLabel) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out BTTGenericCredential_PackingLabel value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<BTTGenericCredential_PackingLabel>(input);
                return true;
            }
            catch { value = default(BTTGenericCredential_PackingLabel); return false; }
        }
        public static BTTGenericCredential_PackingLabel Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BTTGenericCredential_PackingLabel>(input);
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
    /// Provides in-place operations of BTTGenericCredential_PackingLabel defined in TSL.
    /// </summary>
    public unsafe partial class BTTGenericCredential_PackingLabel_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe BTTGenericCredential_PackingLabel_Accessor(byte* _CellPtr
            
            , ResizeFunctionDelegate func
            )
        {
            m_ptr = _CellPtr;
            
            ResizeFunction = func;
                    types_Accessor_Field = new StringAccessorListAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        notaryudid_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        name_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        comments_Accessor_Field = new StringAccessorListAccessor(null,
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
                    
                    "name"
                    ,
                    "comments"
                    
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
            
            byte [] bytes = new byte[1];
            Memory.Copy(m_ptr, 0, bytes, 0, 1);
            return bytes;
            
        }
        
        ///<summary>
        ///Copies the struct content into a byte array.
        ///</summary>
        public byte[] ToByteArray()
        {
            byte* targetPtr = m_ptr;
            {            byte* optheader_0 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_0 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_0 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
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
            {            byte* optheader_0 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_0 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_0 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}
            int size = (int)(targetPtr - m_ptr);
            return size;
        }
        public ResizeFunctionDelegate ResizeFunction { get; set; }
        #endregion
        StringAccessorListAccessor types_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field types.
        ///</summary>
        public unsafe StringAccessorListAccessor types
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
}types_Accessor_Field.m_ptr = targetPtr + 4;
                types_Accessor_Field.m_cellId = this.m_cellId;
                return types_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                types_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != types_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    types_Accessor_Field.m_ptr = types_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, types_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        types_Accessor_Field.m_ptr = types_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, types_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field credtype.
        ///</summary>
        public unsafe BTTGenericCredentialType credtype
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);}
                return *(BTTGenericCredentialType*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);}                *(BTTGenericCredentialType*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field version.
        ///</summary>
        public unsafe long version
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 1;
}
                return *(long*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 1;
}                *(long*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field trustLevel.
        ///</summary>
        public unsafe BTTTrustLevel trustLevel
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 9;
}
                return *(BTTTrustLevel*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 9;
}                *(BTTTrustLevel*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field encryptionFlag.
        ///</summary>
        public unsafe BTTEncryptionFlag encryptionFlag
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 10;
}
                return *(BTTEncryptionFlag*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 10;
}                *(BTTEncryptionFlag*)targetPtr = value;
            }
        }
        StringAccessor notaryudid_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field notaryudid.
        ///</summary>
        public unsafe StringAccessor notaryudid
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
}notaryudid_Accessor_Field.m_ptr = targetPtr + 4;
                notaryudid_Accessor_Field.m_cellId = this.m_cellId;
                return notaryudid_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                notaryudid_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != notaryudid_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    notaryudid_Accessor_Field.m_ptr = notaryudid_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, notaryudid_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        notaryudid_Accessor_Field.m_ptr = notaryudid_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, notaryudid_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        StringAccessor name_Accessor_Field;
        
        ///<summary>
        ///Represents the presence of the optional field name.
        ///</summary>
        public bool Contains_name
        {
            get
            {
                unchecked
                {
                    return (0 != (*(this.m_ptr + 0) & 0x01)) ;
                }
            }
            internal set
            {
                unchecked
                {
                    if (value)
                    {
                        *(this.m_ptr + 0) |= 0x01;
                    }
                    else
                    {
                        *(this.m_ptr + 0) &= 0xFE;
                    }
                }
            }
        }
        ///<summary>
        ///Removes the optional field name from the object being operated.
        ///</summary>
        public unsafe void Remove_name()
        {
            if (!this.Contains_name)
            {
                throw new Exception("Optional field name doesn't exist for current cell.");
            }
            this.Contains_name = false;
            byte* targetPtr = m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);}
            byte* startPtr = targetPtr;
            targetPtr += *(int*)targetPtr + sizeof(int);
            this.ResizeFunction(startPtr, 0, (int)(startPtr - targetPtr));
        }
        
        ///<summary>
        ///Provides in-place access to the object field name.
        ///</summary>
        public unsafe StringAccessor name
        {
            get
            {
                
                if (!this.Contains_name)
                {
                    throw new Exception("Optional field name doesn't exist for current cell.");
                }
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);}name_Accessor_Field.m_ptr = targetPtr + 4;
                name_Accessor_Field.m_cellId = this.m_cellId;
                return name_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                name_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);}
                bool creatingOptionalField = (!this.Contains_name);
                if (creatingOptionalField)
                {
                    this.Contains_name = true;
                    
                int length = *(int*)(value.m_ptr - 4);
                if (value.m_cellId != name_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    name_Accessor_Field.m_ptr = name_Accessor_Field.ResizeFunction(targetPtr, 0, length + sizeof(int));
                    Memory.Copy(value.m_ptr - 4, name_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        name_Accessor_Field.m_ptr = name_Accessor_Field.ResizeFunction(targetPtr, 0, length + sizeof(int));
                        Memory.Copy(tmpcellptr, name_Accessor_Field.m_ptr, length + 4);
                    }
                }

                }
                else
                {
                    
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != name_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    name_Accessor_Field.m_ptr = name_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, name_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        name_Accessor_Field.m_ptr = name_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, name_Accessor_Field.m_ptr, length + 4);
                    }
                }

                }
                
            }
        }
        StringAccessorListAccessor comments_Accessor_Field;
        
        ///<summary>
        ///Represents the presence of the optional field comments.
        ///</summary>
        public bool Contains_comments
        {
            get
            {
                unchecked
                {
                    return (0 != (*(this.m_ptr + 0) & 0x02)) ;
                }
            }
            internal set
            {
                unchecked
                {
                    if (value)
                    {
                        *(this.m_ptr + 0) |= 0x02;
                    }
                    else
                    {
                        *(this.m_ptr + 0) &= 0xFD;
                    }
                }
            }
        }
        ///<summary>
        ///Removes the optional field comments from the object being operated.
        ///</summary>
        public unsafe void Remove_comments()
        {
            if (!this.Contains_comments)
            {
                throw new Exception("Optional field comments doesn't exist for current cell.");
            }
            this.Contains_comments = false;
            byte* targetPtr = m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}
            byte* startPtr = targetPtr;
            targetPtr += *(int*)targetPtr + sizeof(int);
            this.ResizeFunction(startPtr, 0, (int)(startPtr - targetPtr));
        }
        
        ///<summary>
        ///Provides in-place access to the object field comments.
        ///</summary>
        public unsafe StringAccessorListAccessor comments
        {
            get
            {
                
                if (!this.Contains_comments)
                {
                    throw new Exception("Optional field comments doesn't exist for current cell.");
                }
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}comments_Accessor_Field.m_ptr = targetPtr + 4;
                comments_Accessor_Field.m_cellId = this.m_cellId;
                return comments_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                comments_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}
                bool creatingOptionalField = (!this.Contains_comments);
                if (creatingOptionalField)
                {
                    this.Contains_comments = true;
                    
                int length = *(int*)(value.m_ptr - 4);
                if (value.m_cellId != comments_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    comments_Accessor_Field.m_ptr = comments_Accessor_Field.ResizeFunction(targetPtr, 0, length + sizeof(int));
                    Memory.Copy(value.m_ptr - 4, comments_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        comments_Accessor_Field.m_ptr = comments_Accessor_Field.ResizeFunction(targetPtr, 0, length + sizeof(int));
                        Memory.Copy(tmpcellptr, comments_Accessor_Field.m_ptr, length + 4);
                    }
                }

                }
                else
                {
                    
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != comments_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    comments_Accessor_Field.m_ptr = comments_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, comments_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        comments_Accessor_Field.m_ptr = comments_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, comments_Accessor_Field.m_ptr, length + 4);
                    }
                }

                }
                
            }
        }
        
        public static unsafe implicit operator BTTGenericCredential_PackingLabel(BTTGenericCredential_PackingLabel_Accessor accessor)
        {
            string _name = default(string);
            if (accessor.Contains_name)
            {
                
                _name = accessor.name;
                
            }
            List<string> _comments = default(List<string>);
            if (accessor.Contains_comments)
            {
                
                _comments = accessor.comments;
                
            }
            
            return new BTTGenericCredential_PackingLabel(
                
                        accessor.types,
                        accessor.credtype,
                        accessor.version,
                        accessor.trustLevel,
                        accessor.encryptionFlag,
                        accessor.notaryudid,
                        _name ,
                        _comments 
                );
        }
        
        public unsafe static implicit operator BTTGenericCredential_PackingLabel_Accessor(BTTGenericCredential_PackingLabel field)
        {
            byte* targetPtr = null;
            
            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(field.types!= null)
    {
        for(int iterator_2 = 0;iterator_2<field.types.Count;++iterator_2)
        {

        if(field.types[iterator_2]!= null)
        {
            int strlen_3 = field.types[iterator_2].Length * 2;
            targetPtr += strlen_3+sizeof(int);
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

        if(field.notaryudid!= null)
        {
            int strlen_2 = field.notaryudid.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( field.name!= null)
            {

        if(field.name!= null)
        {
            int strlen_2 = field.name.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.comments!= null)
    {
        for(int iterator_2 = 0;iterator_2<field.comments.Count;++iterator_2)
        {

        if(field.comments[iterator_2]!= null)
        {
            int strlen_3 = field.comments[iterator_2].Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
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
            byte* optheader_1 = targetPtr;
            *(optheader_1 + 0) = 0x00;            targetPtr += 1;

{
byte *storedPtr_2 = targetPtr;

    targetPtr += sizeof(int);
    if(field.types!= null)
    {
        for(int iterator_2 = 0;iterator_2<field.types.Count;++iterator_2)
        {

        if(field.types[iterator_2]!= null)
        {
            int strlen_3 = field.types[iterator_2].Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.types[iterator_2])
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_2 = (int)(targetPtr - storedPtr_2 - 4);

}
            *(BTTGenericCredentialType*)targetPtr = field.credtype;
            targetPtr += 1;
            *(long*)targetPtr = field.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = field.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = field.encryptionFlag;
            targetPtr += 1;

        if(field.notaryudid!= null)
        {
            int strlen_2 = field.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.notaryudid)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( field.name!= null)
            {

        if(field.name!= null)
        {
            int strlen_2 = field.name.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.name)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_1 + 0) |= 0x01;
            }
            if( field.comments!= null)
            {

{
byte *storedPtr_2 = targetPtr;

    targetPtr += sizeof(int);
    if(field.comments!= null)
    {
        for(int iterator_2 = 0;iterator_2<field.comments.Count;++iterator_2)
        {

        if(field.comments[iterator_2]!= null)
        {
            int strlen_3 = field.comments[iterator_2].Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.comments[iterator_2])
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_2 = (int)(targetPtr - storedPtr_2 - 4);

}
*(optheader_1 + 0) |= 0x02;
            }

            }BTTGenericCredential_PackingLabel_Accessor ret;
            
            ret = new BTTGenericCredential_PackingLabel_Accessor(tmpcellptr, null);
            
            return ret;
        }
        
        public static bool operator ==(BTTGenericCredential_PackingLabel_Accessor a, BTTGenericCredential_PackingLabel_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (BTTGenericCredential_PackingLabel_Accessor a, BTTGenericCredential_PackingLabel_Accessor b)
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
