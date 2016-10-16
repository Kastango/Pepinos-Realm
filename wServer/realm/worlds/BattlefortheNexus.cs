#region

using wServer.networking;

#endregion

namespace wServer.realm.worlds
{
    public class BattlefortheNexus : World
    {
        private readonly bool isLimbo;

        public BattlefortheNexus(bool isLimbo)
        {
            Id = TUT_ID;
            Name = "Battle For The Nexus";
            ClientWorldName = "server.tutorial";
            Background = 0;
            this.isLimbo = isLimbo;
        }

        protected override void Init()
        {
            if (!(IsLimbo = isLimbo))
            {
                LoadMap("wServer.realm.worlds.maps.Battleforthenexus.jm", MapType.Wmap);
            }
        }

        public override World GetInstance(Client psr)
        {
            return Manager.AddWorld(new Tutorial(false));
        }
    }
}