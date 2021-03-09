using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Tests.Parsers;
using Xunit;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class SSOTicketParserTests : AbstractParserTestBase<SSOTicketParser, SSOTicketMessage>
    {
        public SSOTicketParserTests() : base()
        {

        }

        [Fact]
        private void Parse_WithClientPacket_ReturnsSSOTicketMessage()
        {
            // Arrange
            var ssoTicket = _fixture.Create<string>();

            WriteString(ssoTicket);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (SSOTicketMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(ssoTicket, result.SSO);
        }
    }
}
