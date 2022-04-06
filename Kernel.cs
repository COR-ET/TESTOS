using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using System.Threading.Tasks;
using System.IO;
using Cosmos.System.Graphics;

using System.Drawing;
using System.Threading;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using Cosmos.Core.IOGroup;
using Cosmos.Core.Memory;
using Cosmos.Debug.Kernel;


namespace CSSF
{
    public class Kernel : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.Beep();
            Console.WriteLine("STARTING COROS-20 ...");
            System.Threading.Thread.Sleep(6000);
            Console.BackgroundColor
                       = ConsoleColor.Blue;
            Console.Clear();
            Console.WriteLine("Preparing ...");
            System.Threading.Thread.Sleep(10000);
        }

        

        public static int babaa = 0;

        public static Debugger debugs;

        public static VBECanvas vbecanvas;

        public static CosmosVFS VFS;

        public static Canvas canvas;
        


        public readonly Bitmap mouse = new Bitmap(10, 10,
               new byte[] { 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255,
                    23, 59, 88, 255, 0, 255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255, 23, 59, 88, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 23, 59, 88, 255, 153, 57, 12, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 0, 255, 243, 255, 153, 57, 12, 255, 23, 59, 88, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243,
                    255, 0, 255, 243, 255, 0, 255, 243, 255, 72, 72, 72, 255, 72, 72, 72, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0,
                    255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 72, 72,
                    72, 255, 72, 72, 72, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 10, 66, 148, 255, 10, 66, 148, 255,
                    10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255,
                    243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148, 255, 10, 66, 148,
                    255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255,
                    0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, 0, 255, 243, 255, }, ColorDepth.ColorDepth32);

        

        int MainX = 1280;
        int MainY = 720;

        

        protected override void Run()
        {
            Console.WriteLine("\n Type the cmd : `setup` to START Setup ! ");
            Console.Write(">");
            Cosmos.System.PCSpeaker.Beep();

            string input = "";

            input = Console.ReadLine();


            HandleThisCommand(input);
        }

        private void HandleThisCommand(string input)
        {
            if (input == "help")
            {
                Console.WriteLine("COROS-ALTER-C3 | Version : 0.3.13 Demo ! , Here is All cmds :");
                Console.WriteLine("print --> Print a Message on the Console");
                Console.WriteLine("shutdown --> Turn off the Computer ");
                Console.WriteLine("reboot --> Reboot Your Comupter");
                Console.WriteLine("clear --> Clear you Whole screen ");
                Console.WriteLine("virus --> Runs a Virus for fun :>");
                Console.WriteLine("setup --> Enter the COROS Setup ");

                Run();
            }

            if (input.StartsWith("print"))
            {
                Console.WriteLine(" ");
                Console.WriteLine("Type Your Message");
                string echo = "";

                echo = Console.ReadLine();

                Console.Write("Your Message : ");
                Console.WriteLine(echo);

                System.Threading.Thread.Sleep(1000);
                
                Run();

            }

            if (input == "shutdown")
            {
                Console.WriteLine("Shutting Down in moments ...");
                System.Threading.Thread.Sleep(5000);
                Sys.Power.Shutdown();

            }

            if (input == "reboot")
            {
                Console.WriteLine("Rebooting in moments ...");
                System.Threading.Thread.Sleep(5000);
                Sys.Power.Reboot();

            }

            if (input == "clear")
            {
                Console.WriteLine("Clearing Screen ...");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                Run();


            }

            if (input == "virus")
            {
                Console.WriteLine("Starting Trojan Virus Malwares ...");
                System.Threading.Thread.Sleep(6000);


                for (int i = 0; i < 100; i++)
                {
                Console.WriteLine("#$#@^@$#@!$#%$#%&^#@$()@#%$*@%^&@*%&#*%)$&@)%@$*^%&$*)%&@$)*^&$@%)@%*$@^%*@$)^&$_(%*$@(_%^*$*^$@%");
                 
                }
                Console.Beep();
                Cosmos.System.PCSpeaker.Beep();
                Console.WriteLine("SYSTEM CRASHED ! ... Rebooting Device now ...");
                System.Threading.Thread.Sleep(7000);

                Sys.Power.Reboot();

            }


            




            if (input == "setup")
            {
                Console.WriteLine("Starting Setup ...");
                System.Threading.Thread.Sleep(3000);
                Console.Clear();
                
                Init();

                static void Init()
                {


                   canvas = FullScreenCanvas.GetFullScreenCanvas(new Mode(1280, 720, ColorDepth.ColorDepth32));







                    canvas.Clear(Color.LightBlue);

                    setupo();
                    
                    
                    
                    
                    


                }
                static void setupo()
                {
                    Pen pen = new Pen(Color.White);

                    Sys.Graphics.Point a = new Sys.Graphics.Point();
                    a.X = 0;
                    a.Y = 20;

                    Sys.Graphics.Point b = new Sys.Graphics.Point();
                    b.X = 640;
                    b.Y = 0;

                    Sys.Graphics.Point c = new Sys.Graphics.Point();
                    c.X = 640;
                    c.Y = 20;

                    Sys.Graphics.Point m = new Sys.Graphics.Point();
                    m.X = 0;
                    m.Y = 0;

                    Sys.Graphics.Point n = new Sys.Graphics.Point();
                    n.X = 10;
                    n.Y = 0;



                    int width = 1280;
                    int height = 100;
                    canvas.DrawFilledRectangle(pen, m, width, height);

                    


                    canvas.Display();
                    StartMouse();
                    
                    
                }


               

                static void StartMouse()
                {

                    Pen pen = new Pen(Color.Black);

                    

                    Sys.MouseManager.ScreenHeight =  (uint)canvas.Mode.Columns;
                    Sys.MouseManager.ScreenWidth = (uint)canvas.Mode.Rows;

                    int xxx = (int)Sys.MouseManager.X;
                    int yyy = (int)Sys.MouseManager.Y;
                    Sys.Graphics.Point xx = new Sys.Graphics.Point();
                    

                    xx.X = xxx;
                    xx.Y = yyy;

                    int widd = 6; // wide
                    int gidd = 10; // high


                    Sys.Graphics.Point n = new Sys.Graphics.Point();
                    n.X = xxx;
                    n.Y = yyy;

                    int PosX = n.X;
                    int PosY = n.Y;

                    



                    try
                    {

                        canvas.DrawFilledEllipse(pen, n, widd, gidd);

                        canvas.Display();

                        System.Threading.Thread.Sleep(2);

                        canvas.Clear(Color.LightSkyBlue);





                        setupo();


                    }
                    catch (Exception e)
                    {
                        debugs.Send("ERROR IS "+ e.Message + "  SHUTTING DONW !");
                        System.Threading.Thread.Sleep(50000);
                        
                        Sys.Power.Shutdown();
                    }

                    
                    
                }

            }


            
                
            
            

            else
            {
                Console.WriteLine("Undetected Command , Try using `help` ?");
                Run();

            }
        }

       
    }
}
