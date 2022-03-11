#pragma warning disable 162,168,649,660,661,1522

using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Trinity;
using Trinity.TSL;
using Trinity.TSL.Lib;
namespace BTTN4KNFE
{
    internal class ExternalParser
    {
        
        internal static unsafe bool TryParse_bool(string s, out bool value)
        {
            bool value_type_value;
            JArray jarray;
            
            {
                
                double double_val;
                if (bool.TryParse(s, out value_type_value))
                {
                    value = value_type_value;
                    return true;
                }
                else if (double.TryParse(s, out double_val))
                {
                    value = (double_val != 0);
                    return true;
                }
                else
                {
                    value = default(bool);
                    return false;
                }
            }
            
        }
        
        internal static unsafe bool TryParse_DateTime(string s, out DateTime value)
        {
            DateTime value_type_value;
            JArray jarray;
            
            {
                
                if (DateTime.TryParse(s, null, System.Globalization.DateTimeStyles.RoundtripKind, out value_type_value))
                {
                    value = value_type_value;
                    return true;
                }
                if (s.EndsWith(" UTC", StringComparison.Ordinal) && DateTime.TryParse(s.Substring(0, s.Length - 4) + 'Z', null, System.Globalization.DateTimeStyles.RoundtripKind, out value_type_value))
                {
                    value = value_type_value;
                    return true;
                }
                value  = default(DateTime);
                return false;
            }
            
        }
        
        internal static unsafe bool TryParse_float_Array_150(string s, out float[] value)
        {
            float[] value_type_value;
            JArray jarray;
            
            try
            {
                jarray = JArray.Parse(s);
                value = new  float[150] ;float  element;
                int float_offset = 0;
                
                for (int float_0 = 0; float_0 < 150; ++float_0)
                
                {
                    
                    {
                        if (!float.TryParse((string)jarray[float_offset++], out element))
                            continue;
                        value[float_0] = element;
                    }
                    
                }
                return true;
            }
            catch
            {
                value = default(float[]);
                return false;
            }
            
        }
        
        internal static unsafe bool TryParse_List_long(string s, out List<long> value)
        {
            List<long> value_type_value;
            JArray jarray;
            
            try
            {
                value = new List<long>();
                jarray = JArray.Parse(s);
                foreach (var jarray_element in jarray)
                {
                    long element;
                    
                    if (!long.TryParse((string)jarray_element, out element))
                    {
                        continue;
                    }
                    value.Add(element);
                    
                }
                return true;
            }
            catch
            {
                value = default(List<long>);
                return false;
            }
            
        }
        
        internal static unsafe bool TryParse_List_string(string s, out List<string> value)
        {
            List<string> value_type_value;
            JArray jarray;
            
            try
            {
                value = new List<string>();
                jarray = JArray.Parse(s);
                foreach (var jarray_element in jarray)
                {
                    string element;
                    
                    value.Add((string)jarray_element);
                    
                }
                return true;
            }
            catch
            {
                value = default(List<string>);
                return false;
            }
            
        }
        
        internal static unsafe bool TryParse_List_BTTKeyValuePair(string s, out List<BTTKeyValuePair> value)
        {
            List<BTTKeyValuePair> value_type_value;
            JArray jarray;
            
            try
            {
                value = new List<BTTKeyValuePair>();
                jarray = JArray.Parse(s);
                foreach (var jarray_element in jarray)
                {
                    BTTKeyValuePair element;
                    
                    if (!BTTKeyValuePair.TryParse((string)jarray_element, out element))
                    {
                        continue;
                    }
                    value.Add(element);
                    
                }
                return true;
            }
            catch
            {
                value = default(List<BTTKeyValuePair>);
                return false;
            }
            
        }
        
        internal static unsafe bool TryParse_List_List_BTTKeyValuePair(string s, out List<List<BTTKeyValuePair>> value)
        {
            List<List<BTTKeyValuePair>> value_type_value;
            JArray jarray;
            
            try
            {
                value = new List<List<BTTKeyValuePair>>();
                jarray = JArray.Parse(s);
                foreach (var jarray_element in jarray)
                {
                    List<BTTKeyValuePair> element;
                    
                    if (!ExternalParser.TryParse_List_BTTKeyValuePair((string)jarray_element, out element))
                    {
                        continue;
                    }
                    value.Add(element);
                    
                }
                return true;
            }
            catch
            {
                value = default(List<List<BTTKeyValuePair>>);
                return false;
            }
            
        }
        
        internal static unsafe bool TryParse_List_BTTClaim(string s, out List<BTTClaim> value)
        {
            List<BTTClaim> value_type_value;
            JArray jarray;
            
            try
            {
                value = new List<BTTClaim>();
                jarray = JArray.Parse(s);
                foreach (var jarray_element in jarray)
                {
                    BTTClaim element;
                    
                    if (!BTTClaim.TryParse((string)jarray_element, out element))
                    {
                        continue;
                    }
                    value.Add(element);
                    
                }
                return true;
            }
            catch
            {
                value = default(List<BTTClaim>);
                return false;
            }
            
        }
        
        internal static unsafe bool TryParse_BTTEncryptedClaims_nullable(string s, out BTTEncryptedClaims? value)
        {
            BTTEncryptedClaims value_type_value;
            JArray jarray;
            
            if (string.IsNullOrEmpty(s) || string.Compare(s, "null", ignoreCase: true) == 0)
            {
                value = default(BTTEncryptedClaims?);
                return true;
            }
            else if (BTTEncryptedClaims.TryParse(s, out value_type_value))
            {
                value = value_type_value;
                return true;
            }
            else
            {
                value = default(BTTEncryptedClaims?);
                return false;
            }
            
        }
        
        internal static unsafe bool TryParse_BTTNFE_N4K_Claims_nullable(string s, out BTTNFE_N4K_Claims? value)
        {
            BTTNFE_N4K_Claims value_type_value;
            JArray jarray;
            
            if (string.IsNullOrEmpty(s) || string.Compare(s, "null", ignoreCase: true) == 0)
            {
                value = default(BTTNFE_N4K_Claims?);
                return true;
            }
            else if (BTTNFE_N4K_Claims.TryParse(s, out value_type_value))
            {
                value = value_type_value;
                return true;
            }
            else
            {
                value = default(BTTNFE_N4K_Claims?);
                return false;
            }
            
        }
        
        #region Mute
        
        #endregion
    }
}

#pragma warning restore 162,168,649,660,661,1522
