// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/product.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ShoppyEx.Aggregator.Api.Protos {
  public static partial class ProductGrpc
  {
    static readonly string __ServiceName = "protos.package.ProductGrpc";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Aggregator.Api.Protos.ProductByIdRequestMessage> __Marshaller_protos_package_ProductByIdRequestMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Aggregator.Api.Protos.ProductByIdRequestMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Aggregator.Api.Protos.ProductResponseMessage> __Marshaller_protos_package_ProductResponseMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Aggregator.Api.Protos.ProductResponseMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Aggregator.Api.Protos.ProductPageQueryRequestMessage> __Marshaller_protos_package_ProductPageQueryRequestMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Aggregator.Api.Protos.ProductPageQueryRequestMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Aggregator.Api.Protos.ProductListMessage> __Marshaller_protos_package_ProductListMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Aggregator.Api.Protos.ProductListMessage.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ShoppyEx.Aggregator.Api.Protos.ProductByIdRequestMessage, global::ShoppyEx.Aggregator.Api.Protos.ProductResponseMessage> __Method_GetProductById = new grpc::Method<global::ShoppyEx.Aggregator.Api.Protos.ProductByIdRequestMessage, global::ShoppyEx.Aggregator.Api.Protos.ProductResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductById",
        __Marshaller_protos_package_ProductByIdRequestMessage,
        __Marshaller_protos_package_ProductResponseMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ShoppyEx.Aggregator.Api.Protos.ProductPageQueryRequestMessage, global::ShoppyEx.Aggregator.Api.Protos.ProductListMessage> __Method_GetProductAll = new grpc::Method<global::ShoppyEx.Aggregator.Api.Protos.ProductPageQueryRequestMessage, global::ShoppyEx.Aggregator.Api.Protos.ProductListMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductAll",
        __Marshaller_protos_package_ProductPageQueryRequestMessage,
        __Marshaller_protos_package_ProductListMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ShoppyEx.Aggregator.Api.Protos.ProductReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for ProductGrpc</summary>
    public partial class ProductGrpcClient : grpc::ClientBase<ProductGrpcClient>
    {
      /// <summary>Creates a new client for ProductGrpc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductGrpcClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ProductGrpc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public ProductGrpcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductGrpcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected ProductGrpcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Aggregator.Api.Protos.ProductResponseMessage GetProductById(global::ShoppyEx.Aggregator.Api.Protos.ProductByIdRequestMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Aggregator.Api.Protos.ProductResponseMessage GetProductById(global::ShoppyEx.Aggregator.Api.Protos.ProductByIdRequestMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Aggregator.Api.Protos.ProductResponseMessage> GetProductByIdAsync(global::ShoppyEx.Aggregator.Api.Protos.ProductByIdRequestMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Aggregator.Api.Protos.ProductResponseMessage> GetProductByIdAsync(global::ShoppyEx.Aggregator.Api.Protos.ProductByIdRequestMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Aggregator.Api.Protos.ProductListMessage GetProductAll(global::ShoppyEx.Aggregator.Api.Protos.ProductPageQueryRequestMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Aggregator.Api.Protos.ProductListMessage GetProductAll(global::ShoppyEx.Aggregator.Api.Protos.ProductPageQueryRequestMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Aggregator.Api.Protos.ProductListMessage> GetProductAllAsync(global::ShoppyEx.Aggregator.Api.Protos.ProductPageQueryRequestMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Aggregator.Api.Protos.ProductListMessage> GetProductAllAsync(global::ShoppyEx.Aggregator.Api.Protos.ProductPageQueryRequestMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductAll, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override ProductGrpcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ProductGrpcClient(configuration);
      }
    }

  }
}
#endregion
