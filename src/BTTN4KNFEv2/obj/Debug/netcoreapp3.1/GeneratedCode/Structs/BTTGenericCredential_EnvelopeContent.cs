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
    /// A .NET runtime object representation of BTTGenericCredential_EnvelopeContent defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct BTTGenericCredential_EnvelopeContent
    {
        
        ///<summary>
        ///Initializes a new instance of BTTGenericCredential_EnvelopeContent with the specified parameters.
        ///</summary>
        public BTTGenericCredential_EnvelopeContent(string udid = default(string),List<string> context = default(List<string>),string credentialsubjectudid = default(string),List<BTTClaim> credentialsubjectclaims = default(List<BTTClaim>),BTTEncryptedClaims? encryptedclaims = default(BTTEncryptedClaims?))
        {
            
            this.udid = udid;
            
            this.context = context;
            
            this.credentialsubjectudid = credentialsubjectudid;
            
            this.credentialsubjectclaims = credentialsubjectclaims;
            
            this.encryptedclaims = encryptedclaims;
            
        }
        
        public static bool operator ==(BTTGenericCredential_EnvelopeContent a, BTTGenericCredential_EnvelopeContent b)
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
                
                (a.udid == b.udid)
                &&
                (a.context == b.context)
                &&
                (a.credentialsubjectudid == b.credentialsubjectudid)
                &&
                (a.credentialsubjectclaims == b.credentialsubjectclaims)
                &&
                (a.encryptedclaims == b.encryptedclaims)
                
                ;
            
        }
        public static bool operator !=(BTTGenericCredential_EnvelopeContent a, BTTGenericCredential_EnvelopeContent b)
        {
            return !(a == b);
        }
        
        public string udid;
        
        public List<string> context;
        
        public string credentialsubjectudid;
        
        public List<BTTClaim> credentialsubjectclaims;
        
        public BTTEncryptedClaims? encryptedclaims;
        
        /// <summary>
        /// Converts the string representation of a BTTGenericCredential_EnvelopeContent to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(BTTGenericCredential_EnvelopeContent) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out BTTGenericCredential_EnvelopeContent value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<BTTGenericCredential_EnvelopeContent>(input);
                return true;
            }
            catch { value = default(BTTGenericCredential_EnvelopeContent); return false; }
        }
        public static BTTGenericCredential_EnvelopeContent Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BTTGenericCredential_EnvelopeContent>(input);
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
    /// Provides in-place operations of BTTGenericCredential_EnvelopeContent defined in TSL.
    /// </summary>
    public unsafe partial class BTTGenericCredential_EnvelopeContent_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe BTTGenericCredential_EnvelopeContent_Accessor(byte* _CellPtr
            
            , ResizeFunctionDelegate func
            )
        {
            m_ptr = _CellPtr;
            
            ResizeFunction = func;
                    udid_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        context_Accessor_Field = new StringAccessorListAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        credentialsubjectudid_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        credentialsubjectclaims_Accessor_Field = new BTTClaim_AccessorListAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        encryptedclaims_Accessor_Field = new BTTEncryptedClaims_Accessor(null,
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
                    
                    "credentialsubjectudid"
                    ,
                    "credentialsubjectclaims"
                    ,
                    "encryptedclaims"
                    
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
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_0 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_0 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_0 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_0 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_0 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_0 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}
            int size = (int)(targetPtr - m_ptr);
            return size;
        }
        public ResizeFunctionDelegate ResizeFunction { get; set; }
        #endregion
        StringAccessor udid_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field udid.
        ///</summary>
        public unsafe StringAccessor udid
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
}udid_Accessor_Field.m_ptr = targetPtr + 4;
                udid_Accessor_Field.m_cellId = this.m_cellId;
                return udid_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                udid_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != udid_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    udid_Accessor_Field.m_ptr = udid_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, udid_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        udid_Accessor_Field.m_ptr = udid_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, udid_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        StringAccessorListAccessor context_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field context.
        ///</summary>
        public unsafe StringAccessorListAccessor context
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);}context_Accessor_Field.m_ptr = targetPtr + 4;
                context_Accessor_Field.m_cellId = this.m_cellId;
                return context_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                context_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != context_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    context_Accessor_Field.m_ptr = context_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, context_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        context_Accessor_Field.m_ptr = context_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, context_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        StringAccessor credentialsubjectudid_Accessor_Field;
        
        ///<summary>
        ///Represents the presence of the optional field credentialsubjectudid.
        ///</summary>
        public bool Contains_credentialsubjectudid
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
        ///Removes the optional field credentialsubjectudid from the object being operated.
        ///</summary>
        public unsafe void Remove_credentialsubjectudid()
        {
            if (!this.Contains_credentialsubjectudid)
            {
                throw new Exception("Optional field credentialsubjectudid doesn't exist for current cell.");
            }
            this.Contains_credentialsubjectudid = false;
            byte* targetPtr = m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
            byte* startPtr = targetPtr;
            targetPtr += *(int*)targetPtr + sizeof(int);
            this.ResizeFunction(startPtr, 0, (int)(startPtr - targetPtr));
        }
        
        ///<summary>
        ///Provides in-place access to the object field credentialsubjectudid.
        ///</summary>
        public unsafe StringAccessor credentialsubjectudid
        {
            get
            {
                
                if (!this.Contains_credentialsubjectudid)
                {
                    throw new Exception("Optional field credentialsubjectudid doesn't exist for current cell.");
                }
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}credentialsubjectudid_Accessor_Field.m_ptr = targetPtr + 4;
                credentialsubjectudid_Accessor_Field.m_cellId = this.m_cellId;
                return credentialsubjectudid_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                credentialsubjectudid_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                bool creatingOptionalField = (!this.Contains_credentialsubjectudid);
                if (creatingOptionalField)
                {
                    this.Contains_credentialsubjectudid = true;
                    
                int length = *(int*)(value.m_ptr - 4);
                if (value.m_cellId != credentialsubjectudid_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    credentialsubjectudid_Accessor_Field.m_ptr = credentialsubjectudid_Accessor_Field.ResizeFunction(targetPtr, 0, length + sizeof(int));
                    Memory.Copy(value.m_ptr - 4, credentialsubjectudid_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        credentialsubjectudid_Accessor_Field.m_ptr = credentialsubjectudid_Accessor_Field.ResizeFunction(targetPtr, 0, length + sizeof(int));
                        Memory.Copy(tmpcellptr, credentialsubjectudid_Accessor_Field.m_ptr, length + 4);
                    }
                }

                }
                else
                {
                    
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != credentialsubjectudid_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    credentialsubjectudid_Accessor_Field.m_ptr = credentialsubjectudid_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, credentialsubjectudid_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        credentialsubjectudid_Accessor_Field.m_ptr = credentialsubjectudid_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, credentialsubjectudid_Accessor_Field.m_ptr, length + 4);
                    }
                }

                }
                
            }
        }
        BTTClaim_AccessorListAccessor credentialsubjectclaims_Accessor_Field;
        
        ///<summary>
        ///Represents the presence of the optional field credentialsubjectclaims.
        ///</summary>
        public bool Contains_credentialsubjectclaims
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
        ///Removes the optional field credentialsubjectclaims from the object being operated.
        ///</summary>
        public unsafe void Remove_credentialsubjectclaims()
        {
            if (!this.Contains_credentialsubjectclaims)
            {
                throw new Exception("Optional field credentialsubjectclaims doesn't exist for current cell.");
            }
            this.Contains_credentialsubjectclaims = false;
            byte* targetPtr = m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
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
        ///Provides in-place access to the object field credentialsubjectclaims.
        ///</summary>
        public unsafe BTTClaim_AccessorListAccessor credentialsubjectclaims
        {
            get
            {
                
                if (!this.Contains_credentialsubjectclaims)
                {
                    throw new Exception("Optional field credentialsubjectclaims doesn't exist for current cell.");
                }
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}credentialsubjectclaims_Accessor_Field.m_ptr = targetPtr + 4;
                credentialsubjectclaims_Accessor_Field.m_cellId = this.m_cellId;
                return credentialsubjectclaims_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                credentialsubjectclaims_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}
                bool creatingOptionalField = (!this.Contains_credentialsubjectclaims);
                if (creatingOptionalField)
                {
                    this.Contains_credentialsubjectclaims = true;
                    
                int length = *(int*)(value.m_ptr - 4);
                if (value.m_cellId != credentialsubjectclaims_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    credentialsubjectclaims_Accessor_Field.m_ptr = credentialsubjectclaims_Accessor_Field.ResizeFunction(targetPtr, 0, length + sizeof(int));
                    Memory.Copy(value.m_ptr - 4, credentialsubjectclaims_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        credentialsubjectclaims_Accessor_Field.m_ptr = credentialsubjectclaims_Accessor_Field.ResizeFunction(targetPtr, 0, length + sizeof(int));
                        Memory.Copy(tmpcellptr, credentialsubjectclaims_Accessor_Field.m_ptr, length + 4);
                    }
                }

                }
                else
                {
                    
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != credentialsubjectclaims_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    credentialsubjectclaims_Accessor_Field.m_ptr = credentialsubjectclaims_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, credentialsubjectclaims_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        credentialsubjectclaims_Accessor_Field.m_ptr = credentialsubjectclaims_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, credentialsubjectclaims_Accessor_Field.m_ptr, length + 4);
                    }
                }

                }
                
            }
        }
        BTTEncryptedClaims_Accessor encryptedclaims_Accessor_Field;
        
        ///<summary>
        ///Represents the presence of the optional field encryptedclaims.
        ///</summary>
        public bool Contains_encryptedclaims
        {
            get
            {
                unchecked
                {
                    return (0 != (*(this.m_ptr + 0) & 0x04)) ;
                }
            }
            internal set
            {
                unchecked
                {
                    if (value)
                    {
                        *(this.m_ptr + 0) |= 0x04;
                    }
                    else
                    {
                        *(this.m_ptr + 0) &= 0xFB;
                    }
                }
            }
        }
        ///<summary>
        ///Removes the optional field encryptedclaims from the object being operated.
        ///</summary>
        public unsafe void Remove_encryptedclaims()
        {
            if (!this.Contains_encryptedclaims)
            {
                throw new Exception("Optional field encryptedclaims doesn't exist for current cell.");
            }
            this.Contains_encryptedclaims = false;
            byte* targetPtr = m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}
            byte* startPtr = targetPtr;
            {targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
            this.ResizeFunction(startPtr, 0, (int)(startPtr - targetPtr));
        }
        
        ///<summary>
        ///Provides in-place access to the object field encryptedclaims.
        ///</summary>
        public unsafe BTTEncryptedClaims_Accessor encryptedclaims
        {
            get
            {
                
                if (!this.Contains_encryptedclaims)
                {
                    throw new Exception("Optional field encryptedclaims doesn't exist for current cell.");
                }
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}encryptedclaims_Accessor_Field.m_ptr = targetPtr;
                encryptedclaims_Accessor_Field.m_cellId = this.m_cellId;
                return encryptedclaims_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                encryptedclaims_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}
                bool creatingOptionalField = (!this.Contains_encryptedclaims);
                if (creatingOptionalField)
                {
                    this.Contains_encryptedclaims = true;
                    
                int offset = (int)(targetPtr - m_ptr);
                byte* oldtargetPtr = targetPtr;
                int oldlength = 0;
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
                else
                {
                    
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
        }
        
        public static unsafe implicit operator BTTGenericCredential_EnvelopeContent(BTTGenericCredential_EnvelopeContent_Accessor accessor)
        {
            string _credentialsubjectudid = default(string);
            if (accessor.Contains_credentialsubjectudid)
            {
                
                _credentialsubjectudid = accessor.credentialsubjectudid;
                
            }
            List<BTTClaim> _credentialsubjectclaims = default(List<BTTClaim>);
            if (accessor.Contains_credentialsubjectclaims)
            {
                
                _credentialsubjectclaims = accessor.credentialsubjectclaims;
                
            }
            BTTEncryptedClaims? _encryptedclaims = default(BTTEncryptedClaims?);
            if (accessor.Contains_encryptedclaims)
            {
                
                _encryptedclaims = (BTTEncryptedClaims)accessor.encryptedclaims;
                
            }
            
            return new BTTGenericCredential_EnvelopeContent(
                
                        accessor.udid,
                        accessor.context,
                        _credentialsubjectudid ,
                        _credentialsubjectclaims ,
                        _encryptedclaims 
                );
        }
        
        public unsafe static implicit operator BTTGenericCredential_EnvelopeContent_Accessor(BTTGenericCredential_EnvelopeContent field)
        {
            byte* targetPtr = null;
            
            {
            targetPtr += 1;

        if(field.udid!= null)
        {
            int strlen_2 = field.udid.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(field.context!= null)
    {
        for(int iterator_2 = 0;iterator_2<field.context.Count;++iterator_2)
        {

        if(field.context[iterator_2]!= null)
        {
            int strlen_3 = field.context[iterator_2].Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( field.credentialsubjectudid!= null)
            {

        if(field.credentialsubjectudid!= null)
        {
            int strlen_2 = field.credentialsubjectudid.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.credentialsubjectclaims!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.credentialsubjectclaims!= null)
    {
        for(int iterator_2 = 0;iterator_2<field.credentialsubjectclaims.Count;++iterator_2)
        {

            {
            targetPtr += 1;

        if(field.credentialsubjectclaims[iterator_2].key!= null)
        {
            int strlen_4 = field.credentialsubjectclaims[iterator_2].key.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( field.credentialsubjectclaims[iterator_2].value!= null)
            {

        if(field.credentialsubjectclaims[iterator_2].value!= null)
        {
            int strlen_4 = field.credentialsubjectclaims[iterator_2].value.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.credentialsubjectclaims[iterator_2].attribute!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.credentialsubjectclaims[iterator_2].attribute!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.credentialsubjectclaims[iterator_2].attribute.Count;++iterator_4)
        {

            {

        if(field.credentialsubjectclaims[iterator_2].attribute[iterator_4].key!= null)
        {
            int strlen_6 = field.credentialsubjectclaims[iterator_2].attribute[iterator_4].key.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims[iterator_2].attribute[iterator_4].value!= null)
        {
            int strlen_6 = field.credentialsubjectclaims[iterator_2].attribute[iterator_4].value.Length * 2;
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
            if( field.credentialsubjectclaims[iterator_2].attributes!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.credentialsubjectclaims[iterator_2].attributes!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.credentialsubjectclaims[iterator_2].attributes.Count;++iterator_4)
        {

{

    targetPtr += sizeof(int);
    if(field.credentialsubjectclaims[iterator_2].attributes[iterator_4]!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.credentialsubjectclaims[iterator_2].attributes[iterator_4].Count;++iterator_5)
        {

            {

        if(field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].key!= null)
        {
            int strlen_7 = field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].key.Length * 2;
            targetPtr += strlen_7+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].value!= null)
        {
            int strlen_7 = field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].value.Length * 2;
            targetPtr += strlen_7+sizeof(int);
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
            if( field.encryptedclaims!= null)
            {

            {

        if(field.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_3 = field.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.encryptedclaims.Value.alg!= null)
        {
            int strlen_3 = field.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.encryptedclaims.Value.key!= null)
        {
            int strlen_3 = field.encryptedclaims.Value.key.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
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

        if(field.udid!= null)
        {
            int strlen_2 = field.udid.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.udid)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

{
byte *storedPtr_2 = targetPtr;

    targetPtr += sizeof(int);
    if(field.context!= null)
    {
        for(int iterator_2 = 0;iterator_2<field.context.Count;++iterator_2)
        {

        if(field.context[iterator_2]!= null)
        {
            int strlen_3 = field.context[iterator_2].Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.context[iterator_2])
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
            if( field.credentialsubjectudid!= null)
            {

        if(field.credentialsubjectudid!= null)
        {
            int strlen_2 = field.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.credentialsubjectudid)
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
            if( field.credentialsubjectclaims!= null)
            {

{
byte *storedPtr_2 = targetPtr;

    targetPtr += sizeof(int);
    if(field.credentialsubjectclaims!= null)
    {
        for(int iterator_2 = 0;iterator_2<field.credentialsubjectclaims.Count;++iterator_2)
        {

            {
            byte* optheader_3 = targetPtr;
            *(optheader_3 + 0) = 0x00;            targetPtr += 1;

        if(field.credentialsubjectclaims[iterator_2].key!= null)
        {
            int strlen_4 = field.credentialsubjectclaims[iterator_2].key.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.credentialsubjectclaims[iterator_2].key)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( field.credentialsubjectclaims[iterator_2].value!= null)
            {

        if(field.credentialsubjectclaims[iterator_2].value!= null)
        {
            int strlen_4 = field.credentialsubjectclaims[iterator_2].value.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.credentialsubjectclaims[iterator_2].value)
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
            if( field.credentialsubjectclaims[iterator_2].attribute!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(field.credentialsubjectclaims[iterator_2].attribute!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.credentialsubjectclaims[iterator_2].attribute.Count;++iterator_4)
        {

            {

        if(field.credentialsubjectclaims[iterator_2].attribute[iterator_4].key!= null)
        {
            int strlen_6 = field.credentialsubjectclaims[iterator_2].attribute[iterator_4].key.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.credentialsubjectclaims[iterator_2].attribute[iterator_4].key)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims[iterator_2].attribute[iterator_4].value!= null)
        {
            int strlen_6 = field.credentialsubjectclaims[iterator_2].attribute[iterator_4].value.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.credentialsubjectclaims[iterator_2].attribute[iterator_4].value)
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
    }
*(int*)storedPtr_4 = (int)(targetPtr - storedPtr_4 - 4);

}
*(optheader_3 + 0) |= 0x02;
            }
            if( field.credentialsubjectclaims[iterator_2].attributes!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(field.credentialsubjectclaims[iterator_2].attributes!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.credentialsubjectclaims[iterator_2].attributes.Count;++iterator_4)
        {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(field.credentialsubjectclaims[iterator_2].attributes[iterator_4]!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.credentialsubjectclaims[iterator_2].attributes[iterator_4].Count;++iterator_5)
        {

            {

        if(field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].key!= null)
        {
            int strlen_7 = field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].key.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].key)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].value!= null)
        {
            int strlen_7 = field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].value.Length * 2;
            *(int*)targetPtr = strlen_7;
            targetPtr += sizeof(int);
            fixed(char* pstr_7 = field.credentialsubjectclaims[iterator_2].attributes[iterator_4][iterator_5].value)
            {
                Memory.Copy(pstr_7, targetPtr, strlen_7);
                targetPtr += strlen_7;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_5 = (int)(targetPtr - storedPtr_5 - 4);

}

        }
    }
*(int*)storedPtr_4 = (int)(targetPtr - storedPtr_4 - 4);

}
*(optheader_3 + 0) |= 0x04;
            }

            }
        }
    }
*(int*)storedPtr_2 = (int)(targetPtr - storedPtr_2 - 4);

}
*(optheader_1 + 0) |= 0x02;
            }
            if( field.encryptedclaims!= null)
            {

            {

        if(field.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_3 = field.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.encryptedclaims.Value.alg!= null)
        {
            int strlen_3 = field.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.encryptedclaims.Value.key!= null)
        {
            int strlen_3 = field.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.encryptedclaims.Value.key)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_1 + 0) |= 0x04;
            }

            }BTTGenericCredential_EnvelopeContent_Accessor ret;
            
            ret = new BTTGenericCredential_EnvelopeContent_Accessor(tmpcellptr, null);
            
            return ret;
        }
        
        public static bool operator ==(BTTGenericCredential_EnvelopeContent_Accessor a, BTTGenericCredential_EnvelopeContent_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {            byte* optheader_1 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_1 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_1 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (BTTGenericCredential_EnvelopeContent_Accessor a, BTTGenericCredential_EnvelopeContent_Accessor b)
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
