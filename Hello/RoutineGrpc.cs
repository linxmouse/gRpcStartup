// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: routine.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace greeter.hello {
  public static partial class Greeter
  {
    static readonly string __ServiceName = "Greeter";

    static readonly grpc::Marshaller<global::greeter.hello.HelloRequest> __Marshaller_HelloRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::greeter.hello.HelloRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::greeter.hello.HelloResponse> __Marshaller_HelloResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::greeter.hello.HelloResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::greeter.hello.HelloRequest, global::greeter.hello.HelloResponse> __Method_SayHello = new grpc::Method<global::greeter.hello.HelloRequest, global::greeter.hello.HelloResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayHello",
        __Marshaller_HelloRequest,
        __Marshaller_HelloResponse);

    static readonly grpc::Method<global::greeter.hello.HelloRequest, global::greeter.hello.HelloResponse> __Method_SayWorld = new grpc::Method<global::greeter.hello.HelloRequest, global::greeter.hello.HelloResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "SayWorld",
        __Marshaller_HelloRequest,
        __Marshaller_HelloResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::greeter.hello.RoutineReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of Greeter</summary>
    [grpc::BindServiceMethod(typeof(Greeter), "BindService")]
    public abstract partial class GreeterBase
    {
      public virtual global::System.Threading.Tasks.Task<global::greeter.hello.HelloResponse> SayHello(global::greeter.hello.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::greeter.hello.HelloResponse> SayWorld(global::greeter.hello.HelloRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for Greeter</summary>
    public partial class GreeterClient : grpc::ClientBase<GreeterClient>
    {
      /// <summary>Creates a new client for Greeter</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public GreeterClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for Greeter that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public GreeterClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected GreeterClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected GreeterClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::greeter.hello.HelloResponse SayHello(global::greeter.hello.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHello(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::greeter.hello.HelloResponse SayHello(global::greeter.hello.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::greeter.hello.HelloResponse> SayHelloAsync(global::greeter.hello.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayHelloAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::greeter.hello.HelloResponse> SayHelloAsync(global::greeter.hello.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayHello, null, options, request);
      }
      public virtual global::greeter.hello.HelloResponse SayWorld(global::greeter.hello.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayWorld(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::greeter.hello.HelloResponse SayWorld(global::greeter.hello.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_SayWorld, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::greeter.hello.HelloResponse> SayWorldAsync(global::greeter.hello.HelloRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return SayWorldAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::greeter.hello.HelloResponse> SayWorldAsync(global::greeter.hello.HelloRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_SayWorld, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override GreeterClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new GreeterClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(GreeterBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_SayHello, serviceImpl.SayHello)
          .AddMethod(__Method_SayWorld, serviceImpl.SayWorld).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, GreeterBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_SayHello, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::greeter.hello.HelloRequest, global::greeter.hello.HelloResponse>(serviceImpl.SayHello));
      serviceBinder.AddMethod(__Method_SayWorld, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::greeter.hello.HelloRequest, global::greeter.hello.HelloResponse>(serviceImpl.SayWorld));
    }

  }
}
#endregion