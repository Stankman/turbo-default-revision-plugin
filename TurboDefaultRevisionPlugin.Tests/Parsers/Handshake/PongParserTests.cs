using Turbo.Packets.Incoming.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Tests.Parsers;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class PongParserTests : EmptyPacketParserTestBase<PongParser, PongMessage>
    {
        public PongParserTests() : base()
        {

        }
    }
}
