// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: steammessages_remoteclient_service.steamclient.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenSteamworks.Protobuf {

  /// <summary>Holder for reflection information generated from steammessages_remoteclient_service.steamclient.proto</summary>
  public static partial class SteammessagesRemoteclientServiceSteamclientReflection {

    #region Descriptor
    /// <summary>File descriptor for steammessages_remoteclient_service.steamclient.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SteammessagesRemoteclientServiceSteamclientReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjRzdGVhbW1lc3NhZ2VzX3JlbW90ZWNsaWVudF9zZXJ2aWNlLnN0ZWFtY2xp",
            "ZW50LnByb3RvGiBnb29nbGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90bxoY",
            "c3RlYW1tZXNzYWdlc19iYXNlLnByb3RvGixzdGVhbW1lc3NhZ2VzX3VuaWZp",
            "ZWRfYmFzZS5zdGVhbWNsaWVudC5wcm90bxoxc3RlYW1tZXNzYWdlc19yZW1v",
            "dGVjbGllbnRfc2VydmljZV9tZXNzYWdlcy5wcm90bzKFCwoMUmVtb3RlQ2xp",
            "ZW50El8KDkdldFBhaXJpbmdJbmZvEiUuQ1JlbW90ZUNsaWVudF9HZXRQYWly",
            "aW5nSW5mb19SZXF1ZXN0GiYuQ1JlbW90ZUNsaWVudF9HZXRQYWlyaW5nSW5m",
            "b19SZXNwb25zZRI/CgxOb3RpZnlPbmxpbmUSIi5DUmVtb3RlQ2xpZW50X09u",
            "bGluZV9Ob3RpZmljYXRpb24aCy5Ob1Jlc3BvbnNlEmUKEEdldFJlY2VudENs",
            "aWVudHMSJy5DUmVtb3RlQ2xpZW50X0dldFJlY2VudENsaWVudHNfUmVxdWVz",
            "dBooLkNSZW1vdGVDbGllbnRfR2V0UmVjZW50Q2xpZW50c19SZXNwb25zZRJl",
            "ChBNYXJrVGFza0NvbXBsZXRlEicuQ1JlbW90ZUNsaWVudF9NYXJrVGFza0Nv",
            "bXBsZXRlX1JlcXVlc3QaKC5DUmVtb3RlQ2xpZW50X01hcmtUYXNrQ29tcGxl",
            "dGVfUmVzcG9uc2USSQoRTm90aWZ5UmVwbHlQYWNrZXQSJy5DUmVtb3RlQ2xp",
            "ZW50X1JlcGx5UGFja2V0X05vdGlmaWNhdGlvbhoLLk5vUmVzcG9uc2USbgoT",
            "QWxsb2NhdGVSZWxheVNlcnZlchIqLkNSZW1vdGVDbGllbnRfQWxsb2NhdGVS",
            "ZWxheVNlcnZlcl9SZXF1ZXN0GisuQ1JlbW90ZUNsaWVudF9BbGxvY2F0ZVJl",
            "bGF5U2VydmVyX1Jlc3BvbnNlElYKC0FsbG9jYXRlU0RSEiIuQ1JlbW90ZUNs",
            "aWVudF9BbGxvY2F0ZVNEUl9SZXF1ZXN0GiMuQ1JlbW90ZUNsaWVudF9BbGxv",
            "Y2F0ZVNEUl9SZXNwb25zZRJTChhTZW5kU3RlYW1Ccm9hZGNhc3RQYWNrZXQS",
            "Ki5DUmVtb3RlQ2xpZW50X1N0ZWFtQnJvYWRjYXN0X05vdGlmaWNhdGlvbhoL",
            "Lk5vUmVzcG9uc2USTwoWU2VuZFN0ZWFtVG9TdGVhbVBhY2tldBIoLkNSZW1v",
            "dGVDbGllbnRfU3RlYW1Ub1N0ZWFtX05vdGlmaWNhdGlvbhoLLk5vUmVzcG9u",
            "c2USaQocU2VuZFJlbW90ZVBsYXlTZXNzaW9uU3RhcnRlZBIjLkNSZW1vdGVQ",
            "bGF5X1Nlc3Npb25TdGFydGVkX1JlcXVlc3QaJC5DUmVtb3RlUGxheV9TZXNz",
            "aW9uU3RhcnRlZF9SZXNwb25zZRJVChxTZW5kUmVtb3RlUGxheVNlc3Npb25T",
            "dG9wcGVkEiguQ1JlbW90ZVBsYXlfU2Vzc2lvblN0b3BwZWRfTm90aWZpY2F0",
            "aW9uGgsuTm9SZXNwb25zZRJOChxTZW5kUmVtb3RlUGxheVRvZ2V0aGVyUGFj",
            "a2V0EiEuQ1JlbW90ZVBsYXlUb2dldGhlcl9Ob3RpZmljYXRpb24aCy5Ob1Jl",
            "c3BvbnNlEpsBCiJDcmVhdGVSZW1vdGVQbGF5VG9nZXRoZXJJbnZpdGF0aW9u",
            "EjkuQ1JlbW90ZUNsaWVudF9DcmVhdGVSZW1vdGVQbGF5VG9nZXRoZXJJbnZp",
            "dGF0aW9uX1JlcXVlc3QaOi5DUmVtb3RlQ2xpZW50X0NyZWF0ZVJlbW90ZVBs",
            "YXlUb2dldGhlckludml0YXRpb25fUmVzcG9uc2USmwEKIkRlbGV0ZVJlbW90",
            "ZVBsYXlUb2dldGhlckludml0YXRpb24SOS5DUmVtb3RlQ2xpZW50X0RlbGV0",
            "ZVJlbW90ZVBsYXlUb2dldGhlckludml0YXRpb25fUmVxdWVzdBo6LkNSZW1v",
            "dGVDbGllbnRfRGVsZXRlUmVtb3RlUGxheVRvZ2V0aGVySW52aXRhdGlvbl9S",
            "ZXNwb25zZTLrBAoXUmVtb3RlQ2xpZW50U3RlYW1DbGllbnQSWwoaTm90aWZ5",
            "UmVnaXN0ZXJTdGF0dXNVcGRhdGUSMC5DUmVtb3RlQ2xpZW50X1JlZ2lzdGVy",
            "U3RhdHVzVXBkYXRlX05vdGlmaWNhdGlvbhoLLk5vUmVzcG9uc2USXwocTm90",
            "aWZ5VW5yZWdpc3RlclN0YXR1c1VwZGF0ZRIyLkNSZW1vdGVDbGllbnRfVW5y",
            "ZWdpc3RlclN0YXR1c1VwZGF0ZV9Ob3RpZmljYXRpb24aCy5Ob1Jlc3BvbnNl",
            "EksKEk5vdGlmeVJlbW90ZVBhY2tldBIoLkNSZW1vdGVDbGllbnRfUmVtb3Rl",
            "UGFja2V0X05vdGlmaWNhdGlvbhoLLk5vUmVzcG9uc2USVQoaTm90aWZ5U3Rl",
            "YW1Ccm9hZGNhc3RQYWNrZXQSKi5DUmVtb3RlQ2xpZW50X1N0ZWFtQnJvYWRj",
            "YXN0X05vdGlmaWNhdGlvbhoLLk5vUmVzcG9uc2USUQoYTm90aWZ5U3RlYW1U",
            "b1N0ZWFtUGFja2V0EiguQ1JlbW90ZUNsaWVudF9TdGVhbVRvU3RlYW1fTm90",
            "aWZpY2F0aW9uGgsuTm9SZXNwb25zZRJQCh5Ob3RpZnlSZW1vdGVQbGF5VG9n",
            "ZXRoZXJQYWNrZXQSIS5DUmVtb3RlUGxheVRvZ2V0aGVyX05vdGlmaWNhdGlv",
            "bhoLLk5vUmVzcG9uc2USQwoOTm90aWZ5VGFza0xpc3QSJC5DUmVtb3RlQ2xp",
            "ZW50X1Rhc2tMaXN0X05vdGlmaWNhdGlvbhoLLk5vUmVzcG9uc2UaBMC1GAJC",
            "HYABAaoCF09wZW5TdGVhbXdvcmtzLlByb3RvYnVm"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, global::OpenSteamworks.Protobuf.SteammessagesBaseReflection.Descriptor, global::OpenSteamworks.Protobuf.SteammessagesUnifiedBaseSteamclientReflection.Descriptor, global::OpenSteamworks.Protobuf.SteammessagesRemoteclientServiceMessagesReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code
