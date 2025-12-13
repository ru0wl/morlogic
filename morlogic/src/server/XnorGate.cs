using LogicAPI.Server.Components;

namespace morlogic.Server {
    public class XnorGate : LogicComponent {

        protected override void DoLogicUpdate() {
            bool a = Inputs[0].On;
            bool b = Inputs[1].On;
            Outputs[0].On = a == b;
        }
    }
}
