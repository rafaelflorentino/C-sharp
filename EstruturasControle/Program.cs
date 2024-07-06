int idadeMinima = 16; 
int idadeDaClaudia = 23; 
if (idadeDaClaudia >= idadeMinima) 
{ 
    Console.WriteLine("Você pode fazer parte do curso."); 
} 

// IF Else
idadeMinima = 16; 
idadeDaClaudia = 23; 

if (idadeDaClaudia >= idadeMinima) 
{ 
    Console.WriteLine("Você pode fazer parte do curso.");
    
} else{ 
    Console.WriteLine("Infelizmente você não pode participar!"); 
}

// Ternário
int idadeDaCris= 30; 
idadeDaClaudia = 20; 

Console.WriteLine(idadeDaCris > idadeDaClaudia ? "Cris" : "Claudia");

// Switch Case
int numeroDoMes = 3; 
string mes; 

switch (numeroDoMes)
{ 
    case 1: 
        mes = "janeiro"; 
        break; 
    case 2: 
        mes = "fevereiro"; 
        break; 
    case 3: 
        mes= "março"; 
        break; 
    case 4: 
        mes = "abril"; 
        break; 
    case 5: 
        mes= "maio"; 
        break; 
    case 6: 
        mes = "junho"; 
        break; 
    case 7: 
        mes= "julho"; 
        break;
   case 8: 
        mes = "agosto"; 
        break; 
    case 9: 
        mes= "setembro"; 
        break; 
    case 10: 
        mes= "outubro"; 
        break; 
    case 11: 
        mes= "novembro"; 
        break; 
    case 12: 
        mes= "dezembro"; 
        break; 
    default: 
        mes= "Mês inválido!"; 
        break; 
    } 
    Console.WriteLine(mes);

// Outro switch Case
    float valorA = 20; 
    float valorB = 10; 
    string operacao = "/"; 

    switch (operacao) { 
        case "+": 
            Console.WriteLine(valorA + valorB); 
            break; 
        case "-": 
            Console.WriteLine(valorA- valorB); 
            break; 
        case "*": 
            Console.WriteLine(valorA * valorB); 
            break; 
        case "/": 
            Console.WriteLine(valorA / valorB); 
            break; 
        default: 
            Console.WriteLine("Operação inválida"); 
            break; 
        }