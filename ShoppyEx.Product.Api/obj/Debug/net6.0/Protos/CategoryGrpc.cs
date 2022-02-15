// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/category.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace ShoppyEx.Product.Api {
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
    static readonly grpc::Marshaller<global::ShoppyEx.Product.Api.CategoryByIdRequestMessage> __Marshaller_protos_package_CategoryByIdRequestMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Product.Api.CategoryByIdRequestMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Product.Api.CategoryResponseMessage> __Marshaller_protos_package_CategoryResponseMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Product.Api.CategoryResponseMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Product.Api.CategoryPageQueryRequestMessage> __Marshaller_protos_package_CategoryPageQueryRequestMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Product.Api.CategoryPageQueryRequestMessage.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::ShoppyEx.Product.Api.CategoryListMessage> __Marshaller_protos_package_CategoryListMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::ShoppyEx.Product.Api.CategoryListMessage.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ShoppyEx.Product.Api.CategoryByIdRequestMessage, global::ShoppyEx.Product.Api.CategoryResponseMessage> __Method_GetCategoryById = new grpc::Method<global::ShoppyEx.Product.Api.CategoryByIdRequestMessage, global::ShoppyEx.Product.Api.CategoryResponseMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategoryById",
        __Marshaller_protos_package_CategoryByIdRequestMessage,
        __Marshaller_protos_package_CategoryResponseMessage);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::ShoppyEx.Product.Api.CategoryPageQueryRequestMessage, global::ShoppyEx.Product.Api.CategoryListMessage> __Method_GetCategoryAll = new grpc::Method<global::ShoppyEx.Product.Api.CategoryPageQueryRequestMessage, global::ShoppyEx.Product.Api.CategoryListMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetCategoryAll",
        __Marshaller_protos_package_CategoryPageQueryRequestMessage,
        __Marshaller_protos_package_CategoryListMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::ShoppyEx.Product.Api.CategoryReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of CategoryGrpc</summary>
    [grpc::BindServiceMethod(typeof(CategoryGrpc), "BindService")]
    public abstract partial class CategoryGrpcBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ShoppyEx.Product.Api.CategoryResponseMessage> GetCategoryById(global::ShoppyEx.Product.Api.CategoryByIdRequestMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::ShoppyEx.Product.Api.CategoryListMessage> GetCategoryAll(global::ShoppyEx.Product.Api.CategoryPageQueryRequestMessage request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(CategoryGrpcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetCategoryById, serviceImpl.GetCategoryById)
          .AddMethod(__Method_GetCategoryAll, serviceImpl.GetCategoryAll).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, CategoryGrpcBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetCategoryById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ShoppyEx.Product.Api.CategoryByIdRequestMessage, global::ShoppyEx.Product.Api.CategoryResponseMessage>(serviceImpl.GetCategoryById));
      serviceBinder.AddMethod(__Method_GetCategoryAll, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::ShoppyEx.Product.Api.CategoryPageQueryRequestMessage, global::ShoppyEx.Product.Api.CategoryListMessage>(serviceImpl.GetCategoryAll));
    }

  }
}
#endregion
