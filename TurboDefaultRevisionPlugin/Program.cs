using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace TurboDefaultRevisionPlugin
{
    class Program
    {
        static void Main()
        {
            AppDomain.CurrentDomain.AssemblyResolve += ResolveAssembly;
        }

        private static Assembly ResolveAssembly(object sender, ResolveEventArgs args)
        {
            // Assuming that args.Name contains the full assembly name
            // Parse the assembly name to get the assembly information
            AssemblyName requestedAssemblyName = new AssemblyName(args.Name);

            System.Console.WriteLine(requestedAssemblyName.FullName);

            // Check if the requested assembly is the one you want to load from a different location
            if (requestedAssemblyName.Name == "YourAssemblyName")
            {
                // Specify the path to the assembly in the new location
                string newAssemblyPath = "Path\\To\\Your\\NewLocation\\YourAssembly.dll";

                // Load the assembly from the new location
                if (System.IO.File.Exists(newAssemblyPath))
                {
                    return Assembly.LoadFrom(newAssemblyPath);
                }
                else
                {
                    // Handle the case where the assembly is not found in the new location
                    Console.WriteLine($"Assembly not found at: {newAssemblyPath}");
                }
            }

            // Return null to indicate that the assembly resolution failed
            return null;
        }
    }
}
