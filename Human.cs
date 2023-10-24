//creo lal clase Human
public class Human{
    public string Name { get; set; }
    public int Strength { get; set; }
    public int Intelligence { get; set; }
    public int Dexterity { get; set; }
    public int Health { get; set; }
     
    public Human(string name, int str, int intel, int dex, int hp){
        Name = name;
        Strength = str;
        Intelligence = intel;
        Dexterity = dex;
        Health = hp;
    }
     //calculo el daño que hace el jugador en base a la fuerza de este 
    public int Attack(Human target){
        int dmg = Strength * 3;
        target.Health -= dmg;
        Console.WriteLine($"{Name} ataca {target.Name} con {dmg} de daño!");
        return target.Health;
    }
}
