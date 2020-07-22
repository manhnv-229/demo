using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MISA.Entity;

namespace MISA.DL
{
    public partial class DemoContext : DbContext
    {
        public DemoContext()
        {
        }

        public DemoContext(DbContextOptions<DemoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Ethnic> Ethnic { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("server=35.194.166.58;port=3306;user=nvmanh;password=12345678@Abc;database=MISADemo_NVMANH", x => x.ServerVersion("10.3.22-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ethnic>(entity =>
            {
                entity.Property(e => e.EthnicID)
                   .HasColumnName("EthnicID")
                   .HasCharSet("utf8")
                   .HasCollation("utf8_general_ci");

                entity.Property(e => e.EthnicName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasComment("Bảng danh mục Nhân viên");

            entity.HasIndex(e => e.EmployeeCode)
                .HasName("UK_Employee_Employeecode")
                .IsUnique();

            entity.HasIndex(e => e.FullName);

            entity.HasIndex(e => e.PositionId)
                .HasName("FK_Employee_Position_PositionID");

            entity.Property(e => e.EmployeeId)
                .HasColumnName("EmployeeID")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.CitizenIdentityCode)
                .HasColumnType("varchar(25)")
                .HasComment("Số chứng minh thư")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.CreatedBy)
                .HasColumnType("varchar(255)")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.CreatedDate)
                .HasColumnType("datetime")
                .HasComment("Ngày tạo bản ghi");

            entity.Property(e => e.DateOfBieth)
                .HasColumnType("date")
                .HasComment("Ngày sinh");

            entity.Property(e => e.Email)
                .HasColumnType("varchar(50)")
                .HasComment("Email")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.EmployeeCode)
                .IsRequired()
                .HasColumnType("varchar(20)")
                .HasDefaultValueSql("''")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.FirstName)
                .HasColumnType("varchar(100)")
                .HasComment("Họ")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.FullName)
                .HasColumnType("varchar(100)")
                .HasComment("Họ và tên")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.Gender)
                .HasColumnType("int(11)")
                .HasComment("Giới tính (0-Nữ, 1- Nam, 2- Khác)");

            entity.Property(e => e.LastName)
                .HasColumnType("varchar(100)")
                .HasComment("Tên")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.ModifiedDate)
                .HasColumnType("datetime")
                .HasComment("Ngày thực hiện chỉnh sửa gần nhất");

            entity.Property(e => e.PhoneNumber)
                .HasColumnType("varchar(50)")
                .HasComment("Số điện thoại")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.PositionId)
                .HasColumnName("PositionID")
                .HasCharSet("utf8")
                .HasCollation("utf8_general_ci");

            entity.Property(e => e.WorkState)
                .HasColumnType("int(11)")
                .HasComment("Tình trạng công việc (0- ĐÃ nghỉ việc, 1- Đang làm việc, 2- Đã nghỉ hưu)");

            entity.HasOne(d => d.Position)
                .WithMany(p => p.Employee)
                .HasForeignKey(d => d.PositionId)
                .OnDelete(DeleteBehavior.Cascade);
        });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.HasComment("Vị trí");

                entity.Property(e => e.PositionId)
                    .HasColumnName("PositionID")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasColumnType("varchar(255)")
                    .HasComment("Tên vị trí")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_general_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
