using System;
using ConferenceManagement.Domain.Entities.Constants;
using ConferenceManagement.Common.Resources;

namespace ConferenceManagement.Domain.Entities
{
    public class ScheduledNetworkingEvent: ScheduledTalk
    {
        public ScheduledNetworkingEvent(NetworkingEvent networkEvent, DateTime start)
            : base(networkEvent, start)
        {
            if (AppSettings.NetworkingSessionRangeStartTime > start || AppSettings.NetworkingSessionRangeEndTime < start)
            {
                throw new ArgumentOutOfRangeException(Messages.NetworkingEventRangeTimeError);
            }
        }
    }
}