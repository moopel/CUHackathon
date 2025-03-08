using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Python.Runtime;

namespace CuHackathon.C_Classes
{
    class PythonMedian
    {
        public void RunPythonFunc(string funcName)
        {
            using (Py.GIL()) // Ensure to acquire the Python Global Interpreter Lock (GIL)
            {
                try
                {
                    // Example: Assuming you have a Python script or function to call dynamically

                    // You could either directly pass the Python function name or run the script
                    // Here, we are assuming a simple Python function exists in the global space

                    dynamic py = Py.Import("my_python_script"); // Import your Python module (replace with your script name)

                    // Call the function dynamically by its name
                    dynamic result = py.__getattr__(funcName)();  // Calls the function based on funcName

                    Console.WriteLine($"Result of {funcName}: {result}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        }
    }
}
