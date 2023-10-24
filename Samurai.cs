class Samurai : Human{
    public Samurai(string name) : base(name, 5, 3, 75, 200){
    }
// creo metodo para restaurar la vida a 200
    public int Meditate(){
        Health = 200;
        Console.WriteLine($"{Name} ha meditado y recupero su vida a 200!!");
        return Health;
    }
// creo metodo para ataque anulado 
    public int DeathBlow(Human target){
        if (target.Health < 50){
            target.Health = 0;
            Console.WriteLine($"{Name} da un golpe mortal {target.Name} y dejo su vida en 0!");
        }else{
            target.Attack(target); 
        }
        return target.Health;
    }
}
