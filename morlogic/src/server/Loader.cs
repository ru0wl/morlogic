using LogicAPI.Server;

namespace morlogic.Server {
    public class Loader : ServerMod {
        protected override void Initialize() {
            Logger.Info("morlogic loaded");
        }
    }
}
