// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/shapesAnalyzer.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcServer {
  public static partial class ShapesAnalyzer
  {
    static readonly string __ServiceName = "shapesAnalyzer.ShapesAnalyzer";

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

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

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

    static readonly grpc::Marshaller<global::GrpcServer.TriangleSides> __Marshaller_shapesAnalyzer_TriangleSides = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.TriangleSides.Parser));
    static readonly grpc::Marshaller<global::GrpcServer.Surface> __Marshaller_shapesAnalyzer_Surface = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.Surface.Parser));
    static readonly grpc::Marshaller<global::GrpcServer.IsRightAngle> __Marshaller_shapesAnalyzer_IsRightAngle = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.IsRightAngle.Parser));
    static readonly grpc::Marshaller<global::GrpcServer.IsIsosceles> __Marshaller_shapesAnalyzer_IsIsosceles = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcServer.IsIsosceles.Parser));

    static readonly grpc::Method<global::GrpcServer.TriangleSides, global::GrpcServer.Surface> __Method_GetTriangleSurface = new grpc::Method<global::GrpcServer.TriangleSides, global::GrpcServer.Surface>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetTriangleSurface",
        __Marshaller_shapesAnalyzer_TriangleSides,
        __Marshaller_shapesAnalyzer_Surface);

    static readonly grpc::Method<global::GrpcServer.TriangleSides, global::GrpcServer.IsRightAngle> __Method_IsTriangleRightAngle = new grpc::Method<global::GrpcServer.TriangleSides, global::GrpcServer.IsRightAngle>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsTriangleRightAngle",
        __Marshaller_shapesAnalyzer_TriangleSides,
        __Marshaller_shapesAnalyzer_IsRightAngle);

    static readonly grpc::Method<global::GrpcServer.TriangleSides, global::GrpcServer.IsIsosceles> __Method_IsTriangleIsosceles = new grpc::Method<global::GrpcServer.TriangleSides, global::GrpcServer.IsIsosceles>(
        grpc::MethodType.Unary,
        __ServiceName,
        "IsTriangleIsosceles",
        __Marshaller_shapesAnalyzer_TriangleSides,
        __Marshaller_shapesAnalyzer_IsIsosceles);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcServer.ShapesAnalyzerReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ShapesAnalyzer</summary>
    [grpc::BindServiceMethod(typeof(ShapesAnalyzer), "BindService")]
    public abstract partial class ShapesAnalyzerBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.Surface> GetTriangleSurface(global::GrpcServer.TriangleSides request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.IsRightAngle> IsTriangleRightAngle(global::GrpcServer.TriangleSides request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::GrpcServer.IsIsosceles> IsTriangleIsosceles(global::GrpcServer.TriangleSides request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ShapesAnalyzerBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetTriangleSurface, serviceImpl.GetTriangleSurface)
          .AddMethod(__Method_IsTriangleRightAngle, serviceImpl.IsTriangleRightAngle)
          .AddMethod(__Method_IsTriangleIsosceles, serviceImpl.IsTriangleIsosceles).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ShapesAnalyzerBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetTriangleSurface, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.TriangleSides, global::GrpcServer.Surface>(serviceImpl.GetTriangleSurface));
      serviceBinder.AddMethod(__Method_IsTriangleRightAngle, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.TriangleSides, global::GrpcServer.IsRightAngle>(serviceImpl.IsTriangleRightAngle));
      serviceBinder.AddMethod(__Method_IsTriangleIsosceles, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcServer.TriangleSides, global::GrpcServer.IsIsosceles>(serviceImpl.IsTriangleIsosceles));
    }

  }
}
#endregion
