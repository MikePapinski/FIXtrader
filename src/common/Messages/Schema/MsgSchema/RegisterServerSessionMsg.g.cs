// <auto-generated>
//     Generated SBE (Simple Binary Encoding) message codec
// </auto-generated>

#pragma warning disable 1591 // disable warning on missing comments
using System;
using System.Text;
using Org.SbeTool.Sbe.Dll;

namespace MsgSchema
{
    /// <summary>
    /// Test the Cloud Gateway connections.
    /// </summary>
    public sealed partial class RegisterServerSessionMsg
    {
        public const ushort BlockLength = (ushort)2;
        public const ushort TemplateId = (ushort)6;
        public const ushort SchemaId = (ushort)6;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly RegisterServerSessionMsg _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public RegisterServerSessionMsg()
        {
            _parentMessage = this;
        }

        public void WrapForEncode(DirectBuffer buffer, int offset)
        {
            _buffer = buffer;
            _offset = offset;
            _actingBlockLength = BlockLength;
            _actingVersion = SchemaVersion;
            Limit = offset + _actingBlockLength;
        }

        public void WrapForEncodeAndApplyHeader(DirectBuffer buffer, int offset,  MessageHeader headerEncoder)
        {
            headerEncoder.Wrap(buffer, offset, SchemaVersion);
            headerEncoder.BlockLength = BlockLength;
            headerEncoder.TemplateId = TemplateId;
            headerEncoder.SchemaId = SchemaId;
            headerEncoder.Version = SchemaVersion;
            
            WrapForEncode(buffer, offset + MessageHeader.Size);
        }

        public void WrapForDecode(DirectBuffer buffer, int offset, int actingBlockLength, int actingVersion)
        {
            _buffer = buffer;
            _offset = offset;
            _actingBlockLength = actingBlockLength;
            _actingVersion = actingVersion;
            Limit = offset + _actingBlockLength;
        }

        public int Size
        {
            get
            {
                return _limit - _offset;
            }
        }

        public int Limit
        {
            get
            {
                return _limit;
            }
            set
            {
                _buffer.CheckLimit(value);
                _limit = value;
            }
        }


        public const int StreamServerId = 1;
    public const int StreamServerSinceVersion = 0;
    public const int StreamServerDeprecated = 0;
    public bool StreamServerInActingVersion()
    {
        return _actingVersion >= StreamServerSinceVersion;
    }

        public const int StreamServerOffset = 0;

        public static string StreamServerMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public StreamServer StreamServer
        {
            get
            {
                return (StreamServer)_buffer.Uint8Get(_offset + 0);
            }
            set
            {
                _buffer.Uint8Put(_offset + 0, (byte)value);
            }
        }


        public const int FxBoxEngineId = 2;
    public const int FxBoxEngineSinceVersion = 0;
    public const int FxBoxEngineDeprecated = 0;
    public bool FxBoxEngineInActingVersion()
    {
        return _actingVersion >= FxBoxEngineSinceVersion;
    }

        public const int FxBoxEngineOffset = 1;

        public static string FxBoxEngineMetaAttribute(MetaAttribute metaAttribute)
        {
            switch (metaAttribute)
            {
                case MetaAttribute.Epoch: return "";
                case MetaAttribute.TimeUnit: return "";
                case MetaAttribute.SemanticType: return "";
                case MetaAttribute.Presence: return "required";
            }

            return "";
        }

        public FXBoxEngine FxBoxEngine
        {
            get
            {
                return (FXBoxEngine)_buffer.Uint8Get(_offset + 1);
            }
            set
            {
                _buffer.Uint8Put(_offset + 1, (byte)value);
            }
        }


        public override string ToString()
        {
            var sb = new StringBuilder(100);
            this.BuildString(sb);
            return sb.ToString();
        }

        internal void BuildString(StringBuilder builder)
        {
            if (_buffer == null)
            {
                throw new ArgumentNullException("_buffer");
            }

            int originalLimit = this.Limit;
            this.Limit = _offset + _actingBlockLength;
            builder.Append("[RegisterServerSessionMsg](sbeTemplateId=");
            builder.Append(RegisterServerSessionMsg.TemplateId);
            builder.Append("|sbeSchemaId=");
            builder.Append(RegisterServerSessionMsg.SchemaId);
            builder.Append("|sbeSchemaVersion=");
            if (_parentMessage._actingVersion != RegisterServerSessionMsg.SchemaVersion)
            {
                builder.Append(_parentMessage._actingVersion);
                builder.Append('/');
            }
            builder.Append(RegisterServerSessionMsg.SchemaVersion);
            builder.Append("|sbeBlockLength=");
            if (_actingBlockLength != RegisterServerSessionMsg.BlockLength)
            {
                builder.Append(_actingBlockLength);
                builder.Append('/');
            }
            builder.Append(RegisterServerSessionMsg.BlockLength);
            builder.Append("):");

            builder.Append("StreamServer=");
            builder.Append(this.StreamServer);
            builder.Append('|');
            builder.Append("FxBoxEngine=");
            builder.Append(this.FxBoxEngine);

            this.Limit = originalLimit;

        }
    }
}
