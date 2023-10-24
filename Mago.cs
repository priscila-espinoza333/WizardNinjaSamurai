public class Mago : Human{
    // Creo el Constructor
    public Mago(string name) : base(name, 2, 25, 100, 50){
    }

    // Este es el Método para lanzar un hechizo
    public int CastSpell(Human target){
        int damage = Intelligence * 5;
        target.Health -= damage;
        Console.WriteLine($"{Name} lanza hechizo {target.Name} por {damage} de daño!");
        return target.Health;
    }

    //Aca realizo el  Método de curación
    public int Heal(Human target){
        int healing = Intelligence * 3;
        target.Health += healing;
        Console.WriteLine($"{Name} curado {target.Name} por  {healing} de vida!");
        return target.Health;
    }

    public int CounterSpell(Human target)
    {
        int counterDamage = Intelligence * 4;
        target.Health -= counterDamage;
        Console.WriteLine($"{Name} contrarresta {target.Name} el hechizo por {counterDamage}  de daño!");
        return target.Health;
    }
}
