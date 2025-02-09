public class CompositeClient
{
    public void Execute()
    {
        Leaf leaf1 = new Leaf();
        Leaf leaf2 = new Leaf();
        Leaf leaf3 = new Leaf();

        Composite branch1 = new Composite();
        Composite branch2 = new Composite();

        branch1.Add(leaf1);
        branch1.Add(leaf2);

        branch2.Add(leaf3);

        Composite tree = new Composite();
        tree.Add(branch1);
        tree.Add(branch2);

        IComponent component = tree;
        component.Operation();
    }
}