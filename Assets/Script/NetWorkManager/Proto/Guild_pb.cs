//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Guild.proto
// Note: requires additional types generated from: Entity.proto
namespace Contract.Hall
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResultMyGuildInfoContract")]
  public partial class ResultMyGuildInfoContract : global::ProtoBuf.IExtensible
  {
    public ResultMyGuildInfoContract() {}
    

    private int _Result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }

    private Contract.Entity.GuildEntity _GuildInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"GuildInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Contract.Entity.GuildEntity GuildInfo
    {
      get { return _GuildInfo; }
      set { _GuildInfo = value; }
    }
    private readonly global::System.Collections.Generic.List<Contract.Entity.GuildMemberEntity> _GuildMemberList = new global::System.Collections.Generic.List<Contract.Entity.GuildMemberEntity>();
    [global::ProtoBuf.ProtoMember(3, Name=@"GuildMemberList", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Contract.Entity.GuildMemberEntity> GuildMemberList
    {
      get { return _GuildMemberList; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"IsSignContract")]
  public partial class IsSignContract : global::ProtoBuf.IExtensible
  {
    public IsSignContract() {}
    

    private int _GuildID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"GuildID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int GuildID
    {
      get { return _GuildID; }
      set { _GuildID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResultIsSignContract")]
  public partial class ResultIsSignContract : global::ProtoBuf.IExtensible
  {
    public ResultIsSignContract() {}
    

    private int _Result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BroadChangeActiveValueContract")]
  public partial class BroadChangeActiveValueContract : global::ProtoBuf.IExtensible
  {
    public BroadChangeActiveValueContract() {}
    

    private int _GuildActiveValue = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"GuildActiveValue", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int GuildActiveValue
    {
      get { return _GuildActiveValue; }
      set { _GuildActiveValue = value; }
    }

    private int _MemberActiveValue = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MemberActiveValue", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int MemberActiveValue
    {
      get { return _MemberActiveValue; }
      set { _MemberActiveValue = value; }
    }

    private string _UserID = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"UserID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UserID
    {
      get { return _UserID; }
      set { _UserID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdateGuildNameContract")]
  public partial class UpdateGuildNameContract : global::ProtoBuf.IExtensible
  {
    public UpdateGuildNameContract() {}
    

    private int _GuildID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"GuildID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int GuildID
    {
      get { return _GuildID; }
      set { _GuildID = value; }
    }

    private string _Name = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Name
    {
      get { return _Name; }
      set { _Name = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResultUpdateGuildNameContract")]
  public partial class ResultUpdateGuildNameContract : global::ProtoBuf.IExtensible
  {
    public ResultUpdateGuildNameContract() {}
    

    private int _Result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildKickContract")]
  public partial class GuildKickContract : global::ProtoBuf.IExtensible
  {
    public GuildKickContract() {}
    

    private int _GuildID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"GuildID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int GuildID
    {
      get { return _GuildID; }
      set { _GuildID = value; }
    }

    private string _MemberID = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MemberID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string MemberID
    {
      get { return _MemberID; }
      set { _MemberID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResultGuildKickContract")]
  public partial class ResultGuildKickContract : global::ProtoBuf.IExtensible
  {
    public ResultGuildKickContract() {}
    

    private int _Result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BroadGuildKickContract")]
  public partial class BroadGuildKickContract : global::ProtoBuf.IExtensible
  {
    public BroadGuildKickContract() {}
    

    private string _MemberID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"MemberID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string MemberID
    {
      get { return _MemberID; }
      set { _MemberID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TurnGuildContract")]
  public partial class TurnGuildContract : global::ProtoBuf.IExtensible
  {
    public TurnGuildContract() {}
    

    private int _OldGuildId = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"OldGuildId", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int OldGuildId
    {
      get { return _OldGuildId; }
      set { _OldGuildId = value; }
    }

    private int _NewGuildID = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NewGuildID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int NewGuildID
    {
      get { return _NewGuildID; }
      set { _NewGuildID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResultTurnGuildContract")]
  public partial class ResultTurnGuildContract : global::ProtoBuf.IExtensible
  {
    public ResultTurnGuildContract() {}
    

    private int _Result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BroadExiteGuildContract")]
  public partial class BroadExiteGuildContract : global::ProtoBuf.IExtensible
  {
    public BroadExiteGuildContract() {}
    

    private string _MemberID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"MemberID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string MemberID
    {
      get { return _MemberID; }
      set { _MemberID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BroadJoinGuildContract")]
  public partial class BroadJoinGuildContract : global::ProtoBuf.IExtensible
  {
    public BroadJoinGuildContract() {}
    

    private string _MemberID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"MemberID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string MemberID
    {
      get { return _MemberID; }
      set { _MemberID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SendCharContract")]
  public partial class SendCharContract : global::ProtoBuf.IExtensible
  {
    public SendCharContract() {}
    

    private string _Content = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Content
    {
      get { return _Content; }
      set { _Content = value; }
    }

    private int _GuildID = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"GuildID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int GuildID
    {
      get { return _GuildID; }
      set { _GuildID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BroadCharContract")]
  public partial class BroadCharContract : global::ProtoBuf.IExtensible
  {
    public BroadCharContract() {}
    

    private string _UsreID = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"UsreID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UsreID
    {
      get { return _UsreID; }
      set { _UsreID = value; }
    }

    private string _Content = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string Content
    {
      get { return _Content; }
      set { _Content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GuildOnlineMemberContract")]
  public partial class GuildOnlineMemberContract : global::ProtoBuf.IExtensible
  {
    public GuildOnlineMemberContract() {}
    

    private int _Type = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Type", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Type
    {
      get { return _Type; }
      set { _Type = value; }
    }

    private string _UsreID = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UsreID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string UsreID
    {
      get { return _UsreID; }
      set { _UsreID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}