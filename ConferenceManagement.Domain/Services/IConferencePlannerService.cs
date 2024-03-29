using System.Collections.Generic;
using ConferenceManagement.Domain.Entities;

namespace ConferenceManagement.Domain.Services
{
    public interface IConferencePlannerService
    {
        #region  BestFit Approach
         Conference GreedyBestFitApproach(IEnumerable<Talk> talks);
         Session GetBestSessionBestFitApproach(IEnumerable<Session> sessions, Talk talk);
        
        #endregion

        #region  FirstFit Approach
         Conference GreedyFirstFitApproach(IEnumerable<Talk> talks);
         Session GetBestSessionFirstFitApproach(IEnumerable<Session> sessions, Talk talk);

         #endregion
    }
}
