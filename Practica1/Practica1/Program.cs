using Practica1;
using Practica1.Interfaces;
using System.Reflection.Metadata.Ecma335;

Numero num1 = new Numero(15);
Numero num2 = new Numero(17);

Console.WriteLine("son iguales: " + num1.sosIgual(num2));
Console.WriteLine("es mayor:" + num1.sosMayor(num2));
Console.WriteLine("es menor:" + num1.sosMenor(num2));

//Coleccionable coleccion = new Cola();
//llenar(coleccion);
//informar(coleccion);


Console.WriteLine();

Coleccionable pila = new Pila();
Coleccionable cola = new Cola();
ColeccionMultiple multiple = new ColeccionMultiple(pila,cola);
//llenar(pila);
//llenar(cola);
//informar(pila);
//informar(cola);
//llenarPersonas(pila);
//llenarPersonas(cola);

llenarAlumnos(pila);
llenarAlumnos(cola);

for (int i = 0; i < cola.cuantos(); i++)
{
	Console.WriteLine(((Alumno)(((Cola)cola).Elementos[i])).Promedio);
}

informar(multiple);





//funciones 

void llenar (Coleccionable elementos) {
	for (int i = 0; i < 20; i++)
	{
		Comparable comparable = new Numero(new Random().Next(100));
		elementos.agregar(comparable);
	}
}
void informar(Coleccionable coleccion) {
	Console.WriteLine(coleccion.cuantos());
	//Console.WriteLine(((Numero)coleccion.minimo()).getValor());
	//Console.WriteLine(((Numero)coleccion.maximo()).getValor());
	//Console.WriteLine(((Persona)coleccion.minimo()).Dni);
	//Console.WriteLine(((Persona)coleccion.maximo()).Dni);
	Console.WriteLine(((Alumno)coleccion.minimo()).Promedio);
    Console.WriteLine(((Alumno)coleccion.maximo()).Promedio);

    //Comparable xComparable = new Numero(int.Parse(Console.ReadLine()));
    //Comparable xPersona = new Persona("",int.Parse(Console.ReadLine()));
    //Comparable xAlumno = new Alumno("", 0, 0, int.Parse(Console.ReadLine()));
	if (coleccion.contiene(new Alumno("", 1, 1, int.Parse(Console.ReadLine()))))
	{
		Console.WriteLine("El elemento leido esta en la coleccion");
	}
	else {
		Console.WriteLine("El elemento leido no esta en la coleccion");
	}

}

void llenarPersonas(Coleccionable coleccion)
{
    string[] nombres = { "Ana", "María", "Luis", "Juan", "Pedro", "Sofía", "Carla", "Fernando", "Diego", "Laura", "Roberto", "Rosa", "Sara", "Lucía", "Carlos", "Marta", "Miguel", "Manuel", "Isabel", "Adrián", "Javier", "Jorge", "Mario", "Natalia", "Valentina", "Esteban", "Gabriela", "Alicia", "Antonio", "Beatriz", "Cristina", "Daniel", "Elena", "Emilio", "Francisco", "Gloria", "Ignacio", "Jaime", "Julia", "Lorenzo", "Mariana", "Matías", "Nicolás", "Olivia", "Pablo", "Rafael", "Ramón", "Raúl", "Renata", "Simón", "Tomás", "Victoria", "Ximena", "Yolanda", "Zoe", "Agustín", "Bruno", "Camila", "Damián", "Emma", "Felipe", "Gonzalo", "Hugo", "Íñigo", "José", "Katia", "Leonardo", "Lola", "Magdalena", "Nicol", "Óscar", "Paula", "Quirino", "René", "Santiago", "Thiago", "Ulises", "Verónica", "Walter", "Xavier", "Yanina", "Zaira", "Abril", "Belen", "Carmen", "Dante", "Ezequiel", "Florencia", "Guillermo", "Héctor", "Inés", "Joaquín", "Karen", "Lucas", "Marcela", "Nacho", "Octavio", "Patricia", "Ramiro", "Salvador", "Tania", "Uriel", "Vanesa", "Wanda", "Yago", "Zara" };


    for (int i = 0; i < 20; i++)
	{
		coleccion.agregar(new Persona(nombres[new Random().Next(99)],new Random().Next(11111111,99999999)));
	}
}

void llenarAlumnos(Coleccionable coleccion) {

    string[] nombres = { "Ana", "María", "Luis", "Juan", "Pedro", "Sofía", "Carla", "Fernando", "Diego", "Laura", "Roberto", "Rosa", "Sara", "Lucía", "Carlos", "Marta", "Miguel", "Manuel", "Isabel", "Adrián", "Javier", "Jorge", "Mario", "Natalia", "Valentina", "Esteban", "Gabriela", "Alicia", "Antonio", "Beatriz", "Cristina", "Daniel", "Elena", "Emilio", "Francisco", "Gloria", "Ignacio", "Jaime", "Julia", "Lorenzo", "Mariana", "Matías", "Nicolás", "Olivia", "Pablo", "Rafael", "Ramón", "Raúl", "Renata", "Simón", "Tomás", "Victoria", "Ximena", "Yolanda", "Zoe", "Agustín", "Bruno", "Camila", "Damián", "Emma", "Felipe", "Gonzalo", "Hugo", "Íñigo", "José", "Katia", "Leonardo", "Lola", "Magdalena", "Nicol", "Óscar", "Paula", "Quirino", "René", "Santiago", "Thiago", "Ulises", "Verónica", "Walter", "Xavier", "Yanina", "Zaira", "Abril", "Belen", "Carmen", "Dante", "Ezequiel", "Florencia", "Guillermo", "Héctor", "Inés", "Joaquín", "Karen", "Lucas", "Marcela", "Nacho", "Octavio", "Patricia", "Ramiro", "Salvador", "Tania", "Uriel", "Vanesa", "Wanda", "Yago", "Zara" };

    for (int i = 0;i < 20;i++)
	{
		coleccion.agregar(new Alumno(nombres[new Random().Next(99)], new Random().Next(11111111, 99999999), new Random().Next(00001,99999), new Random().Next(0, 10)));
    }
}
