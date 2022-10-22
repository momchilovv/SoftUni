using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
        public Computer(string model, int capacity)
        {
            Model = model;
            Capacity = capacity;
            Multiprocessor = new List<CPU>();
        }

        public string Model { get; set; }
        public int Capacity { get; set; }
        public List<CPU> Multiprocessor { get; set; }

        public int Count => Multiprocessor.Count;

        public void Add(CPU cpu)
        {
            if (Capacity > Count)
            {
                Multiprocessor.Add(cpu);
            }
        }

        public bool Remove(string brand)
        {
            foreach (var item in Multiprocessor.Where(b => b.Brand == brand))
            {
                Multiprocessor.Remove(item);
                return true;
            }

            return false;
        }

        public CPU MostPowerful()
        {
            return Multiprocessor.OrderByDescending(p => p.Frequency).First();
        }

        public CPU GetCPU(string brand)
        {
            return Multiprocessor.FirstOrDefault(p => p.Brand == brand);
        }

        public string Report()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"CPUs in the Computer {Model}:");
            foreach (var item in Multiprocessor)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}