using Exiled.Events.Handlers;
using Exiled.API.Features;
using MEC;


namespace SCP_500 {
    public class SCP500 : Exiled.API.Features.Plugin<Config>
    {
        public override string Author => "[Девопёс] Сэр Енот";
        public override string Name => "SCP 500 role";
        Exiled.API.Features.Player scp = null;

        public override void OnEnabled() {
            var plugin = this;
            Exiled.Events.Handlers.Server.RoundStarted += plugin.OnRoundStart;
            
        }

        public override void OnDisabled() {
            var plugin = this;
            Exiled.Events.Handlers.Server.RoundStarted -= plugin.OnRoundStart;
        }
        public void MakeScp500(Exiled.API.Features.Player scplayer) {
            scplayer.RoleManager.ServerSetRole(PlayerRoles.RoleTypeId.ClassD, PlayerRoles.RoleChangeReason.RoundStart, PlayerRoles.RoleSpawnFlags.None);
            scplayer.Health = Config.Health;
            scplayer.ShowHint("Теперь вы SCP 500, да ты - панацея на ножках. Иди лечить игроков");
            scplayer.MaxHealth = Config.Health;
        }

        public void OnRoundStart() {
            if (!Config.IsSpawnNormaly) {
                return;
            }

            int r = new Random().Next(0, 100);

            if (r <= Config.SpawnChance) {
                Timing.CallDelayed(3f, () => {
                    scp = Exiled.API.Features.Player.Get(role: PlayerRoles.RoleTypeId.Scp3114).ToArray().RandomItem();
                    MakeScp500(scp);
                });
            }
        }
        
    }
}
