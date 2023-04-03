/*
Ecuación cuadrática:
x1, x2// -b+-= raizCuadrada(b2-4.a.c)
         ______________________________
                    2.a

Ingreso 3 valores
calcular segun los valores
si la raíz da 0, que informe; sino
informar normal
*/

double A, B, C, x1, x2;

Console.WriteLine("Fórmula general");
Console.WriteLine("Ingresar A:");
A=Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresar B:");
B= Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingresar C");
C= Convert.ToDouble(Console.ReadLine());

//Valor de x1
x1=(-B + Math.Sqrt(Math.Pow(B, 2) - 4 *(A * C)))/2*A;

//valor de x2
x2=(-B - Math.Sqrt(Math.Pow(B, 2) - 4 *(A * C)))/2*A;

Console.WriteLine("Raíz de x1: "+x1);
Console.WriteLine("Ráiz de x2: "+x2);

//if(x1 == 1 && x2 == 1){
//     Console.WriteLine("La ecuación tiene una solución real");
//} else if (x1 ==0 && x2==0){
//     Console.WriteLine("La ecuación tiene dos soluciones reales");
//}