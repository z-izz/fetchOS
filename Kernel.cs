using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using Sys = Cosmos.System;

namespace fetchOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void OnBoot()
        {
            Sys.Global.Init(GetTextScreen(), false,false,false,false); // disable all the drivers that can be disabled
        }

        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("fetchOS [build 230415]\n");
            if (Cosmos.Core.CPU.GetCPUVendorName().Contains("Intel")) // if intel chip
            {
                Console.WriteLine("88                              88");
                Console.WriteLine("\"\"              ,d              88");
                Console.WriteLine("                88              88");
                Console.WriteLine("88 8b,dPPYba, MM88MMM ,adPPYba, 88");
                Console.WriteLine("88 88P'   `\"8a  88   a8P_____88 88");
                Console.WriteLine("88 88       88  88   8PP\"\"\"\"\"\"\" 88");
                Console.WriteLine("88 88       88  88,  \"8b,   ,aa 88");
                Console.WriteLine("88 88       88  \"Y888 `\"Ybbd8\"' 88");
            }
            else if (Cosmos.Core.CPU.GetCPUVendorName().Contains("AMD")) // if amd chip
            {
                Console.WriteLine("              *@@@@@@@@@@@@@@@    ");
                Console.WriteLine("                 @@@@@@@@@@@@@    ");
                Console.WriteLine("                @%       @@@@@    ");
                Console.WriteLine("              @@@%       @@@@@    ");
                Console.WriteLine("             @@@@&       @@@@@    ");
                Console.WriteLine("             @@@@@@@@@     @@@    ");
                Console.WriteLine("             #######              ");
                Console.WriteLine();
                Console.WriteLine("            @@     @\\ /@  @@@@*   ");
                Console.WriteLine("           @..@    @ @ @  @.   @  ");
                Console.WriteLine("          @    @   @   @  @@@@*   ");
            }
            Console.Beep(250, 250);
            Console.Beep(500, 250);
            Console.SetCursorPosition(36, 2);
            Console.Write($"{Cosmos.Core.CPU.GetCPUBrandString()}"); // print cpu
            Console.SetCursorPosition(36, 3);
            Console.Write($"RAM: {Cosmos.Core.CPU.GetAmountOfRAM()} MB"); // print ram
            Console.SetCursorPosition(36, 4);
            Console.Write("VM: ");
            if (Sys.VMTools.IsVMWare)
            {
                Console.Write("VMware");
            } else if (Sys.VMTools.IsQEMU)
            {
                Console.Write("QEMU (or maybe KVM)");
            } else if (Sys.VMTools.IsVirtualBox)
            {
                Console.Write("VirtualBox");
            }
            else
            {
                Console.Write("Environment isn't virtualized");
            }
        }

        protected override void Run()
        {
            
        }
    }
}
