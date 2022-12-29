using POO;
//HERENCIA
var carro1= new Carro();

carro1.Marca = "toyota";
carro1.EncerderRadio();

var camion = new Camion();
camion.Marca = "truck";

var vici = new vicicleta();
vici.Marca = "vici";

LeerMarca(camion);
LeerMarca(carro1);
LeerMarca(vici);

camion.darReversa();
carro1.darReversa();


void LeerMarca(Vehiculo vehiculo)
{
    var mensaje = $"Leyendo la marca {vehiculo.Marca} del vehicullo de tipo{vehiculo}";
    Console.WriteLine(mensaje);
}

//ASBTRACT

//var vehiculo = new Vehiculo();

var carro = new Carro();
carro.Acelerar(200);
Console.WriteLine(carro.Velocidad);

//object

