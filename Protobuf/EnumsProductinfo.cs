// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: enums_productinfo.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace OpenSteamworks.Protobuf {

  /// <summary>Holder for reflection information generated from enums_productinfo.proto</summary>
  public static partial class EnumsProductinfoReflection {

    #region Descriptor
    /// <summary>File descriptor for enums_productinfo.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static EnumsProductinfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdlbnVtc19wcm9kdWN0aW5mby5wcm90bxogZ29vZ2xlL3Byb3RvYnVmL2Rl",
            "c2NyaXB0b3IucHJvdG8aGHN0ZWFtbWVzc2FnZXNfYmFzZS5wcm90byqWAgoU",
            "RUNvbnRlbnREZXNjcmlwdG9ySUQSLAooRUNvbnRlbnREZXNjcmlwdG9yX051",
            "ZGl0eU9yU2V4dWFsQ29udGVudBABEi0KKUVDb250ZW50RGVzY3JpcHRvcl9G",
            "cmVxdWVudFZpb2xlbmNlT3JHb3JlEAISLQopRUNvbnRlbnREZXNjcmlwdG9y",
            "X0FkdWx0T25seVNleHVhbENvbnRlbnQQAxIuCipFQ29udGVudERlc2NyaXB0",
            "b3JfR3JhdHVpdG91c1NleHVhbENvbnRlbnQQBBInCiNFQ29udGVudERlc2Ny",
            "aXB0b3JfQW55TWF0dXJlQ29udGVudBAFEhkKFUVDb250ZW50RGVzY3JpcHRv",
            "ck1BWBAGQiNIAYABAaoCF09wZW5TdGVhbXdvcmtzLlByb3RvYnVmgLUYAQ=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.Reflection.DescriptorReflection.Descriptor, global::OpenSteamworks.Protobuf.SteammessagesBaseReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::OpenSteamworks.Protobuf.EContentDescriptorID), }, null, null));
    }
    #endregion

  }
  #region Enums
  public enum EContentDescriptorID {
    [pbr::OriginalName("EContentDescriptor_NudityOrSexualContent")] EcontentDescriptorNudityOrSexualContent = 1,
    [pbr::OriginalName("EContentDescriptor_FrequentViolenceOrGore")] EcontentDescriptorFrequentViolenceOrGore = 2,
    [pbr::OriginalName("EContentDescriptor_AdultOnlySexualContent")] EcontentDescriptorAdultOnlySexualContent = 3,
    [pbr::OriginalName("EContentDescriptor_GratuitousSexualContent")] EcontentDescriptorGratuitousSexualContent = 4,
    [pbr::OriginalName("EContentDescriptor_AnyMatureContent")] EcontentDescriptorAnyMatureContent = 5,
    [pbr::OriginalName("EContentDescriptorMAX")] EcontentDescriptorMax = 6,
  }

  #endregion

}

#endregion Designer generated code
