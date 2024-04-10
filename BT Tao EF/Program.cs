namespace BT_Tao_EF
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new SchoolContext())
            {
                // Lấy danh sách sinh viên thuộc khoa CNTT và có độ tuổi từ 18 đến 20
                var filteredStudents = context.Student
                    .Where(s => s.Department == "CNTT" && s.Age >= 18 && s.Age <= 20)
                    .ToList();

                // Hiển thị thông tin của sinh viên đã lọc
                Console.WriteLine("Students in CNTT department aged between 18 and 20:");
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"ID: {student.StudentId}, Name: {student.Name}, Age: {student.Age}, Department: {student.Department}");
                }
            }
            Console.ReadLine();
        }
    }
}
