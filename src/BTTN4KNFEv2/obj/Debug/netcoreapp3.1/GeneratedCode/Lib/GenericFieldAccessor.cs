#pragma warning disable 162,168,649,660,661,1522

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinity;
using Trinity.TSL;
using Trinity.TSL.Lib;
namespace BTTN4KNFE
{
    internal struct GenericFieldAccessor
    {
        #region FieldID lookup table
        
        static Dictionary<string, uint> FieldLookupTable_SendNFEByIdRequest = new Dictionary<string, uint>()
        {
            
            {"id" , 0}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_SendNFEByIdResponse = new Dictionary<string, uint>()
        {
            
            {"rc" , 0}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_SendNFEEnvelopeRequest = new Dictionary<string, uint>()
        {
            
            {"sealedEnvelope" , 0}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_SendNFEEnvelopeResponse = new Dictionary<string, uint>()
        {
            
            {"rc" , 0}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_GetNFECountRequest = new Dictionary<string, uint>()
        {
            
            {"dummy" , 0}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_GetNFECountResponse = new Dictionary<string, uint>()
        {
            
            {"count" , 0}
            ,
            {"rc" , 1}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_GetNFERequest = new Dictionary<string, uint>()
        {
            
            {"udid" , 0}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_GetNFEResponse = new Dictionary<string, uint>()
        {
            
            {"id" , 0}
            ,
            {"rc" , 1}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_GetNFEBatchRequest = new Dictionary<string, uint>()
        {
            
            {"batchindex" , 0}
            ,
            {"batchsize" , 1}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_GetNFEBatchResponse = new Dictionary<string, uint>()
        {
            
            {"udids" , 0}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTNFE_N4K_Claims = new Dictionary<string, uint>()
        {
            
            {"kissCompass" , 0}
            ,
            {"purpose" , 1}
            ,
            {"kissType" , 2}
            ,
            {"mood" , 3}
            ,
            {"tongue" , 4}
            ,
            {"targetbodypart" , 5}
            ,
            {"actualbodypart" , 6}
            ,
            {"timezoneid" , 7}
            ,
            {"tod0approach" , 8}
            ,
            {"tod1press" , 9}
            ,
            {"tod2sustain" , 10}
            ,
            {"tod3release" , 11}
            ,
            {"tod4recovery" , 12}
            ,
            {"tod5finish" , 13}
            ,
            {"t0ms" , 14}
            ,
            {"t1ms" , 15}
            ,
            {"t2ms" , 16}
            ,
            {"t3ms" , 17}
            ,
            {"t4ms" , 18}
            ,
            {"t5ms" , 19}
            ,
            {"d1ms" , 20}
            ,
            {"d2ms" , 21}
            ,
            {"d3ms" , 22}
            ,
            {"d4ms" , 23}
            ,
            {"d5ms" , 24}
            ,
            {"d1s" , 25}
            ,
            {"d2s" , 26}
            ,
            {"d3s" , 27}
            ,
            {"d4s" , 28}
            ,
            {"d5s" , 29}
            ,
            {"t0s" , 30}
            ,
            {"t1s" , 31}
            ,
            {"t2s" , 32}
            ,
            {"t3s" , 33}
            ,
            {"t4s" , 34}
            ,
            {"t5s" , 35}
            ,
            {"peak" , 36}
            ,
            {"medianms" , 37}
            ,
            {"medians" , 38}
            ,
            {"coverage" , 39}
            ,
            {"d1approachtime" , 40}
            ,
            {"d2presstime" , 41}
            ,
            {"d3sustaintime" , 42}
            ,
            {"d4releasetime" , 43}
            ,
            {"d5recoverytime" , 44}
            ,
            {"d1approachcurve" , 45}
            ,
            {"d2presscurve" , 46}
            ,
            {"d3sustaincurve" , 47}
            ,
            {"d4releasecurve" , 48}
            ,
            {"d5recoverycurve" , 49}
            ,
            {"d1approachpng64" , 50}
            ,
            {"d2presspng64" , 51}
            ,
            {"d3sustainpng64" , 52}
            ,
            {"d4releasepng64" , 53}
            ,
            {"d5recoverypng64" , 54}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTNFE_N4K_EnvelopeContent = new Dictionary<string, uint>()
        {
            
            {"udid" , 0}
            ,
            {"context" , 1}
            ,
            {"credentialsubjectudid" , 2}
            ,
            {"credentialsubjectclaims" , 3}
            ,
            {"encryptedclaims" , 4}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTNFE_N4K_Envelope = new Dictionary<string, uint>()
        {
            
            {"udid" , 0}
            ,
            {"label" , 1}
            ,
            {"content" , 2}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTNFE_N4K_SealedEnvelope = new Dictionary<string, uint>()
        {
            
            {"envelope" , 0}
            ,
            {"proof" , 1}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTKeyValuePair = new Dictionary<string, uint>()
        {
            
            {"key" , 0}
            ,
            {"value" , 1}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTClaim = new Dictionary<string, uint>()
        {
            
            {"key" , 0}
            ,
            {"value" , 1}
            ,
            {"attribute" , 2}
            ,
            {"attributes" , 3}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTEncryptedClaims = new Dictionary<string, uint>()
        {
            
            {"ciphertext16" , 0}
            ,
            {"alg" , 1}
            ,
            {"key" , 2}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTGenericCredential_EnvelopeContent = new Dictionary<string, uint>()
        {
            
            {"udid" , 0}
            ,
            {"context" , 1}
            ,
            {"credentialsubjectudid" , 2}
            ,
            {"credentialsubjectclaims" , 3}
            ,
            {"encryptedclaims" , 4}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTGenericCredential_PackingLabel = new Dictionary<string, uint>()
        {
            
            {"types" , 0}
            ,
            {"credtype" , 1}
            ,
            {"version" , 2}
            ,
            {"trustLevel" , 3}
            ,
            {"encryptionFlag" , 4}
            ,
            {"notaryudid" , 5}
            ,
            {"name" , 6}
            ,
            {"comments" , 7}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTGenericCredential_EnvelopeSeal = new Dictionary<string, uint>()
        {
            
            {"hashedThumbprint64" , 0}
            ,
            {"signedHashSignature64" , 1}
            ,
            {"notaryStamp" , 2}
            ,
            {"comments" , 3}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTGenericCredential_Envelope = new Dictionary<string, uint>()
        {
            
            {"udid" , 0}
            ,
            {"label" , 1}
            ,
            {"content" , 2}
            
        };
        
        static Dictionary<string, uint> FieldLookupTable_BTTVerifiableCredential_SealedEnvelope = new Dictionary<string, uint>()
        {
            
            {"envelope" , 0}
            ,
            {"proof" , 1}
            
        };
        
        #endregion
        
        internal static void SetField<T>(SendNFEByIdRequest_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_SendNFEByIdRequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_SendNFEByIdRequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.id = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(SendNFEByIdRequest_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_SendNFEByIdRequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_SendNFEByIdRequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_long(accessor.id);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(SendNFEByIdResponse_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_SendNFEByIdResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_SendNFEByIdResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.rc = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(SendNFEByIdResponse_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_SendNFEByIdResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_SendNFEByIdResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_long(accessor.rc);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(SendNFEEnvelopeRequest_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_SendNFEEnvelopeRequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 0:
                        GenericFieldAccessor.SetField(accessor.sealedEnvelope, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_SendNFEEnvelopeRequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        BTTNFE_N4K_SealedEnvelope conversion_result = TypeConverter<T>.ConvertTo_BTTNFE_N4K_SealedEnvelope(value);
                        
            {
                accessor.sealedEnvelope = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(SendNFEEnvelopeRequest_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_SendNFEEnvelopeRequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 0:
                        return GenericFieldAccessor.GetField<T>(accessor.sealedEnvelope, fieldName, field_divider_idx + 1);
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_SendNFEEnvelopeRequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_BTTNFE_N4K_SealedEnvelope(accessor.sealedEnvelope);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(SendNFEEnvelopeResponse_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_SendNFEEnvelopeResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_SendNFEEnvelopeResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.rc = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(SendNFEEnvelopeResponse_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_SendNFEEnvelopeResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_SendNFEEnvelopeResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_long(accessor.rc);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(GetNFECountRequest_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFECountRequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFECountRequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.dummy = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(GetNFECountRequest_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFECountRequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFECountRequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_long(accessor.dummy);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(GetNFECountResponse_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFECountResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFECountResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.count = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.rc = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(GetNFECountResponse_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFECountResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFECountResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_long(accessor.count);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_long(accessor.rc);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(GetNFERequest_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFERequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFERequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.udid = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(GetNFERequest_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFERequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFERequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.udid);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(GetNFEResponse_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFEResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFEResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.id = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.rc = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(GetNFEResponse_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFEResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFEResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_long(accessor.id);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_long(accessor.rc);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(GetNFEBatchRequest_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFEBatchRequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFEBatchRequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.batchindex = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.batchsize = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(GetNFEBatchRequest_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFEBatchRequest.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFEBatchRequest.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_long(accessor.batchindex);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_long(accessor.batchsize);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(GetNFEBatchResponse_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFEBatchResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFEBatchResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        List<long> conversion_result = TypeConverter<T>.ConvertTo_List_long(value);
                        
            {
                accessor.udids = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(GetNFEBatchResponse_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_GetNFEBatchResponse.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_GetNFEBatchResponse.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_List_long(accessor.udids);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTNFE_N4K_Claims_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTNFE_N4K_Claims.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTNFE_N4K_Claims.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        float conversion_result = TypeConverter<T>.ConvertTo_float(value);
                        
            {
                accessor.kissCompass = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        BTTN4KPurpose conversion_result = TypeConverter<T>.ConvertTo_BTTN4KPurpose(value);
                        
            {
                accessor.purpose = conversion_result;
            }
            
                        break;
                    }
                
                case 2:
                    {
                        BTTN4KType conversion_result = TypeConverter<T>.ConvertTo_BTTN4KType(value);
                        
            {
                accessor.kissType = conversion_result;
            }
            
                        break;
                    }
                
                case 3:
                    {
                        BTTN4KMood conversion_result = TypeConverter<T>.ConvertTo_BTTN4KMood(value);
                        
            {
                accessor.mood = conversion_result;
            }
            
                        break;
                    }
                
                case 4:
                    {
                        bool conversion_result = TypeConverter<T>.ConvertTo_bool(value);
                        
            {
                accessor.tongue = conversion_result;
            }
            
                        break;
                    }
                
                case 5:
                    {
                        BTTN4KBodyPart conversion_result = TypeConverter<T>.ConvertTo_BTTN4KBodyPart(value);
                        
            {
                accessor.targetbodypart = conversion_result;
            }
            
                        break;
                    }
                
                case 6:
                    {
                        BTTN4KBodyPart conversion_result = TypeConverter<T>.ConvertTo_BTTN4KBodyPart(value);
                        
            {
                accessor.actualbodypart = conversion_result;
            }
            
                        break;
                    }
                
                case 7:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.timezoneid = conversion_result;
            }
            
                        break;
                    }
                
                case 8:
                    {
                        DateTime conversion_result = TypeConverter<T>.ConvertTo_DateTime(value);
                        
            {
                accessor.tod0approach = conversion_result;
            }
            
                        break;
                    }
                
                case 9:
                    {
                        DateTime conversion_result = TypeConverter<T>.ConvertTo_DateTime(value);
                        
            {
                accessor.tod1press = conversion_result;
            }
            
                        break;
                    }
                
                case 10:
                    {
                        DateTime conversion_result = TypeConverter<T>.ConvertTo_DateTime(value);
                        
            {
                accessor.tod2sustain = conversion_result;
            }
            
                        break;
                    }
                
                case 11:
                    {
                        DateTime conversion_result = TypeConverter<T>.ConvertTo_DateTime(value);
                        
            {
                accessor.tod3release = conversion_result;
            }
            
                        break;
                    }
                
                case 12:
                    {
                        DateTime conversion_result = TypeConverter<T>.ConvertTo_DateTime(value);
                        
            {
                accessor.tod4recovery = conversion_result;
            }
            
                        break;
                    }
                
                case 13:
                    {
                        DateTime conversion_result = TypeConverter<T>.ConvertTo_DateTime(value);
                        
            {
                accessor.tod5finish = conversion_result;
            }
            
                        break;
                    }
                
                case 14:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t0ms = conversion_result;
            }
            
                        break;
                    }
                
                case 15:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t1ms = conversion_result;
            }
            
                        break;
                    }
                
                case 16:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t2ms = conversion_result;
            }
            
                        break;
                    }
                
                case 17:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t3ms = conversion_result;
            }
            
                        break;
                    }
                
                case 18:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t4ms = conversion_result;
            }
            
                        break;
                    }
                
                case 19:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t5ms = conversion_result;
            }
            
                        break;
                    }
                
                case 20:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d1ms = conversion_result;
            }
            
                        break;
                    }
                
                case 21:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d2ms = conversion_result;
            }
            
                        break;
                    }
                
                case 22:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d3ms = conversion_result;
            }
            
                        break;
                    }
                
                case 23:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d4ms = conversion_result;
            }
            
                        break;
                    }
                
                case 24:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d5ms = conversion_result;
            }
            
                        break;
                    }
                
                case 25:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d1s = conversion_result;
            }
            
                        break;
                    }
                
                case 26:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d2s = conversion_result;
            }
            
                        break;
                    }
                
                case 27:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d3s = conversion_result;
            }
            
                        break;
                    }
                
                case 28:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d4s = conversion_result;
            }
            
                        break;
                    }
                
                case 29:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.d5s = conversion_result;
            }
            
                        break;
                    }
                
                case 30:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t0s = conversion_result;
            }
            
                        break;
                    }
                
                case 31:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t1s = conversion_result;
            }
            
                        break;
                    }
                
                case 32:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t2s = conversion_result;
            }
            
                        break;
                    }
                
                case 33:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t3s = conversion_result;
            }
            
                        break;
                    }
                
