//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: i2enetworkmessagedefinitions/NetworkMessage.proto
namespace NetworkMessages
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NetworkMessage")]
  public partial class NetworkMessage : global::ProtoBuf.IExtensible
  {
    public NetworkMessage() {}
    
    private bool _requiresAnswer = (bool)false;
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"requiresAnswer", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue((bool)false)]
    public bool requiresAnswer
    {
      get { return _requiresAnswer; }
      set { _requiresAnswer = value; }
    }
    private byte[] _transactionId = null;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"transactionId", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] transactionId
    {
      get { return _transactionId; }
      set { _transactionId = value; }
    }
    private int _messageTypeId;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"messageTypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int messageTypeId
    {
      get { return _messageTypeId; }
      set { _messageTypeId = value; }
    }
    private byte[] _payloadMessage;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"payloadMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] payloadMessage
    {
      get { return _payloadMessage; }
      set { _payloadMessage = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}