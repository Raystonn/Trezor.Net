// This file was generated by a tool; you should avoid making direct changes.
// Consider using 'partial classes' to extend these types
// Input: messages-crypto.proto

#pragma warning disable CS1591, CS0612, CS3021, IDE1006
namespace Trezor.Net.Contracts
{

    [global::ProtoBuf.ProtoContract()]
    public partial class CipherKeyValue : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"key")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Key
        {
            get { return __pbn__Key ?? ""; }
            set { __pbn__Key = value; }
        }
        public bool ShouldSerializeKey() => __pbn__Key != null;
        public void ResetKey() => __pbn__Key = null;
        private string __pbn__Key;

        [global::ProtoBuf.ProtoMember(3, Name = @"value")]
        public byte[] Value
        {
            get { return __pbn__Value; }
            set { __pbn__Value = value; }
        }
        public bool ShouldSerializeValue() => __pbn__Value != null;
        public void ResetValue() => __pbn__Value = null;
        private byte[] __pbn__Value;

        [global::ProtoBuf.ProtoMember(4, Name = @"encrypt")]
        public bool Encrypt
        {
            get { return __pbn__Encrypt.GetValueOrDefault(); }
            set { __pbn__Encrypt = value; }
        }
        public bool ShouldSerializeEncrypt() => __pbn__Encrypt != null;
        public void ResetEncrypt() => __pbn__Encrypt = null;
        private bool? __pbn__Encrypt;

        [global::ProtoBuf.ProtoMember(5, Name = @"ask_on_encrypt")]
        public bool AskOnEncrypt
        {
            get { return __pbn__AskOnEncrypt.GetValueOrDefault(); }
            set { __pbn__AskOnEncrypt = value; }
        }
        public bool ShouldSerializeAskOnEncrypt() => __pbn__AskOnEncrypt != null;
        public void ResetAskOnEncrypt() => __pbn__AskOnEncrypt = null;
        private bool? __pbn__AskOnEncrypt;

        [global::ProtoBuf.ProtoMember(6, Name = @"ask_on_decrypt")]
        public bool AskOnDecrypt
        {
            get { return __pbn__AskOnDecrypt.GetValueOrDefault(); }
            set { __pbn__AskOnDecrypt = value; }
        }
        public bool ShouldSerializeAskOnDecrypt() => __pbn__AskOnDecrypt != null;
        public void ResetAskOnDecrypt() => __pbn__AskOnDecrypt = null;
        private bool? __pbn__AskOnDecrypt;

        [global::ProtoBuf.ProtoMember(7, Name = @"iv")]
        public byte[] Iv
        {
            get { return __pbn__Iv; }
            set { __pbn__Iv = value; }
        }
        public bool ShouldSerializeIv() => __pbn__Iv != null;
        public void ResetIv() => __pbn__Iv = null;
        private byte[] __pbn__Iv;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CipheredKeyValue : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"value")]
        public byte[] Value
        {
            get { return __pbn__Value; }
            set { __pbn__Value = value; }
        }
        public bool ShouldSerializeValue() => __pbn__Value != null;
        public void ResetValue() => __pbn__Value = null;
        private byte[] __pbn__Value;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class IdentityType : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"proto")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Proto
        {
            get { return __pbn__Proto ?? ""; }
            set { __pbn__Proto = value; }
        }
        public bool ShouldSerializeProto() => __pbn__Proto != null;
        public void ResetProto() => __pbn__Proto = null;
        private string __pbn__Proto;

        [global::ProtoBuf.ProtoMember(2, Name = @"user")]
        [global::System.ComponentModel.DefaultValue("")]
        public string User
        {
            get { return __pbn__User ?? ""; }
            set { __pbn__User = value; }
        }
        public bool ShouldSerializeUser() => __pbn__User != null;
        public void ResetUser() => __pbn__User = null;
        private string __pbn__User;

        [global::ProtoBuf.ProtoMember(3, Name = @"host")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Host
        {
            get { return __pbn__Host ?? ""; }
            set { __pbn__Host = value; }
        }
        public bool ShouldSerializeHost() => __pbn__Host != null;
        public void ResetHost() => __pbn__Host = null;
        private string __pbn__Host;

        [global::ProtoBuf.ProtoMember(4, Name = @"port")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Port
        {
            get { return __pbn__Port ?? ""; }
            set { __pbn__Port = value; }
        }
        public bool ShouldSerializePort() => __pbn__Port != null;
        public void ResetPort() => __pbn__Port = null;
        private string __pbn__Port;

        [global::ProtoBuf.ProtoMember(5, Name = @"path")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Path
        {
            get { return __pbn__Path ?? ""; }
            set { __pbn__Path = value; }
        }
        public bool ShouldSerializePath() => __pbn__Path != null;
        public void ResetPath() => __pbn__Path = null;
        private string __pbn__Path;

        [global::ProtoBuf.ProtoMember(6, Name = @"index")]
        [global::System.ComponentModel.DefaultValue(0)]
        public uint Index
        {
            get { return __pbn__Index ?? 0; }
            set { __pbn__Index = value; }
        }
        public bool ShouldSerializeIndex() => __pbn__Index != null;
        public void ResetIndex() => __pbn__Index = null;
        private uint? __pbn__Index;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignIdentity : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"identity")]
        public IdentityType Identity { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"challenge_hidden")]
        public byte[] ChallengeHidden
        {
            get { return __pbn__ChallengeHidden; }
            set { __pbn__ChallengeHidden = value; }
        }
        public bool ShouldSerializeChallengeHidden() => __pbn__ChallengeHidden != null;
        public void ResetChallengeHidden() => __pbn__ChallengeHidden = null;
        private byte[] __pbn__ChallengeHidden;

        [global::ProtoBuf.ProtoMember(3, Name = @"challenge_visual")]
        [global::System.ComponentModel.DefaultValue("")]
        public string ChallengeVisual
        {
            get { return __pbn__ChallengeVisual ?? ""; }
            set { __pbn__ChallengeVisual = value; }
        }
        public bool ShouldSerializeChallengeVisual() => __pbn__ChallengeVisual != null;
        public void ResetChallengeVisual() => __pbn__ChallengeVisual = null;
        private string __pbn__ChallengeVisual;

        [global::ProtoBuf.ProtoMember(4, Name = @"ecdsa_curve_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string EcdsaCurveName
        {
            get { return __pbn__EcdsaCurveName ?? ""; }
            set { __pbn__EcdsaCurveName = value; }
        }
        public bool ShouldSerializeEcdsaCurveName() => __pbn__EcdsaCurveName != null;
        public void ResetEcdsaCurveName() => __pbn__EcdsaCurveName = null;
        private string __pbn__EcdsaCurveName;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class SignedIdentity : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address")]
        [global::System.ComponentModel.DefaultValue("")]
        public string Address
        {
            get { return __pbn__Address ?? ""; }
            set { __pbn__Address = value; }
        }
        public bool ShouldSerializeAddress() => __pbn__Address != null;
        public void ResetAddress() => __pbn__Address = null;
        private string __pbn__Address;

        [global::ProtoBuf.ProtoMember(2, Name = @"public_key")]
        public byte[] PublicKey
        {
            get { return __pbn__PublicKey; }
            set { __pbn__PublicKey = value; }
        }
        public bool ShouldSerializePublicKey() => __pbn__PublicKey != null;
        public void ResetPublicKey() => __pbn__PublicKey = null;
        private byte[] __pbn__PublicKey;

        [global::ProtoBuf.ProtoMember(3, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class GetECDHSessionKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"identity")]
        public IdentityType Identity { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"peer_public_key")]
        public byte[] PeerPublicKey
        {
            get { return __pbn__PeerPublicKey; }
            set { __pbn__PeerPublicKey = value; }
        }
        public bool ShouldSerializePeerPublicKey() => __pbn__PeerPublicKey != null;
        public void ResetPeerPublicKey() => __pbn__PeerPublicKey = null;
        private byte[] __pbn__PeerPublicKey;

        [global::ProtoBuf.ProtoMember(3, Name = @"ecdsa_curve_name")]
        [global::System.ComponentModel.DefaultValue("")]
        public string EcdsaCurveName
        {
            get { return __pbn__EcdsaCurveName ?? ""; }
            set { __pbn__EcdsaCurveName = value; }
        }
        public bool ShouldSerializeEcdsaCurveName() => __pbn__EcdsaCurveName != null;
        public void ResetEcdsaCurveName() => __pbn__EcdsaCurveName = null;
        private string __pbn__EcdsaCurveName;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ECDHSessionKey : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"session_key")]
        public byte[] SessionKey
        {
            get { return __pbn__SessionKey; }
            set { __pbn__SessionKey = value; }
        }
        public bool ShouldSerializeSessionKey() => __pbn__SessionKey != null;
        public void ResetSessionKey() => __pbn__SessionKey = null;
        private byte[] __pbn__SessionKey;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CosiCommit : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data
        {
            get { return __pbn__Data; }
            set { __pbn__Data = value; }
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private byte[] __pbn__Data;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CosiCommitment : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"commitment")]
        public byte[] Commitment
        {
            get { return __pbn__Commitment; }
            set { __pbn__Commitment = value; }
        }
        public bool ShouldSerializeCommitment() => __pbn__Commitment != null;
        public void ResetCommitment() => __pbn__Commitment = null;
        private byte[] __pbn__Commitment;

        [global::ProtoBuf.ProtoMember(2, Name = @"pubkey")]
        public byte[] Pubkey
        {
            get { return __pbn__Pubkey; }
            set { __pbn__Pubkey = value; }
        }
        public bool ShouldSerializePubkey() => __pbn__Pubkey != null;
        public void ResetPubkey() => __pbn__Pubkey = null;
        private byte[] __pbn__Pubkey;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CosiSign : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"address_n")]
        public uint[] AddressNs { get; set; }

        [global::ProtoBuf.ProtoMember(2, Name = @"data")]
        public byte[] Data
        {
            get { return __pbn__Data; }
            set { __pbn__Data = value; }
        }
        public bool ShouldSerializeData() => __pbn__Data != null;
        public void ResetData() => __pbn__Data = null;
        private byte[] __pbn__Data;

        [global::ProtoBuf.ProtoMember(3, Name = @"global_commitment")]
        public byte[] GlobalCommitment
        {
            get { return __pbn__GlobalCommitment; }
            set { __pbn__GlobalCommitment = value; }
        }
        public bool ShouldSerializeGlobalCommitment() => __pbn__GlobalCommitment != null;
        public void ResetGlobalCommitment() => __pbn__GlobalCommitment = null;
        private byte[] __pbn__GlobalCommitment;

        [global::ProtoBuf.ProtoMember(4, Name = @"global_pubkey")]
        public byte[] GlobalPubkey
        {
            get { return __pbn__GlobalPubkey; }
            set { __pbn__GlobalPubkey = value; }
        }
        public bool ShouldSerializeGlobalPubkey() => __pbn__GlobalPubkey != null;
        public void ResetGlobalPubkey() => __pbn__GlobalPubkey = null;
        private byte[] __pbn__GlobalPubkey;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CosiSignature : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
            => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

        [global::ProtoBuf.ProtoMember(1, Name = @"signature")]
        public byte[] Signature
        {
            get { return __pbn__Signature; }
            set { __pbn__Signature = value; }
        }
        public bool ShouldSerializeSignature() => __pbn__Signature != null;
        public void ResetSignature() => __pbn__Signature = null;
        private byte[] __pbn__Signature;

    }

}

#pragma warning restore CS1591, CS0612, CS3021, IDE1006
