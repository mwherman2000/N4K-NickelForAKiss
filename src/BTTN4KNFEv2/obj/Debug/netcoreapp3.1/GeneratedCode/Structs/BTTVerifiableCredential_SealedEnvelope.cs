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
    /// A .NET runtime object representation of BTTVerifiableCredential_SealedEnvelope defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct BTTVerifiableCredential_SealedEnvelope
    {
        
        ///<summary>
        ///Initializes a new instance of BTTVerifiableCredential_SealedEnvelope with the specified parameters.
        ///</summary>
        public BTTVerifiableCredential_SealedEnvelope(BTTGenericCredential_Envelope envelope = default(BTTGenericCredential_Envelope),BTTGenericCredential_EnvelopeSeal proof = default(BTTGenericCredential_EnvelopeSeal))
        {
            
            this.envelope = envelope;
            
            this.proof = proof;
            
        }
        
        public static bool operator ==(BTTVerifiableCredential_SealedEnvelope a, BTTVerifiableCredential_SealedEnvelope b)
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
                
                (a.envelope == b.envelope)
                &&
                (a.proof == b.proof)
                
                ;
            
        }
        public static bool operator !=(BTTVerifiableCredential_SealedEnvelope a, BTTVerifiableCredential_SealedEnvelope b)
        {
            return !(a == b);
        }
        
        public BTTGenericCredential_Envelope envelope;
        
        public BTTGenericCredential_EnvelopeSeal proof;
        
        /// <summary>
        /// Converts the string representation of a BTTVerifiableCredential_SealedEnvelope to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(BTTVerifiableCredential_SealedEnvelope) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out BTTVerifiableCredential_SealedEnvelope value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<BTTVerifiableCredential_SealedEnvelope>(input);
                return true;
            }
            catch { value = default(BTTVerifiableCredential_SealedEnvelope); return false; }
        }
        public static BTTVerifiableCredential_SealedEnvelope Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BTTVerifiableCredential_SealedEnvelope>(input);
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
    /// Provides in-place operations of BTTVerifiableCredential_SealedEnvelope defined in TSL.
    /// </summary>
    public unsafe partial class BTTVerifiableCredential_SealedEnvelope_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe BTTVerifiableCredential_SealedEnvelope_Accessor(byte* _CellPtr
            
            , ResizeFunctionDelegate func
            )
        {
            m_ptr = _CellPtr;
            
            ResizeFunction = func;
                    envelope_Accessor_Field = new BTTGenericCredential_Envelope_Accessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        proof_Accessor_Field = new BTTGenericCredential_EnvelopeSeal_Accessor(null,
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
            {{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_4 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_4 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_4 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_4 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
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
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}{            byte* optheader_2 = targetPtr;
            targetPtr += 1;

                if ((0 != (*(optheader_2 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x04)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x08)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
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
            {{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_4 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_4 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_4 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_4 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
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
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}{            byte* optheader_2 = targetPtr;
            targetPtr += 1;

                if ((0 != (*(optheader_2 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x04)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_2 + 0) & 0x08)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}
            int size = (int)(targetPtr - m_ptr);
            return size;
        }
        public ResizeFunctionDelegate ResizeFunction { get; set; }
        #endregion
        BTTGenericCredential_Envelope_Accessor envelope_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field envelope.
        ///</summary>
        public unsafe BTTGenericCredential_Envelope_Accessor envelope
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {}envelope_Accessor_Field.m_ptr = targetPtr;
                envelope_Accessor_Field.m_cellId = this.m_cellId;
                return envelope_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                envelope_Accessor_Field.m_cellId = this.m_cellId;
                
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
        BTTGenericCredential_EnvelopeSeal_Accessor proof_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field proof.
        ///</summary>
        public unsafe BTTGenericCredential_EnvelopeSeal_Accessor proof
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_5 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_5 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_5 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
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
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}}proof_Accessor_Field.m_ptr = targetPtr;
                proof_Accessor_Field.m_cellId = this.m_cellId;
                return proof_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                proof_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_5 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_5 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_5 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
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
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}}
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
        
        public static unsafe implicit operator BTTVerifiableCredential_SealedEnvelope(BTTVerifiableCredential_SealedEnvelope_Accessor accessor)
        {
            
            return new BTTVerifiableCredential_SealedEnvelope(
                
                        accessor.envelope,
                        accessor.proof
                );
        }
        
        public unsafe static implicit operator BTTVerifiableCredential_SealedEnvelope_Accessor(BTTVerifiableCredential_SealedEnvelope field)
        {
            byte* targetPtr = null;
            
            {

            {

        if(field.envelope.udid!= null)
        {
            int strlen_3 = field.envelope.udid.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            {
            targetPtr += 1;

{

    targetPtr += sizeof(int);
    if(field.envelope.label.types!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.envelope.label.types.Count;++iterator_4)
        {

        if(field.envelope.label.types[iterator_4]!= null)
        {
            int strlen_5 = field.envelope.label.types[iterator_4].Length * 2;
            targetPtr += strlen_5+sizeof(int);
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

        if(field.envelope.label.notaryudid!= null)
        {
            int strlen_4 = field.envelope.label.notaryudid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( field.envelope.label.name!= null)
            {

        if(field.envelope.label.name!= null)
        {
            int strlen_4 = field.envelope.label.name.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.envelope.label.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.envelope.label.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.envelope.label.comments.Count;++iterator_4)
        {

        if(field.envelope.label.comments[iterator_4]!= null)
        {
            int strlen_5 = field.envelope.label.comments[iterator_4].Length * 2;
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
            {
            targetPtr += 1;

        if(field.envelope.content.udid!= null)
        {
            int strlen_4 = field.envelope.content.udid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

{

    targetPtr += sizeof(int);
    if(field.envelope.content.context!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.envelope.content.context.Count;++iterator_4)
        {

        if(field.envelope.content.context[iterator_4]!= null)
        {
            int strlen_5 = field.envelope.content.context[iterator_4].Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        }
    }

}
            if( field.envelope.content.credentialsubjectudid!= null)
            {

        if(field.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_4 = field.envelope.content.credentialsubjectudid.Length * 2;
            targetPtr += strlen_4+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.envelope.content.credentialsubjectclaims!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.envelope.content.credentialsubjectclaims.Count;++iterator_4)
        {

            {
            targetPtr += 1;

        if(field.envelope.content.credentialsubjectclaims[iterator_4].key!= null)
        {
            int strlen_6 = field.envelope.content.credentialsubjectclaims[iterator_4].key.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }
            if( field.envelope.content.credentialsubjectclaims[iterator_4].value!= null)
            {

        if(field.envelope.content.credentialsubjectclaims[iterator_4].value!= null)
        {
            int strlen_6 = field.envelope.content.credentialsubjectclaims[iterator_4].value.Length * 2;
            targetPtr += strlen_6+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.envelope.content.credentialsubjectclaims[iterator_4].attribute!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.envelope.content.credentialsubjectclaims[iterator_4].attribute!= null)
    {
        for(int iterator_6 = 0;iterator_6<field.envelope.content.credentialsubjectclaims[iterator_4].attribute.Count;++iterator_6)
        {

            {

        if(field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].key!= null)
        {
            int strlen_8 = field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].key.Length * 2;
            targetPtr += strlen_8+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].value!= null)
        {
            int strlen_8 = field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].value.Length * 2;
            targetPtr += strlen_8+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
        }
    }

}

            }
            if( field.envelope.content.credentialsubjectclaims[iterator_4].attributes!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.envelope.content.credentialsubjectclaims[iterator_4].attributes!= null)
    {
        for(int iterator_6 = 0;iterator_6<field.envelope.content.credentialsubjectclaims[iterator_4].attributes.Count;++iterator_6)
        {

{

    targetPtr += sizeof(int);
    if(field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6]!= null)
    {
        for(int iterator_7 = 0;iterator_7<field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6].Count;++iterator_7)
        {

            {

        if(field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].key!= null)
        {
            int strlen_9 = field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].key.Length * 2;
            targetPtr += strlen_9+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].value!= null)
        {
            int strlen_9 = field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].value.Length * 2;
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
    }

}

            }

            }
        }
    }

}

            }
            if( field.envelope.content.encryptedclaims!= null)
            {

            {

        if(field.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_5 = field.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_5 = field.envelope.content.encryptedclaims.Value.alg.Length * 2;
            targetPtr += strlen_5+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_5 = field.envelope.content.encryptedclaims.Value.key.Length * 2;
            targetPtr += strlen_5+sizeof(int);
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
            if( field.proof.hashedThumbprint64!= null)
            {

        if(field.proof.hashedThumbprint64!= null)
        {
            int strlen_3 = field.proof.hashedThumbprint64.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.proof.signedHashSignature64!= null)
            {

        if(field.proof.signedHashSignature64!= null)
        {
            int strlen_3 = field.proof.signedHashSignature64.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.proof.notaryStamp!= null)
            {

        if(field.proof.notaryStamp!= null)
        {
            int strlen_3 = field.proof.notaryStamp.Length * 2;
            targetPtr += strlen_3+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            if( field.proof.comments!= null)
            {

{

    targetPtr += sizeof(int);
    if(field.proof.comments!= null)
    {
        for(int iterator_3 = 0;iterator_3<field.proof.comments.Count;++iterator_3)
        {

        if(field.proof.comments[iterator_3]!= null)
        {
            int strlen_4 = field.proof.comments[iterator_3].Length * 2;
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
            }
            byte* tmpcellptr = BufferAllocator.AllocBuffer((int)targetPtr);
            Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
            targetPtr = tmpcellptr;
            
            {

            {

        if(field.envelope.udid!= null)
        {
            int strlen_3 = field.envelope.udid.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.envelope.udid)
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
            byte* optheader_3 = targetPtr;
            *(optheader_3 + 0) = 0x00;            targetPtr += 1;

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(field.envelope.label.types!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.envelope.label.types.Count;++iterator_4)
        {

        if(field.envelope.label.types[iterator_4]!= null)
        {
            int strlen_5 = field.envelope.label.types[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.envelope.label.types[iterator_4])
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
            *(BTTGenericCredentialType*)targetPtr = field.envelope.label.credtype;
            targetPtr += 1;
            *(long*)targetPtr = field.envelope.label.version;
            targetPtr += 8;
            *(BTTTrustLevel*)targetPtr = field.envelope.label.trustLevel;
            targetPtr += 1;
            *(BTTEncryptionFlag*)targetPtr = field.envelope.label.encryptionFlag;
            targetPtr += 1;

        if(field.envelope.label.notaryudid!= null)
        {
            int strlen_4 = field.envelope.label.notaryudid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.envelope.label.notaryudid)
            {
                Memory.Copy(pstr_4, targetPtr, strlen_4);
                targetPtr += strlen_4;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( field.envelope.label.name!= null)
            {

        if(field.envelope.label.name!= null)
        {
            int strlen_4 = field.envelope.label.name.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.envelope.label.name)
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
            if( field.envelope.label.comments!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(field.envelope.label.comments!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.envelope.label.comments.Count;++iterator_4)
        {

        if(field.envelope.label.comments[iterator_4]!= null)
        {
            int strlen_5 = field.envelope.label.comments[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.envelope.label.comments[iterator_4])
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
*(optheader_3 + 0) |= 0x02;
            }

            }
            {
            byte* optheader_3 = targetPtr;
            *(optheader_3 + 0) = 0x00;            targetPtr += 1;

        if(field.envelope.content.udid!= null)
        {
            int strlen_4 = field.envelope.content.udid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.envelope.content.udid)
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
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(field.envelope.content.context!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.envelope.content.context.Count;++iterator_4)
        {

        if(field.envelope.content.context[iterator_4]!= null)
        {
            int strlen_5 = field.envelope.content.context[iterator_4].Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.envelope.content.context[iterator_4])
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
            if( field.envelope.content.credentialsubjectudid!= null)
            {

        if(field.envelope.content.credentialsubjectudid!= null)
        {
            int strlen_4 = field.envelope.content.credentialsubjectudid.Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.envelope.content.credentialsubjectudid)
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
            if( field.envelope.content.credentialsubjectclaims!= null)
            {

{
byte *storedPtr_4 = targetPtr;

    targetPtr += sizeof(int);
    if(field.envelope.content.credentialsubjectclaims!= null)
    {
        for(int iterator_4 = 0;iterator_4<field.envelope.content.credentialsubjectclaims.Count;++iterator_4)
        {

            {
            byte* optheader_5 = targetPtr;
            *(optheader_5 + 0) = 0x00;            targetPtr += 1;

        if(field.envelope.content.credentialsubjectclaims[iterator_4].key!= null)
        {
            int strlen_6 = field.envelope.content.credentialsubjectclaims[iterator_4].key.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.envelope.content.credentialsubjectclaims[iterator_4].key)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
            if( field.envelope.content.credentialsubjectclaims[iterator_4].value!= null)
            {

        if(field.envelope.content.credentialsubjectclaims[iterator_4].value!= null)
        {
            int strlen_6 = field.envelope.content.credentialsubjectclaims[iterator_4].value.Length * 2;
            *(int*)targetPtr = strlen_6;
            targetPtr += sizeof(int);
            fixed(char* pstr_6 = field.envelope.content.credentialsubjectclaims[iterator_4].value)
            {
                Memory.Copy(pstr_6, targetPtr, strlen_6);
                targetPtr += strlen_6;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_5 + 0) |= 0x01;
            }
            if( field.envelope.content.credentialsubjectclaims[iterator_4].attribute!= null)
            {

{
byte *storedPtr_6 = targetPtr;

    targetPtr += sizeof(int);
    if(field.envelope.content.credentialsubjectclaims[iterator_4].attribute!= null)
    {
        for(int iterator_6 = 0;iterator_6<field.envelope.content.credentialsubjectclaims[iterator_4].attribute.Count;++iterator_6)
        {

            {

        if(field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].key!= null)
        {
            int strlen_8 = field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].key.Length * 2;
            *(int*)targetPtr = strlen_8;
            targetPtr += sizeof(int);
            fixed(char* pstr_8 = field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].key)
            {
                Memory.Copy(pstr_8, targetPtr, strlen_8);
                targetPtr += strlen_8;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].value!= null)
        {
            int strlen_8 = field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].value.Length * 2;
            *(int*)targetPtr = strlen_8;
            targetPtr += sizeof(int);
            fixed(char* pstr_8 = field.envelope.content.credentialsubjectclaims[iterator_4].attribute[iterator_6].value)
            {
                Memory.Copy(pstr_8, targetPtr, strlen_8);
                targetPtr += strlen_8;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }
        }
    }
*(int*)storedPtr_6 = (int)(targetPtr - storedPtr_6 - 4);

}
*(optheader_5 + 0) |= 0x02;
            }
            if( field.envelope.content.credentialsubjectclaims[iterator_4].attributes!= null)
            {

{
byte *storedPtr_6 = targetPtr;

    targetPtr += sizeof(int);
    if(field.envelope.content.credentialsubjectclaims[iterator_4].attributes!= null)
    {
        for(int iterator_6 = 0;iterator_6<field.envelope.content.credentialsubjectclaims[iterator_4].attributes.Count;++iterator_6)
        {

{
byte *storedPtr_7 = targetPtr;

    targetPtr += sizeof(int);
    if(field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6]!= null)
    {
        for(int iterator_7 = 0;iterator_7<field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6].Count;++iterator_7)
        {

            {

        if(field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].key!= null)
        {
            int strlen_9 = field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].key.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].key)
            {
                Memory.Copy(pstr_9, targetPtr, strlen_9);
                targetPtr += strlen_9;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].value!= null)
        {
            int strlen_9 = field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].value.Length * 2;
            *(int*)targetPtr = strlen_9;
            targetPtr += sizeof(int);
            fixed(char* pstr_9 = field.envelope.content.credentialsubjectclaims[iterator_4].attributes[iterator_6][iterator_7].value)
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

        }
    }
*(int*)storedPtr_6 = (int)(targetPtr - storedPtr_6 - 4);

}
*(optheader_5 + 0) |= 0x04;
            }

            }
        }
    }
*(int*)storedPtr_4 = (int)(targetPtr - storedPtr_4 - 4);

}
*(optheader_3 + 0) |= 0x02;
            }
            if( field.envelope.content.encryptedclaims!= null)
            {

            {

        if(field.envelope.content.encryptedclaims.Value.ciphertext16!= null)
        {
            int strlen_5 = field.envelope.content.encryptedclaims.Value.ciphertext16.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.envelope.content.encryptedclaims.Value.ciphertext16)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.envelope.content.encryptedclaims.Value.alg!= null)
        {
            int strlen_5 = field.envelope.content.encryptedclaims.Value.alg.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.envelope.content.encryptedclaims.Value.alg)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.envelope.content.encryptedclaims.Value.key!= null)
        {
            int strlen_5 = field.envelope.content.encryptedclaims.Value.key.Length * 2;
            *(int*)targetPtr = strlen_5;
            targetPtr += sizeof(int);
            fixed(char* pstr_5 = field.envelope.content.encryptedclaims.Value.key)
            {
                Memory.Copy(pstr_5, targetPtr, strlen_5);
                targetPtr += strlen_5;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }*(optheader_3 + 0) |= 0x04;
            }

            }
            }
            {
            byte* optheader_2 = targetPtr;
            *(optheader_2 + 0) = 0x00;            targetPtr += 1;
            if( field.proof.hashedThumbprint64!= null)
            {

        if(field.proof.hashedThumbprint64!= null)
        {
            int strlen_3 = field.proof.hashedThumbprint64.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.proof.hashedThumbprint64)
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
            if( field.proof.signedHashSignature64!= null)
            {

        if(field.proof.signedHashSignature64!= null)
        {
            int strlen_3 = field.proof.signedHashSignature64.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.proof.signedHashSignature64)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_2 + 0) |= 0x02;
            }
            if( field.proof.notaryStamp!= null)
            {

        if(field.proof.notaryStamp!= null)
        {
            int strlen_3 = field.proof.notaryStamp.Length * 2;
            *(int*)targetPtr = strlen_3;
            targetPtr += sizeof(int);
            fixed(char* pstr_3 = field.proof.notaryStamp)
            {
                Memory.Copy(pstr_3, targetPtr, strlen_3);
                targetPtr += strlen_3;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }
*(optheader_2 + 0) |= 0x04;
            }
            if( field.proof.comments!= null)
            {

{
byte *storedPtr_3 = targetPtr;

    targetPtr += sizeof(int);
    if(field.proof.comments!= null)
    {
        for(int iterator_3 = 0;iterator_3<field.proof.comments.Count;++iterator_3)
        {

        if(field.proof.comments[iterator_3]!= null)
        {
            int strlen_4 = field.proof.comments[iterator_3].Length * 2;
            *(int*)targetPtr = strlen_4;
            targetPtr += sizeof(int);
            fixed(char* pstr_4 = field.proof.comments[iterator_3])
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
*(optheader_2 + 0) |= 0x08;
            }

            }
            }BTTVerifiableCredential_SealedEnvelope_Accessor ret;
            
            ret = new BTTVerifiableCredential_SealedEnvelope_Accessor(tmpcellptr, null);
            
            return ret;
        }
        
        public static bool operator ==(BTTVerifiableCredential_SealedEnvelope_Accessor a, BTTVerifiableCredential_SealedEnvelope_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_5 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_5 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_5 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
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
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}{            byte* optheader_3 = targetPtr;
            targetPtr += 1;

                if ((0 != (*(optheader_3 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x04)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x08)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {{targetPtr += *(int*)targetPtr + sizeof(int);{            byte* optheader_5 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 11;
targetPtr += *(int*)targetPtr + sizeof(int);
                if ((0 != (*(optheader_5 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_5 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}{            byte* optheader_5 = targetPtr;
            targetPtr += 1;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);
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
{targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                }
}}{            byte* optheader_3 = targetPtr;
            targetPtr += 1;

                if ((0 != (*(optheader_3 + 0) & 0x01)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x02)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x04)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }

                if ((0 != (*(optheader_3 + 0) & 0x08)))
                {
targetPtr += *(int*)targetPtr + sizeof(int);
                }
}}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (BTTVerifiableCredential_SealedEnvelope_Accessor a, BTTVerifiableCredential_SealedEnvelope_Accessor b)
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
