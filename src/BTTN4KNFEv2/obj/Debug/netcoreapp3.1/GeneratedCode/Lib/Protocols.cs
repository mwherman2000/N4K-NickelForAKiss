#pragma warning disable 162,168,649,660,661,1522
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Trinity;
using Trinity.TSL;
using Trinity.Core.Lib;
using Trinity.Network;
using Trinity.Network.Messaging;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using Trinity.Storage;
namespace BTTN4KNFE
{
    
    public abstract partial class BTTN4KLocalStorageAgentBase : TrinityServer
    {
        protected override void RegisterMessageHandler()
        {
            
            {
                
                MessageRegistry.RegisterMessageHandler((ushort)(ushort)global::BTTN4KNFE.TSL.TrinityServer.BTTN4KLocalStorageAgent.SynReqRspMessageType.SendNFEToLocalStorage, _SendNFEToLocalStorageHandler);
                
            }
            
            {
                
                MessageRegistry.RegisterMessageHandler((ushort)(ushort)global::BTTN4KNFE.TSL.TrinityServer.BTTN4KLocalStorageAgent.SynReqRspMessageType.GetNFELocalStorageCount, _GetNFELocalStorageCountHandler);
                
            }
            
            {
                
                MessageRegistry.RegisterMessageHandler((ushort)(ushort)global::BTTN4KNFE.TSL.TrinityServer.BTTN4KLocalStorageAgent.SynReqRspMessageType.GetNFEFromLocalStorage, _GetNFEFromLocalStorageHandler);
                
            }
            
            {
                
                MessageRegistry.RegisterMessageHandler((ushort)(ushort)global::BTTN4KNFE.TSL.TrinityServer.BTTN4KLocalStorageAgent.SynReqRspMessageType.GetNFEBatchFromLocalStorage, _GetNFEBatchFromLocalStorageHandler);
                
            }
            
        }
        
        private unsafe void _SendNFEToLocalStorageHandler(SynReqRspArgs args)
        {
            var rsp = new SendNFEResponseWriter();
            SendNFEToLocalStorageHandler(new SendNFERequestReader(args.Buffer, args.Offset), rsp);
            *(int*)(rsp.m_ptr - TrinityProtocol.MsgHeader) = rsp.Length + TrinityProtocol.TrinityMsgHeader;
            args.Response = new TrinityMessage(rsp.buffer, rsp.Length + TrinityProtocol.MsgHeader);
        }
        public abstract void SendNFEToLocalStorageHandler(SendNFERequestReader request, SendNFEResponseWriter response);
        
        private unsafe void _GetNFELocalStorageCountHandler(SynReqRspArgs args)
        {
            var rsp = new GetNFECountResponseWriter();
            GetNFELocalStorageCountHandler(new GetNFECountRequestReader(args.Buffer, args.Offset), rsp);
            *(int*)(rsp.m_ptr - TrinityProtocol.MsgHeader) = rsp.Length + TrinityProtocol.TrinityMsgHeader;
            args.Response = new TrinityMessage(rsp.buffer, rsp.Length + TrinityProtocol.MsgHeader);
        }
        public abstract void GetNFELocalStorageCountHandler(GetNFECountRequestReader request, GetNFECountResponseWriter response);
        
        private unsafe void _GetNFEFromLocalStorageHandler(SynReqRspArgs args)
        {
            var rsp = new GetNFEResponseWriter();
            GetNFEFromLocalStorageHandler(new GetNFERequestReader(args.Buffer, args.Offset), rsp);
            *(int*)(rsp.m_ptr - TrinityProtocol.MsgHeader) = rsp.Length + TrinityProtocol.TrinityMsgHeader;
            args.Response = new TrinityMessage(rsp.buffer, rsp.Length + TrinityProtocol.MsgHeader);
        }
        public abstract void GetNFEFromLocalStorageHandler(GetNFERequestReader request, GetNFEResponseWriter response);
        
        private unsafe void _GetNFEBatchFromLocalStorageHandler(SynReqRspArgs args)
        {
            var rsp = new GetNFEBatchResponseWriter();
            GetNFEBatchFromLocalStorageHandler(new GetNFEBatchRequestReader(args.Buffer, args.Offset), rsp);
            *(int*)(rsp.m_ptr - TrinityProtocol.MsgHeader) = rsp.Length + TrinityProtocol.TrinityMsgHeader;
            args.Response = new TrinityMessage(rsp.buffer, rsp.Length + TrinityProtocol.MsgHeader);
        }
        public abstract void GetNFEBatchFromLocalStorageHandler(GetNFEBatchRequestReader request, GetNFEBatchResponseWriter response);
        
    }
    
    namespace BTTN4KLocalStorageAgent
    {
        public static class MessagePassingExtension
        {
            
        #region prototype definition template variables
        
        #endregion
        
        public unsafe static SendNFEResponseReader SendNFEToLocalStorage(this Trinity.Storage.IMessagePassingEndpoint storage, SendNFERequestWriter msg)
        {
            byte* bufferPtr = msg.buffer;
            *(int*)(bufferPtr) = msg.Length + TrinityProtocol.TrinityMsgHeader;
            *(TrinityMessageType*)(bufferPtr + TrinityProtocol.MsgTypeOffset) = TrinityMessageType.SYNC_WITH_RSP ;
            *(ushort*)(bufferPtr + TrinityProtocol.MsgIdOffset) = (ushort)global::BTTN4KNFE.TSL.TrinityServer.BTTN4KLocalStorageAgent.SynReqRspMessageType.SendNFEToLocalStorage;
            TrinityResponse response;
            storage.SendMessage(bufferPtr, msg.Length + TrinityProtocol.MsgHeader, out response);
            return new SendNFEResponseReader(response.Buffer, response.Offset);
        }
        
