class Ninja : Human{
    public Ninja(string name) : base(name, 3, 3, 175, 100){
    }

    public int Steal(Human target){
        //calculo cantidad de daño que hara el ninja al enemigo 
        int dmg = Dexterity * 5; //multiplico la destreza por 5
        target.Health -= dmg; // calculo el daño realizado 
        Health += dmg;// aqui robo la salud para el  ninja
        Console.WriteLine($"{Name} stole from {target.Name} for {dmg} damage!");
        return target.Health;
    }

    public int StealthAttack(Human target){
    int damage = Dexterity; // calculo el daño de ataque sigiliso del ninja 
    //creo la instancia para generar numeros aleatorios.
    Random rand = new Random();
    double chance = rand.NextDouble(); // Genero un número aleatorio entre 0 y 1

    if (chance <= 0.2){
        damage += 10;
    }
    target.Health -= damage; //reduce la salud del enemigo
    Console.WriteLine($"{Name} realizó un ataque sigiloso contra {target.Name} por {damage}de daño!");
    return target.Health;
}
//defino la vida que robara el ninja a su enemigo
    public int Robar(Human target){
        int stolenHealth = 5;
        target.Health -= 5;
        Health += 5;
        Console.WriteLine($"{Name} robo de {target.Name} por {stolenHealth} vida!");
        return target.Health;
    }

}
