// See https://aka.ms/new-console-template for more information
int num = 1;
while(true){
    Console.Clear();
    Console.Write(num);
    num = (num % 10 == 0) ? 1 : num + 1;
    System.Threading.Thread.Sleep(100);
}
