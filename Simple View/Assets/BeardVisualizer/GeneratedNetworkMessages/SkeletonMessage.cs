//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SkeletonMessage.proto
namespace NetworkMessages.Trame
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SkeletonMessage")]
  public partial class SkeletonMessage : global::ProtoBuf.IExtensible
  {
    public SkeletonMessage() {}
    
    private long _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private long _timestamp;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }
    private bool _valid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool valid
    {
      get { return _valid; }
      set { _valid = value; }
    }
    private NetworkMessages.Trame.SkeletonMessage.Joint _root;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"root", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public NetworkMessages.Trame.SkeletonMessage.Joint root
    {
      get { return _root; }
      set { _root = value; }
    }
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Joint")]
  public partial class Joint : global::ProtoBuf.IExtensible
  {
    public Joint() {}
    
    private int _type;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int type
    {
      get { return _type; }
      set { _type = value; }
    }
    private bool _valid;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"valid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public bool valid
    {
      get { return _valid; }
      set { _valid = value; }
    }
    private readonly global::System.Collections.Generic.List<float> _orientation = new global::System.Collections.Generic.List<float>();
    [global::ProtoBuf.ProtoMember(3, Name=@"orientation", DataFormat = global::ProtoBuf.DataFormat.FixedSize, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<float> orientation
    {
      get { return _orientation; }
    }
  
    private readonly global::System.Collections.Generic.List<float> _point = new global::System.Collections.Generic.List<float>();
    [global::ProtoBuf.ProtoMember(4, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.FixedSize, Options = global::ProtoBuf.MemberSerializationOptions.Packed)]
    public global::System.Collections.Generic.List<float> point
    {
      get { return _point; }
    }
  
    private readonly global::System.Collections.Generic.List<NetworkMessages.Trame.SkeletonMessage.Joint> _children = new global::System.Collections.Generic.List<NetworkMessages.Trame.SkeletonMessage.Joint>();
    [global::ProtoBuf.ProtoMember(5, Name=@"children", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<NetworkMessages.Trame.SkeletonMessage.Joint> children
    {
      get { return _children; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}