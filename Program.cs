using Laboratorio1VladimirAlexanderVel_squezAlas.Entidades;
using Laboratorio1VladimirAlexanderVel_squezAlas.Negocio;

Persona per = new Persona();
ClsPersona clsPersona = new ClsPersona();

Console.Write(@"Sea bienvenido a su calculadora de IMC
Por favor mi estimado ingresar datos para continuar 
Introduzca su Nombre = ");
per.Nombre = Console.ReadLine();

Console.Write("\nIntroducir su edad estimado= ");
per.Edad = Convert.ToInt32(Console.ReadLine());

Console.Write("\nIntroducir su sexo estimado = ");
per.Sexo = Console.ReadLine();

Console.Write("\nIntroducir su peso en Kg. estimado = ");
per.Peso = Convert.ToDouble(Console.ReadLine());

Console.Write("\nIntroducir su altura en metros estimado = ");
per.Altura = Convert.ToDouble(Console.ReadLine());

Console.Write($@"
Nombre: {per.Nombre} edad: {per.Edad} sexo: {per.Sexo}
Peso: {per.Peso}
Altura: {per.Altura}
Usted {clsPersona.CalcularIMC(per)}
Usted {clsPersona.MayorDeEdad(per)}");
