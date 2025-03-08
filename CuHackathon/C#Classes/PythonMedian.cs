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
        public static void RunPythonFunc()
        {
            try
            {
                // Explicitly set the Python environment path
                Runtime.PythonDLL = "python313.dll";
                PythonEngine.Initialize();
                using (Py.GIL()) // Ensure the Global Interpreter Lock (GIL) is acquired
                {

                    dynamic sys = Py.Import("sys");
                    sys.path.append("C:\\Users\\derek\\source\\repos\\CuHackathon\\CuHackathon\\Backend");  // Or use an absolute path
                    foreach (var p in sys.path)
                    {
                        Console.WriteLine(p);
                    }
                    // Import your Python module (adjust for correct module name)
                    dynamic pythonFile = Py.Import("LOAD_AI_RESPONSE"); // Import your Python module

                    // Assuming the Python script has a function named `get_bot_response`
                    dynamic result = pythonFile.get_bot_response("joker");

                    // Output the result from the Python function
                    Console.WriteLine($"Result of get_bot_response: {result}");
                }
            }
            catch (PythonException ex)
            {
                Console.WriteLine($"Python error occurred: {ex.Message}");
            }
        }
    }
}
