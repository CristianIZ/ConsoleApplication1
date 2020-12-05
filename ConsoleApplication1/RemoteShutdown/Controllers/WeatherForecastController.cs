using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace RemoteShutdown.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get()
        {
            // var script = @"C:\Users\CrisDesk\source\repos\Farmacity.OMS\Connectors\Input\Vtex\Api\main.py";
            // 
            // var processInfo = new ProcessStartInfo();
            // // processInfo.FileName = @"C:\Users\CrisDesk\source\repos\Farmacity.OMS\Connectors\Input\Vtex\Api\main.py";
            // processInfo.FileName = @"C:\Program Files\Python\python.exe";
            // processInfo.Arguments = $"\"{script}\"";
            // processInfo.CreateNoWindow = true;
            // processInfo.UseShellExecute = false;
            // processInfo.RedirectStandardError = true;
            // processInfo.RedirectStandardOutput = true;
            // 
            // // var script = @"C:\Users\CrisDesk\source\repos\Farmacity.OMS\Connectors\Input\Vtex\Api\asd.bat";
            // 
            // var process = Process.Start(processInfo);
            // 
            // process.OutputDataReceived += (object sender, DataReceivedEventArgs e) =>
            //     Console.WriteLine("output>>" + e.Data);
            // process.BeginOutputReadLine();
            // 
            // process.ErrorDataReceived += (object sender, DataReceivedEventArgs e) =>
            //     Console.WriteLine("error>>" + e.Data);
            // process.BeginErrorReadLine();
            // 
            // process.WaitForExit();
            // 
            // Console.WriteLine("ExitCode: {0}", process.ExitCode);
            // process.Close();
            // 
            // return Ok("Se apagara el equipo en 5 minutos");

            // ---------------------------------

            // var dir = new DirectoryInfo(@"C:\Users\CrisDesk\source\repos\Farmacity.OMS\Connectors\Input\Vtex\Api").GetFiles();
            // 
            // // 1)
            // var psi = new ProcessStartInfo();
            // psi.FileName = @"C:\Program Files\Python\python.exe";
            // 
            // // 2)
            // // var script = @"C:\Users\CrisDesk\source\repos\Farmacity.OMS\Connectors\Input\Vtex\Api\main.py";
            // var script = @"C:\Users\CrisDesk\source\repos\Farmacity.OMS\Connectors\Input\Vtex\Api\asd.bat";
            // 
            // // 3)
            // psi.UseShellExecute = false;
            // //psi.CreateNoWindow = true;
            // psi.RedirectStandardOutput = true;
            // psi.RedirectStandardError = true;
            // 
            // // 4)
            // var errors = string.Empty;
            // var results = string.Empty;
            // 
            // using (var process = Process.Start(psi))
            // {
            //     errors = process.StandardError.ReadToEnd();
            //     results = process.StandardOutput.ReadToEnd();
            // }
            // 
            // return Ok("22");

            // ---------------------------------

            var cmdFileName = "shutdown";
            var cmdArgument = "/s /t 350";
            var psi = new ProcessStartInfo(cmdFileName, cmdArgument);
            
            psi.CreateNoWindow = true;
            psi.UseShellExecute = false;
            Process.Start(psi);
            
            return Ok("Se apagara el equipo en 5 minutos");
        }
    }
}
