namespace _02.Graphic_Editor
{
    public class Program
    {
        public static void Main()
        {
            IShape square = new Square();
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();
            GraphicEditor editor = new GraphicEditor();

            editor.DrawShape(square);
            editor.DrawShape(circle);
            editor.DrawShape(rectangle);
        }
    }
}
