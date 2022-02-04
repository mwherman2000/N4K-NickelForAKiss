// Graph Engine
// BlueToqueTools
// Trusted Digial Web Project
// Hyperonomy Digital Identity Lab
// Parallelspace Corporation
// (c) Copyright 2021-2022 Parallelspace Corporation. All Rights Reserved

//////////////////////////////////////////////////////////////////////////////
/// BlueToqueTools Common Types

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using Trinity;
using Trinity.Storage;

namespace BTTN4KNFE
{
    class NFELocalStorageAgentImplementation : BTTN4KLocalStorageAgentBase
    {
        private readonly long DIRECTORY_CELLID = 123456789;
        private static BTTN4KNFEDirectory Directory = new BTTN4KNFEDirectory(0, new List<long>());

        public NFELocalStorageAgentImplementation()
        {
            //Global.LocalStorage.LoadStorage();
            Global.LocalStorage.ResetStorage();
            if (Global.LocalStorage.Count() > 0)
            {
                Directory = Global.LocalStorage.LoadBTTN4KNFEDirectory(DIRECTORY_CELLID);
            }
            else
            {
                Global.LocalStorage.SaveBTTN4KNFEDirectory(DIRECTORY_CELLID, Directory);
                Global.LocalStorage.SaveStorage();
            }
        }

        public override void SendNFEToLocalStorageHandler(SendNFERequestReader request, SendNFEResponseWriter response)
        {
            if (Directory.ids.Contains(request.id))
            {
                // do nothing
            }
            else
            {
                Directory.ids.Add(request.id);
                Directory.count++;
                Global.LocalStorage.SaveBTTN4KNFEDirectory(DIRECTORY_CELLID, Directory);
                Global.LocalStorage.SaveStorage();
            }
        }

        public override void GetNFELocalStorageCountHandler(GetNFECountRequestReader request, GetNFECountResponseWriter response)
        {
            response.count = Global.LocalStorage.LoadBTTN4KNFEDirectory(DIRECTORY_CELLID).count;
            response.rc = (int)TrinityErrorCode.E_SUCCESS;
        }

        public override void GetNFEFromLocalStorageHandler(GetNFERequestReader request, GetNFEResponseWriter response)
        {
            throw new NotImplementedException();
        }

        public override void GetNFEBatchFromLocalStorageHandler(GetNFEBatchRequestReader request, GetNFEBatchResponseWriter response)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static readonly System.Reflection.Assembly assembly = typeof(Program).Assembly;

