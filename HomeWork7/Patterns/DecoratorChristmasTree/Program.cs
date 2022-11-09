namespace DecoratorChristmasTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ChristmasTree christmasTree = new ChristmasTree();
            ToysTreeDecorator toysTreeDecorator = new ToysTreeDecorator();
            LightsTreeDecorator lightsTreeDecorator = new LightsTreeDecorator();

            toysTreeDecorator.SetTree(christmasTree);
            lightsTreeDecorator.SetTree(toysTreeDecorator);

            lightsTreeDecorator.Operation();
        }
    }

    abstract class Tree
    {
        public abstract void Operation();
    }
    class ChristmasTree : Tree
    {
        public override void Operation()
        {
            Console.WriteLine("Christmas Tree in the room");
        }
    }
    abstract class TreeDecorator : Tree
    {
        protected Tree tree;
        public void SetTree(Tree tree)
        {
            this.tree = tree;
        }
        public override void Operation()
        {
            if (tree is not null)
            {
                tree.Operation();
            }
        }
    }

    class ToysTreeDecorator : TreeDecorator
    {
        private string addedState;
        public override void Operation()
        {
            base.Operation();
            addedState = "Christmas toys";
            Console.WriteLine($"And {addedState} on the tree");
        }
    }
    class LightsTreeDecorator : TreeDecorator
    {
        public override void Operation()
        {
            base.Operation();
            Console.WriteLine("And lights on the tree");
            TurnOnLights();
        }
        void TurnOnLights()
        {
            Console.WriteLine("Lights are shining");
        }
    }
}