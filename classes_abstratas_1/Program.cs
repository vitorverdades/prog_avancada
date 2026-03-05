using System;
using Zoologico;

class Program
{
    static void Main(string[] args)
    {
        Cachorro dog = new Cachorro("Dog", new DateTime(2022, 5, 10),
            12.5f, 0.5f, true, 60, "Vira-lata", true);

        Gato cat = new Gato("Cat", new DateTime(2021, 8, 1),
            4.2f, 0.2f, true, 65, "SRD", false);

        Gaviao gav = new Gaviao("Fiel", new DateTime(2020, 3, 15),
            1.3f, 0.1f, 80f, 500f);

        Curio curio = new Curio("Curioso", new DateTime(2023, 1, 20),
            0.03f, 0.01f, 20f, true, 8);

        dog.EmitirSom();
        dog.Comer(0.1f);

        cat.EmitirSom();

        gav.EmitirSom();
        gav.Voar();
        gav.IniciarCaca();

        curio.EmitirSom();
        curio.Voar();
    }
}
