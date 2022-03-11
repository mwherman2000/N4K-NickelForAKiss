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
    /// Represents the enum type BTTN4KBodyPart defined in the TSL.
    /// </summary>
    public enum BTTN4KBodyPart : byte
    {
        Anywhere = 0,Lips = 1,UpperLip = 2,LowerLip = 3,Chin = 4,Forehead = 5,Hair = 6,LeftEarLobe = 7,LeftCheek = 8,LeftNeck = 9,RightEarLobe = 10,RightCheek = 11,RightNeck = 12,HeadOther = 13,LeftShoulder = 14,LeftChest = 15,LeftAbdomen = 16,LeftHandBack = 17,LeftHandPalm = 18,LeftHandFingers = 19,RightShoulder = 20,RightChest = 21,RightAbdomen = 22,RightHandBack = 23,RightHandPalm = 24,RightHandFingers = 25,LeftUpperBodyOther = 26,RightUpperBodyOther = 27,LeftThigh = 28,RightThigh = 29,LeftGlutimus = 30,RightGluimus = 31,LeftKnee = 32,RightKnee = 33,LeftCalf = 34,RightCalf = 35,LeftFoot = 36,RightFoot = 37,LeftToes = 38,RightToes = 39,LeftSole = 40,RightSole = 41,LeftLowerBodyOther = 42,RightLowerBodyOther = 43,Ring = 44,Shoe = 45,Bible = 46,Clothing = 47,Other = 48
    }
    
    /// <summary>
    /// Represents the enum type BTTN4KPurpose defined in the TSL.
    /// </summary>
    public enum BTTN4KPurpose : byte
    {
        Passionate = 0,Romantic = 1,Friendship = 2,Familial = 3,Social = 4
    }
    
    /// <summary>
    /// Represents the enum type BTTN4KType defined in the TSL.
    /// </summary>
    public enum BTTN4KType : byte
    {
        Brush = 0,Sniff = 1,Nuzzle = 2,Press = 3,Deep = 4,Lick = 5
    }
    
    /// <summary>
    /// Represents the enum type BTTN4KMood defined in the TSL.
    /// </summary>
    public enum BTTN4KMood : byte
    {
        Osculum = 0,Basium = 1,Savium = 2
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
