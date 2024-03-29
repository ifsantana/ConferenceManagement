using System;
using System.Collections.Generic;
using System.Linq;
using ConferenceManagement.Domain.Entities;
using ConferenceManagement.Domain.Entities.Factories;
using ConferenceManagement.Domain.Services;

namespace ConferenceManagement.Services.BinPackingLogic
{
    public class ConferencePlannerService : IConferencePlannerService
    {
        #region BESTFIT APPROACH IMPLEMENTATION

        public Conference GreedyBestFitApproach(IEnumerable<Talk> talks)
        {
            talks = talks.OrderBy(talk => talk);
            
            Conference conference = new Conference(new TrackTwoSessionsFactory());

            foreach(Talk talk in talks)
            {
                Session bestSession = GetBestSessionBestFitApproach(conference.EnumerateSessions(), talk);

                if(bestSession == null)
                {
                    conference.CreateNewTrack();
                    bestSession = GetBestSessionBestFitApproach(conference.EnumerateSessions(), talk);
                }

                if(bestSession == null)
                {
                    throw new ArgumentException(string.Format("ErrorUnscheduledEvent", talk));
                }

                bestSession.AcceptTalk(talk);
            }
            return conference;
        }

        public Session GetBestSessionBestFitApproach(IEnumerable<Session> sessions, Talk talk)
        {
            Session bestFitSession = null;

            foreach(Session session in sessions)
            {
                if(session.CanAcceptTalk(talk))
                {
                    if (bestFitSession == null || session.TimeLeft() < bestFitSession.TimeLeft())
                    {
                        bestFitSession = session;
                    }
                }
            }

            return bestFitSession;
        }
        #endregion

        #region OTHER APPROACHS IMPLEMENTATIONS

        public Conference GreedyFirstFitApproach(IEnumerable<Talk> talks)
        {
            throw new NotImplementedException();
        }

        public Session GetBestSessionFirstFitApproach(IEnumerable<Session> sessions, Talk talk)
        {
            throw new NotImplementedException();
        }

        #endregion

    }
}