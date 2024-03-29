using Exiled.API;
using Exiled.API.Features;
using SCP_500.Handlers;
using SCP_500.Conf;

namespace SCP_500 {
    public class SCP500 : Plugin<Config> {
        public override string Author => "[Девопёс] Сэр Енот";
        public override string Name => "SCP 500 role";
        public MainHandler handler;
        public override void OnEnabled() {
            handler = new MainHandler();

            
        }
    }
}
