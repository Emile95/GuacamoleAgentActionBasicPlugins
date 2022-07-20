using Library.Agent.Action;

namespace Jihogo
{
    public class JihoGoAction : AgentAction
    {
        public override AgentActionDefinition GetAgentActionDefinition()
        {
            return new AgentActionDefinition
            {
                DisplayName = "JihoGo !!"
            };
        }

        public override void Process()
        {
            Console.WriteLine("Jihooooogoooo");
        }
    }
}