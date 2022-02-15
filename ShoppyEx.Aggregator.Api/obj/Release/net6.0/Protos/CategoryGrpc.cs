// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/category.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ShoppyEx.Aggregator.Api.Protos {
  public static partial class CategoryGrpc
  {
    static readonly string __ServiceName = "protos.package.CategoryGrpc";

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
    static readonly grpc::Marshaller<global::ShoppyEx.Aggregator.Api.Protos.CategoryByIdRequestMessage> __Marshaller_protos_package_CategoryByIdRequestMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Aggregator.Api.Protos.CategoryByIdRequestMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Aggregator.Api.Protos.CategoryResponseMessage> __Marshaller_protos_package_CategoryResponseMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Aggregator.Api.Protos.CategoryResponseMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Aggregator.Api.Protos.CategoryPageQueryRequestMessage> __Marshaller_protos_package_CategoryPageQueryRequestMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Aggregator.Api.Protos.CategoryPageQueryRequestMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Aggregator.Api.Protos.CategoryListMessage> __Marshaller_protos_package_CategoryListMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Aggregator.Api.Protos.CategoryListMessage.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ShoppyEx.Aggregator.Api.Protos.CategoryByIdRequestMessage, global::ShoppyEx.Aggregator.Api.Protos.CategoryResponseMessage> __Method_GetCategoryById = new grpc::Method<global::ShoppyEx.Aggregator.Api.Protos.CategoryByIdRequestMessage, global::ShoppyEx.Aggregator.Api.Protos.CategoryResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategoryById",
        __Marshaller_protos_package_CategoryByIdRequestMessage,
        __Marshaller_protos_package_CategoryResponseMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ShoppyEx.Aggregator.Api.Protos.CategoryPageQueryRequestMessage, global::ShoppyEx.Aggregator.Api.Protos.CategoryListMessage> __Method_GetCategoryAll = new grpc::Method<global::ShoppyEx.Aggregator.Api.Protos.CategoryPageQueryRequestMessage, global::ShoppyEx.Aggregator.Api.Protos.CategoryListMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategoryAll",
        __Marshaller_protos_package_CategoryPageQueryRequestMessage,
        __Marshaller_protos_package_CategoryListMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ShoppyEx.Aggregator.Api.Protos.CategoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for CategoryGrpc</summary>
    public partial class CategoryGrpcClient : grpc::ClientBase<CategoryGrpcClient>
    {
      /// <summary>Creates a new client for CategoryGrpc</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CategoryGrpcClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for CategoryGrpc that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public CategoryGrpcClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CategoryGrpcClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected CategoryGrpcClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Aggregator.Api.Protos.CategoryResponseMessage GetCategoryById(global::ShoppyEx.Aggregator.Api.Protos.CategoryByIdRequestMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCategoryById(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Aggregator.Api.Protos.CategoryResponseMessage GetCategoryById(global::ShoppyEx.Aggregator.Api.Protos.CategoryByIdRequestMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCategoryById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Aggregator.Api.Protos.CategoryResponseMessage> GetCategoryByIdAsync(global::ShoppyEx.Aggregator.Api.Protos.CategoryByIdRequestMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCategoryByIdAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Aggregator.Api.Protos.CategoryResponseMessage> GetCategoryByIdAsync(global::ShoppyEx.Aggregator.Api.Protos.CategoryByIdRequestMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCategoryById, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Aggregator.Api.Protos.CategoryListMessage GetCategoryAll(global::ShoppyEx.Aggregator.Api.Protos.CategoryPageQueryRequestMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCategoryAll(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::ShoppyEx.Aggregator.Api.Protos.CategoryListMessage GetCategoryAll(global::ShoppyEx.Aggregator.Api.Protos.CategoryPageQueryRequestMessage request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_GetCategoryAll, null, options, request);
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Aggregator.Api.Protos.CategoryListMessage> GetCategoryAllAsync(global::ShoppyEx.Aggregator.Api.Protos.CategoryPageQueryRequestMessage request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return GetCategoryAllAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual grpc::AsyncUnaryCall<global::ShoppyEx.Aggregator.Api.Protos.CategoryListMessage> GetCategoryAllAsync(global::ShoppyEx.Aggregator.Api.Protos.CategoryPageQueryRequestMessage request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_GetCategoryAll, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      protected override CategoryGrpcClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new CategoryGrpcClient(configuration);
      }
    }

  }
}
#endregion