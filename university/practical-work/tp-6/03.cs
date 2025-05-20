char a, b;
string salida;
int num1;
double num2;
bool esNum, dioError, ejecutar;

//Asumimos que todas las variables tienen algún valor al momento de ser utilizadas en
//la llamada.

a. string resultado = Ej1(a, b, salida); //error en el argumento salida, en la funcion se espera como out, ademas que Ej1 es un procedimiento

b. Ej1(a, b, salida); //error en el argumento salida, en la funcion se espera como out

c. int opcion = Ej2(a, b, salida); //esta todo mal, primero que es un procedimiento, y luego cada uno de los argumentos se esperan como out

d. double calculo = F1(num1, num2, ejecutar); //esta llamada esta correcta

e. num1 = LeeNumero(salida, dioError); //error en el argumento dioError, en la funcion se espera como out

f. salida = LeeLetra(salida, num1); //LeeLetra devuelve un char, pero salida es de tipo string

g. b = LeeLetra(salida, num1); //esta llamada es correcta