// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

for (int i=1; i<= 10; i++){
Console.WriteLine(CalcularFactorial(i));
}


long CalcularFactorial(int n){
    if (n == 1){
        return 1;
    }
    return n * CalcularFactorial(n -1);

}