//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Directory9xTypeClient.proto
// Note: requires additional types generated from: CommonData.proto
// Note: requires additional types generated from: MessageData.proto
// Note: requires additional types generated from: ServerData.proto
namespace DataContract
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"__RPC_Directory_CheckVersion_RET_VersionInfo__")]
  public partial class __RPC_Directory_CheckVersion_RET_VersionInfo__ : global::ProtoBuf.IExtensible
  {
    public __RPC_Directory_CheckVersion_RET_VersionInfo__() {}
    

    private DataContract.VersionInfo _ReturnValue = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ReturnValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public DataContract.VersionInfo ReturnValue
    {
      get { return _ReturnValue; }
      set { _ReturnValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"__RPC_Directory_CheckVersion_ARG_string_lang_string_platform_string_channel_string_version__")]
  public partial class __RPC_Directory_CheckVersion_ARG_string_lang_string_platform_string_channel_string_version__ : global::ProtoBuf.IExtensible
  {
    public __RPC_Directory_CheckVersion_ARG_string_lang_string_platform_string_channel_string_version__() {}
    

    private string _Lang = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Lang", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Lang
    {
      get { return _Lang; }
      set { _Lang = value; }
    }

    private string _Platform = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Platform", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Platform
    {
      get { return _Platform; }
      set { _Platform = value; }
    }

    private string _Channel = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Channel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Channel
    {
      get { return _Channel; }
      set { _Channel = value; }
    }

    private string _Version = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Version
    {
      get { return _Version; }
      set { _Version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"__RPC_Directory_CheckVersion2_RET_VersionInfo__")]
  public partial class __RPC_Directory_CheckVersion2_RET_VersionInfo__ : global::ProtoBuf.IExtensible
  {
    public __RPC_Directory_CheckVersion2_RET_VersionInfo__() {}
    

    private DataContract.VersionInfo _ReturnValue = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ReturnValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public DataContract.VersionInfo ReturnValue
    {
      get { return _ReturnValue; }
      set { _ReturnValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"__RPC_Directory_CheckVersion2_ARG_string_lang_string_platform_string_channel_string_version__")]
  public partial class __RPC_Directory_CheckVersion2_ARG_string_lang_string_platform_string_channel_string_version__ : global::ProtoBuf.IExtensible
  {
    public __RPC_Directory_CheckVersion2_ARG_string_lang_string_platform_string_channel_string_version__() {}
    

    private string _Lang = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Lang", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Lang
    {
      get { return _Lang; }
      set { _Lang = value; }
    }

    private string _Platform = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Platform", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Platform
    {
      get { return _Platform; }
      set { _Platform = value; }
    }

    private string _Channel = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Channel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Channel
    {
      get { return _Channel; }
      set { _Channel = value; }
    }

    private string _Version = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Version
    {
      get { return _Version; }
      set { _Version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"__RPC_Directory_CheckVersion3_RET_VersionInfo__")]
  public partial class __RPC_Directory_CheckVersion3_RET_VersionInfo__ : global::ProtoBuf.IExtensible
  {
    public __RPC_Directory_CheckVersion3_RET_VersionInfo__() {}
    

    private DataContract.VersionInfo _ReturnValue = null;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ReturnValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public DataContract.VersionInfo ReturnValue
    {
      get { return _ReturnValue; }
      set { _ReturnValue = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"__RPC_Directory_CheckVersion3_ARG_string_lang_string_platform_string_channel_string_version__")]
  public partial class __RPC_Directory_CheckVersion3_ARG_string_lang_string_platform_string_channel_string_version__ : global::ProtoBuf.IExtensible
  {
    public __RPC_Directory_CheckVersion3_ARG_string_lang_string_platform_string_channel_string_version__() {}
    

    private string _Lang = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Lang", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Lang
    {
      get { return _Lang; }
      set { _Lang = value; }
    }

    private string _Platform = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Platform", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Platform
    {
      get { return _Platform; }
      set { _Platform = value; }
    }

    private string _Channel = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Channel", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Channel
    {
      get { return _Channel; }
      set { _Channel = value; }
    }

    private string _Version = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Version", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Version
    {
      get { return _Version; }
      set { _Version = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}