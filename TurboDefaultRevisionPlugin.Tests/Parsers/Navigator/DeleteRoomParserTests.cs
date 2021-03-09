using AutoFixture;
using DotNetty.Buffers;
using System.Text;
using Turbo.Core.Packets.Messages;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class DeleteRoomParserTests : AbstractParserTestBase<DeleteRoomParser, DeleteRoomMessage>
    {
        public DeleteRoomParserTests() : base()
        {

        }

        [Fact]
        private void Parse_WithClientPacket_DeleteRoomMessage()
        {
            // Arrange
            var roomId = _fixture.Create<int>();

            WriteInt(roomId);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (DeleteRoomMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(roomId, result.RoomID);
        }
    }
}
