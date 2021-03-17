using System;
using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Core.Packets.Revisions;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Outgoing.Room.Session;
using TurboDefaultRevisionPlugin.Headers;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Room.Action;
using TurboDefaultRevisionPlugin.Parsers.Room.Avatar;
using TurboDefaultRevisionPlugin.Parsers.Room.Engine;
using TurboDefaultRevisionPlugin.Parsers.Room.Session;
using TurboDefaultRevisionPlugin.Serializers.Handshake;
using TurboDefaultRevisionPlugin.Serializers.Navigator;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Engine;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Session;

namespace TurboDefaultRevisionPlugin
{
    public class Revision : IRevision
    {
        public IDictionary<int, IParser> Parsers { get; }

        public IDictionary<Type, ISerializer> Serializers { get; }

        string IRevision.Revision => "PRODUCTION-201611291003-338511768";

        public Revision()
        {
            Parsers = new Dictionary<int, IParser>();
            Serializers = new Dictionary<Type, ISerializer>();
            RegisterParsers();
            RegisterSerializers();
        }

        private void RegisterParsers()
        {
            #region Handshake
            Parsers.Add(Incoming.ClientHello, new ClientHelloParser());
            Parsers.Add(Incoming.SSOTicket, new SSOTicketParser());
            Parsers.Add(Incoming.Pong, new PongParser());
            Parsers.Add(Incoming.InfoRetrieve, new InfoRetrieveParser());
            Parsers.Add(Incoming.UniqueId, new UniqueIdParser());
            Parsers.Add(Incoming.VersionCheck, new VersionCheckParser());
            Parsers.Add(Incoming.CompleteDiffieHandshake, new CompleteDiffieHandshakeParser());
            Parsers.Add(Incoming.Disconnect, new DisconnectParser());
            Parsers.Add(Incoming.InitDiffieHandshake, new InitDiffieHandshakeParser());
            #endregion

            #region Room
            #region Action
            Parsers.Add(Incoming.KickUser, new KickUserParser());
            Parsers.Add(Incoming.MuteUser, new MuteUserParser());
            #endregion
            #region Avatar
            Parsers.Add(Incoming.Dance, new DanceParser());
            #endregion
            #region Engine
            Parsers.Add(Incoming.GetFurnitureAliases, new GetFurnitureAliasesParser());
            Parsers.Add(Incoming.GetRoomEntryData, new GetRoomEntryDataParser());
            Parsers.Add(Incoming.PlaceObject, new PlaceObjectParser());
            Parsers.Add(Incoming.MoveAvatar, new MoveAvatarParser());
            #endregion
            #region Session
            Parsers.Add(Incoming.OpenFlatConnection, new OpenFlatConnectionParser());
            #endregion
            #endregion

            #region Navigator
            Parsers.Add(Incoming.CanCreateRoom, new CanCreateRoomParser());
            Parsers.Add(Incoming.CreateFlat, new CreateFlatParser());
            Parsers.Add(Incoming.DeleteRoom, new DeleteRoomParser());
            Parsers.Add(Incoming.ForwardToSomeRoom, new ForwardToSomeRoomParser());
            Parsers.Add(Incoming.GetPopularRoomTags, new GetPopularRoomTagsParser());
            Parsers.Add(Incoming.GetGuestRoom, new GetGuestRoomParser());
            Parsers.Add(Incoming.GetUserEventCats, new GetUserEventCatsParser());
            Parsers.Add(Incoming.GetUserFlatCats, new GetUserFlatCatsParser());
            Parsers.Add(Incoming.MyFavouriteRoomsSearch, new MyFavouriteRoomsSearchParser());
            Parsers.Add(Incoming.MyFriendsRoomsSearch, new MyFriendsRoomsSearchParser());
            Parsers.Add(Incoming.MyGuildBasesSearch, new MyGuildBasesSearchParser());
            Parsers.Add(Incoming.MyRoomHistorySearch, new MyRoomHistorySearchParser());
            Parsers.Add(Incoming.MyRoomRightsSearch, new MyRoomRightsSearchParser());
            Parsers.Add(Incoming.MyRoomsSearch, new MyRoomsSearchParser());
            Parsers.Add(Incoming.NavigatorAddCollapsedCategory, new NavigatorAddCollapsedCategoryParser());
            Parsers.Add(Incoming.NavigatorAddSavedSearch, new NavigatorAddSavedSearchParser());
            Parsers.Add(Incoming.NavigatorDeleteSavedSearch, new NavigatorDeleteSavedSearchParser());
            Parsers.Add(Incoming.NavigatorRemoveCollapsedCategory, new NavigatorRemoveCollapsedCategoryParser());
            Parsers.Add(Incoming.NavigatorSetSearchCodeViewMode, new NavigatorSetSearchCodeViewModeParser());
            Parsers.Add(Incoming.NewNavigatorInit, new NewNavigatorInitParser());
            Parsers.Add(Incoming.NewNavigatorSearch, new NewNavigatorSearchParser());
            Parsers.Add(Incoming.PopularRoomsSearch, new PopularRoomsSearchParser());
            Parsers.Add(Incoming.RoomsWhereMyFriendsAreSearch, new RoomsWhereMyFriendsAreSearchParser());
            Parsers.Add(Incoming.RoomsWithHighestScoreSearch, new RoomsWithHighestScoreSearchParser());
            Parsers.Add(Incoming.SetNewNavigatorWindowPreferences, new SetNewNavigatorWindowPreferencesParser());
            #endregion
        }