        static void Main(string[] args)
        {
            var streams = assembly.GetManifestResourceNames();
            byte[] res;
            int nBytes;
            using (var pngHappyFaceStream = assembly.GetManifestResourceStream("BTTN4KNFE.images.HappyFace.png"))
            {
                res = new byte[pngHappyFaceStream.Length];
                nBytes = pngHappyFaceStream.Read(res);
            }
            var happyFacepng64 = Convert.ToBase64String(res, 0, nBytes);

            DateTime tod0approach = DateTime.UtcNow; // always UTC
            DateTime tod1press = tod0approach.AddSeconds(3);
            DateTime tod2sustain = tod1press.AddSeconds(3);
            DateTime tod3release = tod2sustain.AddSeconds(5);
            DateTime tod4recovery = tod3release.AddSeconds(3);
            DateTime tod5finish = tod4recovery.AddSeconds(4);

            var nfeClaims = new BTTNFE_N4K_Claims();
            nfeClaims.InitializeTimeline(tod0approach, tod1press, tod2sustain, tod3release, tod4recovery, tod5finish);

            N4KSyntheticPressureCurve synthcurve = 
                new N4KSyntheticPressureCurve(nfeClaims.d1ms, nfeClaims.d2ms, nfeClaims.d3ms, nfeClaims.d4ms, nfeClaims.d5ms);
            Array.Copy(synthcurve.GetD1ApproachCurve(), nfeClaims.d1approachcurve = new int[150], nfeClaims.d1s); // KLUDGE possible overflow
            Array.Copy(synthcurve.GetD2PressCurve(), nfeClaims.d2presscurve = new int[150], nfeClaims.d2s);
            Array.Copy(synthcurve.GetD3SustainCurve(), nfeClaims.d3sustaincurve = new int[150], nfeClaims.d3s);
            Array.Copy(synthcurve.GetD4ReleaseCurve(), nfeClaims.d4releasecurve = new int[150], nfeClaims.d4s);
            Array.Copy(synthcurve.GetD5RecoveryCurve(), nfeClaims.d5recoverycurve = new int[150], nfeClaims.d5s);

            int pressCoverage = 0; foreach (int pressure in synthcurve.GetD2PressCurve()) pressCoverage += pressure;
            int sustainCoverage = 0; foreach (int pressure in synthcurve.GetD3SustainCurve()) sustainCoverage += pressure;
            int releaseCoverage = 0; foreach (int pressure in synthcurve.GetD4ReleaseCurve()) releaseCoverage += pressure;
            nfeClaims.coverage = pressCoverage + sustainCoverage + releaseCoverage;

            nfeClaims.d1approachpng64 = happyFacepng64;
            nfeClaims.d2presspng64 = happyFacepng64;
            nfeClaims.d3sustainpng64 = happyFacepng64;
            nfeClaims.d4releasepng64 = happyFacepng64;
            nfeClaims.d5recoverypng64 = happyFacepng64;

            //Console.WriteLine("nfeClaims:\n" + nfeClaims.ToString());

            string nfeUdid = "did:bluetoquenfe:" + Guid.NewGuid().ToString();
            string nfeCSUdid = nfeUdid;
            BTTNFE_N4K_EnvelopeContent nfeContent = new BTTNFE_N4K_EnvelopeContent(nfeUdid, BTTNFE_N4K_Claims.DefaultContext, nfeCSUdid, nfeClaims);

            BTTGenericCredential_PackingLabel nfeLabel = new BTTGenericCredential_PackingLabel(
                new List<string> { "Verifiable Credential", "Structured Credential", BTTGenericCredentialType.BlueToqueNfe.ToString() },
                BTTGenericCredentialType.BlueToqueNfe, 1, BTTTrustLevel.HashedThumbprint, BTTEncryptionFlag.NotEncrypted, 
                null, "N4K NFE Kiss", new List<string> { "An BTT N4K NFE Kiss Structured Credential" });
            BTTNFE_N4K_Envelope nfeEnvelope = new BTTNFE_N4K_Envelope(nfeUdid, nfeLabel, nfeContent);

            string nfeThumbprint64 = BTTNFE_N4K_Claims.ComputeHash64(nfeEnvelope.ToString());
            BTTGenericCredential_EnvelopeSeal nfeProof = new BTTGenericCredential_EnvelopeSeal(nfeThumbprint64, null, null, new List<string> { "SHA3-256 Hashed Thumbprint stored as Base64 string" });
            BTTNFE_N4K_SealedEnvelope nfeSealedEnvelope = new BTTNFE_N4K_SealedEnvelope(nfeEnvelope, nfeProof);

            BTTNFE_N4K_SealedEnvelope_Cell nfeCell = new BTTNFE_N4K_SealedEnvelope_Cell(nfeSealedEnvelope);

            Console.WriteLine("nfeCell:\n" + nfeCell.ToString());

            var agent = new NFELocalStorageAgentImplementation();
            agent.Start();

            Global.LocalStorage.SaveBTTNFE_N4K_SealedEnvelope_Cell(nfeCell);

            //var synReq = new MyMessageWriter(sn: 1);

            //Global.LocalStorage.SynPingToMyServer(0, synReq);

            //var asynReq = new MyMessageWriter(sn: 2);
            //Global.LocalStorage.AsynPingToMyServer(0, asynReq);

            //var synReqRsp = new MyMessageWriter(sn: 3);
            //Console.WriteLine("Response of EchoPing: {0}", Global.LocalStorage[0].SynEchoPing(synReqRsp).sn);

            Console.WriteLine("Done.");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
            Global.Exit(0);
        }
    }
}

