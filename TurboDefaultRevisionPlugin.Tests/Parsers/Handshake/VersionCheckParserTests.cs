using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Tests.Parsers;
using Xunit;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class VersionCheckParserTests : AbstractParserTestBase<VersionCheckParser, VersionCheckMessage>
    {
        public VersionCheckParserTests() : base()
        {

        }

        [Fact]
        private void Parse_WithClientPacket_VersionCheckMessage()
        {
            // Arrange
            var clientId = _fixture.Create<int>();
            var clientUrl = _fixture.Create<string>();
            var externalVariablesUrl = _fixture.Create<string>();

            WriteInt(clientId);
            WriteString(clientUrl);
            WriteString(externalVariablesUrl);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (VersionCheckMessage)_sut.Parse(packet);

            // Assert
            Assert.Equal(clientId, result.ClientID);
            Assert.Equal(clientUrl, result.ClientURL);
            Assert.Equal(externalVariablesUrl, result.ExternalVariablesURL);
        }
    }
}
