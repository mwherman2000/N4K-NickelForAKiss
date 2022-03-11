#pragma warning disable 162,168,649,660,661,1522

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Trinity;
using Trinity.TSL;
using Trinity.TSL.Lib;
namespace BTTN4KNFE
{
    /// <summary>
    /// Provides facilities for serializing data to Json strings.
    /// </summary>
    public class Serializer
    {
        [ThreadStatic]
        static StringBuilder s_stringBuilder;
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void s_ensure_string_builder()
        {
            if (s_stringBuilder == null)
                s_stringBuilder = new StringBuilder();
            else
                s_stringBuilder.Clear();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a bool object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(bool value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a int object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(int value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a long object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(long value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a float object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(float value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a DateTime object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(DateTime value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a string object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(string value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a float[] object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(float[] value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a List<long> object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(List<long> value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a List<string> object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(List<string> value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a List<BTTKeyValuePair> object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(List<BTTKeyValuePair> value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTClaim object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTClaim value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTEncryptedClaims object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTEncryptedClaims value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTGenericCredential_Envelope object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTGenericCredential_Envelope value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTGenericCredential_EnvelopeContent object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTGenericCredential_EnvelopeContent value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTGenericCredential_EnvelopeSeal object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTGenericCredential_EnvelopeSeal value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTGenericCredential_PackingLabel object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTGenericCredential_PackingLabel value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTKeyValuePair object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTKeyValuePair value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTNFE_N4K_Claims object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTNFE_N4K_Claims value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTNFE_N4K_Envelope object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTNFE_N4K_Envelope value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTNFE_N4K_EnvelopeContent object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTNFE_N4K_EnvelopeContent value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTNFE_N4K_SealedEnvelope object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTNFE_N4K_SealedEnvelope value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTVerifiableCredential_SealedEnvelope object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTVerifiableCredential_SealedEnvelope value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a GetNFEBatchRequest object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(GetNFEBatchRequest value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a GetNFEBatchResponse object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(GetNFEBatchResponse value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a GetNFECountRequest object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(GetNFECountRequest value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a GetNFECountResponse object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(GetNFECountResponse value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a GetNFERequest object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(GetNFERequest value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a GetNFEResponse object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(GetNFEResponse value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a SendNFEByIdRequest object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(SendNFEByIdRequest value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a SendNFEByIdResponse object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(SendNFEByIdResponse value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a SendNFEEnvelopeRequest object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(SendNFEEnvelopeRequest value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a SendNFEEnvelopeResponse object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(SendNFEEnvelopeResponse value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTEncryptionFlag object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTEncryptionFlag value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTGenericCredentialType object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTGenericCredentialType value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTN4KBodyPart object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTN4KBodyPart value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTN4KMood object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTN4KMood value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTN4KPurpose object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTN4KPurpose value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTN4KType object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTN4KType value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTTrustLevel object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTTrustLevel value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a List<List<BTTKeyValuePair>> object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(List<List<BTTKeyValuePair>> value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a List<BTTClaim> object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(List<BTTClaim> value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTEncryptedClaims? object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTEncryptedClaims? value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        /// <summary>
        /// Serializes a BTTNFE_N4K_Claims? object to Json string.
        /// </summary>
        /// <param name="value">The target object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTNFE_N4K_Claims? value)
        {
            s_ensure_string_builder();
            ToString_impl(value, s_stringBuilder, in_json: false);
            return s_stringBuilder.ToString();
        }
        
        /// <summary>
        /// Serializes a BTTN4KNFEDirectory object to Json string.
        /// </summary>
        /// <param name="value">The target cell object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTN4KNFEDirectory cell)
        {
            s_ensure_string_builder();
            s_stringBuilder.Append('{');
            s_stringBuilder.AppendFormat("\"CellId\":{0}", cell.CellId);
            
            {
                
                    s_stringBuilder.Append(',');
                    s_stringBuilder.Append("\"count\":");
                    ToString_impl(cell.count, s_stringBuilder, in_json: true);
                    
            }
            
            {
                
                if (cell.ids != null)
                {
                    
                    s_stringBuilder.Append(',');
                    s_stringBuilder.Append("\"ids\":");
                    ToString_impl(cell.ids, s_stringBuilder, in_json: true);
                    
                }
                
            }
            
            s_stringBuilder.Append('}');
            return s_stringBuilder.ToString();
        }
        
        /// <summary>
        /// Serializes a BTTNFE_N4K_SealedEnvelope_Cell object to Json string.
        /// </summary>
        /// <param name="value">The target cell object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTNFE_N4K_SealedEnvelope_Cell cell)
        {
            s_ensure_string_builder();
            s_stringBuilder.Append('{');
            s_stringBuilder.AppendFormat("\"CellId\":{0}", cell.CellId);
            
            {
                
                    s_stringBuilder.Append(',');
                    s_stringBuilder.Append("\"sealedenvelope\":");
                    ToString_impl(cell.sealedenvelope, s_stringBuilder, in_json: true);
                    
            }
            
            s_stringBuilder.Append('}');
            return s_stringBuilder.ToString();
        }
        
        /// <summary>
        /// Serializes a BTTVerifiableCredential_SealedEnvelope_Cell object to Json string.
        /// </summary>
        /// <param name="value">The target cell object to be serialized.</param>
        /// <returns>The serialized Json string.</returns>
        public static string ToString(BTTVerifiableCredential_SealedEnvelope_Cell cell)
        {
            s_ensure_string_builder();
            s_stringBuilder.Append('{');
            s_stringBuilder.AppendFormat("\"CellId\":{0}", cell.CellId);
            
            {
                
                    s_stringBuilder.Append(',');
                    s_stringBuilder.Append("\"signedenvelope\":");
                    ToString_impl(cell.signedenvelope, s_stringBuilder, in_json: true);
                    
            }
            
            s_stringBuilder.Append('}');
            return s_stringBuilder.ToString();
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(bool value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                {
                    str_builder.Append(value.ToString().ToLowerInvariant());
                }
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(int value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                {
                    str_builder.Append(value);
                }
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(long value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                {
                    str_builder.Append(value);
                }
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(float value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                {
                    str_builder.Append(value);
                }
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(DateTime value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if(in_json)
                    str_builder.Append('"');
                
                {
                    
                    {
                        str_builder.Append(value.ToString("o", CultureInfo.InvariantCulture));
                    }
                    
                }
                
                if(in_json)
                    str_builder.Append('"');
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(string value, StringBuilder str_builder, bool in_json)
        {
            
            if (in_json)
            {
                str_builder.Append(JsonStringProcessor.escape(value));
            }
            else
            {
                str_builder.Append(value);
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(float[] value, StringBuilder str_builder, bool in_json)
        {
            
            {
                str_builder.Append('[');
                bool first = true;
                foreach (var element in value)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        str_builder.Append(',');
                    }
                    ToString_impl(element, str_builder, in_json:true);
                }
                str_builder.Append(']');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(List<long> value, StringBuilder str_builder, bool in_json)
        {
            
            {
                str_builder.Append('[');
                bool first = true;
                foreach (var element in value)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        str_builder.Append(',');
                    }
                    ToString_impl(element, str_builder, in_json:true);
                }
                str_builder.Append(']');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(List<string> value, StringBuilder str_builder, bool in_json)
        {
            
            {
                str_builder.Append('[');
                bool first = true;
                foreach (var element in value)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        str_builder.Append(',');
                    }
                    ToString_impl(element, str_builder, in_json:true);
                }
                str_builder.Append(']');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(List<BTTKeyValuePair> value, StringBuilder str_builder, bool in_json)
        {
            
            {
                str_builder.Append('[');
                bool first = true;
                foreach (var element in value)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        str_builder.Append(',');
                    }
                    ToString_impl(element, str_builder, in_json:true);
                }
                str_builder.Append(']');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTClaim value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.key != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"key\":");
                        
                        ToString_impl(value.key, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.value != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"value\":");
                        
                        ToString_impl(value.value, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.attribute != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"attribute\":");
                        
                        ToString_impl(value.attribute, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.attributes != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"attributes\":");
                        
                        ToString_impl(value.attributes, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTEncryptedClaims value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.ciphertext16 != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"ciphertext16\":");
                        
                        ToString_impl(value.ciphertext16, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.alg != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"alg\":");
                        
                        ToString_impl(value.alg, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.key != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"key\":");
                        
                        ToString_impl(value.key, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTGenericCredential_Envelope value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.udid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"udid\":");
                        
                        ToString_impl(value.udid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"label\":");
                        
                        ToString_impl(value.label, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"content\":");
                        
                        ToString_impl(value.content, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTGenericCredential_EnvelopeContent value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.udid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"udid\":");
                        
                        ToString_impl(value.udid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.context != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"context\":");
                        
                        ToString_impl(value.context, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.credentialsubjectudid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"credentialsubjectudid\":");
                        
                        ToString_impl(value.credentialsubjectudid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.credentialsubjectclaims != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"credentialsubjectclaims\":");
                        
                        ToString_impl(value.credentialsubjectclaims, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.encryptedclaims != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"encryptedclaims\":");
                        
                        ToString_impl(value.encryptedclaims, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTGenericCredential_EnvelopeSeal value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.hashedThumbprint64 != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"hashedThumbprint64\":");
                        
                        ToString_impl(value.hashedThumbprint64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.signedHashSignature64 != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"signedHashSignature64\":");
                        
                        ToString_impl(value.signedHashSignature64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.notaryStamp != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"notaryStamp\":");
                        
                        ToString_impl(value.notaryStamp, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.comments != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"comments\":");
                        
                        ToString_impl(value.comments, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTGenericCredential_PackingLabel value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.types != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"types\":");
                        
                        ToString_impl(value.types, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"credtype\":");
                        
                        ToString_impl(value.credtype, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"version\":");
                        
                        ToString_impl(value.version, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"trustLevel\":");
                        
                        ToString_impl(value.trustLevel, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"encryptionFlag\":");
                        
                        ToString_impl(value.encryptionFlag, str_builder, in_json: true);
                        
                }
                
                {
                    
                    if (value.notaryudid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"notaryudid\":");
                        
                        ToString_impl(value.notaryudid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.name != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"name\":");
                        
                        ToString_impl(value.name, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.comments != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"comments\":");
                        
                        ToString_impl(value.comments, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTKeyValuePair value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.key != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"key\":");
                        
                        ToString_impl(value.key, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.value != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"value\":");
                        
                        ToString_impl(value.value, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTNFE_N4K_Claims value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"kissCompass\":");
                        
                        ToString_impl(value.kissCompass, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"purpose\":");
                        
                        ToString_impl(value.purpose, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"kissType\":");
                        
                        ToString_impl(value.kissType, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"mood\":");
                        
                        ToString_impl(value.mood, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tongue\":");
                        
                        ToString_impl(value.tongue, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"targetbodypart\":");
                        
                        ToString_impl(value.targetbodypart, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"actualbodypart\":");
                        
                        ToString_impl(value.actualbodypart, str_builder, in_json: true);
                        
                }
                
                {
                    
                    if (value.timezoneid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"timezoneid\":");
                        
                        ToString_impl(value.timezoneid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod0approach\":");
                        
                        ToString_impl(value.tod0approach, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod1press\":");
                        
                        ToString_impl(value.tod1press, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod2sustain\":");
                        
                        ToString_impl(value.tod2sustain, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod3release\":");
                        
                        ToString_impl(value.tod3release, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod4recovery\":");
                        
                        ToString_impl(value.tod4recovery, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod5finish\":");
                        
                        ToString_impl(value.tod5finish, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t0ms\":");
                        
                        ToString_impl(value.t0ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t1ms\":");
                        
                        ToString_impl(value.t1ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t2ms\":");
                        
                        ToString_impl(value.t2ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t3ms\":");
                        
                        ToString_impl(value.t3ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t4ms\":");
                        
                        ToString_impl(value.t4ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t5ms\":");
                        
                        ToString_impl(value.t5ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1ms\":");
                        
                        ToString_impl(value.d1ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2ms\":");
                        
                        ToString_impl(value.d2ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3ms\":");
                        
                        ToString_impl(value.d3ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4ms\":");
                        
                        ToString_impl(value.d4ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5ms\":");
                        
                        ToString_impl(value.d5ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1s\":");
                        
                        ToString_impl(value.d1s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2s\":");
                        
                        ToString_impl(value.d2s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3s\":");
                        
                        ToString_impl(value.d3s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4s\":");
                        
                        ToString_impl(value.d4s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5s\":");
                        
                        ToString_impl(value.d5s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t0s\":");
                        
                        ToString_impl(value.t0s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t1s\":");
                        
                        ToString_impl(value.t1s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t2s\":");
                        
                        ToString_impl(value.t2s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t3s\":");
                        
                        ToString_impl(value.t3s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t4s\":");
                        
                        ToString_impl(value.t4s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t5s\":");
                        
                        ToString_impl(value.t5s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"peak\":");
                        
                        ToString_impl(value.peak, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"medianms\":");
                        
                        ToString_impl(value.medianms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"medians\":");
                        
                        ToString_impl(value.medians, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"coverage\":");
                        
                        ToString_impl(value.coverage, str_builder, in_json: true);
                        
                }
                
                {
                    
                    if (value.d1approachtime != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1approachtime\":");
                        
                        ToString_impl(value.d1approachtime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d2presstime != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2presstime\":");
                        
                        ToString_impl(value.d2presstime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d3sustaintime != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3sustaintime\":");
                        
                        ToString_impl(value.d3sustaintime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d4releasetime != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4releasetime\":");
                        
                        ToString_impl(value.d4releasetime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d5recoverytime != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5recoverytime\":");
                        
                        ToString_impl(value.d5recoverytime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d1approachcurve != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1approachcurve\":");
                        
                        ToString_impl(value.d1approachcurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d2presscurve != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2presscurve\":");
                        
                        ToString_impl(value.d2presscurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d3sustaincurve != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3sustaincurve\":");
                        
                        ToString_impl(value.d3sustaincurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d4releasecurve != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4releasecurve\":");
                        
                        ToString_impl(value.d4releasecurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d5recoverycurve != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5recoverycurve\":");
                        
                        ToString_impl(value.d5recoverycurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d1approachpng64 != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1approachpng64\":");
                        
                        ToString_impl(value.d1approachpng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d2presspng64 != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2presspng64\":");
                        
                        ToString_impl(value.d2presspng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d3sustainpng64 != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3sustainpng64\":");
                        
                        ToString_impl(value.d3sustainpng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d4releasepng64 != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4releasepng64\":");
                        
                        ToString_impl(value.d4releasepng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.d5recoverypng64 != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5recoverypng64\":");
                        
                        ToString_impl(value.d5recoverypng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTNFE_N4K_Envelope value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.udid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"udid\":");
                        
                        ToString_impl(value.udid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"label\":");
                        
                        ToString_impl(value.label, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"content\":");
                        
                        ToString_impl(value.content, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTNFE_N4K_EnvelopeContent value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.udid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"udid\":");
                        
                        ToString_impl(value.udid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.context != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"context\":");
                        
                        ToString_impl(value.context, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.credentialsubjectudid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"credentialsubjectudid\":");
                        
                        ToString_impl(value.credentialsubjectudid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.credentialsubjectclaims != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"credentialsubjectclaims\":");
                        
                        ToString_impl(value.credentialsubjectclaims, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.encryptedclaims != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"encryptedclaims\":");
                        
                        ToString_impl(value.encryptedclaims, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTNFE_N4K_SealedEnvelope value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"envelope\":");
                        
                        ToString_impl(value.envelope, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"proof\":");
                        
                        ToString_impl(value.proof, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTVerifiableCredential_SealedEnvelope value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"envelope\":");
                        
                        ToString_impl(value.envelope, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"proof\":");
                        
                        ToString_impl(value.proof, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(GetNFEBatchRequest value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"batchindex\":");
                        
                        ToString_impl(value.batchindex, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"batchsize\":");
                        
                        ToString_impl(value.batchsize, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(GetNFEBatchResponse value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.udids != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"udids\":");
                        
                        ToString_impl(value.udids, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(GetNFECountRequest value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"dummy\":");
                        
                        ToString_impl(value.dummy, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(GetNFECountResponse value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"count\":");
                        
                        ToString_impl(value.count, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"rc\":");
                        
                        ToString_impl(value.rc, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(GetNFERequest value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.udid != null)
                    
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"udid\":");
                        
                        ToString_impl(value.udid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(GetNFEResponse value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"id\":");
                        
                        ToString_impl(value.id, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"rc\":");
                        
                        ToString_impl(value.rc, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(SendNFEByIdRequest value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"id\":");
                        
                        ToString_impl(value.id, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(SendNFEByIdResponse value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"rc\":");
                        
                        ToString_impl(value.rc, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(SendNFEEnvelopeRequest value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"sealedEnvelope\":");
                        
                        ToString_impl(value.sealedEnvelope, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(SendNFEEnvelopeResponse value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"rc\":");
                        
                        ToString_impl(value.rc, str_builder, in_json: true);
                        
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTEncryptionFlag value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if(in_json)
                    str_builder.Append('"');
                
                {
                    str_builder.Append(value);
                }
                
                if(in_json)
                    str_builder.Append('"');
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTGenericCredentialType value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if(in_json)
                    str_builder.Append('"');
                
                {
                    str_builder.Append(value);
                }
                
                if(in_json)
                    str_builder.Append('"');
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTN4KBodyPart value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if(in_json)
                    str_builder.Append('"');
                
                {
                    str_builder.Append(value);
                }
                
                if(in_json)
                    str_builder.Append('"');
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTN4KMood value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if(in_json)
                    str_builder.Append('"');
                
                {
                    str_builder.Append(value);
                }
                
                if(in_json)
                    str_builder.Append('"');
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTN4KPurpose value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if(in_json)
                    str_builder.Append('"');
                
                {
                    str_builder.Append(value);
                }
                
                if(in_json)
                    str_builder.Append('"');
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTN4KType value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if(in_json)
                    str_builder.Append('"');
                
                {
                    str_builder.Append(value);
                }
                
                if(in_json)
                    str_builder.Append('"');
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTTrustLevel value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if(in_json)
                    str_builder.Append('"');
                
                {
                    str_builder.Append(value);
                }
                
                if(in_json)
                    str_builder.Append('"');
                
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(List<List<BTTKeyValuePair>> value, StringBuilder str_builder, bool in_json)
        {
            
            {
                str_builder.Append('[');
                bool first = true;
                foreach (var element in value)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        str_builder.Append(',');
                    }
                    ToString_impl(element, str_builder, in_json:true);
                }
                str_builder.Append(']');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(List<BTTClaim> value, StringBuilder str_builder, bool in_json)
        {
            
            {
                str_builder.Append('[');
                bool first = true;
                foreach (var element in value)
                {
                    if (first)
                    {
                        first = false;
                    }
                    else
                    {
                        str_builder.Append(',');
                    }
                    ToString_impl(element, str_builder, in_json:true);
                }
                str_builder.Append(']');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTEncryptedClaims? value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if (value == null)
                    return;
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                    if (value.Value.ciphertext16 != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"ciphertext16\":");
                        
                        ToString_impl(value.Value.ciphertext16, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.alg != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"alg\":");
                        
                        ToString_impl(value.Value.alg, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.key != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"key\":");
                        
                        ToString_impl(value.Value.key, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static void ToString_impl(BTTNFE_N4K_Claims? value, StringBuilder str_builder, bool in_json)
        {
            
            {
                
                if (value == null)
                    return;
                
                str_builder.Append('{');
                bool first_field = true;
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"kissCompass\":");
                        
                        ToString_impl(value.Value.kissCompass, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"purpose\":");
                        
                        ToString_impl(value.Value.purpose, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"kissType\":");
                        
                        ToString_impl(value.Value.kissType, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"mood\":");
                        
                        ToString_impl(value.Value.mood, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tongue\":");
                        
                        ToString_impl(value.Value.tongue, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"targetbodypart\":");
                        
                        ToString_impl(value.Value.targetbodypart, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"actualbodypart\":");
                        
                        ToString_impl(value.Value.actualbodypart, str_builder, in_json: true);
                        
                }
                
                {
                    
                    if (value.Value.timezoneid != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"timezoneid\":");
                        
                        ToString_impl(value.Value.timezoneid, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod0approach\":");
                        
                        ToString_impl(value.Value.tod0approach, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod1press\":");
                        
                        ToString_impl(value.Value.tod1press, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod2sustain\":");
                        
                        ToString_impl(value.Value.tod2sustain, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod3release\":");
                        
                        ToString_impl(value.Value.tod3release, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod4recovery\":");
                        
                        ToString_impl(value.Value.tod4recovery, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"tod5finish\":");
                        
                        ToString_impl(value.Value.tod5finish, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t0ms\":");
                        
                        ToString_impl(value.Value.t0ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t1ms\":");
                        
                        ToString_impl(value.Value.t1ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t2ms\":");
                        
                        ToString_impl(value.Value.t2ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t3ms\":");
                        
                        ToString_impl(value.Value.t3ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t4ms\":");
                        
                        ToString_impl(value.Value.t4ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t5ms\":");
                        
                        ToString_impl(value.Value.t5ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1ms\":");
                        
                        ToString_impl(value.Value.d1ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2ms\":");
                        
                        ToString_impl(value.Value.d2ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3ms\":");
                        
                        ToString_impl(value.Value.d3ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4ms\":");
                        
                        ToString_impl(value.Value.d4ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5ms\":");
                        
                        ToString_impl(value.Value.d5ms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1s\":");
                        
                        ToString_impl(value.Value.d1s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2s\":");
                        
                        ToString_impl(value.Value.d2s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3s\":");
                        
                        ToString_impl(value.Value.d3s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4s\":");
                        
                        ToString_impl(value.Value.d4s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5s\":");
                        
                        ToString_impl(value.Value.d5s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t0s\":");
                        
                        ToString_impl(value.Value.t0s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t1s\":");
                        
                        ToString_impl(value.Value.t1s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t2s\":");
                        
                        ToString_impl(value.Value.t2s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t3s\":");
                        
                        ToString_impl(value.Value.t3s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t4s\":");
                        
                        ToString_impl(value.Value.t4s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"t5s\":");
                        
                        ToString_impl(value.Value.t5s, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"peak\":");
                        
                        ToString_impl(value.Value.peak, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"medianms\":");
                        
                        ToString_impl(value.Value.medianms, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"medians\":");
                        
                        ToString_impl(value.Value.medians, str_builder, in_json: true);
                        
                }
                
                {
                    
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"coverage\":");
                        
                        ToString_impl(value.Value.coverage, str_builder, in_json: true);
                        
                }
                
                {
                    
                    if (value.Value.d1approachtime != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1approachtime\":");
                        
                        ToString_impl(value.Value.d1approachtime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d2presstime != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2presstime\":");
                        
                        ToString_impl(value.Value.d2presstime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d3sustaintime != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3sustaintime\":");
                        
                        ToString_impl(value.Value.d3sustaintime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d4releasetime != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4releasetime\":");
                        
                        ToString_impl(value.Value.d4releasetime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d5recoverytime != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5recoverytime\":");
                        
                        ToString_impl(value.Value.d5recoverytime, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d1approachcurve != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1approachcurve\":");
                        
                        ToString_impl(value.Value.d1approachcurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d2presscurve != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2presscurve\":");
                        
                        ToString_impl(value.Value.d2presscurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d3sustaincurve != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3sustaincurve\":");
                        
                        ToString_impl(value.Value.d3sustaincurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d4releasecurve != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4releasecurve\":");
                        
                        ToString_impl(value.Value.d4releasecurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d5recoverycurve != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5recoverycurve\":");
                        
                        ToString_impl(value.Value.d5recoverycurve, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d1approachpng64 != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d1approachpng64\":");
                        
                        ToString_impl(value.Value.d1approachpng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d2presspng64 != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d2presspng64\":");
                        
                        ToString_impl(value.Value.d2presspng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d3sustainpng64 != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d3sustainpng64\":");
                        
                        ToString_impl(value.Value.d3sustainpng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d4releasepng64 != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d4releasepng64\":");
                        
                        ToString_impl(value.Value.d4releasepng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                {
                    
                    if (value.Value.d5recoverypng64 != null)
                        
                    {
                        
                        if(first_field)
                            first_field = false;
                        else
                            str_builder.Append(',');
                        str_builder.Append("\"d5recoverypng64\":");
                        
                        ToString_impl(value.Value.d5recoverypng64, str_builder, in_json: true);
                        
                    }
                    
                }
                
                str_builder.Append('}');
            }
            
        }
        
        #region mute
        
        #endregion
    }
}

#pragma warning restore 162,168,649,660,661,1522
