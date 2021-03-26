using System;
using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Core.Packets.Revisions;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Outgoing.Room.Session;
using TurboDefaultRevisionPlugin.Headers;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Inventory.Furni;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Room.Action;
using TurboDefaultRevisionPlugin.Parsers.Room.Avatar;
using TurboDefaultRevisionPlugin.Parsers.Room.Engine;
using TurboDefaultRevisionPlugin.Parsers.Room.Session;
using TurboDefaultRevisionPlugin.Serializers.Handshake;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni;
using TurboDefaultRevisionPlugin.Serializers.Navigator;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Action;
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

            #region Inventory

            #region Furni
            Parsers.Add(Incoming.RequestFurniInventory, new RequestFurniInventoryParser());
            Parsers.Add(Incoming.RequestFurniInventoryWhenNotInRoom, new RequestFurniInventoryWhenNotInRoomParser());
            Parsers.Add(Incoming.RequestRoomPropertySet, new RequestRoomPropertySetParser());
            #endregion
            #endregion

            #region Room
            #region Action
            Parsers.Add(Incoming.KickUser, new KickUserParser());
            Parsers.Add(Incoming.MuteUser, new MuteUserParser());
            #endregion
            #region Avatar
            Parsers.Add(Incoming.Dance, new DanceParser());
            Parsers.Add(Incoming.AvatarExpression, new AvatarExpressionParser());
            Parsers.Add(Incoming.ChangeMotto, new ChangeMottoParser());
            Parsers.Add(Incoming.ChangePosture, new ChangePostureParser());
            Parsers.Add(Incoming.CustomizeAvatarWithFurni, new CustomizeAvatarWithFurniParser());
            Parsers.Add(Incoming.DropCarryItem, new DropCarryItemParser());
            Parsers.Add(Incoming.LookTo, new LookToParser());
            Parsers.Add(Incoming.PassCarryItem, new PassCarryItemParser());
            Parsers.Add(Incoming.PassCarryItemToPet, new PassCarryItemToPetParser());
            Parsers.Add(Incoming.Sign, new SignParser());
            #endregion
            #region Engine
            Parsers.Add(Incoming.GetFurnitureAliases, new GetFurnitureAliasesParser());
            Parsers.Add(Incoming.GetRoomEntryData, new GetRoomEntryDataParser());
            Parsers.Add(Incoming.PlaceObject, new PlaceObjectParser());
            Parsers.Add(Incoming.MoveAvatar, new MoveAvatarParser());
            Parsers.Add(Incoming.GetItemData, new GetItemDataParser());
            Parsers.Add(Incoming.MoveObject, new MoveObjectParser());
            Parsers.Add(Incoming.MoveWallItem, new MoveWallItemParser());
            Parsers.Add(Incoming.PickupObject, new PickupObjectParser());
            Parsers.Add(Incoming.RemoveItem, new RemoveItemParser());
            Parsers.Add(Incoming.SetItemData, new SetItemDataParser());
            Parsers.Add(Incoming.SetObjectData, new SetObjectDataParser());
            Parsers.Add(Incoming.UseFurniture, new UseFurnitureParser());
            Parsers.Add(Incoming.UseWallItem, new UseWallItemParser());
            #endregion
            #region Session
            Parsers.Add(Incoming.OpenFlatConnection, new OpenFlatConnectionParser());
            Parsers.Add(Incoming.Quit, new QuitParser());
            Parsers.Add(Incoming.GoToFlat, new GoToFlatParser());
            Parsers.Add(Incoming.ChangeQueue, new ChangeQueueParser());
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
            #region Handshake
            Serializers.Add(typeof(AuthenticationOKMessage), new AuthenticationOKSerializer(Outgoing.AuthenticationOK));
            Serializers.Add(typeof(PingMessage), new PingSerializer(Outgoing.Ping));
            Serializers.Add(typeof(UniqueMachineIdMessage), new UniqueMachineIdSerializer(Outgoing.UniqueMachineID));
            Serializers.Add(typeof(UserObjectMessage), new UserObjectSerializer(Outgoing.UserObject));
            #endregion

            #region Inventory

            #region Furni
            Serializers.Add(typeof(FurniListAddOrUpdateMessage), new FurniListAddOrUpdateSerializer(Outgoing.FurniListAddOrUpdate));
            Serializers.Add(typeof(FurniListInvalidateMessage), new FurniListInvalidateSerializer(Outgoing.FurniListInvalidate));
            Serializers.Add(typeof(FurniListRemoveMessage), new FurniListRemoveSerializer(Outgoing.FurniListRemove));
            Serializers.Add(typeof(PostItPlacedMessage), new PostItPlacedSerializer(Outgoing.PostItPlaced));
            #endregion

            #endregion

            #region Navigator
            Serializers.Add(typeof(NavigatorMetaDataMessage), new NavigatorMetaDataSerializer(Outgoing.NavigatorMetaData));
            Serializers.Add(typeof(GetGuestRoomResultMessage), new GetGuestRoomResultSerializer(Outgoing.GetGuestRoomResult));
            Serializers.Add(typeof(NavigatorLiftedRoomsMessage), new NavigatorLiftedRoomsSerializer(Outgoing.NavigatorLiftedRooms));
            Serializers.Add(typeof(NavigatorSavedSearchesMessage), new NavigatorSavedSearchesSerializer(Outgoing.NavigatorSavedSearches));
            Serializers.Add(typeof(NavigatorEventCategoriesMessage), new NavigatorEventCategoriesSerializer(Outgoing.NavigatorEventCategories));
            #endregion

            #region Room

            #region Action
            Serializers.Add(typeof(AvatarEffectMessage), new AvatarEffectSerializer(Outgoing.AvatarEffect));
            Serializers.Add(typeof(CarryObjectMessage), new CarryObjectSerializer(Outgoing.CarryObject));
            Serializers.Add(typeof(DanceMessage), new DanceSerializer(Outgoing.Dance));
            Serializers.Add(typeof(ExpressionMessage), new ExpressionSerializer(Outgoing.Expression));
            Serializers.Add(typeof(SleepMessage), new SleepSerializer(Outgoing.Sleep));
            Serializers.Add(typeof(UseObjectMessage), new UseObjectSerializer(Outgoing.UseObject));
            #endregion

            #region Engine
            Serializers.Add(typeof(FavouriteMembershipUpdateMessage), new FavouriteMembershipUpdateSerializer(Outgoing.FavouriteMembershipUpdate));
            Serializers.Add(typeof(HeightMapMessage), new HeightMapSerializer(Outgoing.HeightMap));
            Serializers.Add(typeof(HeightMapUpdateMessage), new HeightMapUpdateSerializer(Outgoing.HeightMapUpdate));
            Serializers.Add(typeof(FloorHeightMapMessage), new FloorHeightMapSerializer(Outgoing.FloorHeightMap));
            Serializers.Add(typeof(RoomEntryInfoMessage), new RoomEntryInfoSerializer(Outgoing.RoomEntryInfo));
            Serializers.Add(typeof(FurnitureAliasesMessage), new FurnitureAliasesSerializer(Outgoing.FurnitureAliases));
            Serializers.Add(typeof(UsersMessage), new UsersSerializer(Outgoing.Users));
            Serializers.Add(typeof(UserUpdateMessage), new UserUpdateSerializer(Outgoing.UserUpdate));
            Serializers.Add(typeof(UserRemoveMessage), new UserRemoveSerializer(Outgoing.UserRemove));
            Serializers.Add(typeof(ObjectAddMessage), new ObjectAddSerializer(Outgoing.ObjectAdd));
            Serializers.Add(typeof(ObjectDataUpdateMessage), new ObjectDataUpdateSerializer(Outgoing.ObjectDataUpdate));
            Serializers.Add(typeof(ObjectRemoveMessage), new ObjectRemoveSerializer(Outgoing.ObjectRemove));
            Serializers.Add(typeof(ObjectsDataUpdateMessage), new ObjectsDataUpdateSerializer(Outgoing.ObjectsDataUpdate));
            Serializers.Add(typeof(ObjectsMessage), new ObjectsSerializer(Outgoing.Objects));
            Serializers.Add(typeof(ObjectUpdateMessage), new ObjectUpdateSerializer(Outgoing.ObjectUpdate));
            Serializers.Add(typeof(ItemAddMessage), new ItemAddSerializer(Outgoing.ItemAdd));
            Serializers.Add(typeof(ItemDataUpdateMessage), new ItemDataUpdateSerializer(Outgoing.ItemDataUpdate));
            Serializers.Add(typeof(ItemRemoveMessage), new ItemRemoveSerializer(Outgoing.ItemRemove));
            Serializers.Add(typeof(ItemsMessage), new ItemsSerializer(Outgoing.Items));
            Serializers.Add(typeof(ItemUpdateMessage), new ItemUpdateSerializer(Outgoing.ItemUpdate));
            Serializers.Add(typeof(RoomPropertyMessage), new RoomPropertySerializer(Outgoing.RoomProperty));
            Serializers.Add(typeof(RoomVisualizationSettingsMessage), new RoomVisualizationSettingsSerializer(Outgoing.RoomVisualizationSettings));
            Serializers.Add(typeof(SlideObjectBundleMessage), new SlideObjectBundleSerializer(Outgoing.SlideObjectBundle));
            Serializers.Add(typeof(UserChangeMessage), new UserChangeSerializer(Outgoing.UserChange));
            #endregion

            #region Session
            Serializers.Add(typeof(OpenConnectionMessage), new OpenConnectionSerializer(Outgoing.OpenConnection));
            Serializers.Add(typeof(RoomReadyMessage), new RoomReadySerializer(Outgoing.RoomReady));
            Serializers.Add(typeof(RoomForwardMessage), new RoomForwardSerializer(Outgoing.RoomForward));
            Serializers.Add(typeof(CantConnectMessage), new CantConnectSerializer(Outgoing.CantConnect));
            Serializers.Add(typeof(CloseConnectionMessage), new CloseConnectionSerializer(Outgoing.CloseConnection));
            #endregion
            #endregion
        }
    }
}
