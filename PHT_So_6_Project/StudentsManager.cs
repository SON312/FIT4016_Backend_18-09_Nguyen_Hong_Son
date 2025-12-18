using System;

public class StudentManager
{
    private Student[] students = new Student[50];
    private int count = 0;

    // Thêm sinh viên
    public void AddStudent(string id, string name, double score)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
                throw new Exception("ID đã tồn tại");
        }

        students[count] = new Student(id, name, score);
        count++;
    }

    // Xóa sinh viên
    public void RemoveStudent(string id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
            {
                for (int j = i; j < count - 1; j++)
                {
                    students[j] = students[j + 1];
                }
                count--;
                return;
            }
        }
        throw new Exception("Không tìm thấy sinh viên");
    }

    // Cập nhật điểm
    public void UpdateScore(string id, double newScore)
    {
        if (newScore < 0 || newScore > 10)
            throw new Exception("Điểm không hợp lệ");

        Student sv = FindStudentById(id);
        if (sv == null)
            throw new Exception("Không tìm thấy sinh viên");

        sv.Score = newScore;
    }

    // Điểm trung bình
    public double GetAverageScore()
    {
        double sum = 0;
        for (int i = 0; i < count; i++)
        {
            sum += students[i].Score;
        }
        return count == 0 ? 0 : sum / count;
    }

    // Điểm cao nhất
    public double GetMaxScore()
    {
        double max = students[0].Score;
        for (int i = 1; i < count; i++)
        {
            if (students[i].Score > max)
                max = students[i].Score;
        }
        return max;
    }

    // Tìm sinh viên
    public Student FindStudentById(string id)
    {
        for (int i = 0; i < count; i++)
        {
            if (students[i].StudentId == id)
                return students[i];
        }
        return null;
    }

    // In danh sách
    public void DisplayAllStudents()
    {
        for (int i = 0; i < count; i++)
        {
            students[i].Display();
        }
    }
}