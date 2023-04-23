// программа рисующая точки по экрану
// Console.Clear(); // чистит консоль
// Console.SetCursorPosition(10,4);//поставить курсор на 10 строчку 4позицию
// Console.WriteLine("+"); // вставить плюс
Console.Clear();
int xa = 30, xb = 1,
    ya = 1, yb = 30,
    za = 60, zb = 30;
Console.SetCursorPosition(xa,xb);
Console.WriteLine("X");
Console.SetCursorPosition(ya,yb);
Console.WriteLine("Y");
Console.SetCursorPosition(za,zb);
Console.WriteLine("Z");
int x = xa, y = xb;
int count = 0;
while (count <10000)
{
    int what = new Random().Next(0, 3); // от 0 до 2
    if (what==0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what==1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what==2)
    {
        x = (x + za) / 2;
        y = (y + zb) / 2;
    }
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}