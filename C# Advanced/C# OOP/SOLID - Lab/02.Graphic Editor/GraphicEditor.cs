﻿using P02.Graphic_Editor.Contracts;
using System;

namespace P02.Graphic_Editor
{
    public class GraphicEditor
    {
        public void DrawShape(IShape shape)
        {
            Console.WriteLine($"I'm a {shape.GetType().Name}");
        }
    }
}