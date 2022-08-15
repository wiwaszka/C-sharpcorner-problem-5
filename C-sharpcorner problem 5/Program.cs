double userValue;

Console.WriteLine("Enter a value: ");
userValue = Convert.ToInt32(Console.ReadLine());

//display options
Console.WriteLine("Choose a conversion: \n I > Inch to centimeter \n G > Galon to Litre \n M > Mile to Kilometer \n P > Pound to Kilogram");

char convType = Convert.ToChar(Console.Read());

switch(convType)
{
    case 'I':
        Console.WriteLine(userValue + " In Inches is: " + (userValue * 2.54) + " in Centimeters");
        break;
    case 'G':
        Console.WriteLine(userValue + " In Galons is: " + (userValue * 3.79) + " in Litres");
        break;
    case 'M':
        Console.WriteLine(userValue + " In Miles is: " + (userValue * 1.61) + " in Kilometers");
        break;
    case 'P':
        Console.WriteLine(userValue + " In Pounds is: " + (userValue * 0.4536) + " in Kilograms");
        break;
    default:
        Console.WriteLine("Wrong input for conversion type. Remember to use capital letter");
        break;
}
//convert with switch
//1 inch = 2.54 cm
//1 galon = 3.79 L
//1 mile = 1.61 Km
//1 pound = 0.4536 Kg
