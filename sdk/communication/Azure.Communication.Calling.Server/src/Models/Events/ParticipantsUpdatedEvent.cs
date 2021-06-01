﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace Azure.Communication.Calling.Server
{
    /// <summary>
    /// The call state change event.
    /// </summary>
    public partial class ParticipantsUpdatedEvent : CallEventBase
    {
        /// <summary>
        /// The call leg.id.
        /// </summary>
        public string CallLegId { get; set; }

        /// <summary>
        /// The list of participants.
        /// </summary>
        public IEnumerable<CommunicationParticipant> Participants { get; set; }

        /// <summary> Initializes a new instance of <see cref="ParticipantsUpdatedEvent"/>. </summary>
        /// <param name="callLegId"> The call leg id. </param>
        /// <param name="participants"> The conversation id. </param>
        public ParticipantsUpdatedEvent(string callLegId, IEnumerable<CommunicationParticipant> participants)
        {
            CallLegId = callLegId;
            Participants = participants;
        }
    }
}
