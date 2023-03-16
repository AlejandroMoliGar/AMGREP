using eje21;

Student student = new Student();
student.SetAge(24);
student.SetName("Alejandro");
student.SayHello();
student.GoToClasses();
student.ShowAge();

Teacher teacher = new Teacher();
teacher.SetAge(30);
teacher.SetName("Eduardo");
teacher.SayHello();
teacher.Explain();