namespace TurboDefaultRevisionPlugin.Headers
{
        public static class Incoming
        {
                #region Catalog
                public const int BuildersClubPlaceRoomItem = 1051;
                public const int BuildersClubPlaceWallItem = 462;
                public const int BuildersClubQueryFurniCount = 2529;
                public const int ChargeFirework = -1;
                public const int GetBonusRareInfo = 957;
                public const int GetBundleDiscountRuleset = 223;
                public const int GetCatalogIndex = 1195;
                public const int GetCatalogPage = 412;
                public const int GetCatalogPageWithEarliestExpiry = 3135;
                public const int GetClubGiftInfo = 487;
                public const int GetClubOffers = 3285;
                public const int GetDirectClubBuyAvailable = 801;
                public const int GetGiftWrappingConfiguration = 418;
                public const int GetHabboBasicMembershipExtendOffer = 603;
                public const int GetHabboClubExtendOffer = 2462;
                public const int GetIsOfferGiftable = 1347;
                public const int GetLimitedOfferAppearingNext = 410;
                public const int GetNextTargetedOffer = 596;
                public const int GetProductOffer = 2594;
                public const int GetRoomAdPurchaseInfo = 1075;
                public const int GetSeasonalCalendarDailyOffer = 3257;
                public const int GetSellablePetPalettes = 1756;
                public const int GetTargetedOffer = 2487;
                public const int MarkCatalogNewAdditionsPageOpened = 2150;
                public const int PurchaseBasicMembershipExtension = 2735;
                public const int PurchaseFromCatalogAsGift = 1411;
                public const int PurchaseFromCatalog = 3492;
                public const int PurchaseRoomAd = 777;
                public const int PurchaseTargetedOffer = 1826;
                public const int PurchaseVipMembershipExtension = 3407;
                public const int RedeemVoucher = 339;
                public const int RoomAdPurchaseInitiated = 2283;
                public const int SelectClubGift = 2276;
                public const int SetTargetedOfferState = 2041;
                public const int ShopTargetedOfferViewed = 3483;
                #endregion

                #region Handshake
                public const int ClientHello = 4000;
                public const int SSOTicket = 2419;
                public const int Pong = 2596;
                public const int UniqueId = 2490;
                public const int InfoRetrieve = 357;
                public const int VersionCheck = 1053;
                public const int Disconnect = 2445;
                public const int CompleteDiffieHandshake = 773;
                public const int InitDiffieHandshake = 3110;
                #endregion

                #region Inventory

                #region Badges
                public const int GetBadges = 2769;
                public const int SetActivatedBadges = 644;
                #endregion

                #region Furni
                public const int RequestFurniInventory = 3150;
                public const int RequestFurniInventoryWhenNotInRoom = 3500;
                public const int RequestRoomPropertySet = 711;
                #endregion

                #endregion

                #region Navigator
                public const int CanCreateRoom = 2128;
                public const int CreateFlat = 2752;
                public const int ForwardToSomeRoom = 1703;
                public const int GetPopularRoomTags = 826;
                public const int GetGuestRoom = 2230;
                public const int GetUserEventCats = 1782;
                public const int GetUserFlatCats = 3027;
                public const int MyFavouriteRoomsSearch = 2578;
                public const int MyFriendsRoomsSearch = 2266;
                public const int MyGuildBasesSearch = 39;
                public const int MyRoomHistorySearch = 2264;
                public const int MyRoomRightsSearch = 272;
                public const int MyRoomsSearch = 2277;
                public const int NavigatorAddCollapsedCategory = 1834;
                public const int NavigatorAddSavedSearch = 2226;
                public const int NavigatorDeleteSavedSearch = 1954;
                public const int NavigatorRemoveCollapsedCategory = 637;
                public const int NavigatorSetSearchCodeViewMode = 1202;
                public const int NewNavigatorInit = 2110;
                public const int NewNavigatorSearch = 249;
                public const int PopularRoomsSearch = 2758;
                public const int RoomsWhereMyFriendsAreSearch = 1786;
                public const int RoomsWithHighestScoreSearch = 2939;
                public const int SetNewNavigatorWindowPreferences = 3159;
                #endregion

                #region Room

                #region Action
                public const int AmbassadorAlert = 2996;
                public const int AssignRights = 808;
                public const int BanUserWithDuration = 1477;
                public const int LetUserIn = 1644;
                public const int MuteAllInRoom = 3637;
                public const int RemoveAllRights = 2683;
                public const int RemoveRights = 2064;
                public const int KickUser = 1320;
                public const int MuteUser = 3485;
                public const int UnbanUserFromRoom = 992;
                #endregion

                #region Avatar
                public const int Dance = 2080;
                public const int AvatarExpression = 2456;
                public const int ChangeMotto = 2228;
                public const int ChangePosture = 2235;
                public const int CustomizeAvatarWithFurni = 3374;
                public const int DropCarryItem = 2814;
                public const int LookTo = 3301;
                public const int PassCarryItem = 2941;
                public const int PassCarryItemToPet = 2768;
                public const int Sign = 1975;
                #endregion

                #region Chat
                public const int CancelTyping = 1474;
                public const int Chat = 1314;
                public const int StartTyping = 1597;
                public const int Whisper = 1543;
                public const int SetChatStylePreference = 1030;
                public const int Shout = 2085;
                #endregion

                #region Engine
                public const int GetFurnitureAliases = 3898;
                public const int GetRoomEntryData = 2300;
                public const int PlaceObject = 1258;
                public const int MoveAvatar = 3320;
                public const int GetItemData = 3964;
                public const int MoveObject = 248;
                public const int MoveWallItem = 168;
                public const int PickupObject = 3456;
                public const int RemoveItem = 3336;
                public const int SetItemData = 3666;
                public const int SetObjectData = 3608;
                public const int UseFurniture = 99;
                public const int UseWallItem = 210;
                #endregion

                #region Furniture
                public const int ThrowDice = 1990;
                public const int SetCustomStackingHeight = 3839;
                public const int CloseDice = 1533;
                #endregion

                #region Session
                public const int OpenFlatConnection = 2312;
                public const int Quit = 105;
                public const int GoToFlat = 685;
                public const int ChangeQueue = 3093;
                #endregion

                #endregion

                #region RoomSettings
                public const int DeleteRoom = 532;
                public const int GetBannedUsersFromRoom = 2267;
                public const int GetCustomRoomFilter = 1911;
                public const int GetFlatControllers = 3385;
                public const int GetRoomSettings = 3129;
                public const int SaveRoomSettings = 1969;
                public const int UpdateRoomCategoryAndTradeSettings = 1265;
                public const int UpdateRoomFilter = 3001;
                #endregion

                #region Users
                public const int GetSelectedBadges = 2091;
                #endregion

                #region Wired
                public const int ApplySnapshot = 3373;
                public const int OpenWired = 768;
                public const int UpdateAction = 2281;
                public const int UpdateCondition = 3203;
                public const int UpdateTrigger = 1520;
                #endregion
        }
}
