
using MsgSchema;
using Org.SbeTool.Sbe.Dll;

namespace FXbox.Communication.Messages.Parsers
{
    public static class MessageHeaderParser
    {
        
        public const int BUFFER_OFFSET = 0;
        public const int MSG_VERSION = 0;
        
        public static void Encode(
            DirectBuffer buffer, 
            MessageHeader header, 
            ushort blockLength, 
            ushort schemaId, 
            ushort templateId, 
            ushort schemaVersion)
        {
            header.Wrap(buffer, BUFFER_OFFSET, MSG_VERSION);
            header.BlockLength = blockLength;
            header.SchemaId = schemaId;
            header.TemplateId = templateId;
            header.Version = schemaVersion;
        }

        public static void Decode(DirectBuffer buffer, MessageHeader header)
        {
            header.Wrap(buffer, BUFFER_OFFSET, MSG_VERSION);
        }
        
        public static int GetMsgSchemaId(byte[] buffer)
        {
            var messageHeader = new MessageHeader();
            var directBuffer = new DirectBuffer(buffer);
            var bufferOffset = 0;
            messageHeader.Wrap(directBuffer, bufferOffset, 0);
            return messageHeader.SchemaId;
        }

        public static int GetMsgTemplateId(byte[] buffer)
        {
            var messageHeader = new MessageHeader();
            var directBuffer = new DirectBuffer(buffer);
            var bufferOffset = 0;
            messageHeader.Wrap(directBuffer, bufferOffset, 0);
            return messageHeader.TemplateId;
        }
    }
}