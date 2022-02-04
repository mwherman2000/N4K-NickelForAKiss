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
    /// A .NET runtime object representation of BTTNFE_N4K_Envelope defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct BTTNFE_N4K_Envelope
    {
        
        ///<summary>
        ///Initializes a new instance of BTTNFE_N4K_Envelope with the specified parameters.
        ///</summary>
        public BTTNFE_N4K_Envelope(string udid = default(string),BTTGenericCredential_PackingLabel label = default(BTTGenericCredential_PackingLabel),BTTNFE_N4K_EnvelopeContent content = default(BTTNFE_N4K_EnvelopeContent))
        {
            
            this.udid = udid;
            
            this.label = label;
            
            this.content = content;
            
        }
        
        public static bool operator ==(BTTNFE_N4K_Envelope a, BTTNFE_N4K_Envelope b)
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
                (a.label == b.label)
                &&
                (a.content == b.content)
                
                ;
            
        }
        public static bool operator !=(BTTNFE_N4K_Envelope a, BTTNFE_N4K_Envelope b)
        {
            return !(a == b);
        }
        
        public string udid;
        
        public BTTGenericCredential_PackingLabel label;
        
        public BTTNFE_N4K_EnvelopeContent content;
        
        /// <summary>
        /// Converts the string representation of a BTTNFE_N4K_Envelope to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(BTTNFE_N4K_Envelope) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out BTTNFE_N4K_Envelope value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<BTTNFE_N4K_Envelope>(input);
                return true;
            }
            catch { value = default(BTTNFE_N4K_Envelope); return false; }
        }
        public static BTTNFE_N4K_Envelope Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BTTNFE_N4K_Envelope>(input);
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
    /// Provides in-place operations of BTTNFE_N4K_Envelope defined in TSL.
    /// </summary>
    public unsafe partial class BTTNFE_N4K_Envelope_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe BTTNFE_N4K_Envelope_Accessor(byte* _CellPtr
            
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
                });        label_Accessor_Field = new BTTGenericCredential_PackingLabel_Accessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        content_Accessor_Field = new BTTNFE_N4K_EnvelopeContent_Accessor(null,
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
            {targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_2 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_2 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_2 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_2 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x02)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }

                if ((0 != (*(optheader_2 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}
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
            {targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_2 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_2 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_2 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_2 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x02)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }

                if ((0 != (*(optheader_2 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}
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
                {}udid_Accessor_Field.m_ptr = targetPtr + 4;
                udid_Accessor_Field.m_cellId = this.m_cellId;
                return udid_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                udid_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {}
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
        BTTGenericCredential_PackingLabel_Accessor label_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field label.
        ///</summary>
        public unsafe BTTGenericCredential_PackingLabel_Accessor label
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);}label_Accessor_Field.m_ptr = targetPtr;
                label_Accessor_Field.m_cellId = this.m_cellId;
                return label_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                label_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);}
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
        BTTNFE_N4K_EnvelopeContent_Accessor content_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field content.
        ///</summary>
        public unsafe BTTNFE_N4K_EnvelopeContent_Accessor content
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_3 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_3 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}content_Accessor_Field.m_ptr = targetPtr;
                content_Accessor_Field.m_cellId = this.m_cellId;
                return content_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                content_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_3 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_3 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}
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
        
        public static unsafe implicit operator BTTNFE_N4K_Envelope(BTTNFE_N4K_Envelope_Accessor accessor)
        {
            
            return new BTTNFE_N4K_Envelope(
                
                        accessor.udid,
                        accessor.label,
                        accessor.content
                );
        }
        
        public unsafe static implicit operator BTTNFE_N4K_Envelope_Accessor(BTTNFE_N4K_Envelope field)
        {
            byte* targetPtr = null;
            
            {

        if(field.udid!= null)
        {
            int strlen_2 = field.udid.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(field.label.types!= null)
    {
        for(int iterator_3 = 0;iterator_3<field.label.types.Count;++iterator_3)
        {

        if(field.label.types[iterator_3]!= null)
        {
            int strlen_4 = field.label.types[iterator_3].Length * 2;
            targetPtr += strlen_4+sizeof(int);
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

        if(field.label.notaryudid!= null)
        {
            int strlen_3 = field.label.notaryudid.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( field.label.name!= null)
            {

        if(field.label.name!= null)
        {
            int strlen_3 = field.label.name.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.label.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.label.comments!= null)
    {
        for(int iterator_3 = 0;iterator_3<field.label.comments.Count;++iterator_3)
        {

        if(field.label.comments[iterator_3]!= null)
        {
            int strlen_4 = field.label.comments[iterator_3].Length * 2;
            targetPtr += strlen_4+sizeof(int);
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

        if(field.content.udid!= null)
        {
            int strlen_3 = field.content.udid.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(field.content.context!= null)
    {
        for(int iterator_3 = 0;iterator_3<field.content.context.Count;++iterator_3)
        {

        if(field.content.context[iterator_3]!= null)
        {
            int strlen_4 = field.content.context[iterator_3].Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( field.content.credentialsubjectudid!= null)
            {

        if(field.content.credentialsubjectudid!= null)
        {
            int strlen_3 = field.content.credentialsubjectudid.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.content.credentialsubjectclaims!= null)
            {

            {

        if(field.content.credentialsubjectclaims.Value.timezoneid!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.timezoneid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
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

        if(field.content.credentialsubjectclaims.Value.d1approachpng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d1approachpng64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.content.credentialsubjectclaims.Value.d2presspng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d2presspng64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.content.credentialsubjectclaims.Value.d3sustainpng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d3sustainpng64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.content.credentialsubjectclaims.Value.d4releasepng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d4releasepng64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.content.credentialsubjectclaims.Value.d5recoverypng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d5recoverypng64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            }
            if( field.content.encryptedclaims!= null)
            {

            {

        if(field.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_4 = field.content.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_4 = field.content.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.content.encryptedclaims.Value.key!= null)
        {
            int strlen_4 = field.content.encryptedclaims.Value.key.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            }

            }
            }
            byte* tmpcellptr = BufferAllocator.AllocBuffer((int)targetPtr);
            Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
            targetPtr = tmpcellptr;
            
            {

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
            byte* optheader_2 = targetPtr;
            *(optheader_2 + 0) = 0x00;            targetPtr += 1;

{
byte *storedPtr_3 = targetPtr;

    targetPtr += sizeof(int);
    if(field.label.types!= null)
    {
        for(int iterator_3 = 0;iterator_3<field.label.types.Count;++iterator_3)
        {

        if(field.label.types[iterator_3]!= null)
        {
            int strlen_4 = field.label.types[iterator_3].Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.label.types[iterator_3])
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_3 = (int)(targetPtr - storedPtr_3 - 4);

}
            *(BTTGenericCredentialType*)targetPtr = field.label.credtype;
            targetPtr += 1;
            *(long*)targetPtr = field.label.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = field.label.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = field.label.encryptionFlag;
            targetPtr += 1;

        if(field.label.notaryudid!= null)
        {
            int strlen_3 = field.label.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.label.notaryudid)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( field.label.name!= null)
            {

        if(field.label.name!= null)
        {
            int strlen_3 = field.label.name.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.label.name)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_2 + 0) |= 0x01;
            }
            if( field.label.comments!= null)
            {

{
byte *storedPtr_3 = targetPtr;

    targetPtr += sizeof(int);
    if(field.label.comments!= null)
    {
        for(int iterator_3 = 0;iterator_3<field.label.comments.Count;++iterator_3)
        {

        if(field.label.comments[iterator_3]!= null)
        {
            int strlen_4 = field.label.comments[iterator_3].Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.label.comments[iterator_3])
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_3 = (int)(targetPtr - storedPtr_3 - 4);

}
*(optheader_2 + 0) |= 0x02;
            }

            }
            {
            byte* optheader_2 = targetPtr;
            *(optheader_2 + 0) = 0x00;            targetPtr += 1;

        if(field.content.udid!= null)
        {
            int strlen_3 = field.content.udid.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.content.udid)
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
byte *storedPtr_3 = targetPtr;

    targetPtr += sizeof(int);
    if(field.content.context!= null)
    {
        for(int iterator_3 = 0;iterator_3<field.content.context.Count;++iterator_3)
        {

        if(field.content.context[iterator_3]!= null)
        {
            int strlen_4 = field.content.context[iterator_3].Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.context[iterator_3])
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        }
    }
*(int*)storedPtr_3 = (int)(targetPtr - storedPtr_3 - 4);

}
            if( field.content.credentialsubjectudid!= null)
            {

        if(field.content.credentialsubjectudid!= null)
        {
            int strlen_3 = field.content.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.content.credentialsubjectudid)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_2 + 0) |= 0x01;
            }
            if( field.content.credentialsubjectclaims!= null)
            {

            {

        if(field.content.credentialsubjectclaims.Value.timezoneid!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.timezoneid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.credentialsubjectclaims.Value.timezoneid)
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
            *(long*)targetPtr = field.content.credentialsubjectclaims.Value.tod0approach.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.content.credentialsubjectclaims.Value.tod1press.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.content.credentialsubjectclaims.Value.tod2sustain.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.content.credentialsubjectclaims.Value.tod3release.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.content.credentialsubjectclaims.Value.tod4recovery.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.content.credentialsubjectclaims.Value.tod5finish.ToBinary();
            targetPtr += 8;
        }
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t0ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t1ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t2ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t3ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t4ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t5ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d1ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d2ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d3ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d4ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d5ms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d1s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d2s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d3s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d4s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.d5s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t0s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t1s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t2s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t3s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t4s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.t5s;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.peak;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.medianms;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.medians;
            targetPtr += 4;
            *(int*)targetPtr = field.content.credentialsubjectclaims.Value.coverage;
            targetPtr += 4;
            *(bool*)targetPtr = field.content.credentialsubjectclaims.Value.tongue;
            targetPtr += 1;
            *(BTTNFEBodyPart*)targetPtr = field.content.credentialsubjectclaims.Value.targetbodypart;
            targetPtr += 1;
            *(BTTNFEBodyPart*)targetPtr = field.content.credentialsubjectclaims.Value.actualbodypart;
            targetPtr += 1;
            if(field.content.credentialsubjectclaims.Value.d1approachcurve!= null){
                if(field.content.credentialsubjectclaims.Value.d1approachcurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.content.credentialsubjectclaims.Value.d1approachcurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_4 = field.content.credentialsubjectclaims.Value.d1approachcurve)
                   Memory.memcpy(targetPtr, storedPtr_4, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.content.credentialsubjectclaims.Value.d2presscurve!= null){
                if(field.content.credentialsubjectclaims.Value.d2presscurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.content.credentialsubjectclaims.Value.d2presscurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_4 = field.content.credentialsubjectclaims.Value.d2presscurve)
                   Memory.memcpy(targetPtr, storedPtr_4, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.content.credentialsubjectclaims.Value.d3sustaincurve!= null){
                if(field.content.credentialsubjectclaims.Value.d3sustaincurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.content.credentialsubjectclaims.Value.d3sustaincurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_4 = field.content.credentialsubjectclaims.Value.d3sustaincurve)
                   Memory.memcpy(targetPtr, storedPtr_4, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.content.credentialsubjectclaims.Value.d4releasecurve!= null){
                if(field.content.credentialsubjectclaims.Value.d4releasecurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.content.credentialsubjectclaims.Value.d4releasecurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_4 = field.content.credentialsubjectclaims.Value.d4releasecurve)
                   Memory.memcpy(targetPtr, storedPtr_4, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.content.credentialsubjectclaims.Value.d5recoverycurve!= null){
                if(field.content.credentialsubjectclaims.Value.d5recoverycurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.content.credentialsubjectclaims.Value.d5recoverycurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_4 = field.content.credentialsubjectclaims.Value.d5recoverycurve)
                   Memory.memcpy(targetPtr, storedPtr_4, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;

        if(field.content.credentialsubjectclaims.Value.d1approachpng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d1approachpng64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.credentialsubjectclaims.Value.d1approachpng64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.content.credentialsubjectclaims.Value.d2presspng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d2presspng64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.credentialsubjectclaims.Value.d2presspng64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.content.credentialsubjectclaims.Value.d3sustainpng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d3sustainpng64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.credentialsubjectclaims.Value.d3sustainpng64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.content.credentialsubjectclaims.Value.d4releasepng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d4releasepng64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.credentialsubjectclaims.Value.d4releasepng64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.content.credentialsubjectclaims.Value.d5recoverypng64!= null)
        {
            int strlen_4 = field.content.credentialsubjectclaims.Value.d5recoverypng64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.credentialsubjectclaims.Value.d5recoverypng64)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_2 + 0) |= 0x02;
            }
            if( field.content.encryptedclaims!= null)
            {

            {

        if(field.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_4 = field.content.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_4 = field.content.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.content.encryptedclaims.Value.key!= null)
        {
            int strlen_4 = field.content.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.content.encryptedclaims.Value.key)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_2 + 0) |= 0x04;
            }

            }
            }BTTNFE_N4K_Envelope_Accessor ret;
            
            ret = new BTTNFE_N4K_Envelope_Accessor(tmpcellptr, null);
            
            return ret;
        }
        
        public static bool operator ==(BTTNFE_N4K_Envelope_Accessor a, BTTNFE_N4K_Envelope_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_3 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_3 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_3 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_3 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x02)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }

                if ((0 != (*(optheader_3 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_3 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_3 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_3 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_3 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x02)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }

                if ((0 != (*(optheader_3 + 0) & 0x04)))
                {
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (BTTNFE_N4K_Envelope_Accessor a, BTTNFE_N4K_Envelope_Accessor b)
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
