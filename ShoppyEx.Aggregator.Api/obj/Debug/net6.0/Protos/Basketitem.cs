// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/basketitem.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ShoppyEx.Aggregator.Api {

  /// <summary>Holder for reflection information generated from Protos/basketitem.proto</summary>
  public static partial class BasketitemReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/basketitem.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BasketitemReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChdQcm90b3MvYmFza2V0aXRlbS5wcm90bxIOcHJvdG9zLnBhY2thZ2UaHmdv",
            "b2dsZS9wcm90b2J1Zi93cmFwcGVycy5wcm90byLSAQoTQ2hhbmdlQmFza2V0",
            "Q29tbWFuZBIuCghCYXNrZXRJZBgBIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5T",
            "dHJpbmdWYWx1ZRIvCglQcm9kdWN0SWQYAiABKAsyHC5nb29nbGUucHJvdG9i",
            "dWYuU3RyaW5nVmFsdWUSKwoFUHJpY2UYAyABKAsyHC5nb29nbGUucHJvdG9i",
            "dWYuU3RyaW5nVmFsdWUSLQoIUXVhbnRpdHkYBCABKAsyGy5nb29nbGUucHJv",
            "dG9idWYuSW50MzJWYWx1ZSKmAQoXQ3JlYXRlQmFza2V0SXRlbUNvbW1hbmQS",
            "LwoJUHJvZHVjdElkGAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1Zh",
            "bHVlEisKBVByaWNlGAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1Zh",
            "bHVlEi0KCFF1YW50aXR5GAQgASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDMy",
            "VmFsdWUihQIKHEdldEN1cnJlbnRCYXNrZXRJdGVtUmVzcG9uc2USKAoCSWQY",
            "ASABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSLgoIQmFza2V0",
            "SWQYAiABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSLwoJUHJv",
            "ZHVjdElkGAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEisK",
            "BVByaWNlGAQgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEi0K",
            "CFF1YW50aXR5GAUgASgLMhsuZ29vZ2xlLnByb3RvYnVmLkludDMyVmFsdWUy",
            "EAoOQmFza2V0SXRlbUdycGNCGqoCF1Nob3BweUV4LkFnZ3JlZ2F0b3IuQXBp",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Aggregator.Api.ChangeBasketCommand), global::ShoppyEx.Aggregator.Api.ChangeBasketCommand.Parser, new[]{ "BasketId", "ProductId", "Price", "Quantity" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Aggregator.Api.CreateBasketItemCommand), global::ShoppyEx.Aggregator.Api.CreateBasketItemCommand.Parser, new[]{ "ProductId", "Price", "Quantity" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Aggregator.Api.GetCurrentBasketItemResponse), global::ShoppyEx.Aggregator.Api.GetCurrentBasketItemResponse.Parser, new[]{ "Id", "BasketId", "ProductId", "Price", "Quantity" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ChangeBasketCommand : pb::IMessage<ChangeBasketCommand>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ChangeBasketCommand> _parser = new pb::MessageParser<ChangeBasketCommand>(() => new ChangeBasketCommand());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ChangeBasketCommand> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Aggregator.Api.BasketitemReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeBasketCommand() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeBasketCommand(ChangeBasketCommand other) : this() {
      BasketId = other.BasketId;
      ProductId = other.ProductId;
      Price = other.Price;
      Quantity = other.Quantity;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ChangeBasketCommand Clone() {
      return new ChangeBasketCommand(this);
    }

    /// <summary>Field number for the "BasketId" field.</summary>
    public const int BasketIdFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_basketId_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string basketId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BasketId {
      get { return basketId_; }
      set {
        basketId_ = value;
      }
    }


    /// <summary>Field number for the "ProductId" field.</summary>
    public const int ProductIdFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_productId_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductId {
      get { return productId_; }
      set {
        productId_ = value;
      }
    }


    /// <summary>Field number for the "Price" field.</summary>
    public const int PriceFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_price_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }


    /// <summary>Field number for the "Quantity" field.</summary>
    public const int QuantityFieldNumber = 4;
    private static readonly pb::FieldCodec<int?> _single_quantity_codec = pb::FieldCodec.ForStructWrapper<int>(34);
    private int? quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int? Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ChangeBasketCommand);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ChangeBasketCommand other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BasketId != other.BasketId) return false;
      if (ProductId != other.ProductId) return false;
      if (Price != other.Price) return false;
      if (Quantity != other.Quantity) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (basketId_ != null) hash ^= BasketId.GetHashCode();
      if (productId_ != null) hash ^= ProductId.GetHashCode();
      if (price_ != null) hash ^= Price.GetHashCode();
      if (quantity_ != null) hash ^= Quantity.GetHashCode();
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
      if (basketId_ != null) {
        _single_basketId_codec.WriteTagAndValue(output, BasketId);
      }
      if (productId_ != null) {
        _single_productId_codec.WriteTagAndValue(output, ProductId);
      }
      if (price_ != null) {
        _single_price_codec.WriteTagAndValue(output, Price);
      }
      if (quantity_ != null) {
        _single_quantity_codec.WriteTagAndValue(output, Quantity);
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
      if (basketId_ != null) {
        _single_basketId_codec.WriteTagAndValue(ref output, BasketId);
      }
      if (productId_ != null) {
        _single_productId_codec.WriteTagAndValue(ref output, ProductId);
      }
      if (price_ != null) {
        _single_price_codec.WriteTagAndValue(ref output, Price);
      }
      if (quantity_ != null) {
        _single_quantity_codec.WriteTagAndValue(ref output, Quantity);
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
      if (basketId_ != null) {
        size += _single_basketId_codec.CalculateSizeWithTag(BasketId);
      }
      if (productId_ != null) {
        size += _single_productId_codec.CalculateSizeWithTag(ProductId);
      }
      if (price_ != null) {
        size += _single_price_codec.CalculateSizeWithTag(Price);
      }
      if (quantity_ != null) {
        size += _single_quantity_codec.CalculateSizeWithTag(Quantity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ChangeBasketCommand other) {
      if (other == null) {
        return;
      }
      if (other.basketId_ != null) {
        if (basketId_ == null || other.BasketId != "") {
          BasketId = other.BasketId;
        }
      }
      if (other.productId_ != null) {
        if (productId_ == null || other.ProductId != "") {
          ProductId = other.ProductId;
        }
      }
      if (other.price_ != null) {
        if (price_ == null || other.Price != "") {
          Price = other.Price;
        }
      }
      if (other.quantity_ != null) {
        if (quantity_ == null || other.Quantity != 0) {
          Quantity = other.Quantity;
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
            string value = _single_basketId_codec.Read(input);
            if (basketId_ == null || value != "") {
              BasketId = value;
            }
            break;
          }
          case 18: {
            string value = _single_productId_codec.Read(input);
            if (productId_ == null || value != "") {
              ProductId = value;
            }
            break;
          }
          case 26: {
            string value = _single_price_codec.Read(input);
            if (price_ == null || value != "") {
              Price = value;
            }
            break;
          }
          case 34: {
            int? value = _single_quantity_codec.Read(input);
            if (quantity_ == null || value != 0) {
              Quantity = value;
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
            string value = _single_basketId_codec.Read(ref input);
            if (basketId_ == null || value != "") {
              BasketId = value;
            }
            break;
          }
          case 18: {
            string value = _single_productId_codec.Read(ref input);
            if (productId_ == null || value != "") {
              ProductId = value;
            }
            break;
          }
          case 26: {
            string value = _single_price_codec.Read(ref input);
            if (price_ == null || value != "") {
              Price = value;
            }
            break;
          }
          case 34: {
            int? value = _single_quantity_codec.Read(ref input);
            if (quantity_ == null || value != 0) {
              Quantity = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class CreateBasketItemCommand : pb::IMessage<CreateBasketItemCommand>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<CreateBasketItemCommand> _parser = new pb::MessageParser<CreateBasketItemCommand>(() => new CreateBasketItemCommand());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<CreateBasketItemCommand> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Aggregator.Api.BasketitemReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateBasketItemCommand() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateBasketItemCommand(CreateBasketItemCommand other) : this() {
      ProductId = other.ProductId;
      Price = other.Price;
      Quantity = other.Quantity;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public CreateBasketItemCommand Clone() {
      return new CreateBasketItemCommand(this);
    }

    /// <summary>Field number for the "ProductId" field.</summary>
    public const int ProductIdFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_productId_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductId {
      get { return productId_; }
      set {
        productId_ = value;
      }
    }


    /// <summary>Field number for the "Price" field.</summary>
    public const int PriceFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_price_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }


    /// <summary>Field number for the "Quantity" field.</summary>
    public const int QuantityFieldNumber = 4;
    private static readonly pb::FieldCodec<int?> _single_quantity_codec = pb::FieldCodec.ForStructWrapper<int>(34);
    private int? quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int? Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as CreateBasketItemCommand);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(CreateBasketItemCommand other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (ProductId != other.ProductId) return false;
      if (Price != other.Price) return false;
      if (Quantity != other.Quantity) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (productId_ != null) hash ^= ProductId.GetHashCode();
      if (price_ != null) hash ^= Price.GetHashCode();
      if (quantity_ != null) hash ^= Quantity.GetHashCode();
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
      if (productId_ != null) {
        _single_productId_codec.WriteTagAndValue(output, ProductId);
      }
      if (price_ != null) {
        _single_price_codec.WriteTagAndValue(output, Price);
      }
      if (quantity_ != null) {
        _single_quantity_codec.WriteTagAndValue(output, Quantity);
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
      if (productId_ != null) {
        _single_productId_codec.WriteTagAndValue(ref output, ProductId);
      }
      if (price_ != null) {
        _single_price_codec.WriteTagAndValue(ref output, Price);
      }
      if (quantity_ != null) {
        _single_quantity_codec.WriteTagAndValue(ref output, Quantity);
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
      if (productId_ != null) {
        size += _single_productId_codec.CalculateSizeWithTag(ProductId);
      }
      if (price_ != null) {
        size += _single_price_codec.CalculateSizeWithTag(Price);
      }
      if (quantity_ != null) {
        size += _single_quantity_codec.CalculateSizeWithTag(Quantity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(CreateBasketItemCommand other) {
      if (other == null) {
        return;
      }
      if (other.productId_ != null) {
        if (productId_ == null || other.ProductId != "") {
          ProductId = other.ProductId;
        }
      }
      if (other.price_ != null) {
        if (price_ == null || other.Price != "") {
          Price = other.Price;
        }
      }
      if (other.quantity_ != null) {
        if (quantity_ == null || other.Quantity != 0) {
          Quantity = other.Quantity;
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
          case 18: {
            string value = _single_productId_codec.Read(input);
            if (productId_ == null || value != "") {
              ProductId = value;
            }
            break;
          }
          case 26: {
            string value = _single_price_codec.Read(input);
            if (price_ == null || value != "") {
              Price = value;
            }
            break;
          }
          case 34: {
            int? value = _single_quantity_codec.Read(input);
            if (quantity_ == null || value != 0) {
              Quantity = value;
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
          case 18: {
            string value = _single_productId_codec.Read(ref input);
            if (productId_ == null || value != "") {
              ProductId = value;
            }
            break;
          }
          case 26: {
            string value = _single_price_codec.Read(ref input);
            if (price_ == null || value != "") {
              Price = value;
            }
            break;
          }
          case 34: {
            int? value = _single_quantity_codec.Read(ref input);
            if (quantity_ == null || value != 0) {
              Quantity = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class GetCurrentBasketItemResponse : pb::IMessage<GetCurrentBasketItemResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetCurrentBasketItemResponse> _parser = new pb::MessageParser<GetCurrentBasketItemResponse>(() => new GetCurrentBasketItemResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetCurrentBasketItemResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Aggregator.Api.BasketitemReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurrentBasketItemResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurrentBasketItemResponse(GetCurrentBasketItemResponse other) : this() {
      Id = other.Id;
      BasketId = other.BasketId;
      ProductId = other.ProductId;
      Price = other.Price;
      Quantity = other.Quantity;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetCurrentBasketItemResponse Clone() {
      return new GetCurrentBasketItemResponse(this);
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


    /// <summary>Field number for the "BasketId" field.</summary>
    public const int BasketIdFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_basketId_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string basketId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string BasketId {
      get { return basketId_; }
      set {
        basketId_ = value;
      }
    }


    /// <summary>Field number for the "ProductId" field.</summary>
    public const int ProductIdFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_productId_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string productId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ProductId {
      get { return productId_; }
      set {
        productId_ = value;
      }
    }


    /// <summary>Field number for the "Price" field.</summary>
    public const int PriceFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_price_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }


    /// <summary>Field number for the "Quantity" field.</summary>
    public const int QuantityFieldNumber = 5;
    private static readonly pb::FieldCodec<int?> _single_quantity_codec = pb::FieldCodec.ForStructWrapper<int>(42);
    private int? quantity_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int? Quantity {
      get { return quantity_; }
      set {
        quantity_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetCurrentBasketItemResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetCurrentBasketItemResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (BasketId != other.BasketId) return false;
      if (ProductId != other.ProductId) return false;
      if (Price != other.Price) return false;
      if (Quantity != other.Quantity) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (basketId_ != null) hash ^= BasketId.GetHashCode();
      if (productId_ != null) hash ^= ProductId.GetHashCode();
      if (price_ != null) hash ^= Price.GetHashCode();
      if (quantity_ != null) hash ^= Quantity.GetHashCode();
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
      if (basketId_ != null) {
        _single_basketId_codec.WriteTagAndValue(output, BasketId);
      }
      if (productId_ != null) {
        _single_productId_codec.WriteTagAndValue(output, ProductId);
      }
      if (price_ != null) {
        _single_price_codec.WriteTagAndValue(output, Price);
      }
      if (quantity_ != null) {
        _single_quantity_codec.WriteTagAndValue(output, Quantity);
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
      if (basketId_ != null) {
        _single_basketId_codec.WriteTagAndValue(ref output, BasketId);
      }
      if (productId_ != null) {
        _single_productId_codec.WriteTagAndValue(ref output, ProductId);
      }
      if (price_ != null) {
        _single_price_codec.WriteTagAndValue(ref output, Price);
      }
      if (quantity_ != null) {
        _single_quantity_codec.WriteTagAndValue(ref output, Quantity);
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
      if (basketId_ != null) {
        size += _single_basketId_codec.CalculateSizeWithTag(BasketId);
      }
      if (productId_ != null) {
        size += _single_productId_codec.CalculateSizeWithTag(ProductId);
      }
      if (price_ != null) {
        size += _single_price_codec.CalculateSizeWithTag(Price);
      }
      if (quantity_ != null) {
        size += _single_quantity_codec.CalculateSizeWithTag(Quantity);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetCurrentBasketItemResponse other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != "") {
          Id = other.Id;
        }
      }
      if (other.basketId_ != null) {
        if (basketId_ == null || other.BasketId != "") {
          BasketId = other.BasketId;
        }
      }
      if (other.productId_ != null) {
        if (productId_ == null || other.ProductId != "") {
          ProductId = other.ProductId;
        }
      }
      if (other.price_ != null) {
        if (price_ == null || other.Price != "") {
          Price = other.Price;
        }
      }
      if (other.quantity_ != null) {
        if (quantity_ == null || other.Quantity != 0) {
          Quantity = other.Quantity;
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
          case 18: {
            string value = _single_basketId_codec.Read(input);
            if (basketId_ == null || value != "") {
              BasketId = value;
            }
            break;
          }
          case 26: {
            string value = _single_productId_codec.Read(input);
            if (productId_ == null || value != "") {
              ProductId = value;
            }
            break;
          }
          case 34: {
            string value = _single_price_codec.Read(input);
            if (price_ == null || value != "") {
              Price = value;
            }
            break;
          }
          case 42: {
            int? value = _single_quantity_codec.Read(input);
            if (quantity_ == null || value != 0) {
              Quantity = value;
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
          case 18: {
            string value = _single_basketId_codec.Read(ref input);
            if (basketId_ == null || value != "") {
              BasketId = value;
            }
            break;
          }
          case 26: {
            string value = _single_productId_codec.Read(ref input);
            if (productId_ == null || value != "") {
              ProductId = value;
            }
            break;
          }
          case 34: {
            string value = _single_price_codec.Read(ref input);
            if (price_ == null || value != "") {
              Price = value;
            }
            break;
          }
          case 42: {
            int? value = _single_quantity_codec.Read(ref input);
            if (quantity_ == null || value != 0) {
              Quantity = value;
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
