#pragma warning disable 162,168,649,660,661,1522

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Trinity;
using Trinity.Storage;
using Trinity.TSL;
using Trinity.TSL.Lib;
namespace BTTN4KNFE
{
    class Throw
    {
        
        internal static void parse_bool(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into bool.");
        }
        internal static void incompatible_with_bool()
        {
            throw new DataTypeIncompatibleException("Data type 'bool' not compatible with the target field.");
        }
        
        internal static void parse_int(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into int.");
        }
        internal static void incompatible_with_int()
        {
            throw new DataTypeIncompatibleException("Data type 'int' not compatible with the target field.");
        }
        
        internal static void parse_long(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into long.");
        }
        internal static void incompatible_with_long()
        {
            throw new DataTypeIncompatibleException("Data type 'long' not compatible with the target field.");
        }
        
        internal static void parse_DateTime(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into DateTime.");
        }
        internal static void incompatible_with_DateTime()
        {
            throw new DataTypeIncompatibleException("Data type 'DateTime' not compatible with the target field.");
        }
        
        internal static void parse_string(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into string.");
        }
        internal static void incompatible_with_string()
        {
            throw new DataTypeIncompatibleException("Data type 'string' not compatible with the target field.");
        }
        
        internal static void parse_int_Array_150(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into int[].");
        }
        internal static void incompatible_with_int_Array_150()
        {
            throw new DataTypeIncompatibleException("Data type 'int[]' not compatible with the target field.");
        }
        
        internal static void parse_List_long(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into List<long>.");
        }
        internal static void incompatible_with_List_long()
        {
            throw new DataTypeIncompatibleException("Data type 'List<long>' not compatible with the target field.");
        }
        
        internal static void parse_List_string(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into List<string>.");
        }
        internal static void incompatible_with_List_string()
        {
            throw new DataTypeIncompatibleException("Data type 'List<string>' not compatible with the target field.");
        }
        
        internal static void parse_List_BTTKeyValuePair(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into List<BTTKeyValuePair>.");
        }
        internal static void incompatible_with_List_BTTKeyValuePair()
        {
            throw new DataTypeIncompatibleException("Data type 'List<BTTKeyValuePair>' not compatible with the target field.");
        }
        
        internal static void parse_BTTClaim(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTClaim.");
        }
        internal static void incompatible_with_BTTClaim()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTClaim' not compatible with the target field.");
        }
        
