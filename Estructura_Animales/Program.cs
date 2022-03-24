Animales ani = new Animales();
ani.Nombre = "Lobo";
ani.Total_patas = 4;
ani.Clasificación = "Mammalia";
ani.Color = "Gris";
Console.WriteLine("El animal es: {0} y su total de patas es: {1} ", ani.Nombre, ani.Total_patas);
Console.ReadKey(true);
struct Animales
{
    public string Nombre;
    public int Total_patas;
    public string Clasificación;
    public string Color;
}