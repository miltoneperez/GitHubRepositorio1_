//programa que permita visualizar los departamentos de nicaragua con su cantidad poblacional.
//Encuentre: Mayor, menor, sumas y ordene los datos
using System.Collections;
Dictionary<string, int> dep = new Dictionary<string, int>()
{
    {"Boaco",185013},
    {"Carazo",197139},
    {"Chinandega",439906},
    {"Chontales",190863},
    {"Costa Caribe Norte",530586},
    {"Costa Caribe Sur",414543},
    {"Estelí",229866},
    {"Granada",214317},
    {"Jinotega",475630},
    {"León",421050},
    {"Madriz",174744},
    {"Managua",1,575819},
    {"Masaya",391903},
    {"Matagalpa",593503},
    {"Nueva Segovia",271581},
    {"Río San Juan",135446},
    {"Rivas",182645}
};
//Ordenando de manera ascendente
var orderDepResult=dep.OrderBy(d=>d.Value);

//mostrar el diccionario ordenado por población
foreach (var item in orderDepResult)
    Console.WriteLine($"{item.Key,20} ==> {item.Value,10:N0}");
//Suma de toda la población
Console.WriteLine($"Población General:{dep.Values.Sum():N0}");
//Mayor y menor población
var minResult = dep.Where(x => x.Value == dep.Value.Min());
Console.WriteLine($"Más pequeño Población:{minResult.First().Key}");
Console.WriteLine($"Más grande Población:{orderDepResult.Last().Key}");
