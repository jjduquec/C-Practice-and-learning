using static System.Console;
using static System.ConsoleColor;


internal class Program
{
    private static void Main(string[] args)
    {



            if (args.Length < 3)
            {
                WriteLine("You must specify two colors and cursor size, e.g");
                WriteLine("yellow red 50");
                return; // stop running 

            }
        
            //Setup foreground color 
            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true

                );


            //Setup background color 
            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),  
                value: args[1], 
                ignoreCase: true
            
            
                );
        //Setup cursor size   
        try
        {
            CursorSize = int.Parse(args[2]);

        }
        catch {

            WriteLine("The current plataform doesn't support changig the size of the cursor ");
            //other way to consider which O.S we are using is :  OperatingSystem.IsWindows()
            /* Code example: 
             * 
             * if (PeratingSystem.IsWindows()){
             *  then, execute code that only works on windows
             * }
             * 
             * Execute code that only works on windows 10 or later
             * OperatingSystem.IsWindowsVersionAtLeast(major:10)            
             * 
             * Execute code that only works on IOS 14.5 or later 
             * OperatingSystem.IsIOSVersionAtLeast(major: 14, minor :5)
             * 
             * 
             * Execute code that only works in the browser with blazor 
             * OperatingSystem.IsBrowser()
             * 
             * FOR MORE INFORMATION CHECK  OperatingSystem class  
             */
        
        
        }





    }//Main bracket 




}