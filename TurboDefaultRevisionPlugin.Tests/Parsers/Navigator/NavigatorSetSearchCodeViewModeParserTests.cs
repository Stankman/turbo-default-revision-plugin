using AutoFixture;
using Turbo.Core.Game.Navigator.Constants;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class NavigatorSetSearchCodeViewModeParserTests : AbstractParserTestBase<NavigatorSetSearchCodeViewModeParser, NavigatorSetSearchCodeViewModeMessage>
    {
        public NavigatorSetSearchCodeViewModeParserTests() : base()
        {
        }

        [Theory]
        [InlineData(0, NavigatorResultsMode.ROWS)]
        [InlineData(1, NavigatorResultsMode.TILES)]
        [InlineData(2, NavigatorResultsMode.ROWS)]
        private void Parse_WithClientPacket_NavigatorSetSearchCodeViewModeMessage(int viewMode, NavigatorResultsMode expectedMode)
        {
            // Arrange
            var categoryName = _fixture.Create<string>();

            WriteString(categoryName);
            WriteInt(viewMode);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (NavigatorSetSearchCodeViewModeMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(categoryName, result.CategoryName);
            Assert.Equal(expectedMode, result.ViewMode);
        }
    }
}
