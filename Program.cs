//creo la instancia de las clases heredadas
class Program{
    static void Main(string[] args){
        Ninja ninja = new Ninja("NinjaDojo");
        Mago mago = new Mago("DojoMago");
        Samurai samurai = new Samurai("SamuraiDojo");

        ninja.Attack(mago); //metodo para atacar llamando ala instancia attack
        mago.CastSpell(samurai); //llamo al metodo  catspell en la instancia del mago 
        samurai.Meditate(); // llamo al metodo meditate para restaurar su vida 

        mago.CounterSpell(samurai);

          mago.Heal(samurai);

        ninja.StealthAttack(samurai);

        ninja.Robar(samurai);
        samurai.DeathBlow(ninja);
    }
  

    }
