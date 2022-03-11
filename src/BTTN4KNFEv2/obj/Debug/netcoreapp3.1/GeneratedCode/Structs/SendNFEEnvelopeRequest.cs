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
    /// A .NET runtime object representation of SendNFEEnvelopeRequest defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct SendNFEEnvelopeRequest
    {
        
        ///<summary>
        ///Initializes a new instance of SendNFEEnvelopeRequest with the specified parameters.
        ///</summary>
        public SendNFEEnvelopeRequest(BTTNFE_N4K_SealedEnvelope sealedEnvelope = default(BTTNFE_N4K_SealedEnvelope))
        {
            
            this.sealedEnvelope = sealedEnvelope;
            
        }
        
        public static bool operator ==(SendNFEEnvelopeRequest a, SendNFEEnvelopeRequest b)
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
                
                (a.sealedEnvelope == b.sealedEnvelope)
                
                ;
            
        }
        public static bool operator !=(SendNFEEnvelopeRequest a, SendNFEEnvelopeRequest b)
        {
            return !(a == b);
        }
        
        public BTTNFE_N4K_SealedEnvelope sealedEnvelope;
        
        /// <summary>
        /// Converts the string representation of a SendNFEEnvelopeRequest to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(SendNFEEnvelopeRequest) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out SendNFEEnvelopeRequest value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<SendNFEEnvelopeRequest>(input);
                return true;
            }
            catch { value = default(SendNFEEnvelopeRequest); return false; }
        }
        public static SendNFEEnvelopeRequest Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<SendNFEEnvelopeRequest>(input);
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
    /// Provides in-place operations of SendNFEEnvelopeRequest defined in TSL.
    /// </summary>
    public unsafe partial class SendNFEEnvelopeRequest_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe SendNFEEnvelopeRequest_Accessor(byte* _CellPtr
            
            , ResizeFunctionDelegate func
            )
        {
            m_ptr = _CellPtr;
            
            ResizeFunction = func;
                    sealedEnvelope_Accessor_Field = new BTTNFE_N4K_SealedEnvelope_Accessor(null,
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
{            targetPtr += 10;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 6152;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
        #region IAccessor
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
{            targetPtr += 10;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 6152;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
        BTTNFE_N4K_SealedEnvelope_Accessor sealedEnvelope_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field sealedEnvelope.
        ///</summary>
        public unsafe BTTNFE_N4K_SealedEnvelope_Accessor sealedEnvelope
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {}sealedEnvelope_Accessor_Field.m_ptr = targetPtr;
                sealedEnvelope_Accessor_Field.m_cellId = this.m_cellId;
                return sealedEnvelope_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                sealedEnvelope_Accessor_Field.m_cellId = this.m_cellId;
                
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
        
        public static unsafe implicit operator SendNFEEnvelopeRequest(SendNFEEnvelopeRequest_Accessor accessor)
        {
            
            return new SendNFEEnvelopeRequest(
                
                        accessor.sealedEnvelope
                );
        }
        
        public unsafe static implicit operator SendNFEEnvelopeRequest_Accessor(SendNFEEnvelopeRequest field)
        {
            byte* targetPtr = null;
            
            {

            {

            {

        if(field.sealedEnvelope.envelope.udid!= null)
        {
            int strlen_4 = field.sealedEnvelope.envelope.udid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(field.sealedEnvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.sealedEnvelope.envelope.label.types.Count;++iterator_5)
        {

        if(field.sealedEnvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.label.types[iterator_5].Length * 2;
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

        if(field.sealedEnvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = field.sealedEnvelope.envelope.label.notaryudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( field.sealedEnvelope.envelope.label.name!= null)
            {

        if(field.sealedEnvelope.envelope.label.name!= null)
        {
            int strlen_5 = field.sealedEnvelope.envelope.label.name.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.sealedEnvelope.envelope.label.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.sealedEnvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.sealedEnvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(field.sealedEnvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.label.comments[iterator_5].Length * 2;
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

        if(field.sealedEnvelope.envelope.content.udid!= null)
        {
            int strlen_5 = field.sealedEnvelope.envelope.content.udid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(field.sealedEnvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.sealedEnvelope.envelope.content.context.Count;++iterator_5)
        {

        if(field.sealedEnvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.context[iterator_5].Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( field.sealedEnvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(field.sealedEnvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = field.sealedEnvelope.envelope.content.credentialsubjectudid.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.sealedEnvelope.envelope.content.credentialsubjectclaims!= null)
            {

            {
            targetPtr += 4;
            targetPtr += 1;
            targetPtr += 1;
            targetPtr += 1;
            targetPtr += 1;
            targetPtr += 1;
            targetPtr += 1;

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.timezoneid!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.timezoneid.Length * 2;
            targetPtr += strlen_6+sizeof(int);
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
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;
targetPtr += 600;

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachpng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachpng64.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presspng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presspng64.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustainpng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustainpng64.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasepng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasepng64.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverypng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverypng64.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            }
            if( field.sealedEnvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(field.sealedEnvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
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
            if( field.sealedEnvelope.proof.hashedThumbprint64!= null)
            {

        if(field.sealedEnvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = field.sealedEnvelope.proof.hashedThumbprint64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.sealedEnvelope.proof.signedHashSignature64!= null)
            {

        if(field.sealedEnvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = field.sealedEnvelope.proof.signedHashSignature64.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.sealedEnvelope.proof.notaryStamp!= null)
            {

        if(field.sealedEnvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = field.sealedEnvelope.proof.notaryStamp.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.sealedEnvelope.proof.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.sealedEnvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.sealedEnvelope.proof.comments.Count;++iterator_4)
        {

        if(field.sealedEnvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = field.sealedEnvelope.proof.comments[iterator_4].Length * 2;
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

        if(field.sealedEnvelope.envelope.udid!= null)
        {
            int strlen_4 = field.sealedEnvelope.envelope.udid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.sealedEnvelope.envelope.udid)
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
    if(field.sealedEnvelope.envelope.label.types!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.sealedEnvelope.envelope.label.types.Count;++iterator_5)
        {

        if(field.sealedEnvelope.envelope.label.types[iterator_5]!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.label.types[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.label.types[iterator_5])
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
            *(BTTGenericCredentialType*)targetPtr = field.sealedEnvelope.envelope.label.credtype;
            targetPtr += 1;
            *(long*)targetPtr = field.sealedEnvelope.envelope.label.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = field.sealedEnvelope.envelope.label.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = field.sealedEnvelope.envelope.label.encryptionFlag;
            targetPtr += 1;

        if(field.sealedEnvelope.envelope.label.notaryudid!= null)
        {
            int strlen_5 = field.sealedEnvelope.envelope.label.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.sealedEnvelope.envelope.label.notaryudid)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( field.sealedEnvelope.envelope.label.name!= null)
            {

        if(field.sealedEnvelope.envelope.label.name!= null)
        {
            int strlen_5 = field.sealedEnvelope.envelope.label.name.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.sealedEnvelope.envelope.label.name)
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
            if( field.sealedEnvelope.envelope.label.comments!= null)
            {

{
byte *storedPtr_5 = targetPtr;

    targetPtr += sizeof(int);
    if(field.sealedEnvelope.envelope.label.comments!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.sealedEnvelope.envelope.label.comments.Count;++iterator_5)
        {

        if(field.sealedEnvelope.envelope.label.comments[iterator_5]!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.label.comments[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.label.comments[iterator_5])
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

        if(field.sealedEnvelope.envelope.content.udid!= null)
        {
            int strlen_5 = field.sealedEnvelope.envelope.content.udid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.sealedEnvelope.envelope.content.udid)
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
    if(field.sealedEnvelope.envelope.content.context!= null)
    {
        for(int iterator_5 = 0;iterator_5<field.sealedEnvelope.envelope.content.context.Count;++iterator_5)
        {

        if(field.sealedEnvelope.envelope.content.context[iterator_5]!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.context[iterator_5].Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.context[iterator_5])
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
            if( field.sealedEnvelope.envelope.content.credentialsubjectudid!= null)
            {

        if(field.sealedEnvelope.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_5 = field.sealedEnvelope.envelope.content.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.sealedEnvelope.envelope.content.credentialsubjectudid)
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
            if( field.sealedEnvelope.envelope.content.credentialsubjectclaims!= null)
            {

            {
            *(float*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.kissCompass;
            targetPtr += 4;
            *(BTTN4KPurpose*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.purpose;
            targetPtr += 1;
            *(BTTN4KType*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.kissType;
            targetPtr += 1;
            *(BTTN4KMood*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.mood;
            targetPtr += 1;
            *(bool*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.tongue;
            targetPtr += 1;
            *(BTTN4KBodyPart*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.targetbodypart;
            targetPtr += 1;
            *(BTTN4KBodyPart*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.actualbodypart;
            targetPtr += 1;

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.timezoneid!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.timezoneid.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.timezoneid)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        {
            *(long*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.tod0approach.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.tod1press.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.tod2sustain.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.tod3release.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.tod4recovery.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.tod5finish.ToBinary();
            targetPtr += 8;
        }
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t0ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t1ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t2ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t3ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t4ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t5ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5ms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t0s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t1s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t2s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t3s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t4s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.t5s;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.peak;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.medianms;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.medians;
            targetPtr += 4;
            *(int*)targetPtr = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.coverage;
            targetPtr += 4;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachtime!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachtime.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachtime.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachtime)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presstime!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presstime.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presstime.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presstime)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustaintime!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustaintime.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustaintime.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustaintime)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasetime!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasetime.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasetime.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasetime)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverytime!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverytime.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverytime.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverytime)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachcurve!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachcurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachcurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachcurve)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presscurve!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presscurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presscurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presscurve)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustaincurve!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustaincurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustaincurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustaincurve)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasecurve!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasecurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasecurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasecurve)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverycurve!= null){
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverycurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverycurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(float* storedPtr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverycurve)
                   Memory.memcpy(targetPtr, storedPtr_6, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachpng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachpng64.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d1approachpng64)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presspng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presspng64.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d2presspng64)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustainpng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustainpng64.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d3sustainpng64)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasepng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasepng64.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d4releasepng64)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverypng64!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverypng64.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.credentialsubjectclaims.Value.d5recoverypng64)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_4 + 0) |= 0x02;
            }
            if( field.sealedEnvelope.envelope.content.encryptedclaims!= null)
            {

            {

        if(field.sealedEnvelope.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.sealedEnvelope.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.sealedEnvelope.envelope.content.encryptedclaims.Value.key)
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
            if( field.sealedEnvelope.proof.hashedThumbprint64!= null)
            {

        if(field.sealedEnvelope.proof.hashedThumbprint64!= null)
        {
            int strlen_4 = field.sealedEnvelope.proof.hashedThumbprint64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.sealedEnvelope.proof.hashedThumbprint64)
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
            if( field.sealedEnvelope.proof.signedHashSignature64!= null)
            {

        if(field.sealedEnvelope.proof.signedHashSignature64!= null)
        {
            int strlen_4 = field.sealedEnvelope.proof.signedHashSignature64.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.sealedEnvelope.proof.signedHashSignature64)
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
            if( field.sealedEnvelope.proof.notaryStamp!= null)
            {

        if(field.sealedEnvelope.proof.notaryStamp!= null)
        {
            int strlen_4 = field.sealedEnvelope.proof.notaryStamp.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.sealedEnvelope.proof.notaryStamp)
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
            if( field.sealedEnvelope.proof.comments!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(field.sealedEnvelope.proof.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.sealedEnvelope.proof.comments.Count;++iterator_4)
        {

        if(field.sealedEnvelope.proof.comments[iterator_4]!= null)
        {
            int strlen_5 = field.sealedEnvelope.proof.comments[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.sealedEnvelope.proof.comments[iterator_4])
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
            }SendNFEEnvelopeRequest_Accessor ret;
            
            ret = new SendNFEEnvelopeRequest_Accessor(tmpcellptr, null);
            
            return ret;
        }
        
        public static bool operator ==(SendNFEEnvelopeRequest_Accessor a, SendNFEEnvelopeRequest_Accessor b)
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
{            targetPtr += 10;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 6152;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
{            targetPtr += 10;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 6152;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
        public static bool operator != (SendNFEEnvelopeRequest_Accessor a, SendNFEEnvelopeRequest_Accessor b)
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
