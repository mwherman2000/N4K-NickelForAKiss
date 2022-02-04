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
    /// A .NET runtime object representation of BTTNFE_N4K_Claims defined in TSL.
    /// </summary>
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public partial struct BTTNFE_N4K_Claims
    {
        
        ///<summary>
        ///Initializes a new instance of BTTNFE_N4K_Claims with the specified parameters.
        ///</summary>
        public BTTNFE_N4K_Claims(string timezoneid = default(string),DateTime tod0approach = default(DateTime),DateTime tod1press = default(DateTime),DateTime tod2sustain = default(DateTime),DateTime tod3release = default(DateTime),DateTime tod4recovery = default(DateTime),DateTime tod5finish = default(DateTime),int t0ms = default(int),int t1ms = default(int),int t2ms = default(int),int t3ms = default(int),int t4ms = default(int),int t5ms = default(int),int d1ms = default(int),int d2ms = default(int),int d3ms = default(int),int d4ms = default(int),int d5ms = default(int),int d1s = default(int),int d2s = default(int),int d3s = default(int),int d4s = default(int),int d5s = default(int),int t0s = default(int),int t1s = default(int),int t2s = default(int),int t3s = default(int),int t4s = default(int),int t5s = default(int),int peak = default(int),int medianms = default(int),int medians = default(int),int coverage = default(int),bool tongue = default(bool),BTTNFEBodyPart targetbodypart = default(BTTNFEBodyPart),BTTNFEBodyPart actualbodypart = default(BTTNFEBodyPart),int[] d1approachcurve = default(int[]),int[] d2presscurve = default(int[]),int[] d3sustaincurve = default(int[]),int[] d4releasecurve = default(int[]),int[] d5recoverycurve = default(int[]),string d1approachpng64 = default(string),string d2presspng64 = default(string),string d3sustainpng64 = default(string),string d4releasepng64 = default(string),string d5recoverypng64 = default(string))
        {
            
            this.timezoneid = timezoneid;
            
            this.tod0approach = tod0approach;
            
            this.tod1press = tod1press;
            
            this.tod2sustain = tod2sustain;
            
            this.tod3release = tod3release;
            
            this.tod4recovery = tod4recovery;
            
            this.tod5finish = tod5finish;
            
            this.t0ms = t0ms;
            
            this.t1ms = t1ms;
            
            this.t2ms = t2ms;
            
            this.t3ms = t3ms;
            
            this.t4ms = t4ms;
            
            this.t5ms = t5ms;
            
            this.d1ms = d1ms;
            
            this.d2ms = d2ms;
            
            this.d3ms = d3ms;
            
            this.d4ms = d4ms;
            
            this.d5ms = d5ms;
            
            this.d1s = d1s;
            
            this.d2s = d2s;
            
            this.d3s = d3s;
            
            this.d4s = d4s;
            
            this.d5s = d5s;
            
            this.t0s = t0s;
            
            this.t1s = t1s;
            
            this.t2s = t2s;
            
            this.t3s = t3s;
            
            this.t4s = t4s;
            
            this.t5s = t5s;
            
            this.peak = peak;
            
            this.medianms = medianms;
            
            this.medians = medians;
            
            this.coverage = coverage;
            
            this.tongue = tongue;
            
            this.targetbodypart = targetbodypart;
            
            this.actualbodypart = actualbodypart;
            
            this.d1approachcurve = d1approachcurve;
            
            this.d2presscurve = d2presscurve;
            
            this.d3sustaincurve = d3sustaincurve;
            
            this.d4releasecurve = d4releasecurve;
            
            this.d5recoverycurve = d5recoverycurve;
            
            this.d1approachpng64 = d1approachpng64;
            
            this.d2presspng64 = d2presspng64;
            
            this.d3sustainpng64 = d3sustainpng64;
            
            this.d4releasepng64 = d4releasepng64;
            
            this.d5recoverypng64 = d5recoverypng64;
            
        }
        
        public static bool operator ==(BTTNFE_N4K_Claims a, BTTNFE_N4K_Claims b)
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
                
                (a.timezoneid == b.timezoneid)
                &&
                (a.tod0approach == b.tod0approach)
                &&
                (a.tod1press == b.tod1press)
                &&
                (a.tod2sustain == b.tod2sustain)
                &&
                (a.tod3release == b.tod3release)
                &&
                (a.tod4recovery == b.tod4recovery)
                &&
                (a.tod5finish == b.tod5finish)
                &&
                (a.t0ms == b.t0ms)
                &&
                (a.t1ms == b.t1ms)
                &&
                (a.t2ms == b.t2ms)
                &&
                (a.t3ms == b.t3ms)
                &&
                (a.t4ms == b.t4ms)
                &&
                (a.t5ms == b.t5ms)
                &&
                (a.d1ms == b.d1ms)
                &&
                (a.d2ms == b.d2ms)
                &&
                (a.d3ms == b.d3ms)
                &&
                (a.d4ms == b.d4ms)
                &&
                (a.d5ms == b.d5ms)
                &&
                (a.d1s == b.d1s)
                &&
                (a.d2s == b.d2s)
                &&
                (a.d3s == b.d3s)
                &&
                (a.d4s == b.d4s)
                &&
                (a.d5s == b.d5s)
                &&
                (a.t0s == b.t0s)
                &&
                (a.t1s == b.t1s)
                &&
                (a.t2s == b.t2s)
                &&
                (a.t3s == b.t3s)
                &&
                (a.t4s == b.t4s)
                &&
                (a.t5s == b.t5s)
                &&
                (a.peak == b.peak)
                &&
                (a.medianms == b.medianms)
                &&
                (a.medians == b.medians)
                &&
                (a.coverage == b.coverage)
                &&
                (a.tongue == b.tongue)
                &&
                (a.targetbodypart == b.targetbodypart)
                &&
                (a.actualbodypart == b.actualbodypart)
                &&
                (a.d1approachcurve == b.d1approachcurve)
                &&
                (a.d2presscurve == b.d2presscurve)
                &&
                (a.d3sustaincurve == b.d3sustaincurve)
                &&
                (a.d4releasecurve == b.d4releasecurve)
                &&
                (a.d5recoverycurve == b.d5recoverycurve)
                &&
                (a.d1approachpng64 == b.d1approachpng64)
                &&
                (a.d2presspng64 == b.d2presspng64)
                &&
                (a.d3sustainpng64 == b.d3sustainpng64)
                &&
                (a.d4releasepng64 == b.d4releasepng64)
                &&
                (a.d5recoverypng64 == b.d5recoverypng64)
                
                ;
            
        }
        public static bool operator !=(BTTNFE_N4K_Claims a, BTTNFE_N4K_Claims b)
        {
            return !(a == b);
        }
        
        public string timezoneid;
        
        public DateTime tod0approach;
        
        public DateTime tod1press;
        
        public DateTime tod2sustain;
        
        public DateTime tod3release;
        
        public DateTime tod4recovery;
        
        public DateTime tod5finish;
        
        public int t0ms;
        
        public int t1ms;
        
        public int t2ms;
        
        public int t3ms;
        
        public int t4ms;
        
        public int t5ms;
        
        public int d1ms;
        
        public int d2ms;
        
        public int d3ms;
        
        public int d4ms;
        
        public int d5ms;
        
        public int d1s;
        
        public int d2s;
        
        public int d3s;
        
        public int d4s;
        
        public int d5s;
        
        public int t0s;
        
        public int t1s;
        
        public int t2s;
        
        public int t3s;
        
        public int t4s;
        
        public int t5s;
        
        public int peak;
        
        public int medianms;
        
        public int medians;
        
        public int coverage;
        
        public bool tongue;
        
        public BTTNFEBodyPart targetbodypart;
        
        public BTTNFEBodyPart actualbodypart;
        
        public int[] d1approachcurve;
        
        public int[] d2presscurve;
        
        public int[] d3sustaincurve;
        
        public int[] d4releasecurve;
        
        public int[] d5recoverycurve;
        
        public string d1approachpng64;
        
        public string d2presspng64;
        
        public string d3sustainpng64;
        
        public string d4releasepng64;
        
        public string d5recoverypng64;
        
        /// <summary>
        /// Converts the string representation of a BTTNFE_N4K_Claims to its
        /// struct equivalent. A return value indicates whether the 
        /// operation succeeded.
        /// </summary>
        /// <param name="input">A string to convert.</param>
        /// <param name="value">
        /// When this method returns, contains the struct equivalent of the value contained 
        /// in input, if the conversion succeeded, or default(BTTNFE_N4K_Claims) if the conversion
        /// failed. The conversion fails if the input parameter is null or String.Empty, or is 
        /// not of the correct format. This parameter is passed uninitialized. 
        /// </param>
        /// <returns>True if input was converted successfully; otherwise, false.</returns>
        public unsafe static bool TryParse(string input, out BTTNFE_N4K_Claims value)
        {
            try
            {
                value = Newtonsoft.Json.JsonConvert.DeserializeObject<BTTNFE_N4K_Claims>(input);
                return true;
            }
            catch { value = default(BTTNFE_N4K_Claims); return false; }
        }
        public static BTTNFE_N4K_Claims Parse(string input)
        {
            return Newtonsoft.Json.JsonConvert.DeserializeObject<BTTNFE_N4K_Claims>(input);
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
    /// Provides in-place operations of BTTNFE_N4K_Claims defined in TSL.
    /// </summary>
    public unsafe partial class BTTNFE_N4K_Claims_Accessor : IAccessor
    {
        ///<summary>
        ///The pointer to the content of the object.
        ///</summary>
        internal byte* m_ptr;
        internal long m_cellId;
        internal unsafe BTTNFE_N4K_Claims_Accessor(byte* _CellPtr
            
            , ResizeFunctionDelegate func
            )
        {
            m_ptr = _CellPtr;
            
            ResizeFunction = func;
                    timezoneid_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        tod0approach_Accessor_Field = new DateTimeAccessor(null);        tod1press_Accessor_Field = new DateTimeAccessor(null);        tod2sustain_Accessor_Field = new DateTimeAccessor(null);        tod3release_Accessor_Field = new DateTimeAccessor(null);        tod4recovery_Accessor_Field = new DateTimeAccessor(null);        tod5finish_Accessor_Field = new DateTimeAccessor(null);        d1approachcurve_Accessor_Field = new intArray_150(null);        d2presscurve_Accessor_Field = new intArray_150(null);        d3sustaincurve_Accessor_Field = new intArray_150(null);        d4releasecurve_Accessor_Field = new intArray_150(null);        d5recoverycurve_Accessor_Field = new intArray_150(null);        d1approachpng64_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        d2presspng64_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        d3sustainpng64_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        d4releasepng64_Accessor_Field = new StringAccessor(null,
                (ptr,ptr_offset,delta)=>
                {
                    int substructure_offset = (int)(ptr - this.m_ptr);
                    this.m_ptr = this.ResizeFunction(this.m_ptr, ptr_offset + substructure_offset, delta);
                    return this.m_ptr + substructure_offset;
                });        d5recoverypng64_Accessor_Field = new StringAccessor(null,
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
            {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
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
            {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
            int size = (int)(targetPtr - m_ptr);
            return size;
        }
        public ResizeFunctionDelegate ResizeFunction { get; set; }
        #endregion
        StringAccessor timezoneid_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field timezoneid.
        ///</summary>
        public unsafe StringAccessor timezoneid
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {}timezoneid_Accessor_Field.m_ptr = targetPtr + 4;
                timezoneid_Accessor_Field.m_cellId = this.m_cellId;
                return timezoneid_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                timezoneid_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != timezoneid_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    timezoneid_Accessor_Field.m_ptr = timezoneid_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, timezoneid_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        timezoneid_Accessor_Field.m_ptr = timezoneid_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, timezoneid_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        DateTimeAccessor tod0approach_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field tod0approach.
        ///</summary>
        public unsafe DateTimeAccessor tod0approach
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);}tod0approach_Accessor_Field.m_ptr = targetPtr;
                tod0approach_Accessor_Field.m_cellId = this.m_cellId;
                return tod0approach_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                tod0approach_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);}                Memory.Copy(value.m_ptr, targetPtr, 8); 
            }
        }
        DateTimeAccessor tod1press_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field tod1press.
        ///</summary>
        public unsafe DateTimeAccessor tod1press
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 8;
}tod1press_Accessor_Field.m_ptr = targetPtr;
                tod1press_Accessor_Field.m_cellId = this.m_cellId;
                return tod1press_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                tod1press_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 8;
}                Memory.Copy(value.m_ptr, targetPtr, 8); 
            }
        }
        DateTimeAccessor tod2sustain_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field tod2sustain.
        ///</summary>
        public unsafe DateTimeAccessor tod2sustain
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 16;
}tod2sustain_Accessor_Field.m_ptr = targetPtr;
                tod2sustain_Accessor_Field.m_cellId = this.m_cellId;
                return tod2sustain_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                tod2sustain_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 16;
}                Memory.Copy(value.m_ptr, targetPtr, 8); 
            }
        }
        DateTimeAccessor tod3release_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field tod3release.
        ///</summary>
        public unsafe DateTimeAccessor tod3release
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 24;
}tod3release_Accessor_Field.m_ptr = targetPtr;
                tod3release_Accessor_Field.m_cellId = this.m_cellId;
                return tod3release_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                tod3release_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 24;
}                Memory.Copy(value.m_ptr, targetPtr, 8); 
            }
        }
        DateTimeAccessor tod4recovery_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field tod4recovery.
        ///</summary>
        public unsafe DateTimeAccessor tod4recovery
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 32;
}tod4recovery_Accessor_Field.m_ptr = targetPtr;
                tod4recovery_Accessor_Field.m_cellId = this.m_cellId;
                return tod4recovery_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                tod4recovery_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 32;
}                Memory.Copy(value.m_ptr, targetPtr, 8); 
            }
        }
        DateTimeAccessor tod5finish_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field tod5finish.
        ///</summary>
        public unsafe DateTimeAccessor tod5finish
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 40;
}tod5finish_Accessor_Field.m_ptr = targetPtr;
                tod5finish_Accessor_Field.m_cellId = this.m_cellId;
                return tod5finish_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                tod5finish_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 40;
}                Memory.Copy(value.m_ptr, targetPtr, 8); 
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t0ms.
        ///</summary>
        public unsafe int t0ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 48;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 48;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t1ms.
        ///</summary>
        public unsafe int t1ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 52;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 52;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t2ms.
        ///</summary>
        public unsafe int t2ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 56;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 56;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t3ms.
        ///</summary>
        public unsafe int t3ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 60;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 60;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t4ms.
        ///</summary>
        public unsafe int t4ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 64;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 64;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t5ms.
        ///</summary>
        public unsafe int t5ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 68;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 68;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d1ms.
        ///</summary>
        public unsafe int d1ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 72;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 72;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d2ms.
        ///</summary>
        public unsafe int d2ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 76;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 76;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d3ms.
        ///</summary>
        public unsafe int d3ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 80;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 80;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d4ms.
        ///</summary>
        public unsafe int d4ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 84;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 84;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d5ms.
        ///</summary>
        public unsafe int d5ms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 88;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 88;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d1s.
        ///</summary>
        public unsafe int d1s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 92;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 92;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d2s.
        ///</summary>
        public unsafe int d2s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 96;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 96;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d3s.
        ///</summary>
        public unsafe int d3s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 100;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 100;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d4s.
        ///</summary>
        public unsafe int d4s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 104;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 104;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field d5s.
        ///</summary>
        public unsafe int d5s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 108;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 108;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t0s.
        ///</summary>
        public unsafe int t0s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 112;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 112;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t1s.
        ///</summary>
        public unsafe int t1s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 116;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 116;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t2s.
        ///</summary>
        public unsafe int t2s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 120;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 120;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t3s.
        ///</summary>
        public unsafe int t3s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 124;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 124;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t4s.
        ///</summary>
        public unsafe int t4s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 128;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 128;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field t5s.
        ///</summary>
        public unsafe int t5s
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 132;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 132;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field peak.
        ///</summary>
        public unsafe int peak
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 136;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 136;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field medianms.
        ///</summary>
        public unsafe int medianms
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 140;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 140;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field medians.
        ///</summary>
        public unsafe int medians
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 144;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 144;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field coverage.
        ///</summary>
        public unsafe int coverage
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 148;
}
                return *(int*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 148;
}                *(int*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field tongue.
        ///</summary>
        public unsafe bool tongue
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 152;
}
                return *(bool*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 152;
}                *(bool*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field targetbodypart.
        ///</summary>
        public unsafe BTTNFEBodyPart targetbodypart
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 153;
}
                return *(BTTNFEBodyPart*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 153;
}                *(BTTNFEBodyPart*)targetPtr = value;
            }
        }
        
        ///<summary>
        ///Provides in-place access to the object field actualbodypart.
        ///</summary>
        public unsafe BTTNFEBodyPart actualbodypart
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 154;
}
                return *(BTTNFEBodyPart*)(targetPtr);
                
            }
            set
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 154;
}                *(BTTNFEBodyPart*)targetPtr = value;
            }
        }
        intArray_150 d1approachcurve_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d1approachcurve.
        ///</summary>
        public unsafe intArray_150 d1approachcurve
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 155;
}d1approachcurve_Accessor_Field.m_ptr = targetPtr;
                d1approachcurve_Accessor_Field.m_cellId = this.m_cellId;
                return d1approachcurve_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d1approachcurve_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 155;
}                Memory.Copy(value.m_ptr, targetPtr, 600); 
            }
        }
        intArray_150 d2presscurve_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d2presscurve.
        ///</summary>
        public unsafe intArray_150 d2presscurve
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 755;
}d2presscurve_Accessor_Field.m_ptr = targetPtr;
                d2presscurve_Accessor_Field.m_cellId = this.m_cellId;
                return d2presscurve_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d2presscurve_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 755;
}                Memory.Copy(value.m_ptr, targetPtr, 600); 
            }
        }
        intArray_150 d3sustaincurve_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d3sustaincurve.
        ///</summary>
        public unsafe intArray_150 d3sustaincurve
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 1355;
}d3sustaincurve_Accessor_Field.m_ptr = targetPtr;
                d3sustaincurve_Accessor_Field.m_cellId = this.m_cellId;
                return d3sustaincurve_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d3sustaincurve_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 1355;
}                Memory.Copy(value.m_ptr, targetPtr, 600); 
            }
        }
        intArray_150 d4releasecurve_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d4releasecurve.
        ///</summary>
        public unsafe intArray_150 d4releasecurve
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 1955;
}d4releasecurve_Accessor_Field.m_ptr = targetPtr;
                d4releasecurve_Accessor_Field.m_cellId = this.m_cellId;
                return d4releasecurve_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d4releasecurve_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 1955;
}                Memory.Copy(value.m_ptr, targetPtr, 600); 
            }
        }
        intArray_150 d5recoverycurve_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d5recoverycurve.
        ///</summary>
        public unsafe intArray_150 d5recoverycurve
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 2555;
}d5recoverycurve_Accessor_Field.m_ptr = targetPtr;
                d5recoverycurve_Accessor_Field.m_cellId = this.m_cellId;
                return d5recoverycurve_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d5recoverycurve_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 2555;
}                Memory.Copy(value.m_ptr, targetPtr, 600); 
            }
        }
        StringAccessor d1approachpng64_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d1approachpng64.
        ///</summary>
        public unsafe StringAccessor d1approachpng64
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
}d1approachpng64_Accessor_Field.m_ptr = targetPtr + 4;
                d1approachpng64_Accessor_Field.m_cellId = this.m_cellId;
                return d1approachpng64_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d1approachpng64_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != d1approachpng64_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    d1approachpng64_Accessor_Field.m_ptr = d1approachpng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, d1approachpng64_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        d1approachpng64_Accessor_Field.m_ptr = d1approachpng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, d1approachpng64_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        StringAccessor d2presspng64_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d2presspng64.
        ///</summary>
        public unsafe StringAccessor d2presspng64
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);}d2presspng64_Accessor_Field.m_ptr = targetPtr + 4;
                d2presspng64_Accessor_Field.m_cellId = this.m_cellId;
                return d2presspng64_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d2presspng64_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != d2presspng64_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    d2presspng64_Accessor_Field.m_ptr = d2presspng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, d2presspng64_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        d2presspng64_Accessor_Field.m_ptr = d2presspng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, d2presspng64_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        StringAccessor d3sustainpng64_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d3sustainpng64.
        ///</summary>
        public unsafe StringAccessor d3sustainpng64
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}d3sustainpng64_Accessor_Field.m_ptr = targetPtr + 4;
                d3sustainpng64_Accessor_Field.m_cellId = this.m_cellId;
                return d3sustainpng64_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d3sustainpng64_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != d3sustainpng64_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    d3sustainpng64_Accessor_Field.m_ptr = d3sustainpng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, d3sustainpng64_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        d3sustainpng64_Accessor_Field.m_ptr = d3sustainpng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, d3sustainpng64_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        StringAccessor d4releasepng64_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d4releasepng64.
        ///</summary>
        public unsafe StringAccessor d4releasepng64
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}d4releasepng64_Accessor_Field.m_ptr = targetPtr + 4;
                d4releasepng64_Accessor_Field.m_cellId = this.m_cellId;
                return d4releasepng64_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d4releasepng64_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != d4releasepng64_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    d4releasepng64_Accessor_Field.m_ptr = d4releasepng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, d4releasepng64_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        d4releasepng64_Accessor_Field.m_ptr = d4releasepng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, d4releasepng64_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        StringAccessor d5recoverypng64_Accessor_Field;
        
        ///<summary>
        ///Provides in-place access to the object field d5recoverypng64.
        ///</summary>
        public unsafe StringAccessor d5recoverypng64
        {
            get
            {
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}d5recoverypng64_Accessor_Field.m_ptr = targetPtr + 4;
                d5recoverypng64_Accessor_Field.m_cellId = this.m_cellId;
                return d5recoverypng64_Accessor_Field;
                
            }
            set
            {
                
                if ((object)value == null) throw new ArgumentNullException("The assigned variable is null.");
                d5recoverypng64_Accessor_Field.m_cellId = this.m_cellId;
                
                byte* targetPtr = m_ptr;
                {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
                int length = *(int*)(value.m_ptr - 4);
                int oldlength = *(int*)targetPtr;
                if (value.m_cellId != d5recoverypng64_Accessor_Field.m_cellId)
                {
                    //if not in the same Cell
                    d5recoverypng64_Accessor_Field.m_ptr = d5recoverypng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                    Memory.Copy(value.m_ptr - 4, d5recoverypng64_Accessor_Field.m_ptr, length + 4);
                }
                else
                {
                    byte[] tmpcell = new byte[length + 4];
                    fixed (byte* tmpcellptr = tmpcell)
                    {                        
                        Memory.Copy(value.m_ptr - 4, tmpcellptr, length + 4);
                        d5recoverypng64_Accessor_Field.m_ptr = d5recoverypng64_Accessor_Field.ResizeFunction(targetPtr, 0, length - oldlength);
                        Memory.Copy(tmpcellptr, d5recoverypng64_Accessor_Field.m_ptr, length + 4);
                    }
                }

            }
        }
        
        public static unsafe implicit operator BTTNFE_N4K_Claims(BTTNFE_N4K_Claims_Accessor accessor)
        {
            
            return new BTTNFE_N4K_Claims(
                
                        accessor.timezoneid,
                        accessor.tod0approach,
                        accessor.tod1press,
                        accessor.tod2sustain,
                        accessor.tod3release,
                        accessor.tod4recovery,
                        accessor.tod5finish,
                        accessor.t0ms,
                        accessor.t1ms,
                        accessor.t2ms,
                        accessor.t3ms,
                        accessor.t4ms,
                        accessor.t5ms,
                        accessor.d1ms,
                        accessor.d2ms,
                        accessor.d3ms,
                        accessor.d4ms,
                        accessor.d5ms,
                        accessor.d1s,
                        accessor.d2s,
                        accessor.d3s,
                        accessor.d4s,
                        accessor.d5s,
                        accessor.t0s,
                        accessor.t1s,
                        accessor.t2s,
                        accessor.t3s,
                        accessor.t4s,
                        accessor.t5s,
                        accessor.peak,
                        accessor.medianms,
                        accessor.medians,
                        accessor.coverage,
                        accessor.tongue,
                        accessor.targetbodypart,
                        accessor.actualbodypart,
                        accessor.d1approachcurve,
                        accessor.d2presscurve,
                        accessor.d3sustaincurve,
                        accessor.d4releasecurve,
                        accessor.d5recoverycurve,
                        accessor.d1approachpng64,
                        accessor.d2presspng64,
                        accessor.d3sustainpng64,
                        accessor.d4releasepng64,
                        accessor.d5recoverypng64
                );
        }
        
        public unsafe static implicit operator BTTNFE_N4K_Claims_Accessor(BTTNFE_N4K_Claims field)
        {
            byte* targetPtr = null;
            
            {

        if(field.timezoneid!= null)
        {
            int strlen_2 = field.timezoneid.Length * 2;
            targetPtr += strlen_2+sizeof(int);
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

        if(field.d1approachpng64!= null)
        {
            int strlen_2 = field.d1approachpng64.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.d2presspng64!= null)
        {
            int strlen_2 = field.d2presspng64.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.d3sustainpng64!= null)
        {
            int strlen_2 = field.d3sustainpng64.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.d4releasepng64!= null)
        {
            int strlen_2 = field.d4releasepng64.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

        if(field.d5recoverypng64!= null)
        {
            int strlen_2 = field.d5recoverypng64.Length * 2;
            targetPtr += strlen_2+sizeof(int);
        }else
        {
            targetPtr += sizeof(int);
        }

            }
            byte* tmpcellptr = BufferAllocator.AllocBuffer((int)targetPtr);
            Memory.memset(tmpcellptr, 0, (ulong)targetPtr);
            targetPtr = tmpcellptr;
            
            {

        if(field.timezoneid!= null)
        {
            int strlen_2 = field.timezoneid.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.timezoneid)
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
            *(long*)targetPtr = field.tod0approach.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.tod1press.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.tod2sustain.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.tod3release.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.tod4recovery.ToBinary();
            targetPtr += 8;
        }

        {
            *(long*)targetPtr = field.tod5finish.ToBinary();
            targetPtr += 8;
        }
            *(int*)targetPtr = field.t0ms;
            targetPtr += 4;
            *(int*)targetPtr = field.t1ms;
            targetPtr += 4;
            *(int*)targetPtr = field.t2ms;
            targetPtr += 4;
            *(int*)targetPtr = field.t3ms;
            targetPtr += 4;
            *(int*)targetPtr = field.t4ms;
            targetPtr += 4;
            *(int*)targetPtr = field.t5ms;
            targetPtr += 4;
            *(int*)targetPtr = field.d1ms;
            targetPtr += 4;
            *(int*)targetPtr = field.d2ms;
            targetPtr += 4;
            *(int*)targetPtr = field.d3ms;
            targetPtr += 4;
            *(int*)targetPtr = field.d4ms;
            targetPtr += 4;
            *(int*)targetPtr = field.d5ms;
            targetPtr += 4;
            *(int*)targetPtr = field.d1s;
            targetPtr += 4;
            *(int*)targetPtr = field.d2s;
            targetPtr += 4;
            *(int*)targetPtr = field.d3s;
            targetPtr += 4;
            *(int*)targetPtr = field.d4s;
            targetPtr += 4;
            *(int*)targetPtr = field.d5s;
            targetPtr += 4;
            *(int*)targetPtr = field.t0s;
            targetPtr += 4;
            *(int*)targetPtr = field.t1s;
            targetPtr += 4;
            *(int*)targetPtr = field.t2s;
            targetPtr += 4;
            *(int*)targetPtr = field.t3s;
            targetPtr += 4;
            *(int*)targetPtr = field.t4s;
            targetPtr += 4;
            *(int*)targetPtr = field.t5s;
            targetPtr += 4;
            *(int*)targetPtr = field.peak;
            targetPtr += 4;
            *(int*)targetPtr = field.medianms;
            targetPtr += 4;
            *(int*)targetPtr = field.medians;
            targetPtr += 4;
            *(int*)targetPtr = field.coverage;
            targetPtr += 4;
            *(bool*)targetPtr = field.tongue;
            targetPtr += 1;
            *(BTTNFEBodyPart*)targetPtr = field.targetbodypart;
            targetPtr += 1;
            *(BTTNFEBodyPart*)targetPtr = field.actualbodypart;
            targetPtr += 1;
            if(field.d1approachcurve!= null){
                if(field.d1approachcurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.d1approachcurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_2 = field.d1approachcurve)
                   Memory.memcpy(targetPtr, storedPtr_2, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.d2presscurve!= null){
                if(field.d2presscurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.d2presscurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_2 = field.d2presscurve)
                   Memory.memcpy(targetPtr, storedPtr_2, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.d3sustaincurve!= null){
                if(field.d3sustaincurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.d3sustaincurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_2 = field.d3sustaincurve)
                   Memory.memcpy(targetPtr, storedPtr_2, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.d4releasecurve!= null){
                if(field.d4releasecurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.d4releasecurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_2 = field.d4releasecurve)
                   Memory.memcpy(targetPtr, storedPtr_2, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;
            if(field.d5recoverycurve!= null){
                if(field.d5recoverycurve.Rank != 1) throw new IndexOutOfRangeException("The assigned array'storage Rank mismatch.");
                if(field.d5recoverycurve.GetLength(0) != 150) throw new IndexOutOfRangeException("The assigned array'storage dimension mismatch.");
               fixed(int* storedPtr_2 = field.d5recoverycurve)
                   Memory.memcpy(targetPtr, storedPtr_2, (ulong)(600));
            } else {
                Memory.memset(targetPtr, 0, (ulong)(600));
            }
            targetPtr += 600;

        if(field.d1approachpng64!= null)
        {
            int strlen_2 = field.d1approachpng64.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.d1approachpng64)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.d2presspng64!= null)
        {
            int strlen_2 = field.d2presspng64.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.d2presspng64)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.d3sustainpng64!= null)
        {
            int strlen_2 = field.d3sustainpng64.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.d3sustainpng64)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.d4releasepng64!= null)
        {
            int strlen_2 = field.d4releasepng64.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.d4releasepng64)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

        if(field.d5recoverypng64!= null)
        {
            int strlen_2 = field.d5recoverypng64.Length * 2;
            *(int*)targetPtr = strlen_2;
            targetPtr += sizeof(int);
            fixed(char* pstr_2 = field.d5recoverypng64)
            {
                Memory.Copy(pstr_2, targetPtr, strlen_2);
                targetPtr += strlen_2;
            }
        }else
        {
            *(int*)targetPtr = 0;
            targetPtr += sizeof(int);
        }

            }BTTNFE_N4K_Claims_Accessor ret;
            
            ret = new BTTNFE_N4K_Claims_Accessor(tmpcellptr, null);
            
            return ret;
        }
        
        public static bool operator ==(BTTNFE_N4K_Claims_Accessor a, BTTNFE_N4K_Claims_Accessor b)
        {
            if (ReferenceEquals(a, b))
                return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;
            if (a.m_ptr == b.m_ptr) return true;
            byte* targetPtr = a.m_ptr;
            {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
            int lengthA = (int)(targetPtr - a.m_ptr);
            targetPtr = b.m_ptr;
            {targetPtr += *(int*)targetPtr + sizeof(int);            targetPtr += 3155;
targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);targetPtr += *(int*)targetPtr + sizeof(int);}
            int lengthB = (int)(targetPtr - b.m_ptr);
            if(lengthA != lengthB) return false;
            return Memory.Compare(a.m_ptr,b.m_ptr,lengthA);
        }
        public static bool operator != (BTTNFE_N4K_Claims_Accessor a, BTTNFE_N4K_Claims_Accessor b)
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
