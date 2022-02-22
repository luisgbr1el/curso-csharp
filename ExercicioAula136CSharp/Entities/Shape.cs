using System;
using System.Collections.Generic;
using System.Text;
using ExercicioAula136CSharp.Entities.Enums;

namespace ExercicioAula136CSharp.Entities {
    abstract class Shape {
        public Color Color { get; set; }

        public Shape(Color color) {
            Color = color;
        }

        public abstract double Area();
    }
}
