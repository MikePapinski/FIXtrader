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
    /// Unsubscription message for specific symbol
    /// </summary>
    public sealed partial class UnsubscribeMarketDataMsg
    {
        public const ushort BlockLength = (ushort)48;
        public const ushort TemplateId = (ushort)6;
        public const ushort SchemaId = (ushort)1;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly UnsubscribeMarketDataMsg _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public UnsubscribeMarketDataMsg()
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


        public const int SessionIdId = 1;
    public const int SessionIdSinceVersion = 0;
    public const int SessionIdDeprecated = 0;
    public bool SessionIdInActingVersion()
    {
        return _actingVersion >= SessionIdSinceVersion;
    }

        public const int SessionIdOffset = 0;

        public static string SessionIdMetaAttribute(MetaAttribute metaAttribute)
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

        public const ushort SessionIdNullValue = (ushort)65535;
        public const ushort SessionIdMinValue = (ushort)0;
        public const ushort SessionIdMaxValue = (ushort)65534;

        public ushort SessionId
        {
            get
            {
                return _buffer.Uint16GetLittleEndian(_offset + 0);
            }
            set
            {
                _buffer.Uint16PutLittleEndian(_offset + 0, value);
            }
        }


        public const int SymbolIdId = 2;
    public const int SymbolIdSinceVersion = 0;
    public const int SymbolIdDeprecated = 0;
    public bool SymbolIdInActingVersion()
    {
        return _actingVersion >= SymbolIdSinceVersion;
    }

        public const int SymbolIdOffset = 2;

        public static string SymbolIdMetaAttribute(MetaAttribute metaAttribute)
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

        public const ushort SymbolIdNullValue = (ushort)65535;
        public const ushort SymbolIdMinValue = (ushort)0;
        public const ushort SymbolIdMaxValue = (ushort)65534;

        public ushort SymbolId
        {
            get
            {
                return _buffer.Uint16GetLittleEndian(_offset + 2);
            }
            set
            {
                _buffer.Uint16PutLittleEndian(_offset + 2, value);
            }
        }


        public const int SecurityNameId = 3;
    public const int SecurityNameSinceVersion = 0;
    public const int SecurityNameDeprecated = 0;
    public bool SecurityNameInActingVersion()
    {
        return _actingVersion >= SecurityNameSinceVersion;
    }

        public const int SecurityNameOffset = 4;

        public static string SecurityNameMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte SecurityNameNullValue = (byte)0;
        public const byte SecurityNameMinValue = (byte)32;
        public const byte SecurityNameMaxValue = (byte)126;

        public const int SecurityNameLength = 20;

        public byte GetSecurityName(int index)
        {
            if ((uint) index >= 20)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 4 + (index * 1));
        }

        public void SetSecurityName(int index, byte value)
        {
            if ((uint) index >= 20)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 4 + (index * 1), value);
        }

        public ReadOnlySpan<byte> SecurityName
        {
            get => _buffer.AsReadOnlySpan<byte>(_offset + 4, SecurityNameLength);
            set => value.CopyTo(_buffer.AsSpan<byte>(_offset + 4, SecurityNameLength));
        }

        public Span<byte> SecurityNameAsSpan()
        {
            return _buffer.AsSpan<byte>(_offset + 4, SecurityNameLength);
        }

        public const string SecurityNameCharacterEncoding = "ASCII";
        public static Encoding SecurityNameResolvedCharacterEncoding = Encoding.GetEncoding(SecurityNameCharacterEncoding);


        public int GetSecurityName(byte[] dst, int dstOffset)
        {
            const int length = 20;
            return GetSecurityName(new Span<byte>(dst, dstOffset, length));
        }

        public int GetSecurityName(Span<byte> dst)
        {
            const int length = 20;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 4, dst);
            return length;
        }

        public void SetSecurityName(byte[] src, int srcOffset)
        {
            SetSecurityName(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetSecurityName(ReadOnlySpan<byte> src)
        {
            const int length = 20;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 4, src);
        }

        public void SetSecurityName(string value)
        {
            _buffer.SetNullTerminatedBytesFromString(SecurityNameResolvedCharacterEncoding, value, _offset + 4, SecurityNameLength, SecurityNameNullValue);
        }
        public string GetSecurityName()
        {
            return _buffer.GetStringFromNullTerminatedBytes(SecurityNameResolvedCharacterEncoding, _offset + 4, SecurityNameLength, SecurityNameNullValue);
        }

        public const int SecurityIdId = 4;
    public const int SecurityIdSinceVersion = 0;
    public const int SecurityIdDeprecated = 0;
    public bool SecurityIdInActingVersion()
    {
        return _actingVersion >= SecurityIdSinceVersion;
    }

        public const int SecurityIdOffset = 24;

        public static string SecurityIdMetaAttribute(MetaAttribute metaAttribute)
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

        public const ushort SecurityIdNullValue = (ushort)65535;
        public const ushort SecurityIdMinValue = (ushort)0;
        public const ushort SecurityIdMaxValue = (ushort)65534;

        public ushort SecurityId
        {
            get
            {
                return _buffer.Uint16GetLittleEndian(_offset + 24);
            }
            set
            {
                _buffer.Uint16PutLittleEndian(_offset + 24, value);
            }
        }


        public const int ExchangeIdId = 5;
    public const int ExchangeIdSinceVersion = 0;
    public const int ExchangeIdDeprecated = 0;
    public bool ExchangeIdInActingVersion()
    {
        return _actingVersion >= ExchangeIdSinceVersion;
    }

        public const int ExchangeIdOffset = 26;

        public static string ExchangeIdMetaAttribute(MetaAttribute metaAttribute)
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

        public const ushort ExchangeIdNullValue = (ushort)65535;
        public const ushort ExchangeIdMinValue = (ushort)0;
        public const ushort ExchangeIdMaxValue = (ushort)65534;

        public ushort ExchangeId
        {
            get
            {
                return _buffer.Uint16GetLittleEndian(_offset + 26);
            }
            set
            {
                _buffer.Uint16PutLittleEndian(_offset + 26, value);
            }
        }


        public const int ExchangeNameId = 6;
    public const int ExchangeNameSinceVersion = 0;
    public const int ExchangeNameDeprecated = 0;
    public bool ExchangeNameInActingVersion()
    {
        return _actingVersion >= ExchangeNameSinceVersion;
    }

        public const int ExchangeNameOffset = 28;

        public static string ExchangeNameMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte ExchangeNameNullValue = (byte)0;
        public const byte ExchangeNameMinValue = (byte)32;
        public const byte ExchangeNameMaxValue = (byte)126;

        public const int ExchangeNameLength = 20;

        public byte GetExchangeName(int index)
        {
            if ((uint) index >= 20)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 28 + (index * 1));
        }

        public void SetExchangeName(int index, byte value)
        {
            if ((uint) index >= 20)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 28 + (index * 1), value);
        }

        public ReadOnlySpan<byte> ExchangeName
        {
            get => _buffer.AsReadOnlySpan<byte>(_offset + 28, ExchangeNameLength);
            set => value.CopyTo(_buffer.AsSpan<byte>(_offset + 28, ExchangeNameLength));
        }

        public Span<byte> ExchangeNameAsSpan()
        {
            return _buffer.AsSpan<byte>(_offset + 28, ExchangeNameLength);
        }

        public const string ExchangeNameCharacterEncoding = "ASCII";
        public static Encoding ExchangeNameResolvedCharacterEncoding = Encoding.GetEncoding(ExchangeNameCharacterEncoding);


        public int GetExchangeName(byte[] dst, int dstOffset)
        {
            const int length = 20;
            return GetExchangeName(new Span<byte>(dst, dstOffset, length));
        }

        public int GetExchangeName(Span<byte> dst)
        {
            const int length = 20;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 28, dst);
            return length;
        }

        public void SetExchangeName(byte[] src, int srcOffset)
        {
            SetExchangeName(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetExchangeName(ReadOnlySpan<byte> src)
        {
            const int length = 20;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 28, src);
        }

        public void SetExchangeName(string value)
        {
            _buffer.SetNullTerminatedBytesFromString(ExchangeNameResolvedCharacterEncoding, value, _offset + 28, ExchangeNameLength, ExchangeNameNullValue);
        }
        public string GetExchangeName()
        {
            return _buffer.GetStringFromNullTerminatedBytes(ExchangeNameResolvedCharacterEncoding, _offset + 28, ExchangeNameLength, ExchangeNameNullValue);
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
            builder.Append("[UnsubscribeMarketDataMsg](sbeTemplateId=");
            builder.Append(UnsubscribeMarketDataMsg.TemplateId);
            builder.Append("|sbeSchemaId=");
            builder.Append(UnsubscribeMarketDataMsg.SchemaId);
            builder.Append("|sbeSchemaVersion=");
            if (_parentMessage._actingVersion != UnsubscribeMarketDataMsg.SchemaVersion)
            {
                builder.Append(_parentMessage._actingVersion);
                builder.Append('/');
            }
            builder.Append(UnsubscribeMarketDataMsg.SchemaVersion);
            builder.Append("|sbeBlockLength=");
            if (_actingBlockLength != UnsubscribeMarketDataMsg.BlockLength)
            {
                builder.Append(_actingBlockLength);
                builder.Append('/');
            }
            builder.Append(UnsubscribeMarketDataMsg.BlockLength);
            builder.Append("):");

            builder.Append("SessionId=");
            builder.Append(this.SessionId);
            builder.Append('|');
            builder.Append("SymbolId=");
            builder.Append(this.SymbolId);
            builder.Append('|');
            builder.Append("SecurityName=");
            for (int i = 0; i < SecurityNameLength && this.GetSecurityName(i) > 0; ++i)
            {
                builder.Append((char)this.GetSecurityName(i));
            }
            builder.Append('|');
            builder.Append("SecurityId=");
            builder.Append(this.SecurityId);
            builder.Append('|');
            builder.Append("ExchangeId=");
            builder.Append(this.ExchangeId);
            builder.Append('|');
            builder.Append("ExchangeName=");
            for (int i = 0; i < ExchangeNameLength && this.GetExchangeName(i) > 0; ++i)
            {
                builder.Append((char)this.GetExchangeName(i));
            }

            this.Limit = originalLimit;

        }
    }
}