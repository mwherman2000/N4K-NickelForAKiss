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
    /// A .NET runtime object representation of BTTNFE_N4K_EnvelopeContent defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct BTTNFE_N4K_EnvelopeContent
    {
        
        ///<summary>
        ///Initializes a new instance of BTTNFE_N4K_EnvelopeContent with the specified parameters.
        ///</summary>
        public BTTNFE_N4K_EnvelopeContent(string udid = default(string),List<string> context = default(List<string>),string credentialsubjectudid = default(string),BTTNFE_N4K_Claims? credentialsubjectclaims = default(BTTNFE_N4K_Claims?),BTTEncryptedClaims? encryptedclaims = default(BTTEncryptedClaims?))
        {
            
            this.udid = udid;
            
            this.context = context;
            
            this.credentialsubjectudid = credentialsubjectudid;
            
            this.credentialsubjectclaims = credentialsubjectclaims;
            
            this.encryptedclaims = encryptedclaims;
            
        }
        
        public static bool operator ==(BTTNFE_N4K_EnvelopeContent a, BTTNFE_N4K_EnvelopeContent b)
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
        public static bool operator !=(BTTNFE_N4K_EnvelopeContent a, BTTNFE_N4K_EnvelopeContent b)
        {
            return !(a == b);
        }
        
        public string udid;
        
        public List<string> context;
        
        public string credentialsubjectudid;
        
        public BTTNFE_N4K_Claims? credentialsubjectclaims;
        
        public BTTEncryptedClaims? encryptedclaims;
        
        /// <summary>
        /// Converts the string representation of a BTTNFE_N4K_EnvelopeContent to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(BTTNFE_N4K_EnvelopeContent) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out BTTNFE_N4K_EnvelopeContent value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<BTTNFE_N4K_EnvelopeContent>(input);
                return true;
            }
            catch { value = default(BTTNFE_N4K_EnvelopeContent); return false; }
        }
        public static BTTNFE_N4K_EnvelopeContent Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BTTNFE_N4K_EnvelopeContent>(input);
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
    /// Provides in-place operations of BTTNFE_N4K_EnvelopeContent defined in TSL.
    /// </summary>
    public unsafe partial class BTTNFE_N4K_EnvelopeContent_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe BTTNFE_N4K_EnvelopeContent_Accessor(byte* _CellPtr
            
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
                });        credentialsubjectclaims_Accessor_Field = new BTTNFE_N4K_Claims_Accessor(null,
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
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
        BTTNFE_N4K_Claims_Accessor credentialsubjectclaims_Accessor_Field;
        
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
            {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
            this.ResizeFunction(startPtr, 0, (int)(startPtr - targetPtr));
        }
        
        ///<summary>
        ///Provides in-place access to the object field credentialsubjectclaims.
        ///</summary>
        public unsafe BTTNFE_N4K_Claims_Accessor credentialsubjectclaims
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
}credentialsubjectclaims_Accessor_Field.m_ptr = targetPtr;
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
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
        
        public static unsafe implicit operator BTTNFE_N4K_EnvelopeContent(BTTNFE_N4K_EnvelopeContent_Accessor accessor)
        {
            string _credentialsubjectudid = default(string);
            if (accessor.Contains_credentialsubjectudid)
            {
                
                _credentialsubjectudid = accessor.credentialsubjectudid;
                
            }
            BTTNFE_N4K_Claims? _credentialsubjectclaims = default(BTTNFE_N4K_Claims?);
            if (accessor.Contains_credentialsubjectclaims)
            {
                
                _credentialsubjectclaims = (BTTNFE_N4K_Claims)accessor.credentialsubjectclaims;
                
            }
            BTTEncryptedClaims? _encryptedclaims = default(BTTEncryptedClaims?);
            if (accessor.Contains_encryptedclaims)
            {
                
                _encryptedclaims = (BTTEncryptedClaims)accessor.encryptedclaims;
                
            }
            
            return new BTTNFE_N4K_EnvelopeContent(
                
                        accessor.udid,
                        accessor.context,
                        _credentialsubjectudid ,
                        _credentialsubjectclaims ,
                        _encryptedclaims 
                );
        }
        
        public unsafe static implicit operator BTTNFE_N4K_EnvelopeContent_Accessor(BTTNFE_N4K_EnvelopeContent field)
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

        if(field.credentialsubjectclaims.Value.timezoneid!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.timezoneid.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
targetPtr += 8;targetPtr += 8;targetPtr += 8;targetPtr += 8;targetPtr += 8;targetPtr += 8;            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 4;
            targetPtr += 1;
            targetPtr += 1;
            targetPtr += 1;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;

        if(field.credentialsubjectclaims.Value.d1approachpng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d1approachpng64.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims.Value.d2presspng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d2presspng64.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims.Value.d3sustainpng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d3sustainpng64.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims.Value.d4releasepng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d4releasepng64.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims.Value.d5recoverypng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d5recoverypng64.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
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

        if(field.credentialsubjectclaims.Value.timezoneid!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.timezoneid.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.credentialsubjectclaims.Value.timezoneid)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        {
            *(long*)targetPtr = field.credentialsubjectclaims.Value.tod0approach.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.credentialsubjectclaims.Value.tod1press.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.credentialsubjectclaims.Value.tod2sustain.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.credentialsubjectclaims.Value.tod3release.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.credentialsubjectclaims.Value.tod4recovery.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.credentialsubjectclaims.Value.tod5finish.ToBinary();
            targetPtr += 8;
        }
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t0ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t1ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t2ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t3ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t4ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t5ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d1ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d2ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d3ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d4ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d5ms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d1s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d2s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d3s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d4s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.d5s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t0s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t1s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t2s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t3s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t4s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.t5s;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.peak;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.medianms;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.medians;
            targetPtr += 4;
            *(int*)targetPtr = field.credentialsubjectclaims.Value.coverage;
            targetPtr += 4;
            *(bool*)targetPtr = field.credentialsubjectclaims.Value.tongue;
            targetPtr += 1;
            *(BTTNFEBodyPart*)targetPtr = field.credentialsubjectclaims.Value.targetbodypart;
            targetPtr += 1;
            *(BTTNFEBodyPart*)targetPtr = field.credentialsubjectclaims.Value.actualbodypart;
            targetPtr += 1;
            if(field.credentialsubjectclaims.Value.d1approachcurve!= null){
                if(field.credentialsubjectclaims.Value.d1approachcurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.credentialsubjectclaims.Value.d1approachcurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_3 = field.credentialsubjectclaims.Value.d1approachcurve)
                   Memory.memcpy(targetPtr, storedPtr_3, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.credentialsubjectclaims.Value.d2presscurve!= null){
                if(field.credentialsubjectclaims.Value.d2presscurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.credentialsubjectclaims.Value.d2presscurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_3 = field.credentialsubjectclaims.Value.d2presscurve)
                   Memory.memcpy(targetPtr, storedPtr_3, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.credentialsubjectclaims.Value.d3sustaincurve!= null){
                if(field.credentialsubjectclaims.Value.d3sustaincurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.credentialsubjectclaims.Value.d3sustaincurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_3 = field.credentialsubjectclaims.Value.d3sustaincurve)
                   Memory.memcpy(targetPtr, storedPtr_3, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.credentialsubjectclaims.Value.d4releasecurve!= null){
                if(field.credentialsubjectclaims.Value.d4releasecurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.credentialsubjectclaims.Value.d4releasecurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_3 = field.credentialsubjectclaims.Value.d4releasecurve)
                   Memory.memcpy(targetPtr, storedPtr_3, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.credentialsubjectclaims.Value.d5recoverycurve!= null){
                if(field.credentialsubjectclaims.Value.d5recoverycurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.credentialsubjectclaims.Value.d5recoverycurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_3 = field.credentialsubjectclaims.Value.d5recoverycurve)
                   Memory.memcpy(targetPtr, storedPtr_3, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;

        if(field.credentialsubjectclaims.Value.d1approachpng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d1approachpng64.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.credentialsubjectclaims.Value.d1approachpng64)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims.Value.d2presspng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d2presspng64.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.credentialsubjectclaims.Value.d2presspng64)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims.Value.d3sustainpng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d3sustainpng64.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.credentialsubjectclaims.Value.d3sustainpng64)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims.Value.d4releasepng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d4releasepng64.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.credentialsubjectclaims.Value.d4releasepng64)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.credentialsubjectclaims.Value.d5recoverypng64!= null)
        {
            int strlen_3 = field.credentialsubjectclaims.Value.d5recoverypng64.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.credentialsubjectclaims.Value.d5recoverypng64)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_1 + 0) |= 0x02;
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

            }BTTNFE_N4K_EnvelopeContent_Accessor ret;
            
            ret = new BTTNFE_N4K_EnvelopeContent_Accessor(tmpcellptr, null);
            
            return ret;
        }
        
        public static bool operator ==(BTTNFE_N4K_EnvelopeContent_Accessor a, BTTNFE_N4K_EnvelopeContent_Accessor b)
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
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
        public static bool operator != (BTTNFE_N4K_EnvelopeContent_Accessor a, BTTNFE_N4K_EnvelopeContent_Accessor b)
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