        internal static void parse_BTTEncryptedClaims(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTEncryptedClaims.");
        }
        internal static void incompatible_with_BTTEncryptedClaims()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTEncryptedClaims' not compatible with the target field.");
        }
        
        internal static void parse_BTTGenericCredential_Envelope(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTGenericCredential_Envelope.");
        }
        internal static void incompatible_with_BTTGenericCredential_Envelope()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTGenericCredential_Envelope' not compatible with the target field.");
        }
        
        internal static void parse_BTTGenericCredential_EnvelopeContent(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTGenericCredential_EnvelopeContent.");
        }
        internal static void incompatible_with_BTTGenericCredential_EnvelopeContent()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTGenericCredential_EnvelopeContent' not compatible with the target field.");
        }
        
        internal static void parse_BTTGenericCredential_EnvelopeSeal(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTGenericCredential_EnvelopeSeal.");
        }
        internal static void incompatible_with_BTTGenericCredential_EnvelopeSeal()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTGenericCredential_EnvelopeSeal' not compatible with the target field.");
        }
        
        internal static void parse_BTTGenericCredential_PackingLabel(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTGenericCredential_PackingLabel.");
        }
        internal static void incompatible_with_BTTGenericCredential_PackingLabel()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTGenericCredential_PackingLabel' not compatible with the target field.");
        }
        
        internal static void parse_BTTKeyValuePair(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTKeyValuePair.");
        }
        internal static void incompatible_with_BTTKeyValuePair()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTKeyValuePair' not compatible with the target field.");
        }
        
        internal static void parse_BTTNFE_N4K_Claims(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTNFE_N4K_Claims.");
        }
        internal static void incompatible_with_BTTNFE_N4K_Claims()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTNFE_N4K_Claims' not compatible with the target field.");
        }
        
        internal static void parse_BTTNFE_N4K_Envelope(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTNFE_N4K_Envelope.");
        }
        internal static void incompatible_with_BTTNFE_N4K_Envelope()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTNFE_N4K_Envelope' not compatible with the target field.");
        }
        
        internal static void parse_BTTNFE_N4K_EnvelopeContent(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTNFE_N4K_EnvelopeContent.");
        }
        internal static void incompatible_with_BTTNFE_N4K_EnvelopeContent()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTNFE_N4K_EnvelopeContent' not compatible with the target field.");
        }
        
        internal static void parse_BTTNFE_N4K_SealedEnvelope(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTNFE_N4K_SealedEnvelope.");
        }
        internal static void incompatible_with_BTTNFE_N4K_SealedEnvelope()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTNFE_N4K_SealedEnvelope' not compatible with the target field.");
        }
        
        internal static void parse_BTTVerifiableCredential_SealedEnvelope(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTVerifiableCredential_SealedEnvelope.");
        }
        internal static void incompatible_with_BTTVerifiableCredential_SealedEnvelope()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTVerifiableCredential_SealedEnvelope' not compatible with the target field.");
        }
        
        internal static void parse_BTTEncryptionFlag(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTEncryptionFlag.");
        }
        internal static void incompatible_with_BTTEncryptionFlag()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTEncryptionFlag' not compatible with the target field.");
        }
        
        internal static void parse_BTTGenericCredentialType(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTGenericCredentialType.");
        }
        internal static void incompatible_with_BTTGenericCredentialType()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTGenericCredentialType' not compatible with the target field.");
        }
        
        internal static void parse_BTTNFEBodyPart(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTNFEBodyPart.");
        }
        internal static void incompatible_with_BTTNFEBodyPart()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTNFEBodyPart' not compatible with the target field.");
        }
        
        internal static void parse_BTTTrustLevel(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTTrustLevel.");
        }
        internal static void incompatible_with_BTTTrustLevel()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTTrustLevel' not compatible with the target field.");
        }
        
        internal static void parse_List_List_BTTKeyValuePair(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into List<List<BTTKeyValuePair>>.");
        }
        internal static void incompatible_with_List_List_BTTKeyValuePair()
        {
            throw new DataTypeIncompatibleException("Data type 'List<List<BTTKeyValuePair>>' not compatible with the target field.");
        }
        
        internal static void parse_List_BTTClaim(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into List<BTTClaim>.");
        }
        internal static void incompatible_with_List_BTTClaim()
        {
            throw new DataTypeIncompatibleException("Data type 'List<BTTClaim>' not compatible with the target field.");
        }
        
        internal static void parse_BTTEncryptedClaims_nullable(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTEncryptedClaims?.");
        }
        internal static void incompatible_with_BTTEncryptedClaims_nullable()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTEncryptedClaims?' not compatible with the target field.");
        }
        
        internal static void parse_BTTNFE_N4K_Claims_nullable(string value)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into BTTNFE_N4K_Claims?.");
        }
        internal static void incompatible_with_BTTNFE_N4K_Claims_nullable()
        {
            throw new DataTypeIncompatibleException("Data type 'BTTNFE_N4K_Claims?' not compatible with the target field.");
        }
        
        internal static void data_type_incompatible_with_list(string type)
        {
            throw new DataTypeIncompatibleException("Data type '" + type + "' not compatible with the target list.");
        }
        internal static void data_type_incompatible_with_field(string type)
        {
            throw new DataTypeIncompatibleException("Data type '" + type + "' not compatible with the target field.");
        }
        internal static void target__field_not_list()
        {
            throw new DataTypeIncompatibleException("Target field is not a List, value or a string, cannot perform append operation.");
        }
        internal static void list_incompatible_list(string type)
        {
            throw new DataTypeIncompatibleException("List type '" + type + "' not compatible with the target list.");
        }
        internal static void incompatible_with_cell()
        {
            throw new DataTypeIncompatibleException("Data type incompatible with the cell.");
        }
        internal static void array_dimension_size_mismatch(string type)
        {
            throw new ArgumentException(type + ": Array dimension size mismatch.");
        }
        internal static void invalid_cell_type()
        {
            throw new ArgumentException("Invalid cell type name. If you want a new cell type, please define it in your TSL.");
        }
        internal static void undefined_field()
        {
            throw new ArgumentException("Undefined field.");
        }
        
        internal static void member_access_on_non_struct__field(string field_name_string)
        {
            throw new DataTypeIncompatibleException("Cannot apply member access method on a non-struct field'" + field_name_string + "'.");
        }
        internal static void cell_not_found()
        {
            throw new CellNotFoundException("The cell is not found.");
        }
        internal static void cell_not_found(long cellId)
        {
            throw new CellNotFoundException("The cell with id = " + cellId + " not found.");
        }
        internal static void wrong_cell_type()
        {
            throw new CellTypeNotMatchException("Cell type mismatched.");
        }
        internal static unsafe void cannot_parse(string value, string type_str)
        {
            throw new ArgumentException("Cannot parse \""+value+"\" into " + type_str + ".");
        }
        internal static unsafe byte* invalid_resize_on_fixed_struct()
        {
            throw new InvalidOperationException("Invalid resize operation on a fixed struct.");
        }
    }
}

#pragma warning restore 162,168,649,660,661,1522