        #region prototype definition template variables
        
        #endregion
        
        public unsafe static GetNFECountResponseReader GetNFELocalStorageCount(this Trinity.Storage.IMessagePassingEndpoint storage, GetNFECountRequestWriter msg)
        {
            byte* bufferPtr = msg.buffer;
            *(int*)(bufferPtr) = msg.Length + TrinityProtocol.TrinityMsgHeader;
            *(TrinityMessageType*)(bufferPtr + TrinityProtocol.MsgTypeOffset) = TrinityMessageType.SYNC_WITH_RSP ;
            *(ushort*)(bufferPtr + TrinityProtocol.MsgIdOffset) = (ushort)global::BTTN4KNFE.TSL.TrinityServer.BTTN4KLocalStorageAgent.SynReqRspMessageType.GetNFELocalStorageCount;
            TrinityResponse response;
            storage.SendMessage(bufferPtr, msg.Length + TrinityProtocol.MsgHeader, out response);
            return new GetNFECountResponseReader(response.Buffer, response.Offset);
        }
        
        #region prototype definition template variables
        
        #endregion
        
        public unsafe static GetNFEResponseReader GetNFEFromLocalStorage(this Trinity.Storage.IMessagePassingEndpoint storage, GetNFERequestWriter msg)
        {
            byte* bufferPtr = msg.buffer;
            *(int*)(bufferPtr) = msg.Length + TrinityProtocol.TrinityMsgHeader;
            *(TrinityMessageType*)(bufferPtr + TrinityProtocol.MsgTypeOffset) = TrinityMessageType.SYNC_WITH_RSP ;
            *(ushort*)(bufferPtr + TrinityProtocol.MsgIdOffset) = (ushort)global::BTTN4KNFE.TSL.TrinityServer.BTTN4KLocalStorageAgent.SynReqRspMessageType.GetNFEFromLocalStorage;
            TrinityResponse response;
            storage.SendMessage(bufferPtr, msg.Length + TrinityProtocol.MsgHeader, out response);
            return new GetNFEResponseReader(response.Buffer, response.Offset);
        }
        
        #region prototype definition template variables
        
        #endregion
        
        public unsafe static GetNFEBatchResponseReader GetNFEBatchFromLocalStorage(this Trinity.Storage.IMessagePassingEndpoint storage, GetNFEBatchRequestWriter msg)
        {
            byte* bufferPtr = msg.buffer;
            *(int*)(bufferPtr) = msg.Length + TrinityProtocol.TrinityMsgHeader;
            *(TrinityMessageType*)(bufferPtr + TrinityProtocol.MsgTypeOffset) = TrinityMessageType.SYNC_WITH_RSP ;
            *(ushort*)(bufferPtr + TrinityProtocol.MsgIdOffset) = (ushort)global::BTTN4KNFE.TSL.TrinityServer.BTTN4KLocalStorageAgent.SynReqRspMessageType.GetNFEBatchFromLocalStorage;
            TrinityResponse response;
            storage.SendMessage(bufferPtr, msg.Length + TrinityProtocol.MsgHeader, out response);
            return new GetNFEBatchResponseReader(response.Buffer, response.Offset);
        }
        
        }
    }
    
    #region Legacy
    public static class LegacyMessagePassingExtension
    {
        
        #region prototype definition template variables
        
        #endregion
        
        public unsafe static SendNFEResponseReader SendNFEToLocalStorageToBTTN4KLocalStorageAgent(this Trinity.Storage.MemoryCloud storage,  int partitionId, SendNFERequestWriter msg)
        {
            return BTTN4KLocalStorageAgent.MessagePassingExtension.SendNFEToLocalStorage(storage[partitionId], msg);
        }
        
        #region prototype definition template variables
        
        #endregion
        
        public unsafe static GetNFECountResponseReader GetNFELocalStorageCountToBTTN4KLocalStorageAgent(this Trinity.Storage.MemoryCloud storage,  int partitionId, GetNFECountRequestWriter msg)
        {
            return BTTN4KLocalStorageAgent.MessagePassingExtension.GetNFELocalStorageCount(storage[partitionId], msg);
        }
        
        #region prototype definition template variables
        
        #endregion
        
        public unsafe static GetNFEResponseReader GetNFEFromLocalStorageToBTTN4KLocalStorageAgent(this Trinity.Storage.MemoryCloud storage,  int partitionId, GetNFERequestWriter msg)
        {
            return BTTN4KLocalStorageAgent.MessagePassingExtension.GetNFEFromLocalStorage(storage[partitionId], msg);
        }
        
        #region prototype definition template variables
        
        #endregion
        
        public unsafe static GetNFEBatchResponseReader GetNFEBatchFromLocalStorageToBTTN4KLocalStorageAgent(this Trinity.Storage.MemoryCloud storage,  int partitionId, GetNFEBatchRequestWriter msg)
        {
            return BTTN4KLocalStorageAgent.MessagePassingExtension.GetNFEBatchFromLocalStorage(storage[partitionId], msg);
        }
        
    }
    
    #endregion
}

#pragma warning restore 162,168,649,660,661,1522
