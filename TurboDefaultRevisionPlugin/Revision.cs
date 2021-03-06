using System;
using System.Collections.Generic;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Parsers;
using Turbo.Packets.Revisions;
using Turbo.Packets.Serializers;
using TurboDefaultRevisionPlugin.Headers;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Serializers.Handshake;

namespace TurboDefaultRevisionPlugin
{
    public class Revision : IRevision
    {
        public IDictionary<int, IParser> Parsers { get; }

        public IDictionary<Type, ISerializer> Serializers { get; }

        string IRevision.Revision => "PRODUCTION-201611291003-338511768";

        public Revision()
        {
            Parsers = new Dictionary<int, IParser>();
            Serializers = new Dictionary<Type, ISerializer>();
            RegisterParsers();
            RegisterSerializers();
        }

        private void RegisterParsers()
        {
            Parsers.Add(Incoming.ClientHello, new ClientHelloParser());
            Parsers.Add(Incoming.SSOTicket, new SSOTicketParser());
            Parsers.Add(Incoming.Pong, new PongParser());
            Parsers.Add(Incoming.InfoRetrieve, new InfoRetrieveParser());
            Parsers.Add(Incoming.UniqueId, new UniqueIdParser());
            Parsers.Add(Incoming.VersionCheck, new VersionCheckParser());
        }

        private void RegisterSerializers()
        {
            Serializers.Add(typeof(AuthenticationOKMessage), new AuthenticationOKSerializer());
            Serializers.Add(typeof(PingMessage), new PingSerializer());
            Serializers.Add(typeof(UniqueMachineIdMessage), new UniqueMachineIdSerializer());
        }
    }
}
