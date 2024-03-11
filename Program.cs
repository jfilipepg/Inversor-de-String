// 5) Escreva um programa que inverta os caracteres de um string.
string invertida, auxiliar = "";
int i;

Console.Write ("Informe a string que você deseja que seja invertida: ");
invertida = Console.ReadLine();

for(i = invertida.Length - 1; i >= 0; i--){
    auxiliar += invertida[i];
}

invertida = auxiliar;