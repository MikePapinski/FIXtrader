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
    /// Connection for GainFutureFixFast
    /// </summary>
    public sealed partial class ConnectSessionGainFutureFixFastMsg
    {
        public const ushort BlockLength = (ushort)62;
        public const ushort TemplateId = (ushort)11;
        public const ushort SchemaId = (ushort)3;
        public const ushort SchemaVersion = (ushort)0;
        public const string SemanticType = "";

        private readonly ConnectSessionGainFutureFixFastMsg _parentMessage;
        private DirectBuffer _buffer;
        private int _offset;
        private int _limit;
        private int _actingBlockLength;
        private int _actingVersion;

        public int Offset { get { return _offset; } }

        public ConnectSessionGainFutureFixFastMsg()
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


        public const int LoginId = 2;
    public const int LoginSinceVersion = 0;
    public const int LoginDeprecated = 0;
    public bool LoginInActingVersion()
    {
        return _actingVersion >= LoginSinceVersion;
    }

        public const int LoginOffset = 2;

        public static string LoginMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte LoginNullValue = (byte)0;
        public const byte LoginMinValue = (byte)32;
        public const byte LoginMaxValue = (byte)126;

        public const int LoginLength = 40;

        public byte GetLogin(int index)
        {
            if ((uint) index >= 40)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 2 + (index * 1));
        }

        public void SetLogin(int index, byte value)
        {
            if ((uint) index >= 40)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 2 + (index * 1), value);
        }

        public ReadOnlySpan<byte> Login
        {
            get => _buffer.AsReadOnlySpan<byte>(_offset + 2, LoginLength);
            set => value.CopyTo(_buffer.AsSpan<byte>(_offset + 2, LoginLength));
        }

        public Span<byte> LoginAsSpan()
        {
            return _buffer.AsSpan<byte>(_offset + 2, LoginLength);
        }

        public const string LoginCharacterEncoding = "ASCII";
        public static Encoding LoginResolvedCharacterEncoding = Encoding.GetEncoding(LoginCharacterEncoding);


        public int GetLogin(byte[] dst, int dstOffset)
        {
            const int length = 40;
            return GetLogin(new Span<byte>(dst, dstOffset, length));
        }

        public int GetLogin(Span<byte> dst)
        {
            const int length = 40;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 2, dst);
            return length;
        }

        public void SetLogin(byte[] src, int srcOffset)
        {
            SetLogin(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetLogin(ReadOnlySpan<byte> src)
        {
            const int length = 40;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 2, src);
        }

        public void SetLogin(string value)
        {
            _buffer.SetNullTerminatedBytesFromString(LoginResolvedCharacterEncoding, value, _offset + 2, LoginLength, LoginNullValue);
        }
        public string GetLogin()
        {
            return _buffer.GetStringFromNullTerminatedBytes(LoginResolvedCharacterEncoding, _offset + 2, LoginLength, LoginNullValue);
        }

        public const int PasswordId = 3;
    public const int PasswordSinceVersion = 0;
    public const int PasswordDeprecated = 0;
    public bool PasswordInActingVersion()
    {
        return _actingVersion >= PasswordSinceVersion;
    }

        public const int PasswordOffset = 42;

        public static string PasswordMetaAttribute(MetaAttribute metaAttribute)
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

        public const byte PasswordNullValue = (byte)0;
        public const byte PasswordMinValue = (byte)32;
        public const byte PasswordMaxValue = (byte)126;

        public const int PasswordLength = 20;

        public byte GetPassword(int index)
        {
            if ((uint) index >= 20)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            return _buffer.CharGet(_offset + 42 + (index * 1));
        }

        public void SetPassword(int index, byte value)
        {
            if ((uint) index >= 20)
            {
                ThrowHelper.ThrowIndexOutOfRangeException(index);
            }

            _buffer.CharPut(_offset + 42 + (index * 1), value);
        }

        public ReadOnlySpan<byte> Password
        {
            get => _buffer.AsReadOnlySpan<byte>(_offset + 42, PasswordLength);
            set => value.CopyTo(_buffer.AsSpan<byte>(_offset + 42, PasswordLength));
        }

        public Span<byte> PasswordAsSpan()
        {
            return _buffer.AsSpan<byte>(_offset + 42, PasswordLength);
        }

        public const string PasswordCharacterEncoding = "ASCII";
        public static Encoding PasswordResolvedCharacterEncoding = Encoding.GetEncoding(PasswordCharacterEncoding);


        public int GetPassword(byte[] dst, int dstOffset)
        {
            const int length = 20;
            return GetPassword(new Span<byte>(dst, dstOffset, length));
        }

        public int GetPassword(Span<byte> dst)
        {
            const int length = 20;
            if (dst.Length < length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooSmall(dst.Length);
            }

            _buffer.GetBytes(_offset + 42, dst);
            return length;
        }

        public void SetPassword(byte[] src, int srcOffset)
        {
            SetPassword(new ReadOnlySpan<byte>(src, srcOffset, src.Length - srcOffset));
        }

        public void SetPassword(ReadOnlySpan<byte> src)
        {
            const int length = 20;
            if (src.Length > length)
            {
                ThrowHelper.ThrowWhenSpanLengthTooLarge(src.Length);
            }

            _buffer.SetBytes(_offset + 42, src);
        }

        public void SetPassword(string value)
        {
            _buffer.SetNullTerminatedBytesFromString(PasswordResolvedCharacterEncoding, value, _offset + 42, PasswordLength, PasswordNullValue);
        }
        public string GetPassword()
        {
            return _buffer.GetStringFromNullTerminatedBytes(PasswordResolvedCharacterEncoding, _offset + 42, PasswordLength, PasswordNullValue);
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
            builder.Append("[ConnectSessionGainFutureFixFastMsg](sbeTemplateId=");
            builder.Append(ConnectSessionGainFutureFixFastMsg.TemplateId);
            builder.Append("|sbeSchemaId=");
            builder.Append(ConnectSessionGainFutureFixFastMsg.SchemaId);
            builder.Append("|sbeSchemaVersion=");
            if (_parentMessage._actingVersion != ConnectSessionGainFutureFixFastMsg.SchemaVersion)
            {
                builder.Append(_parentMessage._actingVersion);
                builder.Append('/');
            }
            builder.Append(ConnectSessionGainFutureFixFastMsg.SchemaVersion);
            builder.Append("|sbeBlockLength=");
            if (_actingBlockLength != ConnectSessionGainFutureFixFastMsg.BlockLength)
            {
                builder.Append(_actingBlockLength);
                builder.Append('/');
            }
            builder.Append(ConnectSessionGainFutureFixFastMsg.BlockLength);
            builder.Append("):");

            builder.Append("SessionId=");
            builder.Append(this.SessionId);
            builder.Append('|');
            builder.Append("Login=");
            for (int i = 0; i < LoginLength && this.GetLogin(i) > 0; ++i)
            {
                builder.Append((char)this.GetLogin(i));
            }
            builder.Append('|');
            builder.Append("Password=");
            for (int i = 0; i < PasswordLength && this.GetPassword(i) > 0; ++i)
            {
                builder.Append((char)this.GetPassword(i));
            }

            this.Limit = originalLimit;

        }
    }
}
