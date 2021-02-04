// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.Chat
{
    /// <summary> Result of the create chat thread operation. </summary>
    internal partial class CreateChatThreadResultInternal
    {
        /// <summary> Initializes a new instance of CreateChatThreadResultInternal. </summary>
        internal CreateChatThreadResultInternal()
        {
        }

        /// <summary> Initializes a new instance of CreateChatThreadResultInternal. </summary>
        /// <param name="chatThread"> Chat thread. </param>
        /// <param name="errors"> Errors encountered during the creation of the chat thread. </param>
        internal CreateChatThreadResultInternal(ChatThreadInternal chatThread, CreateChatThreadErrors errors)
        {
            ChatThread = chatThread;
            Errors = errors;
        }

        /// <summary> Chat thread. </summary>
        public ChatThreadInternal ChatThread { get; }
        /// <summary> Errors encountered during the creation of the chat thread. </summary>
        public CreateChatThreadErrors Errors { get; }
    }
}