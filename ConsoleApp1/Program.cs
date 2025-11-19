// See https://aka.ms/new-console-template for more information
using ConsoleApp1;
using ConsoleApp1.Interfaces;

Console.WriteLine("Hello, World!");


ICalc calc = new Calc();
Console.WriteLine(calc.Add(0, 4));
Console.WriteLine(calc.Subtract(0, 4));
if (false)
{
    Console.WriteLine(calc.Divide(4, 0));
}

string result = "";
for (int i = 0; i < 10000; i++)
{
    result += i;
}

Console.WriteLine(result[..10]);

int a = 0;
int b = 4;

if (a + b == 4)
{
    Console.WriteLine("Addition works!");
}


var lorumIpsum = """
    Lorem ipsum dolor sit amet, consectetur adipiscing elit. Aliquam cursus nibh sed nisi dapibus porttitor. Donec iaculis cursus libero id dictum. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Vestibulum et rutrum quam. Curabitur euismod dui libero, nec mattis massa pulvinar ut. Vivamus scelerisque dignissim lorem, vel gravida nisi ullamcorper non. Suspendisse vestibulum, velit placerat feugiat ornare, orci mauris pharetra eros, in gravida ipsum velit sed mi. Morbi orci nisi, lobortis eu hendrerit quis, aliquam in ipsum. Vestibulum at nisl sed neque cursus cursus. Aliquam ac nunc quam. Proin scelerisque massa euismod nisl tristique ullamcorper. Sed in eleifend lorem.

    Fusce pellentesque auctor justo, non ullamcorper diam ullamcorper eget. Morbi tincidunt erat non elit posuere, non ultrices libero volutpat. Sed commodo diam nisi, eu tempor velit finibus ut. Donec laoreet erat ullamcorper, maximus ex vehicula, pharetra magna. Fusce pharetra nisi orci. Vivamus faucibus lacus ut sollicitudin feugiat. Suspendisse non lorem dapibus mauris facilisis sodales vel fringilla sapien. Donec ut lectus accumsan, accumsan ligula hendrerit, facilisis leo.

    Donec porta eu mi sed fermentum. Praesent volutpat neque at orci tempus, quis consectetur velit interdum. Duis lorem sem, pharetra nec placerat ac, tempus ac neque. Vivamus pharetra massa sit amet tellus ullamcorper pharetra. In id elit in dui imperdiet porta et et felis. Ut nec dolor porta, mattis diam id, ultricies purus. Nunc diam quam, eleifend fringilla justo ut, venenatis bibendum sem. Nunc et consequat lectus. Integer imperdiet lacinia sapien eget mollis. Pellentesque convallis faucibus lectus non pharetra.

    Curabitur consequat urna et metus vulputate sagittis. Integer eu lacus maximus, elementum ante et, scelerisque lectus. Ut faucibus commodo lacus et volutpat. Aliquam porta facilisis justo, sed aliquet mi consequat viverra. Pellentesque luctus velit a fringilla tincidunt. Quisque quis libero a dolor lacinia faucibus sit amet eget risus. Vestibulum felis erat, pharetra et nunc in, ornare pulvinar urna. Nullam vel diam tincidunt odio fringilla varius vel at neque. Vestibulum sed lorem quis elit suscipit molestie sed non tellus. Mauris vel leo at dui vulputate dapibus. Nam nec sem condimentum, pulvinar ante at, lacinia turpis. Vestibulum luctus urna ut erat tempor imperdiet.

    Vivamus nisl arcu, tempor vel nisi pharetra, vestibulum pulvinar nulla. In viverra velit dictum, consectetur tellus malesuada, ultricies lacus. Nulla justo nibh, sagittis quis condimentum id, scelerisque eu neque. Vestibulum ac tincidunt magna, non facilisis enim. Mauris quis ex vitae nisl placerat dictum vulputate quis ipsum. Sed sit amet viverra sem, sed luctus metus. Aenean pulvinar id dui at porttitor.
    """;

var d = true;