        private void RegisterSerializers()
        {
            #region Authentication
            Serializers.Add(typeof(AuthenticationOKMessage), new AuthenticationOKSerializer(Outgoing.AuthenticationOK));
            Serializers.Add(typeof(PingMessage), new PingSerializer(Outgoing.Ping));
            Serializers.Add(typeof(UniqueMachineIdMessage), new UniqueMachineIdSerializer(Outgoing.UniqueMachineID));
            Serializers.Add(typeof(UserObjectMessage), new UserObjectSerializer(Outgoing.UserObject));
            #endregion

            #region Navigator
            Serializers.Add(typeof(GetGuestRoomResultMessage), new GetGuestRoomResultSerializer(Outgoing.GetGuestRoomResult));
            #endregion

            #region Rooms.Engine
            Serializers.Add(typeof(HeightMapMessage), new HeightMapSerializer(Outgoing.HeightMap));
            Serializers.Add(typeof(HeightMapUpdateMessage), new HeightMapUpdateSerializer(Outgoing.HeightMapUpdate));
            Serializers.Add(typeof(FloorHeightMapMessage), new FloorHeightMapSerializer(Outgoing.FloorHeightMap));
            Serializers.Add(typeof(RoomEntryInfoMessage), new RoomEntryInfoSerializer(Outgoing.RoomEntryInfo));
            Serializers.Add(typeof(FurnitureAliasesMessage), new FurnitureAliasesSerializer(Outgoing.FurnitureAliases));
            Serializers.Add(typeof(UsersMessage), new UsersSerializer(Outgoing.Users));
            Serializers.Add(typeof(UserUpdateMessage), new UserUpdateSerializer(Outgoing.UserUpdate));
            Serializers.Add(typeof(UserRemoveMessage), new UserRemoveSerializer(Outgoing.UserRemove));
            #endregion

            #region Rooms.Session
            Serializers.Add(typeof(OpenConnectionMessage), new OpenConnectionSerializer(Outgoing.OpenConnection));
            Serializers.Add(typeof(RoomReadyMessage), new RoomReadySerializer(Outgoing.RoomReady));
            Serializers.Add(typeof(RoomForwardMessage), new RoomForwardSerializer(Outgoing.RoomForward));
            Serializers.Add(typeof(CantConnectMessage), new CantConnectSerializer(Outgoing.CantConnect));
            #endregion
        }
    }
}
