#pragma warning disable 162,168,649,660,661,1522
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trinity;
using Trinity.TSL;
namespace BTTN4KNFE
{
    
    /// <summary>
    /// Represents the enum type BTTNFEBodyPart defined in the TSL.
    /// </summary>
    public enum BTTNFEBodyPart : byte
    {
        Anywhere = 0,Lips = 1,UpperLip = 2,LowerLip = 3,Chin = 4,Forehead = 5,LeftEarLobe = 6,LeftCheek = 7,LeftNeck = 8,RightEarLobe = 9,RightCheek = 10,RightNeck = 11,HeadOther = 12,LeftShoulder = 13,LeftChest = 14,LeftAbdomen = 15,LeftHandBack = 16,LeftHandPalm = 17,LeftHandFingers = 18,RightShoulder = 19,RightChest = 20,RightAbdomen = 21,RightHandBack = 22,RightHandPalm = 23,RightHandFingers = 24,LeftUpperBodyOther = 25,RightUpperBodyOther = 26,LeftThigh = 27,RightThigh = 28,LeftGlutimus = 29,RightGluimus = 30,LeftKnee = 31,RightKnee = 32,LeftCalf = 33,RightCalf = 34,LeftFoot = 35,RightFoot = 36,LeftToes = 37,RightToes = 38,LeftSole = 39,RightSole = 40,LeftLowerBodyOther = 41,RightUpperBodyOthe = 42
    }
    
    /// <summary>
    /// Represents the enum type BTTTrustLevel defined in the TSL.
    /// </summary>
    public enum BTTTrustLevel : byte
    {
        Undefined = 0,UnResolvable = 1,Unsigned = 2,HashedThumbprint = 3,SignedHashSignature = 4,Notarized = 5,CorruptSignatures = 6
    }
    
    /// <summary>
    /// Represents the enum type BTTEncryptionFlag defined in the TSL.
    /// </summary>
    public enum BTTEncryptionFlag : byte
    {
        NotEncrypted = 0,Encrypted = 1
    }
    
    /// <summary>
    /// Represents the enum type BTTGenericCredentialType defined in the TSL.
    /// </summary>
    public enum BTTGenericCredentialType : byte
    {
        GenericCredential = 0,UDIDDocument = 1,VerifiableCredential = 2,NotarizedCredential = 3,VerifiableCapabilityAuthorization = 4,MasterVerifiableCapabilityAuthorization = 5,ServerCertificate = 6,RevocationCertificate = 7,Object = 8,BlueToqueNfe = 9,BlueToqueDeed = 10,BlueToqueAgent = 11,BlueToqueProcess = 12,BlueToqueBizDoc = 13
    }
    
    /// <summary>
    /// Represents the enum type BTTServiceType defined in the TSL.
    /// </summary>
    public enum BTTServiceType : byte
    {
        Unknown = 0,ProcessingAgent = 1,StorageAgent = 2,VerifiableDataRegistryService = 3,DIDRegistryAgent = 4,SEPREgistryAgent = 5,RevocationListAgent = 6,SmartContractRegistryAgent = 7,KeyManagementAgent = 8,MasterKeyManagementAgent = 9,AuthenticationAgent = 10,AuthorivationAgent = 11,UDIDDocumentVerificationAgent = 12,StructuredCredentialVerificationAgent = 13
    }
    
}

#pragma warning restore 162,168,649,660,661,1522
