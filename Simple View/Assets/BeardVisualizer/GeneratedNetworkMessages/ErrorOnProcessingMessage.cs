//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ErrorOnProcessingMessage.proto
namespace NetworkMessages
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ErrorOnProcessingMessage")]
  public partial class ErrorOnProcessingMessage : global::ProtoBuf.IExtensible
  {
    public ErrorOnProcessingMessage() {}
    
    private byte[] _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public byte[] id
    {
      get { return _id; }
      set { _id = value; }
    }
    private NetworkMessages.ErrorOnProcessingMessage.ErrorCode _errorCode = NetworkMessages.ErrorOnProcessingMessage.ErrorCode.UNKNOWN;
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"errorCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(NetworkMessages.ErrorOnProcessingMessage.ErrorCode.UNKNOWN)]
    public NetworkMessages.ErrorOnProcessingMessage.ErrorCode errorCode
    {
      get { return _errorCode; }
      set { _errorCode = value; }
    }
    private string _errorMessage = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"errorMessage", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string errorMessage
    {
      get { return _errorMessage; }
      set { _errorMessage = value; }
    }
    [global::ProtoBuf.ProtoContract(Name=@"ErrorCode")]
    public enum ErrorCode
    {
            
      [global::ProtoBuf.ProtoEnum(Name=@"UNKNOWN", Value=0)]
      UNKNOWN = 0,
            
      [global::ProtoBuf.ProtoEnum(Name=@"MESSAGETYPENOTSUPPORTED", Value=1)]
      MESSAGETYPENOTSUPPORTED = 1,
            
      [global::ProtoBuf.ProtoEnum(Name=@"PROCESSINGMESSAGEFAILED", Value=2)]
      PROCESSINGMESSAGEFAILED = 2
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}