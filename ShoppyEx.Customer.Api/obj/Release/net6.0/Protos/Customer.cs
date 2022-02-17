// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/customer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ShoppyEx.Customer.Api {

  /// <summary>Holder for reflection information generated from Protos/customer.proto</summary>
  public static partial class CustomerReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/customer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CustomerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChVQcm90b3MvY3VzdG9tZXIucHJvdG8SDnByb3Rvcy5wYWNrYWdlGh5nb29n",
            "bGUvcHJvdG9idWYvd3JhcHBlcnMucHJvdG8aFHByb3Rvcy9hZGRyZXNzLnBy",
            "b3RvIkYKGkN1c3RvbWVyQnlJZFJlcXVlc3RNZXNzYWdlEigKAklkGAEgASgL",
            "MhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlIrABChxDdXN0b21lckNy",
            "ZWF0ZVJlcXVlc3RNZXNzYWdlEioKBE5hbWUYASABKAsyHC5nb29nbGUucHJv",
            "dG9idWYuU3RyaW5nVmFsdWUSLAoGVXNlcklkGAIgASgLMhwuZ29vZ2xlLnBy",
            "b3RvYnVmLlN0cmluZ1ZhbHVlEjYKB0FkZHJlc3MYAyABKAsyJS5wcm90b3Mu",
            "cGFja2FnZS5BZGRyZXNzUmVxdWVzdE1lc3NhZ2Ui1gEKF0N1c3RvbWVyUmVz",
            "cG9uc2VNZXNzYWdlEigKAklkGAEgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0",
            "cmluZ1ZhbHVlEioKBE5hbWUYAiABKAsyHC5nb29nbGUucHJvdG9idWYuU3Ry",
            "aW5nVmFsdWUSLAoGVXNlcklkGAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0",
            "cmluZ1ZhbHVlEjcKB0FkZHJlc3MYBCABKAsyJi5wcm90b3MucGFja2FnZS5B",
            "ZGRyZXNzUmVzcG9uc2VNZXNzYWdlIkUKGUN1c3RvbWVySWRSZXNwb25zZU1l",
            "c3NhZ2USKAoCSWQYASABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFs",
            "dWUy4gEKDEN1c3RvbWVyR3JwYxJoCgtBZGRDdXN0b21lchIsLnByb3Rvcy5w",
            "YWNrYWdlLkN1c3RvbWVyQ3JlYXRlUmVxdWVzdE1lc3NhZ2UaKS5wcm90b3Mu",
            "cGFja2FnZS5DdXN0b21lcklkUmVzcG9uc2VNZXNzYWdlIgASaAoPR2V0Q3Vz",
            "dG9tZXJCeUlkEioucHJvdG9zLnBhY2thZ2UuQ3VzdG9tZXJCeUlkUmVxdWVz",
            "dE1lc3NhZ2UaJy5wcm90b3MucGFja2FnZS5DdXN0b21lclJlc3BvbnNlTWVz",
            "c2FnZSIAQhiqAhVTaG9wcHlFeC5DdXN0b21lci5BcGliBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::ShoppyEx.Customer.Api.AddressReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Customer.Api.CustomerByIdRequestMessage), global::ShoppyEx.Customer.Api.CustomerByIdRequestMessage.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Customer.Api.CustomerCreateRequestMessage), global::ShoppyEx.Customer.Api.CustomerCreateRequestMessage.Parser, new[]{ "Name", "UserId", "Address" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Customer.Api.CustomerResponseMessage), global::ShoppyEx.Customer.Api.CustomerResponseMessage.Parser, new[]{ "Id", "Name", "UserId", "Address" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Customer.Api.CustomerIdResponseMessage), global::ShoppyEx.Customer.Api.CustomerIdResponseMessage.Parser, new[]{ "Id" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class CustomerByIdRequestMessage : pb::IMessage<CustomerByIdRequestMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerByIdRequestMessage> _parser = new pb::MessageParser<CustomerByIdRequestMessage>(() => new CustomerByIdRequestMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerByIdRequestMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Customer.Api.CustomerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerByIdRequestMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerByIdRequestMessage(CustomerByIdRequestMessage other) : this() {
      Id = other.Id;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerByIdRequestMessage Clone() {
      return new CustomerByIdRequestMessage(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_id_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerByIdRequestMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerByIdRequestMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(ref output, Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerByIdRequestMessage other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != "") {
          Id = other.Id;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            string value = _single_id_codec.Read(input);
            if (id_ == null || value != "") {
              Id = value;
            }
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            string value = _single_id_codec.Read(ref input);
            if (id_ == null || value != "") {
              Id = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CustomerCreateRequestMessage : pb::IMessage<CustomerCreateRequestMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerCreateRequestMessage> _parser = new pb::MessageParser<CustomerCreateRequestMessage>(() => new CustomerCreateRequestMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerCreateRequestMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Customer.Api.CustomerReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerCreateRequestMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerCreateRequestMessage(CustomerCreateRequestMessage other) : this() {
      Name = other.Name;
      UserId = other.UserId;
      address_ = other.address_ != null ? other.address_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerCreateRequestMessage Clone() {
      return new CustomerCreateRequestMessage(this);
    }

    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string name_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_userId_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }


    /// <summary>Field number for the "Address" field.</summary>
    public const int AddressFieldNumber = 3;
    private global::ShoppyEx.Customer.Api.AddressRequestMessage address_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ShoppyEx.Customer.Api.AddressRequestMessage Address {
      get { return address_; }
      set {
        address_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerCreateRequestMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerCreateRequestMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (UserId != other.UserId) return false;
      if (!object.Equals(Address, other.Address)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (name_ != null) hash ^= Name.GetHashCode();
      if (userId_ != null) hash ^= UserId.GetHashCode();
      if (address_ != null) hash ^= Address.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (userId_ != null) {
        _single_userId_codec.WriteTagAndValue(output, UserId);
      }
      if (address_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Address);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(ref output, Name);
      }
      if (userId_ != null) {
        _single_userId_codec.WriteTagAndValue(ref output, UserId);
      }
      if (address_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Address);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (userId_ != null) {
        size += _single_userId_codec.CalculateSizeWithTag(UserId);
      }
      if (address_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Address);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerCreateRequestMessage other) {
      if (other == null) {
        return;
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.userId_ != null) {
        if (userId_ == null || other.UserId != "") {
          UserId = other.UserId;
        }
      }
      if (other.address_ != null) {
        if (address_ == null) {
          Address = new global::ShoppyEx.Customer.Api.AddressRequestMessage();
        }
        Address.MergeFrom(other.Address);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 18: {
            string value = _single_userId_codec.Read(input);
            if (userId_ == null || value != "") {
              UserId = value;
            }
            break;
          }
          case 26: {
            if (address_ == null) {
              Address = new global::ShoppyEx.Customer.Api.AddressRequestMessage();
            }
            input.ReadMessage(Address);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            string value = _single_name_codec.Read(ref input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 18: {
            string value = _single_userId_codec.Read(ref input);
            if (userId_ == null || value != "") {
              UserId = value;
            }
            break;
          }
          case 26: {
            if (address_ == null) {
              Address = new global::ShoppyEx.Customer.Api.AddressRequestMessage();
            }
            input.ReadMessage(Address);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CustomerResponseMessage : pb::IMessage<CustomerResponseMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerResponseMessage> _parser = new pb::MessageParser<CustomerResponseMessage>(() => new CustomerResponseMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerResponseMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Customer.Api.CustomerReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerResponseMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerResponseMessage(CustomerResponseMessage other) : this() {
      Id = other.Id;
      Name = other.Name;
      UserId = other.UserId;
      address_ = other.address_ != null ? other.address_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerResponseMessage Clone() {
      return new CustomerResponseMessage(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_id_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    /// <summary>Field number for the "Name" field.</summary>
    public const int NameFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_name_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string name_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = value;
      }
    }


    /// <summary>Field number for the "UserId" field.</summary>
    public const int UserIdFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_userId_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string userId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string UserId {
      get { return userId_; }
      set {
        userId_ = value;
      }
    }


    /// <summary>Field number for the "Address" field.</summary>
    public const int AddressFieldNumber = 4;
    private global::ShoppyEx.Customer.Api.AddressResponseMessage address_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::ShoppyEx.Customer.Api.AddressResponseMessage Address {
      get { return address_; }
      set {
        address_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerResponseMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerResponseMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Name != other.Name) return false;
      if (UserId != other.UserId) return false;
      if (!object.Equals(Address, other.Address)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (name_ != null) hash ^= Name.GetHashCode();
      if (userId_ != null) hash ^= UserId.GetHashCode();
      if (address_ != null) hash ^= Address.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(output, Name);
      }
      if (userId_ != null) {
        _single_userId_codec.WriteTagAndValue(output, UserId);
      }
      if (address_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Address);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(ref output, Id);
      }
      if (name_ != null) {
        _single_name_codec.WriteTagAndValue(ref output, Name);
      }
      if (userId_ != null) {
        _single_userId_codec.WriteTagAndValue(ref output, UserId);
      }
      if (address_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Address);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (name_ != null) {
        size += _single_name_codec.CalculateSizeWithTag(Name);
      }
      if (userId_ != null) {
        size += _single_userId_codec.CalculateSizeWithTag(UserId);
      }
      if (address_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Address);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerResponseMessage other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != "") {
          Id = other.Id;
        }
      }
      if (other.name_ != null) {
        if (name_ == null || other.Name != "") {
          Name = other.Name;
        }
      }
      if (other.userId_ != null) {
        if (userId_ == null || other.UserId != "") {
          UserId = other.UserId;
        }
      }
      if (other.address_ != null) {
        if (address_ == null) {
          Address = new global::ShoppyEx.Customer.Api.AddressResponseMessage();
        }
        Address.MergeFrom(other.Address);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            string value = _single_id_codec.Read(input);
            if (id_ == null || value != "") {
              Id = value;
            }
            break;
          }
          case 18: {
            string value = _single_name_codec.Read(input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 26: {
            string value = _single_userId_codec.Read(input);
            if (userId_ == null || value != "") {
              UserId = value;
            }
            break;
          }
          case 34: {
            if (address_ == null) {
              Address = new global::ShoppyEx.Customer.Api.AddressResponseMessage();
            }
            input.ReadMessage(Address);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            string value = _single_id_codec.Read(ref input);
            if (id_ == null || value != "") {
              Id = value;
            }
            break;
          }
          case 18: {
            string value = _single_name_codec.Read(ref input);
            if (name_ == null || value != "") {
              Name = value;
            }
            break;
          }
          case 26: {
            string value = _single_userId_codec.Read(ref input);
            if (userId_ == null || value != "") {
              UserId = value;
            }
            break;
          }
          case 34: {
            if (address_ == null) {
              Address = new global::ShoppyEx.Customer.Api.AddressResponseMessage();
            }
            input.ReadMessage(Address);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CustomerIdResponseMessage : pb::IMessage<CustomerIdResponseMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CustomerIdResponseMessage> _parser = new pb::MessageParser<CustomerIdResponseMessage>(() => new CustomerIdResponseMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CustomerIdResponseMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Customer.Api.CustomerReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerIdResponseMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerIdResponseMessage(CustomerIdResponseMessage other) : this() {
      Id = other.Id;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CustomerIdResponseMessage Clone() {
      return new CustomerIdResponseMessage(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_id_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string id_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Id {
      get { return id_; }
      set {
        id_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CustomerIdResponseMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CustomerIdResponseMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(output, Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (id_ != null) {
        _single_id_codec.WriteTagAndValue(ref output, Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (id_ != null) {
        size += _single_id_codec.CalculateSizeWithTag(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CustomerIdResponseMessage other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != "") {
          Id = other.Id;
        }
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            string value = _single_id_codec.Read(input);
            if (id_ == null || value != "") {
              Id = value;
            }
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            string value = _single_id_codec.Read(ref input);
            if (id_ == null || value != "") {
              Id = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
