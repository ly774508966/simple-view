//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SetCameraTransformMessage.proto
namespace NetworkMessages
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SetCameraTransformMessage")]
  public partial class SetCameraTransformMessage : global::ProtoBuf.IExtensible
  {
    public SetCameraTransformMessage() {}
    
    private float _cameraPositionX;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"cameraPositionX", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float cameraPositionX
    {
      get { return _cameraPositionX; }
      set { _cameraPositionX = value; }
    }
    private float _cameraPositionY;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"cameraPositionY", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float cameraPositionY
    {
      get { return _cameraPositionY; }
      set { _cameraPositionY = value; }
    }
    private float _cameraPositionZ;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"cameraPositionZ", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float cameraPositionZ
    {
      get { return _cameraPositionZ; }
      set { _cameraPositionZ = value; }
    }
    private float _cameraRotationX;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"cameraRotationX", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float cameraRotationX
    {
      get { return _cameraRotationX; }
      set { _cameraRotationX = value; }
    }
    private float _cameraRotationY;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"cameraRotationY", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float cameraRotationY
    {
      get { return _cameraRotationY; }
      set { _cameraRotationY = value; }
    }
    private float _cameraRotationZ;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"cameraRotationZ", DataFormat = global::ProtoBuf.DataFormat.FixedSize)]
    public float cameraRotationZ
    {
      get { return _cameraRotationZ; }
      set { _cameraRotationZ = value; }
    }
    private long _id;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}