using AutoFixture;
using Turbo.Core.Game.Navigator.Constants;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class CreateFlatParserTests : AbstractParserTestBase<CreateFlatParser, CreateFlatMessage>
    {
        public CreateFlatParserTests() : base()
        {

        }

        [Theory]
        [InlineData(0, RoomTradeSetting.TradingNotAllowed)]
        [InlineData(1, RoomTradeSetting.TradingRoomOwnerAndRights)]
        [InlineData(2, RoomTradeSetting.TradingAllowed)]
        [InlineData(3, RoomTradeSetting.TradingNotAllowed)]
        private void Parse_WithClientPacket_CreateFlatMessage(int tradeType, RoomTradeSetting expectedSetting)
        {
            // Arrange
            var flatName = _fixture.Create<string>();
            var flatDescription = _fixture.Create<string>();
            var flatModelName = _fixture.Create<string>();
            var categoryID = _fixture.Create<int>();
            var maxPlayers = _fixture.Create<int>();

            WriteString(flatName);
            WriteString(flatDescription);
            WriteString(flatModelName);
            WriteInt(categoryID);
            WriteInt(maxPlayers);
            WriteInt(tradeType);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (CreateFlatMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(flatName, result.FlatName);
            Assert.Equal(flatDescription, result.FlatDescription);
            Assert.Equal(flatModelName, result.FlatModelName);
            Assert.Equal(categoryID, result.CategoryID);
            Assert.Equal(maxPlayers, result.MaxPlayers);
            Assert.Equal(expectedSetting, result.TradeSetting);
        }
    }
}
