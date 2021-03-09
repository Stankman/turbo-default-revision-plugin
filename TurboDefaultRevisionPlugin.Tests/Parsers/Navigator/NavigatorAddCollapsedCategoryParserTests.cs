using AutoFixture;
using Turbo.Packets.Incoming;
using Turbo.Packets.Incoming.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using Xunit;

namespace TurboDefaultRevisionPlugin.Tests.Parsers.Navigator
{
    public class NavigatorAddCollapsedCategoryParserTests : AbstractParserTestBase<NavigatorAddCollapsedCategoryParser, NavigatorAddCollapsedCategoryMessage>
    {
        public NavigatorAddCollapsedCategoryParserTests() : base()
        {
        }

        [Fact]
        private void Parse_WithClientPacket_NavigatorAddCollapsedCategoryMessage()
        {
            // Arrange
            var categoryName = _fixture.Create<string>();

            WriteString(categoryName);

            var packet = new ClientPacket(_fixture.Create<int>(), _buffer);

            // Act
            var result = (NavigatorAddCollapsedCategoryMessage) _sut.Parse(packet);

            // Assert
            Assert.Equal(categoryName, result.CategoryName);
        }
    }
}
