// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/product.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ShoppyEx.Order.Api {
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
    static readonly grpc::Marshaller<global::ShoppyEx.Order.Api.ProductsGetAllQuery> __Marshaller_protos_package_ProductsGetAllQuery = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Order.Api.ProductsGetAllQuery.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Order.Api.ProductListMessage> __Marshaller_protos_package_ProductListMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Order.Api.ProductListMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Order.Api.GetProductByIdQuery> __Marshaller_protos_package_GetProductByIdQuery = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Order.Api.GetProductByIdQuery.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Order.Api.ProductResponseMessage> __Marshaller_protos_package_ProductResponseMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Order.Api.ProductResponseMessage.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ShoppyEx.Order.Api.ProductsGetAllQuery, global::ShoppyEx.Order.Api.ProductListMessage> __Method_GetProductAll = new grpc::Method<global::ShoppyEx.Order.Api.ProductsGetAllQuery, global::ShoppyEx.Order.Api.ProductListMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductAll",
        __Marshaller_protos_package_ProductsGetAllQuery,
        __Marshaller_protos_package_ProductListMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ShoppyEx.Order.Api.GetProductByIdQuery, global::ShoppyEx.Order.Api.ProductResponseMessage> __Method_GetProductById = new grpc::Method<global::ShoppyEx.Order.Api.GetProductByIdQuery, global::ShoppyEx.Order.Api.ProductResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetProductById",
        __Marshaller_protos_package_GetProductByIdQuery,
        __Marshaller_protos_package_ProductResponseMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ShoppyEx.Order.Api.ProductReflection.Descriptor.Services[0]; }
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
      public virtual global::ShoppyEx.Order.Api.ProductListMessage GetProductAll(global::ShoppyEx.Order.Api.ProductsGetAllQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Order.Api.ProductListMessage GetProductAll(global::ShoppyEx.Order.Api.ProductsGetAllQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Order.Api.ProductListMessage> GetProductAllAsync(global::ShoppyEx.Order.Api.ProductsGetAllQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Order.Api.ProductListMessage> GetProductAllAsync(global::ShoppyEx.Order.Api.ProductsGetAllQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Order.Api.ProductResponseMessage GetProductById(global::ShoppyEx.Order.Api.GetProductByIdQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Order.Api.ProductResponseMessage GetProductById(global::ShoppyEx.Order.Api.GetProductByIdQuery request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetProductById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Order.Api.ProductResponseMessage> GetProductByIdAsync(global::ShoppyEx.Order.Api.GetProductByIdQuery request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetProductByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Order.Api.ProductResponseMessage> GetProductByIdAsync(global::ShoppyEx.Order.Api.GetProductByIdQuery request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetProductById, null, options, request);
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