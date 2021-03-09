using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Tests.Parsers;
using Xunit;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class ClientHelloParserTests : AbstractParserTestBase<ClientHelloParser, ClientHelloMessage>
    {
        public ClientHelloParserTests() : base()
        {

        }

        [Fact]
        private void Parse_WithClientPacket_ReturnsClientHelloMessage()
        {
            // Arrange
            var production = _fixture.Create<string>();
            var platform = _fixture.Create<string>();
            var clientPlatform = _fixture.Create<int>();
            var deviceCategory = _fixture.Create<int>();

            WriteString(production);
            WriteString(platform);
            WriteInt(clientPlatform);
            WriteInt(deviceCategory);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (ClientHelloMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(production, result.Production);
            Assert.Equal(platform, result.Platform);
            Assert.Equal(clientPlatform, result.ClientPlatform);
            Assert.Equal(deviceCategory, result.DeviceCategory);
        }
    }
}
