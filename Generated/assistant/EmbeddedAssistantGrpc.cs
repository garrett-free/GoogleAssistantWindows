// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: googleapis/google/assistant/embedded/v1alpha1/embedded_assistant.proto
// Original file comments:
// Copyright 2017 Google Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Google.Assistant.Embedded.V1Alpha1 {
  /// <summary>
  /// Service that implements Google Assistant API.
  /// </summary>
  public static partial class EmbeddedAssistant
  {
    static readonly string __ServiceName = "google.assistant.embedded.v1alpha1.EmbeddedAssistant";

    static readonly grpc::Marshaller<global::Google.Assistant.Embedded.V1Alpha1.ConverseRequest> __Marshaller_ConverseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Assistant.Embedded.V1Alpha1.ConverseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Assistant.Embedded.V1Alpha1.ConverseResponse> __Marshaller_ConverseResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Assistant.Embedded.V1Alpha1.ConverseResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Google.Assistant.Embedded.V1Alpha1.ConverseRequest, global::Google.Assistant.Embedded.V1Alpha1.ConverseResponse> __Method_Converse = new grpc::Method<global::Google.Assistant.Embedded.V1Alpha1.ConverseRequest, global::Google.Assistant.Embedded.V1Alpha1.ConverseResponse>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "Converse",
        __Marshaller_ConverseRequest,
        __Marshaller_ConverseResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Google.Assistant.Embedded.V1Alpha1.EmbeddedAssistantReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of EmbeddedAssistant</summary>
    public abstract partial class EmbeddedAssistantBase
    {
      /// <summary>
      /// Initiates or continues a conversation with the embedded assistant service.
      /// Each call performs one round-trip, sending an audio request to the service
      /// and receiving the audio response. Uses bidirectional streaming to receive
      /// results, such as the `END_OF_UTTERANCE` event, while sending audio.
      ///
      /// A conversation is one or more gRPC connections, each consisting of several
      /// streamed requests and responses.
      /// For example, the user says *Add to my shopping list* and the assistant
      /// responds *What do you want to add?*. The sequence of streamed requests and
      /// responses in the first gRPC message could be:
      ///
      /// *   ConverseRequest.config
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseResponse.event_type.END_OF_UTTERANCE
      /// *   ConverseResponse.result.microphone_mode.DIALOG_FOLLOW_ON
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      ///
      /// The user then says *bagels* and the assistant responds
      /// *OK, I've added bagels to your shopping list*. This is sent as another gRPC
      /// connection call to the `Converse` method, again with streamed requests and
      /// responses, such as:
      ///
      /// *   ConverseRequest.config
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseResponse.event_type.END_OF_UTTERANCE
      /// *   ConverseResponse.result.microphone_mode.CLOSE_MICROPHONE
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      ///
      /// Although the precise order of responses is not guaranteed, sequential
      /// ConverseResponse.audio_out messages will always contain sequential portions
      /// of audio.
      /// </summary>
      /// <param name="requestStream">Used for reading requests from the client.</param>
      /// <param name="responseStream">Used for sending responses back to the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>A task indicating completion of the handler.</returns>
      public virtual global::System.Threading.Tasks.Task Converse(grpc::IAsyncStreamReader<global::Google.Assistant.Embedded.V1Alpha1.ConverseRequest> requestStream, grpc::IServerStreamWriter<global::Google.Assistant.Embedded.V1Alpha1.ConverseResponse> responseStream, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for EmbeddedAssistant</summary>
    public partial class EmbeddedAssistantClient : grpc::ClientBase<EmbeddedAssistantClient>
    {
      /// <summary>Creates a new client for EmbeddedAssistant</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public EmbeddedAssistantClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for EmbeddedAssistant that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public EmbeddedAssistantClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected EmbeddedAssistantClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected EmbeddedAssistantClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// Initiates or continues a conversation with the embedded assistant service.
      /// Each call performs one round-trip, sending an audio request to the service
      /// and receiving the audio response. Uses bidirectional streaming to receive
      /// results, such as the `END_OF_UTTERANCE` event, while sending audio.
      ///
      /// A conversation is one or more gRPC connections, each consisting of several
      /// streamed requests and responses.
      /// For example, the user says *Add to my shopping list* and the assistant
      /// responds *What do you want to add?*. The sequence of streamed requests and
      /// responses in the first gRPC message could be:
      ///
      /// *   ConverseRequest.config
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseResponse.event_type.END_OF_UTTERANCE
      /// *   ConverseResponse.result.microphone_mode.DIALOG_FOLLOW_ON
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      ///
      /// The user then says *bagels* and the assistant responds
      /// *OK, I've added bagels to your shopping list*. This is sent as another gRPC
      /// connection call to the `Converse` method, again with streamed requests and
      /// responses, such as:
      ///
      /// *   ConverseRequest.config
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseResponse.event_type.END_OF_UTTERANCE
      /// *   ConverseResponse.result.microphone_mode.CLOSE_MICROPHONE
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      ///
      /// Although the precise order of responses is not guaranteed, sequential
      /// ConverseResponse.audio_out messages will always contain sequential portions
      /// of audio.
      /// </summary>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Assistant.Embedded.V1Alpha1.ConverseRequest, global::Google.Assistant.Embedded.V1Alpha1.ConverseResponse> Converse(grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Converse(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// Initiates or continues a conversation with the embedded assistant service.
      /// Each call performs one round-trip, sending an audio request to the service
      /// and receiving the audio response. Uses bidirectional streaming to receive
      /// results, such as the `END_OF_UTTERANCE` event, while sending audio.
      ///
      /// A conversation is one or more gRPC connections, each consisting of several
      /// streamed requests and responses.
      /// For example, the user says *Add to my shopping list* and the assistant
      /// responds *What do you want to add?*. The sequence of streamed requests and
      /// responses in the first gRPC message could be:
      ///
      /// *   ConverseRequest.config
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseResponse.event_type.END_OF_UTTERANCE
      /// *   ConverseResponse.result.microphone_mode.DIALOG_FOLLOW_ON
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      ///
      /// The user then says *bagels* and the assistant responds
      /// *OK, I've added bagels to your shopping list*. This is sent as another gRPC
      /// connection call to the `Converse` method, again with streamed requests and
      /// responses, such as:
      ///
      /// *   ConverseRequest.config
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseRequest.audio_in
      /// *   ConverseResponse.event_type.END_OF_UTTERANCE
      /// *   ConverseResponse.result.microphone_mode.CLOSE_MICROPHONE
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      /// *   ConverseResponse.audio_out
      ///
      /// Although the precise order of responses is not guaranteed, sequential
      /// ConverseResponse.audio_out messages will always contain sequential portions
      /// of audio.
      /// </summary>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncDuplexStreamingCall<global::Google.Assistant.Embedded.V1Alpha1.ConverseRequest, global::Google.Assistant.Embedded.V1Alpha1.ConverseResponse> Converse(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_Converse, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override EmbeddedAssistantClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new EmbeddedAssistantClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(EmbeddedAssistantBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Converse, serviceImpl.Converse).Build();
    }

  }
}
#endregion