                case 34:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t4s = conversion_result;
            }
            
                        break;
                    }
                
                case 35:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.t5s = conversion_result;
            }
            
                        break;
                    }
                
                case 36:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.peak = conversion_result;
            }
            
                        break;
                    }
                
                case 37:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.medianms = conversion_result;
            }
            
                        break;
                    }
                
                case 38:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.medians = conversion_result;
            }
            
                        break;
                    }
                
                case 39:
                    {
                        int conversion_result = TypeConverter<T>.ConvertTo_int(value);
                        
            {
                accessor.coverage = conversion_result;
            }
            
                        break;
                    }
                
                case 40:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d1approachtime = conversion_result;
            }
            
                        break;
                    }
                
                case 41:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d2presstime = conversion_result;
            }
            
                        break;
                    }
                
                case 42:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d3sustaintime = conversion_result;
            }
            
                        break;
                    }
                
                case 43:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d4releasetime = conversion_result;
            }
            
                        break;
                    }
                
                case 44:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d5recoverytime = conversion_result;
            }
            
                        break;
                    }
                
                case 45:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d1approachcurve = conversion_result;
            }
            
                        break;
                    }
                
                case 46:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d2presscurve = conversion_result;
            }
            
                        break;
                    }
                
                case 47:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d3sustaincurve = conversion_result;
            }
            
                        break;
                    }
                
                case 48:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d4releasecurve = conversion_result;
            }
            
                        break;
                    }
                
                case 49:
                    {
                        float[] conversion_result = TypeConverter<T>.ConvertTo_float_Array_150(value);
                        
            {
                accessor.d5recoverycurve = conversion_result;
            }
            
                        break;
                    }
                
                case 50:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.d1approachpng64 = conversion_result;
            }
            
                        break;
                    }
                
                case 51:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.d2presspng64 = conversion_result;
            }
            
                        break;
                    }
                
                case 52:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.d3sustainpng64 = conversion_result;
            }
            
                        break;
                    }
                
                case 53:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.d4releasepng64 = conversion_result;
            }
            
                        break;
                    }
                
                case 54:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.d5recoverypng64 = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTNFE_N4K_Claims_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTNFE_N4K_Claims.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTNFE_N4K_Claims.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_float(accessor.kissCompass);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_BTTN4KPurpose(accessor.purpose);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_BTTN4KType(accessor.kissType);
                    break;
                
                case 3:
                    return TypeConverter<T>.ConvertFrom_BTTN4KMood(accessor.mood);
                    break;
                
                case 4:
                    return TypeConverter<T>.ConvertFrom_bool(accessor.tongue);
                    break;
                
                case 5:
                    return TypeConverter<T>.ConvertFrom_BTTN4KBodyPart(accessor.targetbodypart);
                    break;
                
                case 6:
                    return TypeConverter<T>.ConvertFrom_BTTN4KBodyPart(accessor.actualbodypart);
                    break;
                
                case 7:
                    return TypeConverter<T>.ConvertFrom_string(accessor.timezoneid);
                    break;
                
                case 8:
                    return TypeConverter<T>.ConvertFrom_DateTime(accessor.tod0approach);
                    break;
                
                case 9:
                    return TypeConverter<T>.ConvertFrom_DateTime(accessor.tod1press);
                    break;
                
                case 10:
                    return TypeConverter<T>.ConvertFrom_DateTime(accessor.tod2sustain);
                    break;
                
                case 11:
                    return TypeConverter<T>.ConvertFrom_DateTime(accessor.tod3release);
                    break;
                
                case 12:
                    return TypeConverter<T>.ConvertFrom_DateTime(accessor.tod4recovery);
                    break;
                
                case 13:
                    return TypeConverter<T>.ConvertFrom_DateTime(accessor.tod5finish);
                    break;
                
                case 14:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t0ms);
                    break;
                
                case 15:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t1ms);
                    break;
                
                case 16:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t2ms);
                    break;
                
                case 17:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t3ms);
                    break;
                
                case 18:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t4ms);
                    break;
                
                case 19:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t5ms);
                    break;
                
                case 20:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d1ms);
                    break;
                
                case 21:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d2ms);
                    break;
                
                case 22:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d3ms);
                    break;
                
                case 23:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d4ms);
                    break;
                
                case 24:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d5ms);
                    break;
                
                case 25:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d1s);
                    break;
                
                case 26:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d2s);
                    break;
                
                case 27:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d3s);
                    break;
                
                case 28:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d4s);
                    break;
                
                case 29:
                    return TypeConverter<T>.ConvertFrom_int(accessor.d5s);
                    break;
                
                case 30:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t0s);
                    break;
                
                case 31:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t1s);
                    break;
                
                case 32:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t2s);
                    break;
                
                case 33:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t3s);
                    break;
                
                case 34:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t4s);
                    break;
                
                case 35:
                    return TypeConverter<T>.ConvertFrom_int(accessor.t5s);
                    break;
                
                case 36:
                    return TypeConverter<T>.ConvertFrom_int(accessor.peak);
                    break;
                
                case 37:
                    return TypeConverter<T>.ConvertFrom_int(accessor.medianms);
                    break;
                
                case 38:
                    return TypeConverter<T>.ConvertFrom_int(accessor.medians);
                    break;
                
                case 39:
                    return TypeConverter<T>.ConvertFrom_int(accessor.coverage);
                    break;
                
                case 40:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d1approachtime);
                    break;
                
                case 41:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d2presstime);
                    break;
                
                case 42:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d3sustaintime);
                    break;
                
                case 43:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d4releasetime);
                    break;
                
                case 44:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d5recoverytime);
                    break;
                
                case 45:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d1approachcurve);
                    break;
                
                case 46:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d2presscurve);
                    break;
                
                case 47:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d3sustaincurve);
                    break;
                
                case 48:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d4releasecurve);
                    break;
                
                case 49:
                    return TypeConverter<T>.ConvertFrom_float_Array_150(accessor.d5recoverycurve);
                    break;
                
                case 50:
                    return TypeConverter<T>.ConvertFrom_string(accessor.d1approachpng64);
                    break;
                
                case 51:
                    return TypeConverter<T>.ConvertFrom_string(accessor.d2presspng64);
                    break;
                
                case 52:
                    return TypeConverter<T>.ConvertFrom_string(accessor.d3sustainpng64);
                    break;
                
                case 53:
                    return TypeConverter<T>.ConvertFrom_string(accessor.d4releasepng64);
                    break;
                
                case 54:
                    return TypeConverter<T>.ConvertFrom_string(accessor.d5recoverypng64);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTNFE_N4K_EnvelopeContent_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTNFE_N4K_EnvelopeContent.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 3:
                        GenericFieldAccessor.SetField(accessor.credentialsubjectclaims, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    case 4:
                        GenericFieldAccessor.SetField(accessor.encryptedclaims, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTNFE_N4K_EnvelopeContent.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.udid = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        List<string> conversion_result = TypeConverter<T>.ConvertTo_List_string(value);
                        
            {
                accessor.context = conversion_result;
            }
            
                        break;
                    }
                
                case 2:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                if (conversion_result != default(string))
                    accessor.credentialsubjectudid = conversion_result;
                else
                    accessor.Remove_credentialsubjectudid();
            }
            
                        break;
                    }
                
                case 3:
                    {
                        BTTNFE_N4K_Claims? conversion_result = TypeConverter<T>.ConvertTo_BTTNFE_N4K_Claims_nullable(value);
                        
            {
                if (conversion_result.HasValue)
                    accessor.credentialsubjectclaims = conversion_result.Value;
                else
                    accessor.Remove_credentialsubjectclaims();
            }
            
                        break;
                    }
                
                case 4:
                    {
                        BTTEncryptedClaims? conversion_result = TypeConverter<T>.ConvertTo_BTTEncryptedClaims_nullable(value);
                        
            {
                if (conversion_result.HasValue)
                    accessor.encryptedclaims = conversion_result.Value;
                else
                    accessor.Remove_encryptedclaims();
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTNFE_N4K_EnvelopeContent_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTNFE_N4K_EnvelopeContent.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 3:
                        return GenericFieldAccessor.GetField<T>(accessor.credentialsubjectclaims, fieldName, field_divider_idx + 1);
                    
                    case 4:
                        return GenericFieldAccessor.GetField<T>(accessor.encryptedclaims, fieldName, field_divider_idx + 1);
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTNFE_N4K_EnvelopeContent.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.udid);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_List_string(accessor.context);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_string(accessor.credentialsubjectudid);
                    break;
                
                case 3:
                    return TypeConverter<T>.ConvertFrom_BTTNFE_N4K_Claims_nullable(accessor.credentialsubjectclaims);
                    break;
                
                case 4:
                    return TypeConverter<T>.ConvertFrom_BTTEncryptedClaims_nullable(accessor.encryptedclaims);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTNFE_N4K_Envelope_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTNFE_N4K_Envelope.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 1:
                        GenericFieldAccessor.SetField(accessor.label, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    case 2:
                        GenericFieldAccessor.SetField(accessor.content, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTNFE_N4K_Envelope.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.udid = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        BTTGenericCredential_PackingLabel conversion_result = TypeConverter<T>.ConvertTo_BTTGenericCredential_PackingLabel(value);
                        
            {
                accessor.label = conversion_result;
            }
            
                        break;
                    }
                
                case 2:
                    {
                        BTTNFE_N4K_EnvelopeContent conversion_result = TypeConverter<T>.ConvertTo_BTTNFE_N4K_EnvelopeContent(value);
                        
            {
                accessor.content = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTNFE_N4K_Envelope_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTNFE_N4K_Envelope.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 1:
                        return GenericFieldAccessor.GetField<T>(accessor.label, fieldName, field_divider_idx + 1);
                    
                    case 2:
                        return GenericFieldAccessor.GetField<T>(accessor.content, fieldName, field_divider_idx + 1);
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTNFE_N4K_Envelope.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.udid);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_BTTGenericCredential_PackingLabel(accessor.label);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_BTTNFE_N4K_EnvelopeContent(accessor.content);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTNFE_N4K_SealedEnvelope_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTNFE_N4K_SealedEnvelope.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 0:
                        GenericFieldAccessor.SetField(accessor.envelope, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    case 1:
                        GenericFieldAccessor.SetField(accessor.proof, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTNFE_N4K_SealedEnvelope.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        BTTNFE_N4K_Envelope conversion_result = TypeConverter<T>.ConvertTo_BTTNFE_N4K_Envelope(value);
                        
            {
                accessor.envelope = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        BTTGenericCredential_EnvelopeSeal conversion_result = TypeConverter<T>.ConvertTo_BTTGenericCredential_EnvelopeSeal(value);
                        
            {
                accessor.proof = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTNFE_N4K_SealedEnvelope_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTNFE_N4K_SealedEnvelope.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 0:
                        return GenericFieldAccessor.GetField<T>(accessor.envelope, fieldName, field_divider_idx + 1);
                    
                    case 1:
                        return GenericFieldAccessor.GetField<T>(accessor.proof, fieldName, field_divider_idx + 1);
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTNFE_N4K_SealedEnvelope.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_BTTNFE_N4K_Envelope(accessor.envelope);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_BTTGenericCredential_EnvelopeSeal(accessor.proof);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTKeyValuePair_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTKeyValuePair.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTKeyValuePair.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.key = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.value = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTKeyValuePair_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTKeyValuePair.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTKeyValuePair.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.key);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_string(accessor.value);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTClaim_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTClaim.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTClaim.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.key = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                if (conversion_result != default(string))
                    accessor.value = conversion_result;
                else
                    accessor.Remove_value();
            }
            
                        break;
                    }
                
                case 2:
                    {
                        List<BTTKeyValuePair> conversion_result = TypeConverter<T>.ConvertTo_List_BTTKeyValuePair(value);
                        
            {
                if (conversion_result != default(List<BTTKeyValuePair>))
                    accessor.attribute = conversion_result;
                else
                    accessor.Remove_attribute();
            }
            
                        break;
                    }
                
                case 3:
                    {
                        List<List<BTTKeyValuePair>> conversion_result = TypeConverter<T>.ConvertTo_List_List_BTTKeyValuePair(value);
                        
            {
                if (conversion_result != default(List<List<BTTKeyValuePair>>))
                    accessor.attributes = conversion_result;
                else
                    accessor.Remove_attributes();
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTClaim_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTClaim.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTClaim.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.key);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_string(accessor.value);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_List_BTTKeyValuePair(accessor.attribute);
                    break;
                
                case 3:
                    return TypeConverter<T>.ConvertFrom_List_List_BTTKeyValuePair(accessor.attributes);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTEncryptedClaims_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTEncryptedClaims.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTEncryptedClaims.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.ciphertext16 = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.alg = conversion_result;
            }
            
                        break;
                    }
                
                case 2:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.key = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTEncryptedClaims_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTEncryptedClaims.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTEncryptedClaims.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.ciphertext16);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_string(accessor.alg);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_string(accessor.key);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTGenericCredential_EnvelopeContent_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTGenericCredential_EnvelopeContent.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 4:
                        GenericFieldAccessor.SetField(accessor.encryptedclaims, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTGenericCredential_EnvelopeContent.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.udid = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        List<string> conversion_result = TypeConverter<T>.ConvertTo_List_string(value);
                        
            {
                accessor.context = conversion_result;
            }
            
                        break;
                    }
                
                case 2:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                if (conversion_result != default(string))
                    accessor.credentialsubjectudid = conversion_result;
                else
                    accessor.Remove_credentialsubjectudid();
            }
            
                        break;
                    }
                
                case 3:
                    {
                        List<BTTClaim> conversion_result = TypeConverter<T>.ConvertTo_List_BTTClaim(value);
                        
            {
                if (conversion_result != default(List<BTTClaim>))
                    accessor.credentialsubjectclaims = conversion_result;
                else
                    accessor.Remove_credentialsubjectclaims();
            }
            
                        break;
                    }
                
                case 4:
                    {
                        BTTEncryptedClaims? conversion_result = TypeConverter<T>.ConvertTo_BTTEncryptedClaims_nullable(value);
                        
            {
                if (conversion_result.HasValue)
                    accessor.encryptedclaims = conversion_result.Value;
                else
                    accessor.Remove_encryptedclaims();
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTGenericCredential_EnvelopeContent_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTGenericCredential_EnvelopeContent.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 4:
                        return GenericFieldAccessor.GetField<T>(accessor.encryptedclaims, fieldName, field_divider_idx + 1);
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTGenericCredential_EnvelopeContent.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.udid);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_List_string(accessor.context);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_string(accessor.credentialsubjectudid);
                    break;
                
                case 3:
                    return TypeConverter<T>.ConvertFrom_List_BTTClaim(accessor.credentialsubjectclaims);
                    break;
                
                case 4:
                    return TypeConverter<T>.ConvertFrom_BTTEncryptedClaims_nullable(accessor.encryptedclaims);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTGenericCredential_PackingLabel_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTGenericCredential_PackingLabel.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTGenericCredential_PackingLabel.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        List<string> conversion_result = TypeConverter<T>.ConvertTo_List_string(value);
                        
            {
                accessor.types = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        BTTGenericCredentialType conversion_result = TypeConverter<T>.ConvertTo_BTTGenericCredentialType(value);
                        
            {
                accessor.credtype = conversion_result;
            }
            
                        break;
                    }
                
                case 2:
                    {
                        long conversion_result = TypeConverter<T>.ConvertTo_long(value);
                        
            {
                accessor.version = conversion_result;
            }
            
                        break;
                    }
                
                case 3:
                    {
                        BTTTrustLevel conversion_result = TypeConverter<T>.ConvertTo_BTTTrustLevel(value);
                        
            {
                accessor.trustLevel = conversion_result;
            }
            
                        break;
                    }
                
                case 4:
                    {
                        BTTEncryptionFlag conversion_result = TypeConverter<T>.ConvertTo_BTTEncryptionFlag(value);
                        
            {
                accessor.encryptionFlag = conversion_result;
            }
            
                        break;
                    }
                
                case 5:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.notaryudid = conversion_result;
            }
            
                        break;
                    }
                
                case 6:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                if (conversion_result != default(string))
                    accessor.name = conversion_result;
                else
                    accessor.Remove_name();
            }
            
                        break;
                    }
                
                case 7:
                    {
                        List<string> conversion_result = TypeConverter<T>.ConvertTo_List_string(value);
                        
            {
                if (conversion_result != default(List<string>))
                    accessor.comments = conversion_result;
                else
                    accessor.Remove_comments();
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTGenericCredential_PackingLabel_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTGenericCredential_PackingLabel.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTGenericCredential_PackingLabel.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_List_string(accessor.types);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_BTTGenericCredentialType(accessor.credtype);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_long(accessor.version);
                    break;
                
                case 3:
                    return TypeConverter<T>.ConvertFrom_BTTTrustLevel(accessor.trustLevel);
                    break;
                
                case 4:
                    return TypeConverter<T>.ConvertFrom_BTTEncryptionFlag(accessor.encryptionFlag);
                    break;
                
                case 5:
                    return TypeConverter<T>.ConvertFrom_string(accessor.notaryudid);
                    break;
                
                case 6:
                    return TypeConverter<T>.ConvertFrom_string(accessor.name);
                    break;
                
                case 7:
                    return TypeConverter<T>.ConvertFrom_List_string(accessor.comments);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTGenericCredential_EnvelopeSeal_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTGenericCredential_EnvelopeSeal.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTGenericCredential_EnvelopeSeal.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                if (conversion_result != default(string))
                    accessor.hashedThumbprint64 = conversion_result;
                else
                    accessor.Remove_hashedThumbprint64();
            }
            
                        break;
                    }
                
                case 1:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                if (conversion_result != default(string))
                    accessor.signedHashSignature64 = conversion_result;
                else
                    accessor.Remove_signedHashSignature64();
            }
            
                        break;
                    }
                
                case 2:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                if (conversion_result != default(string))
                    accessor.notaryStamp = conversion_result;
                else
                    accessor.Remove_notaryStamp();
            }
            
                        break;
                    }
                
                case 3:
                    {
                        List<string> conversion_result = TypeConverter<T>.ConvertTo_List_string(value);
                        
            {
                if (conversion_result != default(List<string>))
                    accessor.comments = conversion_result;
                else
                    accessor.Remove_comments();
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTGenericCredential_EnvelopeSeal_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTGenericCredential_EnvelopeSeal.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTGenericCredential_EnvelopeSeal.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.hashedThumbprint64);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_string(accessor.signedHashSignature64);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_string(accessor.notaryStamp);
                    break;
                
                case 3:
                    return TypeConverter<T>.ConvertFrom_List_string(accessor.comments);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTGenericCredential_Envelope_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTGenericCredential_Envelope.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 1:
                        GenericFieldAccessor.SetField(accessor.label, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    case 2:
                        GenericFieldAccessor.SetField(accessor.content, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTGenericCredential_Envelope.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        string conversion_result = TypeConverter<T>.ConvertTo_string(value);
                        
            {
                accessor.udid = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        BTTGenericCredential_PackingLabel conversion_result = TypeConverter<T>.ConvertTo_BTTGenericCredential_PackingLabel(value);
                        
            {
                accessor.label = conversion_result;
            }
            
                        break;
                    }
                
                case 2:
                    {
                        BTTGenericCredential_EnvelopeContent conversion_result = TypeConverter<T>.ConvertTo_BTTGenericCredential_EnvelopeContent(value);
                        
            {
                accessor.content = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTGenericCredential_Envelope_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTGenericCredential_Envelope.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 1:
                        return GenericFieldAccessor.GetField<T>(accessor.label, fieldName, field_divider_idx + 1);
                    
                    case 2:
                        return GenericFieldAccessor.GetField<T>(accessor.content, fieldName, field_divider_idx + 1);
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTGenericCredential_Envelope.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_string(accessor.udid);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_BTTGenericCredential_PackingLabel(accessor.label);
                    break;
                
                case 2:
                    return TypeConverter<T>.ConvertFrom_BTTGenericCredential_EnvelopeContent(accessor.content);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
        internal static void SetField<T>(BTTVerifiableCredential_SealedEnvelope_Accessor accessor, string fieldName, int field_name_idx, T value)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTVerifiableCredential_SealedEnvelope.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 0:
                        GenericFieldAccessor.SetField(accessor.envelope, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    case 1:
                        GenericFieldAccessor.SetField(accessor.proof, fieldName, field_divider_idx + 1, value);
                        break;
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
                return;
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTVerifiableCredential_SealedEnvelope.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    {
                        BTTGenericCredential_Envelope conversion_result = TypeConverter<T>.ConvertTo_BTTGenericCredential_Envelope(value);
                        
            {
                accessor.envelope = conversion_result;
            }
            
                        break;
                    }
                
                case 1:
                    {
                        BTTGenericCredential_EnvelopeSeal conversion_result = TypeConverter<T>.ConvertTo_BTTGenericCredential_EnvelopeSeal(value);
                        
            {
                accessor.proof = conversion_result;
            }
            
                        break;
                    }
                
            }
        }
        internal static T GetField<T>(BTTVerifiableCredential_SealedEnvelope_Accessor accessor, string fieldName, int field_name_idx)
        {
            uint member_id;
            int field_divider_idx = fieldName.IndexOf('.', field_name_idx);
            if (-1 != field_divider_idx)
            {
                string member_name_string = fieldName.Substring(field_name_idx, field_divider_idx - field_name_idx);
                if (!FieldLookupTable_BTTVerifiableCredential_SealedEnvelope.TryGetValue(member_name_string, out member_id))
                    Throw.undefined_field();
                switch (member_id)
                {
                    
                    case 0:
                        return GenericFieldAccessor.GetField<T>(accessor.envelope, fieldName, field_divider_idx + 1);
                    
                    case 1:
                        return GenericFieldAccessor.GetField<T>(accessor.proof, fieldName, field_divider_idx + 1);
                    
                    default:
                        Throw.member_access_on_non_struct__field(member_name_string);
                        break;
                }
            }
            fieldName = fieldName.Substring(field_name_idx);
            if (!FieldLookupTable_BTTVerifiableCredential_SealedEnvelope.TryGetValue(fieldName, out member_id))
                Throw.undefined_field();
            switch (member_id)
            {
                
                case 0:
                    return TypeConverter<T>.ConvertFrom_BTTGenericCredential_Envelope(accessor.envelope);
                    break;
                
                case 1:
                    return TypeConverter<T>.ConvertFrom_BTTGenericCredential_EnvelopeSeal(accessor.proof);
                    break;
                
            }
            /* Should not reach here */
            throw new Exception("Internal error T5008");
        }
        
    }
}

#pragma warning restore 162,168,649,660,661,1522
