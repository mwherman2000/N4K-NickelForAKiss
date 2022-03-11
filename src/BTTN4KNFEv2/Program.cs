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
using System.IO;

using Trinity;
using Trinity.Storage;
using System.Net.Http;

namespace BTTN4KNFE
{
    class NFELocalStorageAgentImplementation : LocalStorageAgentBase
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

        public override void SendNFEByIdToLocalStorageHandler(SendNFEByIdRequestReader request, SendNFEByIdResponseWriter response)
        {
            using (request)
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

        public override void SendNFEEnvelopeToStorageHandler(SendNFEEnvelopeRequest request, out SendNFEEnvelopeResponse response)
        {
            BTTNFE_N4K_SealedEnvelope nfeSealedEnvelope = request.sealedEnvelope;
            string json = nfeSealedEnvelope.ToString();
            Console.WriteLine("nfeSealedEnvelope:\n" + json);
            File.WriteAllText("c:\\temp\\nfeSealedEnvelope.json", json);

            response.rc = (int)TrinityErrorCode.E_SUCCESS;
        }
    }

    class Program
    {
        private const int MAX_METRIC = 150;

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
            nfeClaims.InitializeTimeline(0, BTTN4KType.Press, BTTN4KMood.Savium, BTTN4KPurpose.Romantic,
                tod0approach, tod1press, tod2sustain, tod3release, tod4recovery, tod5finish);

            N4KSyntheticPressureCurve synthcurve = 
                new N4KSyntheticPressureCurve(nfeClaims.d1ms, nfeClaims.d2ms, nfeClaims.d3ms, nfeClaims.d4ms, nfeClaims.d5ms);
            //Array.Copy(synthcurve.GetD1ApproachCurve(), nfeClaims.d1approachcurve = new int[150], nfeClaims.d1s);
            //Array.Copy(synthcurve.GetD2PressCurve(), nfeClaims.d2presscurve = new int[150], nfeClaims.d2s);
            //Array.Copy(synthcurve.GetD3SustainCurve(), nfeClaims.d3sustaincurve = new int[150], nfeClaims.d3s);
            //Array.Copy(synthcurve.GetD4ReleaseCurve(), nfeClaims.d4releasecurve = new int[150], nfeClaims.d4s);
            //Array.Copy(synthcurve.GetD5RecoveryCurve(), nfeClaims.d5recoverycurve = new int[150], nfeClaims.d5s);

            var apressure = synthcurve.GetD1ApproachCurve();
            nfeClaims.d1approachtime = new float[MAX_METRIC];
            nfeClaims.d1approachcurve = new float[MAX_METRIC];
            for (int t = 0; t < nfeClaims.d1s; t++)
            {
                nfeClaims.d1approachtime[t] = (float)(t * 0.1);
                nfeClaims.d1approachcurve[t] = (float)apressure[t];
            }

            var ppressure = synthcurve.GetD2PressCurve();
            nfeClaims.d2presstime = new float[MAX_METRIC];
            nfeClaims.d2presscurve = new float[MAX_METRIC];
            for (int t = 0; t < nfeClaims.d2s; t++)
            {
                nfeClaims.d2presstime[t] = (float)(t * 0.1);
                nfeClaims.d2presscurve[t] = (float)ppressure[t];
            }

            var spressure = synthcurve.GetD3SustainCurve();
            nfeClaims.d3sustaintime = new float[MAX_METRIC];
            nfeClaims.d3sustaincurve = new float[MAX_METRIC];
            for (int t = 0; t < nfeClaims.d3s; t++)
            {
                nfeClaims.d3sustaintime[t] = (float)(t * 0.1);
                nfeClaims.d3sustaincurve[t] = (float)spressure[t];
            }

            var rpressure = synthcurve.GetD4ReleaseCurve();
            nfeClaims.d4releasetime = new float[MAX_METRIC];
            nfeClaims.d4releasecurve = new float[MAX_METRIC];
            for (int t = 0; t < nfeClaims.d4s; t++)
            {
                nfeClaims.d4releasetime[t] = (float)(t * 0.1);
                nfeClaims.d4releasecurve[t] = (float)rpressure[t];
            }

            var vpressure = synthcurve.GetD5RecoveryCurve();
            nfeClaims.d5recoverytime = new float[MAX_METRIC];
            nfeClaims.d5recoverycurve = new float[MAX_METRIC];
            for (int t = 0; t < nfeClaims.d5s; t++)
            {
                nfeClaims.d5recoverytime[t] = (float)(t * 0.1);
                nfeClaims.d5recoverycurve[t] = (float)vpressure[t];
            }

            int pressCoverage = 0; foreach (int pressure in ppressure) pressCoverage += pressure;
            int sustainCoverage = 0; foreach (int pressure in spressure) sustainCoverage += pressure;
            int releaseCoverage = 0; foreach (int pressure in rpressure) releaseCoverage += pressure;
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

            string json = nfeCell.ToString();
            Console.WriteLine("nfeCell:\n" + json);
            File.WriteAllText("c:\\temp\\nfeCell.json", json);

            Global.LocalStorage.SaveBTTNFE_N4K_SealedEnvelope_Cell(nfeCell);

            TrinityConfig.HttpPort = 8080 + 1;
#pragma warning disable CS0612 // Type or member is obsolete
            TrinityConfig.ServerPort = 5304 + 1;
#pragma warning restore CS0612 // Type or member is obsolete
            var agent = new NFELocalStorageAgentImplementation();
            agent.Start();

            using (var httpClient = new HttpClient())
            {
                SendNFEEnvelopeRequest request = new SendNFEEnvelopeRequest(nfeSealedEnvelope);
                string agentUrl = "http://localhost:8081/SendNFEEnvelopeToStorage/";
                Console.WriteLine(">>>" + agentUrl);
                using (var requestMessage = new HttpRequestMessage(new HttpMethod("POST"), agentUrl))
                {
                    requestMessage.Headers.TryAddWithoutValidation("Accept", "application/json");
                    //string jsonRequest = JsonConvert.SerializeObject(request);
                    string jsonRequest = request.ToString();
                    requestMessage.Content = new StringContent(jsonRequest);
                    var task = httpClient.SendAsync(requestMessage);
                    task.Wait();
                    var result = task.Result;
                    string jsonResponse = result.Content.ReadAsStringAsync().Result;
                    Console.WriteLine(jsonResponse);
                    Console.WriteLine("Press Enter to continue...");
                    Console.ReadLine();
                }
            }

            agent.Stop();

            Console.WriteLine("Done.");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
            Global.Exit(0);
        }
    }
}

