using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Threading.Tasks;

namespace OOP6
{
    public class VectorAsync
    {
        public async static Task<List<double>> FillVectorFromFileAsync(string filepath, IProgress<int> progress)
        {
            return await Task.Run(() =>
            {
                try
                {
                    List<double> list = new List<double>();
                    string content = File.ReadAllText(filepath);
                    string[] strings = content.Split(new char[] { ' ', '\n', '\r', ',' }, StringSplitOptions.RemoveEmptyEntries);
                    int steps = strings.Length, count = 0;
                    foreach (string i in strings)
                    {
                        if (double.TryParse(i, NumberStyles.Any, CultureInfo.InvariantCulture, out double value))
                        {
                            list.Add(value);
                        }
                        count++;
                        progress?.Report(count * 100 / steps);
                    }
                    return list;
                }
                catch (Exception)
                {
                    throw new IOException("Файл не может быть прочитан.");
                }
            });
        }

        public async static Task<double> VectorMedianAsync(List<double> list, IProgress<int> progress)
        {
            return await Task.Run(() =>
            {
                if (list.Count == 0)
                {
                    return 0.0;
                }
                list.Sort();
                progress?.Report(50);
                if (list.Count % 2 == 1)
                {
                    return list[list.Count / 2];
                }
                else
                {
                    return 0.5 * (list[list.Count / 2 - 1] + list[list.Count / 2]);
                }
            });
        }
    }
}
