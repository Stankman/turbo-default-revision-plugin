using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using Turbo.Packets.Parsers;
using Xunit;
using DotNetty.Buffers;
using AutoFixture;
using TurboDefaultRevisionPlugin.Parsers.Handshake;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class PongParserTests
    {
        private readonly IFixture _fixture;
        private readonly IParser _sut;

        public PongParserTests()
        {
            _fixture = new Fixture();
            _sut = new PongParser();
        }

        [Fact]
        private void Parse_WithClientPacket_ReturnsPongMessage()
        {
            // Arrange
            var packetHeader = _fixture.Create<int>();
            IByteBuffer buffer = Unpooled.Buffer();
            var packet = new ClientPacket(packetHeader, buffer);

            // Act
            var result = _sut.Parse(packet);

            // Assert
            Assert.True(result is PongMessage);
        }
    }
}
