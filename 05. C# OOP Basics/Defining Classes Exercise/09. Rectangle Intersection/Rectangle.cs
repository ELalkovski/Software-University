namespace _09.Rectangle_Intersection
{
    public class Rectangle
    {
        private string id;
        private double height;
        private double width;
        private double leftCornerX;
        private double leftCornerY;

        public Rectangle(string id, double width, double height, double x, double y)
        {
            this.id = id;
            this.height = height;
            this.width = width;
            this.leftCornerX = x;
            this.leftCornerY = y;
        }

        public string Id
        {
            get { return this.id; }
        }

        public double LeftCornerX
        {
            get { return this.leftCornerX; }
        }

        public double LeftCornerY
        {
            get { return this.leftCornerY; }
        }
        public double Height
        {
            get { return this.height; }
        }
        public double Width
        {
            get { return this.width; }
        }

        public bool IsIntersected(Rectangle rect2)
        {
            if ((rect2.LeftCornerY >= this.LeftCornerY && rect2.LeftCornerY - rect2.Height <= this.LeftCornerY && rect2.LeftCornerX <= this.LeftCornerX && rect2.LeftCornerX + rect2.Width >= this.LeftCornerX) ||
                (rect2.LeftCornerY >= this.LeftCornerY && rect2.LeftCornerY - rect2.Height <= this.LeftCornerY && rect2.LeftCornerX >= this.LeftCornerX && rect2.leftCornerX <= this.leftCornerX + this.Width) ||
                (rect2.LeftCornerY <= this.LeftCornerY && rect2.LeftCornerY >= this.LeftCornerY - this.Height && rect2.LeftCornerX <= this.LeftCornerX && rect2.LeftCornerX + rect2.Width >= this.LeftCornerX) ||
                (rect2.LeftCornerY <= this.LeftCornerY && rect2.LeftCornerY >= this.LeftCornerY - this.Height && rect2.LeftCornerX >= this.LeftCornerX && rect2.leftCornerX <= this.leftCornerX + this.Width))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
