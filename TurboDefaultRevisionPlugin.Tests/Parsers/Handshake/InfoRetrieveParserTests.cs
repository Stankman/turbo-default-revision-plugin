using AutoFixture;
using DotNetty.Buffers;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using Xunit;

namespace Turbo.Packets.Tests.Parsers.Handshake
{
    public class InfoRetrieveParserTests
    {
        private readonly IFixture _fixture;
        private readonly IParser _sut;

        public InfoRetrieveParserTests()
        {
            _fixture = new Fixture();
            _sut = new InfoRetrieveParser();
        }

        [Fact]
        private void Parse_WithClientPacket_ReturnsInfoRetrieveMessage()
        {
            // Arrange
            var packetHeader = _fixture.Create<int>();
            IByteBuffer buffer = Unpooled.Buffer();
            var packet = new ClientPacket(packetHeader, buffer);

            // Act
            var result = _sut.Parse(packet);

            // Assert
            Assert.True(result is InfoRetrieveMessage);
        }
    }
}
