//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: Game.proto
// Note: requires additional types generated from: Entity.proto
namespace Contract.Hall
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"StartGameContract")]
  public partial class StartGameContract : global::ProtoBuf.IExtensible
  {
    public StartGameContract() {}
    

    private int _ID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }

    private string _PropID = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PropID", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string PropID
    {
      get { return _PropID; }
      set { _PropID = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResultStartGameContract")]
  public partial class ResultStartGameContract : global::ProtoBuf.IExtensible
  {
    public ResultStartGameContract() {}
    

    private int _Result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }

    private int _Strength = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Strength", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Strength
    {
      get { return _Strength; }
      set { _Strength = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"GameOverContract")]
  public partial class GameOverContract : global::ProtoBuf.IExtensible
  {
    public GameOverContract() {}
    

    private int _ID = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ID", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int ID
    {
      get { return _ID; }
      set { _ID = value; }
    }

    private int _GoldCoin = default(int);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"GoldCoin", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int GoldCoin
    {
      get { return _GoldCoin; }
      set { _GoldCoin = value; }
    }

    private bool _IsSuccess = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IsSuccess", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool IsSuccess
    {
      get { return _IsSuccess; }
      set { _IsSuccess = value; }
    }

    private int _StarsNum = default(int);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"StarsNum", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int StarsNum
    {
      get { return _StarsNum; }
      set { _StarsNum = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ResultGameOverContract")]
  public partial class ResultGameOverContract : global::ProtoBuf.IExtensible
  {
    public ResultGameOverContract() {}
    

    private int _Result = default(int);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Result", DataFormat = global::ProtoBuf.DataFormat.ZigZag)]
    [global::System.ComponentModel.DefaultValue(default(int))]
    public int Result
    {
      get { return _Result; }
      set { _Result = value; }
    }

    private Contract.Entity.UserEntity _UserInfo = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UserInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public Contract.Entity.UserEntity UserInfo
    {
      get { return _UserInfo; }
      set { _UserInfo = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}