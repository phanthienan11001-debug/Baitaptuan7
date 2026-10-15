
using Microsoft.EntityFrameworkCore;
using QLSV.DAL;
namespace QLSV.BLL
{
    public class StudentBLL
    {
        public async Task<List<Student>> LayDanhSachSinhVienAsync()
        {
            using var context = new AppDbContext();
            return await context.Students.ToListAsync();
        }
    }
}
