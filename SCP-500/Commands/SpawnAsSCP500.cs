using CommandSystem;
using Exiled.API.Features;

namespace SCP_500.Commands {
    [CommandHandler(typeof(RemoteAdminCommandHandler))]
    public class SpawnAsSCP500 : ICommand {
        public string Command => "makeMeSCPPls";

        public string[] Aliases => ["spawn_as_scp_500", "spawn_as_better_skeleton"];

        public string Description => "spawns you as scp 500";
        

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response) {
            Player player = Player.Get(arguments.At(0));
            if (player == null) {
                response = $"Игрок не найден: {arguments.At(0)}";
                return false;
            }

            player.RoleManager.ServerSetRole(PlayerRoles.RoleTypeId.ClassD, PlayerRoles.RoleChangeReason.RoundStart, PlayerRoles.RoleSpawnFlags.None);
            player.Health = 800;
            player.ShowHint("Теперь вы SCP 500, да ты - панацея на ножках. Иди лечить игроков");
            player.MaxHealth = 800;

            response = "Успешно";
            return true;            
        }
    }
}
