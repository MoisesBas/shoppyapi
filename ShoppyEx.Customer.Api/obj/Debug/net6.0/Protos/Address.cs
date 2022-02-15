// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/address.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace ShoppyEx.Customer.Api.Protos {

  /// <summary>Holder for reflection information generated from Protos/address.proto</summary>
  public static partial class AddressReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/address.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AddressReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChRQcm90b3MvYWRkcmVzcy5wcm90bxIOcHJvdG9zLnBhY2thZ2UaHmdvb2ds",
            "ZS9wcm90b2J1Zi93cmFwcGVycy5wcm90byKsAgoWQWRkcmVzc1Jlc3BvbnNl",
            "TWVzc2FnZRIoCgJJZBgBIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdW",
            "YWx1ZRIqCgRDaXR5GAIgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1Zh",
            "bHVlEi0KB0NvdW50cnkYAyABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5n",
            "VmFsdWUSLQoHQWRkcmVzcxgEIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJp",
            "bmdWYWx1ZRIsCgZSZWdpb24YBSABKAsyHC5nb29nbGUucHJvdG9idWYuU3Ry",
            "aW5nVmFsdWUSMAoKUG9zdGFsQ29kZRgGIAEoCzIcLmdvb2dsZS5wcm90b2J1",
            "Zi5TdHJpbmdWYWx1ZSKBAgoVQWRkcmVzc1JlcXVlc3RNZXNzYWdlEioKBENp",
            "dHkYASABKAsyHC5nb29nbGUucHJvdG9idWYuU3RyaW5nVmFsdWUSLQoHQ291",
            "bnRyeRgCIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRItCgdB",
            "ZGRyZXNzGAMgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1ZhbHVlEiwK",
            "BlJlZ2lvbhgEIAEoCzIcLmdvb2dsZS5wcm90b2J1Zi5TdHJpbmdWYWx1ZRIw",
            "CgpQb3N0YWxDb2RlGAUgASgLMhwuZ29vZ2xlLnByb3RvYnVmLlN0cmluZ1Zh",
            "bHVlMg0KC0FkZHJlc3NHcnBjQh+qAhxTaG9wcHlFeC5DdXN0b21lci5BcGku",
            "UHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Customer.Api.Protos.AddressResponseMessage), global::ShoppyEx.Customer.Api.Protos.AddressResponseMessage.Parser, new[]{ "Id", "City", "Country", "Address", "Region", "PostalCode" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::ShoppyEx.Customer.Api.Protos.AddressRequestMessage), global::ShoppyEx.Customer.Api.Protos.AddressRequestMessage.Parser, new[]{ "City", "Country", "Address", "Region", "PostalCode" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class AddressResponseMessage : pb::IMessage<AddressResponseMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddressResponseMessage> _parser = new pb::MessageParser<AddressResponseMessage>(() => new AddressResponseMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddressResponseMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Customer.Api.Protos.AddressReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressResponseMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressResponseMessage(AddressResponseMessage other) : this() {
      Id = other.Id;
      City = other.City;
      Country = other.Country;
      Address = other.Address;
      Region = other.Region;
      PostalCode = other.PostalCode;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressResponseMessage Clone() {
      return new AddressResponseMessage(this);
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


    /// <summary>Field number for the "City" field.</summary>
    public const int CityFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_city_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string city_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string City {
      get { return city_; }
      set {
        city_ = value;
      }
    }


    /// <summary>Field number for the "Country" field.</summary>
    public const int CountryFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_country_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string country_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Country {
      get { return country_; }
      set {
        country_ = value;
      }
    }


    /// <summary>Field number for the "Address" field.</summary>
    public const int AddressFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_address_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string address_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = value;
      }
    }


    /// <summary>Field number for the "Region" field.</summary>
    public const int RegionFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_region_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string region_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_; }
      set {
        region_ = value;
      }
    }


    /// <summary>Field number for the "PostalCode" field.</summary>
    public const int PostalCodeFieldNumber = 6;
    private static readonly pb::FieldCodec<string> _single_postalCode_codec = pb::FieldCodec.ForClassWrapper<string>(50);
    private string postalCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PostalCode {
      get { return postalCode_; }
      set {
        postalCode_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddressResponseMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddressResponseMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (City != other.City) return false;
      if (Country != other.Country) return false;
      if (Address != other.Address) return false;
      if (Region != other.Region) return false;
      if (PostalCode != other.PostalCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (id_ != null) hash ^= Id.GetHashCode();
      if (city_ != null) hash ^= City.GetHashCode();
      if (country_ != null) hash ^= Country.GetHashCode();
      if (address_ != null) hash ^= Address.GetHashCode();
      if (region_ != null) hash ^= Region.GetHashCode();
      if (postalCode_ != null) hash ^= PostalCode.GetHashCode();
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
      if (city_ != null) {
        _single_city_codec.WriteTagAndValue(output, City);
      }
      if (country_ != null) {
        _single_country_codec.WriteTagAndValue(output, Country);
      }
      if (address_ != null) {
        _single_address_codec.WriteTagAndValue(output, Address);
      }
      if (region_ != null) {
        _single_region_codec.WriteTagAndValue(output, Region);
      }
      if (postalCode_ != null) {
        _single_postalCode_codec.WriteTagAndValue(output, PostalCode);
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
      if (city_ != null) {
        _single_city_codec.WriteTagAndValue(ref output, City);
      }
      if (country_ != null) {
        _single_country_codec.WriteTagAndValue(ref output, Country);
      }
      if (address_ != null) {
        _single_address_codec.WriteTagAndValue(ref output, Address);
      }
      if (region_ != null) {
        _single_region_codec.WriteTagAndValue(ref output, Region);
      }
      if (postalCode_ != null) {
        _single_postalCode_codec.WriteTagAndValue(ref output, PostalCode);
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
      if (city_ != null) {
        size += _single_city_codec.CalculateSizeWithTag(City);
      }
      if (country_ != null) {
        size += _single_country_codec.CalculateSizeWithTag(Country);
      }
      if (address_ != null) {
        size += _single_address_codec.CalculateSizeWithTag(Address);
      }
      if (region_ != null) {
        size += _single_region_codec.CalculateSizeWithTag(Region);
      }
      if (postalCode_ != null) {
        size += _single_postalCode_codec.CalculateSizeWithTag(PostalCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddressResponseMessage other) {
      if (other == null) {
        return;
      }
      if (other.id_ != null) {
        if (id_ == null || other.Id != "") {
          Id = other.Id;
        }
      }
      if (other.city_ != null) {
        if (city_ == null || other.City != "") {
          City = other.City;
        }
      }
      if (other.country_ != null) {
        if (country_ == null || other.Country != "") {
          Country = other.Country;
        }
      }
      if (other.address_ != null) {
        if (address_ == null || other.Address != "") {
          Address = other.Address;
        }
      }
      if (other.region_ != null) {
        if (region_ == null || other.Region != "") {
          Region = other.Region;
        }
      }
      if (other.postalCode_ != null) {
        if (postalCode_ == null || other.PostalCode != "") {
          PostalCode = other.PostalCode;
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
            string value = _single_city_codec.Read(input);
            if (city_ == null || value != "") {
              City = value;
            }
            break;
          }
          case 26: {
            string value = _single_country_codec.Read(input);
            if (country_ == null || value != "") {
              Country = value;
            }
            break;
          }
          case 34: {
            string value = _single_address_codec.Read(input);
            if (address_ == null || value != "") {
              Address = value;
            }
            break;
          }
          case 42: {
            string value = _single_region_codec.Read(input);
            if (region_ == null || value != "") {
              Region = value;
            }
            break;
          }
          case 50: {
            string value = _single_postalCode_codec.Read(input);
            if (postalCode_ == null || value != "") {
              PostalCode = value;
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
            string value = _single_city_codec.Read(ref input);
            if (city_ == null || value != "") {
              City = value;
            }
            break;
          }
          case 26: {
            string value = _single_country_codec.Read(ref input);
            if (country_ == null || value != "") {
              Country = value;
            }
            break;
          }
          case 34: {
            string value = _single_address_codec.Read(ref input);
            if (address_ == null || value != "") {
              Address = value;
            }
            break;
          }
          case 42: {
            string value = _single_region_codec.Read(ref input);
            if (region_ == null || value != "") {
              Region = value;
            }
            break;
          }
          case 50: {
            string value = _single_postalCode_codec.Read(ref input);
            if (postalCode_ == null || value != "") {
              PostalCode = value;
            }
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class AddressRequestMessage : pb::IMessage<AddressRequestMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AddressRequestMessage> _parser = new pb::MessageParser<AddressRequestMessage>(() => new AddressRequestMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AddressRequestMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::ShoppyEx.Customer.Api.Protos.AddressReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressRequestMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressRequestMessage(AddressRequestMessage other) : this() {
      City = other.City;
      Country = other.Country;
      Address = other.Address;
      Region = other.Region;
      PostalCode = other.PostalCode;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AddressRequestMessage Clone() {
      return new AddressRequestMessage(this);
    }

    /// <summary>Field number for the "City" field.</summary>
    public const int CityFieldNumber = 1;
    private static readonly pb::FieldCodec<string> _single_city_codec = pb::FieldCodec.ForClassWrapper<string>(10);
    private string city_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string City {
      get { return city_; }
      set {
        city_ = value;
      }
    }


    /// <summary>Field number for the "Country" field.</summary>
    public const int CountryFieldNumber = 2;
    private static readonly pb::FieldCodec<string> _single_country_codec = pb::FieldCodec.ForClassWrapper<string>(18);
    private string country_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Country {
      get { return country_; }
      set {
        country_ = value;
      }
    }


    /// <summary>Field number for the "Address" field.</summary>
    public const int AddressFieldNumber = 3;
    private static readonly pb::FieldCodec<string> _single_address_codec = pb::FieldCodec.ForClassWrapper<string>(26);
    private string address_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Address {
      get { return address_; }
      set {
        address_ = value;
      }
    }


    /// <summary>Field number for the "Region" field.</summary>
    public const int RegionFieldNumber = 4;
    private static readonly pb::FieldCodec<string> _single_region_codec = pb::FieldCodec.ForClassWrapper<string>(34);
    private string region_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Region {
      get { return region_; }
      set {
        region_ = value;
      }
    }


    /// <summary>Field number for the "PostalCode" field.</summary>
    public const int PostalCodeFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _single_postalCode_codec = pb::FieldCodec.ForClassWrapper<string>(42);
    private string postalCode_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PostalCode {
      get { return postalCode_; }
      set {
        postalCode_ = value;
      }
    }


    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AddressRequestMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AddressRequestMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (City != other.City) return false;
      if (Country != other.Country) return false;
      if (Address != other.Address) return false;
      if (Region != other.Region) return false;
      if (PostalCode != other.PostalCode) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (city_ != null) hash ^= City.GetHashCode();
      if (country_ != null) hash ^= Country.GetHashCode();
      if (address_ != null) hash ^= Address.GetHashCode();
      if (region_ != null) hash ^= Region.GetHashCode();
      if (postalCode_ != null) hash ^= PostalCode.GetHashCode();
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
      if (city_ != null) {
        _single_city_codec.WriteTagAndValue(output, City);
      }
      if (country_ != null) {
        _single_country_codec.WriteTagAndValue(output, Country);
      }
      if (address_ != null) {
        _single_address_codec.WriteTagAndValue(output, Address);
      }
      if (region_ != null) {
        _single_region_codec.WriteTagAndValue(output, Region);
      }
      if (postalCode_ != null) {
        _single_postalCode_codec.WriteTagAndValue(output, PostalCode);
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
      if (city_ != null) {
        _single_city_codec.WriteTagAndValue(ref output, City);
      }
      if (country_ != null) {
        _single_country_codec.WriteTagAndValue(ref output, Country);
      }
      if (address_ != null) {
        _single_address_codec.WriteTagAndValue(ref output, Address);
      }
      if (region_ != null) {
        _single_region_codec.WriteTagAndValue(ref output, Region);
      }
      if (postalCode_ != null) {
        _single_postalCode_codec.WriteTagAndValue(ref output, PostalCode);
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
      if (city_ != null) {
        size += _single_city_codec.CalculateSizeWithTag(City);
      }
      if (country_ != null) {
        size += _single_country_codec.CalculateSizeWithTag(Country);
      }
      if (address_ != null) {
        size += _single_address_codec.CalculateSizeWithTag(Address);
      }
      if (region_ != null) {
        size += _single_region_codec.CalculateSizeWithTag(Region);
      }
      if (postalCode_ != null) {
        size += _single_postalCode_codec.CalculateSizeWithTag(PostalCode);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AddressRequestMessage other) {
      if (other == null) {
        return;
      }
      if (other.city_ != null) {
        if (city_ == null || other.City != "") {
          City = other.City;
        }
      }
      if (other.country_ != null) {
        if (country_ == null || other.Country != "") {
          Country = other.Country;
        }
      }
      if (other.address_ != null) {
        if (address_ == null || other.Address != "") {
          Address = other.Address;
        }
      }
      if (other.region_ != null) {
        if (region_ == null || other.Region != "") {
          Region = other.Region;
        }
      }
      if (other.postalCode_ != null) {
        if (postalCode_ == null || other.PostalCode != "") {
          PostalCode = other.PostalCode;
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
            string value = _single_city_codec.Read(input);
            if (city_ == null || value != "") {
              City = value;
            }
            break;
          }
          case 18: {
            string value = _single_country_codec.Read(input);
            if (country_ == null || value != "") {
              Country = value;
            }
            break;
          }
          case 26: {
            string value = _single_address_codec.Read(input);
            if (address_ == null || value != "") {
              Address = value;
            }
            break;
          }
          case 34: {
            string value = _single_region_codec.Read(input);
            if (region_ == null || value != "") {
              Region = value;
            }
            break;
          }
          case 42: {
            string value = _single_postalCode_codec.Read(input);
            if (postalCode_ == null || value != "") {
              PostalCode = value;
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
            string value = _single_city_codec.Read(ref input);
            if (city_ == null || value != "") {
              City = value;
            }
            break;
          }
          case 18: {
            string value = _single_country_codec.Read(ref input);
            if (country_ == null || value != "") {
              Country = value;
            }
            break;
          }
          case 26: {
            string value = _single_address_codec.Read(ref input);
            if (address_ == null || value != "") {
              Address = value;
            }
            break;
          }
          case 34: {
            string value = _single_region_codec.Read(ref input);
            if (region_ == null || value != "") {
              Region = value;
            }
            break;
          }
          case 42: {
            string value = _single_postalCode_codec.Read(ref input);
            if (postalCode_ == null || value != "") {
              PostalCode = value;
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
