﻿namespace NServiceBus.Unicast.Routing
{
    using System;

    /// <summary>
    /// Keeps track of where a given message should be routed to
    /// </summary>
    public interface IRouteMessages
    {
        /// <summary>
        /// Gets the owner/destination for the given message
        /// </summary>
        Address GetDestinationFor(Type messageType);
    }
}