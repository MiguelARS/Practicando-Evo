using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleTesting
{
    public class CourseService
    {
        public List<string> Errores { get; private set; }

        public bool IsValid(Course course)
        {
            Errores = new List<string>();
            var valid = true;
            if (string.IsNullOrWhiteSpace(course.name))
            {
                Errores.Add("El nombre del curso es un campo obligatorio");
                valid = false;
            }
            return valid;
            
            if (course.price>0)
            {
                valid = false;
            }
            if (string.IsNullOrWhiteSpace(course.description))
            {
                Errores.Add("La descripcion del curso es un campo obligatorio");
                valid = false;
            }
        }
    }
}
