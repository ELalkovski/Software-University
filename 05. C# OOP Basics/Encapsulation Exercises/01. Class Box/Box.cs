using System.Text;

namespace _01.Class_Box
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }

        public double SurfaceArea()
        {
            return (2 * this.length * this.width) + (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double LateralSurfaceArea()
        {
            return (2 * this.length * this.height) + (2 * this.width * this.height);
        }

        public double Volume()
        {
            return this.length * this.width * this.height;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Surface Area - {SurfaceArea():f2}");
            sb.AppendLine($"Lateral Surface Area - {LateralSurfaceArea():f2}");
            sb.AppendLine($"Volume - {Volume():f2}");

            return sb.ToString();
        }
    }
}
