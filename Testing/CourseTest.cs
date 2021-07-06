using ExampleTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Testing
{
    public class CourseTest
    {
        [Fact]
        public void TestCourse()
        {
            CourseService service = new CourseService();
            var course = new Course() { name = string.Empty, price = 10,description = string.Empty };
            var result = service.IsValid(course);

            Assert.False(result);

        }
    }
}
