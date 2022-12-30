using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MsgSchema;
using Org.SbeTool.Sbe.Dll;

namespace FXbox.Communication.Messages.Parsers
{
    public class SbeMsgParser
    {
        private string _msgNamespace;
        public List<Type> MsgTypes;
        public List<object> MsgInstances;
        private DirectBuffer _buffer { get;}
        private MessageHeader _header { get; }
        
        private byte[] _data { get; }
        
        public SbeMsgParser()
        {
            _msgNamespace = "MsgSchema";
            MsgTypes = (from t in Assembly.GetExecutingAssembly().GetTypes()
                where t.IsClass && t.Namespace == _msgNamespace
                select t).ToList();

            _data = new byte[1024];
            _buffer = new DirectBuffer(_data);
            _header = new MessageHeader();
            _header.Wrap(_buffer,0,0);

            MsgInstances = new List<object>();
            foreach (var msgType in MsgTypes)
            {
                MsgInstances.Add(Activator.CreateInstance(msgType));
            }
            
            foreach (var msgInstance in MsgInstances)
            {
                var SchemaId = msgInstance.GetType().GetField("SchemaId");
                var TemplateId = msgInstance.GetType().GetField("TemplateId");
                if (SchemaId != null && TemplateId != null)
                {
                    var methodInfo = msgInstance.GetType().GetMethod("WrapForEncode");
                        methodInfo.Invoke(msgInstance, new object[] { _buffer, 0 } );
                }
            }
        }
        
        public string MsgToString(byte[] data)
        {
            var result = "SBE MESSAGE NOT FOUND IN TEMPLATES !!!";
            
            

            _buffer.Wrap(data);
            _header.Wrap(_buffer, 0, 0);

            foreach (var msgInstance in MsgInstances)
            {
                var SchemaId = msgInstance.GetType().GetField("SchemaId");
                var TemplateId = msgInstance.GetType().GetField("TemplateId");
                if (SchemaId != null && TemplateId != null)
                {
                    if (_header.SchemaId == (ushort)SchemaId.GetValue(msgInstance) && _header.TemplateId == (ushort)TemplateId.GetValue(msgInstance))
                    {
                        var methodInfo = msgInstance.GetType().GetMethod("WrapForDecode");
                        methodInfo.Invoke(msgInstance, new object[] { _buffer, MessageHeader.Size, _header.BlockLength, MessageHeader.SbeSchemaVersion } );
                        result = msgInstance.ToString();
                        break;
                    }
                }
            }
            return result;
        }
    }
}