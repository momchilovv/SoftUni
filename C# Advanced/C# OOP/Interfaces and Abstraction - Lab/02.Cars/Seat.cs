using System.Text;

namespace Cars
{
    public class Seat : ICar
    {
        private string model;
        private string color;

        public Seat(string model, string color)
        {
            this.model = model;
            this.color = color;
        }

        public string Model()
        {
            return model;
        }

        public string Color()
        {
            return color;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"{color} Seat {model}");
            sb.AppendLine(Start());
            sb.AppendLine(Stop());

            return sb.ToString().TrimEnd();
        }
    }
}