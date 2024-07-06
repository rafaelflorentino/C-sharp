
// Operadores Aritméticos 
int valorUm = 10; 
int valorDois = 5; 
Console.WriteLine(valorUm+ valorDois);
Console.WriteLine(valorUm-valorDois); 
Console.WriteLine(valorUm* valorDois); 
Console.WriteLine(valorUm/ valorDois); 
Console.WriteLine(valorUm% valorDois); 

// Precedência 
float total; 
total= 5 + 4 * 9; 
Console.WriteLine(total); // 41 
total= (5 + 4) * 9; 
Console.WriteLine(total); // 81

// Operadores de atribuição combinados com alguma operação. 
float valor = 10; 
Console.WriteLine(valor += 1); // 11 

// substitui o valor = valor + 1 
Console.WriteLine(valor-= 2); // 9 
Console.WriteLine(valor *= 5); // 45 
Console.WriteLine(valor /= 5); // 9 
Console.WriteLine(valor %= 3); // 0

// Operadores de incremento e decremento.

// incremento 
valor++; 
Console.WriteLine(valor); 

// decremento 
valor--; Console.WriteLine(valor);

// Relacionais 
inta= 4; 
intb= 2; 

Console.WriteLine(a== b); // false 
Console.WriteLine(a!= b); // true 
Console.WriteLine(a> b); // true 
Console.WriteLine(a>= b); // true 
Console.WriteLine(a< b); // false 
Console.WriteLine(a<= b); // false

Console.WriteLine(false&& true); //false 
Console.WriteLine(false&& false); //false 
Console.WriteLine(true&& true); //true 
Console.WriteLine(false|| true); //true 
Console.WriteLine(false|| false); //false 
Console.WriteLine(true|| true); //true

