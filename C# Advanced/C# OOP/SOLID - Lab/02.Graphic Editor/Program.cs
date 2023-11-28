using P02.Graphic_Editor.Contracts;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            IShape circle = new Circle();
            IShape rectangle = new Rectangle();

            GraphicEditor editor = new GraphicEditor();

            editor.DrawShape(circle);
            editor.DrawShape(rectangle);
        }
    }
}