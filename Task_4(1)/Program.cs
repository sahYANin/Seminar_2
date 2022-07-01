/*
    1 доп.з. Улитка ползёт по вертикальному шесту высотой h метров, 
поднимаясь за день на a метров, а за ночь спускаясь на b метров. 
На какой день улитка доползёт до вершины шеста?
*/
Console.WriteLine("Улитка ползет");
Console.Write("Улитка ползет на высоту см. : ");
int H = Convert.ToInt16(Console.ReadLine());
Console.Write("Ползет вверх в день см. : ");
int A = Convert.ToInt16(Console.ReadLine());
Console.Write("Ползет вниз за ночь см. : ");
int B = Convert.ToInt16(Console.ReadLine());
int i = 0, N = 0;

while(i<1)
{
    // Console.WriteLine("1"); Проверка как и снизу 
    H = H - A;
    // Console.WriteLine("2");
    N++;
    // Console.WriteLine("3");
    if(H<=0) {
        i=1;
        // Console.WriteLine("4");
    }
    
    else {H=H+B;
        // Console.WriteLine("5");
    }

}

Console.Write("Улитка проползет весь путь за ");

Console.Write(N);





/*
do
{
    i = i - A;
    // Console.Write(i);
    if (i <= 0) { 
        // N++; 
        Console.Write(N);
        i=-9999; 
    }
    i = i + B;
    N++;
    Console.Write(i);
}
while(i==-9999);

*/