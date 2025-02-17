public partial class Hp : Node
{
    private int hp;
    [Export]
    public int HP { get => hp; set => SetHP(value); }

    private void SetHP(int newHP)
    {
        hp = newHP;

        if (hp <= 0)
        {
            Die();
        }
    }

    public void Die()
        => GetParent().QueueFree();
}
