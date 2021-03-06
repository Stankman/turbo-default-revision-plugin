namespace TurboDefaultRevisionPlugin.Headers
{
    public static class Incoming
    {
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

        #region Room

        #region Action
        public const int KickUser = 1320;
        public const int MuteUser = 3485;
        #endregion

        #endregion
    }
}
