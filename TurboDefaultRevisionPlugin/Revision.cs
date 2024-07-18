using System;
using System.Collections.Generic;
using Turbo.Core.Packets.Messages;
using Turbo.Core.Packets.Revisions;
using Turbo.Packets.Outgoing.Catalog;
using Turbo.Packets.Outgoing.Handshake;
using Turbo.Packets.Outgoing.Inventory.Badges;
using Turbo.Packets.Outgoing.Inventory.Furni;
using Turbo.Packets.Outgoing.Navigator;
using Turbo.Packets.Outgoing.Notifications;
using Turbo.Packets.Outgoing.Room.Action;
using Turbo.Packets.Outgoing.Room.Chat;
using Turbo.Packets.Outgoing.Room.Engine;
using Turbo.Packets.Outgoing.Room.Furniture;
using Turbo.Packets.Outgoing.Room.Permissions;
using Turbo.Packets.Outgoing.Room.Session;
using Turbo.Packets.Outgoing.RoomSettings;
using Turbo.Packets.Outgoing.Users;
using Turbo.Packets.Outgoing.Wired;
using TurboDefaultRevisionPlugin.Headers;
using TurboDefaultRevisionPlugin.Parsers.Catalog;
using TurboDefaultRevisionPlugin.Parsers.Handshake;
using TurboDefaultRevisionPlugin.Parsers.Inventory.Badges;
using TurboDefaultRevisionPlugin.Parsers.Inventory.Furni;
using TurboDefaultRevisionPlugin.Parsers.Navigator;
using TurboDefaultRevisionPlugin.Parsers.Preferences;
using TurboDefaultRevisionPlugin.Parsers.Room.Action;
using TurboDefaultRevisionPlugin.Parsers.Room.Avatar;
using TurboDefaultRevisionPlugin.Parsers.Room.Chat;
using TurboDefaultRevisionPlugin.Parsers.Room.Engine;
using TurboDefaultRevisionPlugin.Parsers.Room.Furniture;
using TurboDefaultRevisionPlugin.Parsers.Room.Session;
using TurboDefaultRevisionPlugin.Parsers.RoomSettings;
using TurboDefaultRevisionPlugin.Parsers.Users;
using TurboDefaultRevisionPlugin.Parsers.Wired;
using TurboDefaultRevisionPlugin.Serializers.Catalog;
using TurboDefaultRevisionPlugin.Serializers.Handshake;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Badges;
using TurboDefaultRevisionPlugin.Serializers.Inventory.Furni;
using TurboDefaultRevisionPlugin.Serializers.Navigator;
using TurboDefaultRevisionPlugin.Serializers.Notifications;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Action;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Chat;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Engine;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Furniture;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Permissions;
using TurboDefaultRevisionPlugin.Serializers.Rooms.Session;
using TurboDefaultRevisionPlugin.Serializers.RoomSettings;
using TurboDefaultRevisionPlugin.Serializers.Users;
using TurboDefaultRevisionPlugin.Serializers.Wired;

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
            #region Catalog
            Parsers.Add(Incoming.BuildersClubPlaceRoomItem, new BuildersClubPlaceRoomItemParser());
            Parsers.Add(Incoming.BuildersClubPlaceWallItem, new BuildersClubPlaceWallItemParser());
            Parsers.Add(Incoming.BuildersClubQueryFurniCount, new BuildersClubQueryFurniCountParser());
            Parsers.Add(Incoming.ChargeFirework, new ChargeFireworkParser());
            Parsers.Add(Incoming.GetBonusRareInfo, new GetBonusRareInfoParser());
            Parsers.Add(Incoming.GetBundleDiscountRuleset, new GetBundleDiscountRulesetParser());
            Parsers.Add(Incoming.GetCatalogIndex, new GetCatalogIndexParser());
            Parsers.Add(Incoming.GetCatalogPage, new GetCatalogPageParser());
            Parsers.Add(Incoming.GetCatalogPageWithEarliestExpiry, new GetCatalogPageWithEarliestExpiryParser());
            Parsers.Add(Incoming.GetClubGiftInfo, new GetClubGiftInfoParser());
            Parsers.Add(Incoming.GetClubOffers, new GetClubOffersParser());
            Parsers.Add(Incoming.GetDirectClubBuyAvailable, new GetDirectClubBuyAvailableParser());
            Parsers.Add(Incoming.GetGiftWrappingConfiguration, new GetGiftWrappingConfigurationParser());
            Parsers.Add(Incoming.GetHabboBasicMembershipExtendOffer, new GetHabboBasicMembershipExtendOfferParser());
            Parsers.Add(Incoming.GetHabboClubExtendOffer, new GetHabboClubExtendOfferParser());
            Parsers.Add(Incoming.GetIsOfferGiftable, new GetIsOfferGiftableParser());
            Parsers.Add(Incoming.GetLimitedOfferAppearingNext, new GetLimitedOfferAppearingNextParser());
            Parsers.Add(Incoming.GetNextTargetedOffer, new GetNextTargetedOfferParser());
            Parsers.Add(Incoming.GetProductOffer, new GetProductOfferParser());
            Parsers.Add(Incoming.GetRoomAdPurchaseInfo, new GetRoomAdPurchaseInfoParser());
            Parsers.Add(Incoming.GetSeasonalCalendarDailyOffer, new GetSeasonalCalendarDailyOfferParser());
            Parsers.Add(Incoming.GetSellablePetPalettes, new GetSellablePetPalettesParser());
            Parsers.Add(Incoming.GetTargetedOffer, new GetTargetedOfferParser());
            Parsers.Add(Incoming.MarkCatalogNewAdditionsPageOpened, new MarkCatalogNewAdditionsPageOpenedParser());
            Parsers.Add(Incoming.PurchaseBasicMembershipExtension, new PurchaseBasicMembershipExtensionParser());
            Parsers.Add(Incoming.PurchaseFromCatalogAsGift, new PurchaseFromCatalogAsGiftParser());
            Parsers.Add(Incoming.PurchaseFromCatalog, new PurchaseFromCatalogParser());
            Parsers.Add(Incoming.PurchaseRoomAd, new PurchaseRoomAdParser());
            Parsers.Add(Incoming.PurchaseTargetedOffer, new PurchaseTargetedOfferParser());
            Parsers.Add(Incoming.PurchaseVipMembershipExtension, new PurchaseVipMembershipExtensionParser());
            Parsers.Add(Incoming.RedeemVoucher, new RedeemVoucherParser());
            Parsers.Add(Incoming.RoomAdPurchaseInitiated, new RoomAdPurchaseInitiatedParser());
            Parsers.Add(Incoming.SelectClubGift, new SelectClubGiftParser());
            Parsers.Add(Incoming.SetTargetedOfferState, new SetTargetedOfferStateParser());
            Parsers.Add(Incoming.ShopTargetedOfferViewed, new ShopTargetedOfferViewedParser());
            #endregion

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

            #region Badges
            Parsers.Add(Incoming.GetBadges, new GetBadgesParser());
            Parsers.Add(Incoming.SetActivatedBadges, new SetActivatedBadgesParser());
            #endregion

            #region Furni
            Parsers.Add(Incoming.RequestFurniInventory, new RequestFurniInventoryParser());
            Parsers.Add(Incoming.RequestFurniInventoryWhenNotInRoom, new RequestFurniInventoryWhenNotInRoomParser());
            Parsers.Add(Incoming.RequestRoomPropertySet, new RequestRoomPropertySetParser());
            #endregion

            #endregion

            #region Navigator
            Parsers.Add(Incoming.CanCreateRoom, new CanCreateRoomParser());
            Parsers.Add(Incoming.CreateFlat, new CreateFlatParser());
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

            #region Room

            #region Action
            Parsers.Add(Incoming.AmbassadorAlert, new AmbassadorAlertParser());
            Parsers.Add(Incoming.AssignRights, new AssignRightsParser());
            Parsers.Add(Incoming.BanUserWithDuration, new BanUserWithDurationParser());
            Parsers.Add(Incoming.LetUserIn, new LetUserInParser());
            Parsers.Add(Incoming.MuteAllInRoom, new MuteAllInRoomParser());
            Parsers.Add(Incoming.RemoveAllRights, new RemoveAllRightsParser());
            Parsers.Add(Incoming.RemoveRights, new RemoveRightsParser());
            Parsers.Add(Incoming.KickUser, new KickUserParser());
            Parsers.Add(Incoming.MuteUser, new MuteUserParser());
            Parsers.Add(Incoming.UnbanUserFromRoom, new UnbanUserFromRoomParser());
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
            
            #region Chat
            Parsers.Add(Incoming.CancelTyping, new CancelTypingParser());
            Parsers.Add(Incoming.Chat, new ChatParser());
            Parsers.Add(Incoming.StartTyping, new StartTypingParser());
            Parsers.Add(Incoming.Whisper, new WhisperParser());
            Parsers.Add(Incoming.SetChatStylePreference, new SetChatStylePreferenceParser());
            Parsers.Add(Incoming.Shout, new ShoutParser());
            #endregion

            #region Engine
            Parsers.Add(Incoming.GetFurnitureAliases, new GetFurnitureAliasesParser());
            Parsers.Add(Incoming.GetItemData, new GetItemDataParser());
            Parsers.Add(Incoming.GetRoomEntryData, new GetRoomEntryDataParser());
            Parsers.Add(Incoming.MoveAvatar, new MoveAvatarParser());
            Parsers.Add(Incoming.MoveObject, new MoveObjectParser());
            Parsers.Add(Incoming.MoveWallItem, new MoveWallItemParser());
            Parsers.Add(Incoming.PickupObject, new PickupObjectParser());
            Parsers.Add(Incoming.PlaceObject, new PlaceObjectParser());
            Parsers.Add(Incoming.RemoveItem, new RemoveItemParser());
            Parsers.Add(Incoming.SetItemData, new SetItemDataParser());
            Parsers.Add(Incoming.SetObjectData, new SetObjectDataParser());
            Parsers.Add(Incoming.UseFurniture, new UseFurnitureParser());
            Parsers.Add(Incoming.UseWallItem, new UseWallItemParser());
            #endregion

            #region Furniture
            Parsers.Add(Incoming.ThrowDice, new ThrowDiceParser());
            Parsers.Add(Incoming.SetCustomStackingHeight, new SetCustomStackingHeightParser());
            Parsers.Add(Incoming.CloseDice, new DiceOffParser());
            #endregion

            #region Session
            Parsers.Add(Incoming.OpenFlatConnection, new OpenFlatConnectionParser());
            Parsers.Add(Incoming.Quit, new QuitParser());
            Parsers.Add(Incoming.GoToFlat, new GoToFlatParser());
            Parsers.Add(Incoming.ChangeQueue, new ChangeQueueParser());
            #endregion

            #endregion

            #region RoomSettings
            Parsers.Add(Incoming.DeleteRoom, new DeleteRoomParser());
            Parsers.Add(Incoming.GetBannedUsersFromRoom, new GetBannedUsersFromRoomParser());
            Parsers.Add(Incoming.GetCustomRoomFilter, new GetCustomRoomFilterParser());
            Parsers.Add(Incoming.GetFlatControllers, new GetFlatControllersParser());
            Parsers.Add(Incoming.GetRoomSettings, new GetRoomSettingsParser());
            Parsers.Add(Incoming.SaveRoomSettings, new SaveRoomSettingsParser());
            Parsers.Add(Incoming.UpdateRoomCategoryAndTradeSettings, new UpdateRoomCategoryAndTradeSettingsParser());
            Parsers.Add(Incoming.UpdateRoomFilter, new UpdateRoomFilterParser());
            #endregion

            #region Users
            Parsers.Add(Incoming.GetSelectedBadges, new GetSelectedBadgesParser());
            #endregion

            #region Wired
            Parsers.Add(Incoming.ApplySnapshot, new ApplySnapshotParser());
            Parsers.Add(Incoming.OpenWired, new OpenParser());
            Parsers.Add(Incoming.UpdateAction, new UpdateActionParser());
            Parsers.Add(Incoming.UpdateCondition, new UpdateConditionParser());
            Parsers.Add(Incoming.UpdateTrigger, new UpdateTriggerParser());
            #endregion
        }

        private void RegisterSerializers()
        {
            #region Catalog
            Serializers.Add(typeof(BonusRareInfoMessage), new BonusRareInfoSerializer(Outgoing.BonusRareInfo));
            Serializers.Add(typeof(BuildersClubFurniCountMessage), new BuildersClubFurniCountSerializer(Outgoing.BuildersClubFurniCount));
            Serializers.Add(typeof(BuildersClubSubscriptionStatusMessage), new BuildersClubSubscriptionStatusSerializer(Outgoing.BuildersClubSubscriptionStatus));
            Serializers.Add(typeof(BundleDiscountRulesetMessage), new BundleDiscountRulesetSerializer(Outgoing.BundleDiscountRuleset));
            Serializers.Add(typeof(CatalogIndexMessage), new CatalogIndexerializer(Outgoing.CatalogIndex));
            Serializers.Add(typeof(CatalogPageMessage), new CatalogPageSerializer(Outgoing.CatalogPage));
            Serializers.Add(typeof(ProductOfferMessage), new ProductOfferSerializer(Outgoing.ProductOffer));
            Serializers.Add(typeof(PurchaseErrorMessage), new PurchaseErrorSerializer(Outgoing.PurchaseError));
            Serializers.Add(typeof(PurchaseNotAllowedMessage), new PurchaseNotAllowedSerializer(Outgoing.PurchaseNotAllowed));
            Serializers.Add(typeof(PurchaseOkMessage), new PurchaseOkSerializer(Outgoing.PurchaseOk));
            #endregion

            #region Handshake
            Serializers.Add(typeof(AuthenticationOKMessage), new AuthenticationOKSerializer(Outgoing.AuthenticationOK));
            Serializers.Add(typeof(GenericErrorMessage), new GenericErrorSerializer(Outgoing.GenericError));
            Serializers.Add(typeof(PingMessage), new PingSerializer(Outgoing.Ping));
            Serializers.Add(typeof(UniqueMachineIdMessage), new UniqueMachineIdSerializer(Outgoing.UniqueMachineID));
            Serializers.Add(typeof(UserObjectMessage), new UserObjectSerializer(Outgoing.UserObject));
            Serializers.Add(typeof(UserRightsMessage), new UserRightsSerializer(Outgoing.UserRights));
            #endregion

            #region Inventory

            #region Badges
            Serializers.Add(typeof(BadgeReceivedMessage), new BadgeReceivedSerializer(Outgoing.BadgeReceived));
            Serializers.Add(typeof(BadgeMessage), new BadgeSerializer(Outgoing.Badge));
            #endregion

            #region Furni
            Serializers.Add(typeof(FurniListAddOrUpdateMessage), new FurniListAddOrUpdateSerializer(Outgoing.FurniListAddOrUpdate));
            Serializers.Add(typeof(FurniListInvalidateMessage), new FurniListInvalidateSerializer(Outgoing.FurniListInvalidate));
            Serializers.Add(typeof(FurniListRemoveMessage), new FurniListRemoveSerializer(Outgoing.FurniListRemove));
            Serializers.Add(typeof(FurniListMessage), new FurniListSerializer(Outgoing.FurniList));
            Serializers.Add(typeof(PostItPlacedMessage), new PostItPlacedSerializer(Outgoing.PostItPlaced));
            #endregion

            #endregion

            #region Navigator
            Serializers.Add(typeof(DoorbellMessage), new DoorbellSerializer(Outgoing.Doorbell));
            Serializers.Add(typeof(GetGuestRoomResultMessage), new GetGuestRoomResultSerializer(Outgoing.GetGuestRoomResult));
            Serializers.Add(typeof(NavigatorEventCategoriesMessage), new NavigatorEventCategoriesSerializer(Outgoing.NavigatorEventCategories));
            Serializers.Add(typeof(NavigatorLiftedRoomsMessage), new NavigatorLiftedRoomsSerializer(Outgoing.NavigatorLiftedRooms));
            Serializers.Add(typeof(NavigatorMetaDataMessage), new NavigatorMetaDataSerializer(Outgoing.NavigatorMetaData));
            Serializers.Add(typeof(NavigatorSavedSearchesMessage), new NavigatorSavedSearchesSerializer(Outgoing.NavigatorSavedSearches));
            Serializers.Add(typeof(NavigatorSettingsMessage), new NavigatorSettingsSerializer(Outgoing.NavigatorSettings));
            Serializers.Add(typeof(NewNavigatorPreferencesMessage), new NewNavigatorPreferencesSerializer(Outgoing.NewNavigatorPreferences));
            Serializers.Add(typeof(RoomInfoUpdatedMessage), new RoomInfoUpdatedSerializer(Outgoing.RoomInfoUpdated));
            Serializers.Add(typeof(UserFlatCatsMessage), new UserFlatCatsSerializer(Outgoing.UserFlatCats));
            #endregion

            #region Notifications
            Serializers.Add(typeof(UnseenItemsMessage), new UnseenItemsSerializer(Outgoing.UnseenItems));
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

            #region Chat
            Serializers.Add(typeof(ChatMessage), new ChatSerializer(Outgoing.Chat));
            Serializers.Add(typeof(WhisperMessage), new WhisperSerializer(Outgoing.Whisper));
            Serializers.Add(typeof(ShoutMessage), new ShoutSerializer(Outgoing.Shout));
            Serializers.Add(typeof(FloodControlMessage), new FloodControlSerializer(Outgoing.FloodControl));
            Serializers.Add(typeof(RemaningMutePeriodMessage), new RemainingMutePeriodSerializer(Outgoing.RemainingMutePeriod));
            Serializers.Add(typeof(RoomChatSettingsMessage), new RoomChatSettingsSerializer(Outgoing.RoomChatSettings));
            Serializers.Add(typeof(RoomFilterSettingsMessage), new RoomFilterSettingsSerializer(Outgoing.RoomFilterSettings));
            Serializers.Add(typeof(UserTypingMessage), new UserTypingSerializer(Outgoing.UserTyping));
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

            #region Furniture
            Serializers.Add(typeof(CustomStackingHeightUpdateMessage), new CustomStackingHeightUpdateSerializer(Outgoing.CustomStackingHeightUpdate));
            #endregion

            #region Permissions
            Serializers.Add(typeof(YouAreControllerMessage), new YouAreControllerSerializer(Outgoing.YouAreController));
            Serializers.Add(typeof(YouAreNotControllerMessage), new YouAreNotControllerSerializer(Outgoing.YouAreNotController));
            Serializers.Add(typeof(YouAreOwnerMessage), new YouAreOwnerSerializer(Outgoing.YouAreOwner));
            #endregion

            #region Session
            Serializers.Add(typeof(CantConnectMessage), new CantConnectSerializer(Outgoing.CantConnect));
            Serializers.Add(typeof(CloseConnectionMessage), new CloseConnectionSerializer(Outgoing.CloseConnection));
            Serializers.Add(typeof(FlatAccessibleMessage), new FlatAccessibleSerializer(Outgoing.FlatAccessible));
            Serializers.Add(typeof(OpenConnectionMessage), new OpenConnectionSerializer(Outgoing.OpenConnection));
            Serializers.Add(typeof(RoomForwardMessage), new RoomForwardSerializer(Outgoing.RoomForward));
            Serializers.Add(typeof(RoomReadyMessage), new RoomReadySerializer(Outgoing.RoomReady));
            Serializers.Add(typeof(YouArePlayingGameMessage), new YouArePlayingGameSerializer(Outgoing.YouArePlayingGame));
            Serializers.Add(typeof(YouAreSpectatorMessage), new YouAreSpectatorSerializer(Outgoing.YouAreSpectator));
            #endregion

            #endregion

            #region RoomSettings
            Serializers.Add(typeof(BannedUsersFromRoomMessage), new BannedUsersFromRoomSerializer(Outgoing.BannedUsersFromRoom));
            Serializers.Add(typeof(FlatControllerAddedMessage), new FlatControllerAddedSerializer(Outgoing.FlatControllerAdded));
            Serializers.Add(typeof(FlatControllerRemovedMessage), new FlatControllerRemovedSerializer(Outgoing.FlatControllerRemoved));
            Serializers.Add(typeof(FlatControllersMessage), new FlatControllersSerializer(Outgoing.FlatControllers));
            Serializers.Add(typeof(MuteAllInRoomMessage), new MuteAllInRoomSerializer(Outgoing.MuteAllInRoom));
            Serializers.Add(typeof(NoSuchFlatMessage), new NoSuchFlatSerializer(Outgoing.NoSuchFlat));
            Serializers.Add(typeof(RoomSettingsDataMessage), new RoomSettingsDataSerializer(Outgoing.RoomSettingsData));
            Serializers.Add(typeof(RoomSettingsErrorMessage), new RoomSettingsErrorSerializer(Outgoing.RoomSettingsError));
            Serializers.Add(typeof(RoomSettingsSavedMessage), new RoomSettingsSavedSerializer(Outgoing.RoomSettingsSaved));
            Serializers.Add(typeof(RoomSettingsSaveErrorMessage), new RoomSettingsSaveErrorSerializer(Outgoing.RoomSettingsSaveError));
            Serializers.Add(typeof(ShowEnforceRoomCategoryDialogMessage), new ShowEnforceRoomCategoryDialogSerializer(Outgoing.ShowEnforceRoomCategoryDialog));
            Serializers.Add(typeof(UserUnbannedFromRoomMessage), new UserUnbannedFromRoomSerializer(Outgoing.UserUnbannedFromRoom));
            #endregion

            #region Users
            Serializers.Add(typeof(UserBadgesMessage), new UserBadgesSerializer(Outgoing.UserBadges));
            #endregion

            #region Wired
            Serializers.Add(typeof(OpenMessage), new OpenSerializer(Outgoing.WiredOpen));
            Serializers.Add(typeof(WiredConditionDataMessage), new WiredConditionDataSerializer(Outgoing.WiredConditionData));
            Serializers.Add(typeof(WiredEffectDataMessage), new WiredEffectDataSerializer(Outgoing.WiredEffectData));
            Serializers.Add(typeof(WiredRewardResultMessage), new WiredRewardResultSerializer(Outgoing.WiredRewardResult));
            Serializers.Add(typeof(WiredSavedMessage), new WiredSavedSerializer(Outgoing.WiredSaved));
            Serializers.Add(typeof(WiredTriggerDataMessage), new WiredTriggerDataSerializer(Outgoing.WiredTriggerData));
            #endregion
        }
    }
}
