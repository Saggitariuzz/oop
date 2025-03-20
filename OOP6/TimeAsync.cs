using System;
using System.Threading.Tasks;

namespace OOP6
{
    internal class TimeAsync
    {
        public async static Task<string> SystemTimeAsync(IProgress<int> progress)
        {
            return await Task.Run(() => {
                progress?.Report(100);
                return DateTime.Now.ToString("HH:mm:ss");
            });
        }
    }
}
