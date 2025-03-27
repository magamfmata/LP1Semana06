namespace MyGame
{
    public class Enemy
    {
    private string name;
    private float health;
    private float shield;
    // Construtor
    public Enemy(string name)

        {
        this.name = name; // Porque razao usamos "this"?
        health = 100;
        shield = 0;

        }

    }

}
