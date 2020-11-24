using System;

namespace Mediator.MediatR
{
    public class PongResponse
    {
        public DateTime Timestamp;

        public PongResponse(DateTime timestamp)
        {
            Timestamp = timestamp;
        }
    }
}