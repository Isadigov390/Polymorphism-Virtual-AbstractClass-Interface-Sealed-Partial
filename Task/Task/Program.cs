

using Task.Classes;
bool isContinue=true;
Square square = new Square(1);
Rectangular rectangular = new Rectangular(1,1);
do
{
    Console.WriteLine("Menu \n 1. Square\r\n2. Rectangular\r\n0. Quit\r\n");
	int choice=Convert.ToInt32(Console.ReadLine());
	switch (choice)
	{
		case 1:
            Console.Write("Side:");
			square.Side = Convert.ToInt32(Console.ReadLine());
            
            if(square.CalcArea()!=-1) Console.WriteLine("Area:"+square.CalcArea());
            else Console.WriteLine("Invalid input");
            Console.WriteLine("-----------------");
            break;
			case 2:
            Console.Write("Width:");rectangular.Width = Convert.ToInt32(Console.ReadLine());
            Console.Write("Length:");rectangular.Length = Convert.ToInt32(Console.ReadLine());

            if (rectangular.CalcArea() != -1) Console.WriteLine("Area:"+rectangular.CalcArea());
            else Console.WriteLine("Invalid input");
            Console.WriteLine("-----------------");
            break;
			case 0:isContinue=false;
			break;
		default:
            Console.WriteLine("Invalid choice!");
			break;
	}

}
while (isContinue);