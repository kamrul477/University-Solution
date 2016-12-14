namespace DataLayer.UniversitySolution.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Applications",
                c => new
                    {
                        ApplicationId = c.Guid(nullable: false),
                        FristName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Gender = c.String(unicode: false),
                        StreetAddress = c.String(unicode: false),
                        City = c.String(unicode: false),
                        State = c.String(unicode: false),
                        PostCode = c.Int(nullable: false),
                        TelephoneNo = c.Int(nullable: false),
                        Email = c.String(unicode: false),
                        DateOfBirth = c.DateTime(nullable: false, precision: 0),
                        CGPA = c.Double(nullable: false),
                        SatMathScore = c.Double(nullable: false),
                        SatReadingScore = c.Double(nullable: false),
                        SatWrittingScore = c.Double(nullable: false),
                        ReceivedDate = c.DateTime(nullable: false, precision: 0),
                        ApplicationStaus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ApplicationId);
            
            CreateTable(
                "dbo.Sessions",
                c => new
                    {
                        SessionId = c.Guid(nullable: false),
                        SessionStarYear = c.DateTime(nullable: false, precision: 0),
                        SessionEndYear = c.DateTime(nullable: false, precision: 0),
                        Application_ApplicationId = c.Guid(),
                    })
                .PrimaryKey(t => t.SessionId)
                .ForeignKey("dbo.Applications", t => t.Application_ApplicationId)
                .Index(t => t.Application_ApplicationId);
            
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        CourseId = c.Guid(nullable: false),
                        CourseTitle = c.String(unicode: false),
                        CourseDescription = c.String(unicode: false),
                        Credit = c.Double(nullable: false),
                        Department_DepartmentId = c.Guid(),
                    })
                .PrimaryKey(t => t.CourseId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId);
            
            CreateTable(
                "dbo.Degrees",
                c => new
                    {
                        DegreeId = c.Guid(nullable: false),
                        DegreeTitle = c.String(unicode: false),
                        Course_CourseId = c.Guid(),
                        DegreeType_DegreeTypeId = c.Guid(),
                    })
                .PrimaryKey(t => t.DegreeId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .ForeignKey("dbo.DegreeTypes", t => t.DegreeType_DegreeTypeId)
                .Index(t => t.Course_CourseId)
                .Index(t => t.DegreeType_DegreeTypeId);
            
            CreateTable(
                "dbo.DegreeRequirments",
                c => new
                    {
                        DegreeRequirmentId = c.Guid(nullable: false),
                        Degree_DegreeId = c.Guid(),
                    })
                .PrimaryKey(t => t.DegreeRequirmentId)
                .ForeignKey("dbo.Degrees", t => t.Degree_DegreeId)
                .Index(t => t.Degree_DegreeId);
            
            CreateTable(
                "dbo.DegreeTypes",
                c => new
                    {
                        DegreeTypeId = c.Guid(nullable: false),
                        DegreeTypeTitle = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.DegreeTypeId);
            
            CreateTable(
                "dbo.Grades",
                c => new
                    {
                        GradeId = c.Guid(nullable: false),
                        Degree_DegreeId = c.Guid(),
                    })
                .PrimaryKey(t => t.GradeId)
                .ForeignKey("dbo.Degrees", t => t.Degree_DegreeId)
                .Index(t => t.Degree_DegreeId);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DepartmentId = c.Guid(nullable: false),
                        NameOfDepartment = c.String(unicode: false),
                        University_UniversityId = c.Guid(),
                    })
                .PrimaryKey(t => t.DepartmentId)
                .ForeignKey("dbo.Universities", t => t.University_UniversityId)
                .Index(t => t.University_UniversityId);
            
            CreateTable(
                "dbo.FacultyMembers",
                c => new
                    {
                        FacultyMemberId = c.Guid(nullable: false),
                        FristName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Gender = c.String(unicode: false),
                        StreetAddress = c.String(unicode: false),
                        City = c.String(unicode: false),
                        State = c.String(unicode: false),
                        PostCode = c.Int(nullable: false),
                        TelephoneNo = c.Int(nullable: false),
                        Email = c.String(unicode: false),
                        DateOfBirth = c.DateTime(nullable: false, precision: 0),
                        Department_DepartmentId = c.Guid(),
                    })
                .PrimaryKey(t => t.FacultyMemberId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .Index(t => t.Department_DepartmentId);
            
            CreateTable(
                "dbo.Students",
                c => new
                    {
                        StudentId = c.Guid(nullable: false),
                        FristName = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Gender = c.String(unicode: false),
                        StreetAddress = c.String(unicode: false),
                        City = c.String(unicode: false),
                        State = c.String(unicode: false),
                        PostCode = c.Int(nullable: false),
                        TelephoneNo = c.Int(nullable: false),
                        Email = c.String(unicode: false),
                        DateOfBirth = c.DateTime(nullable: false, precision: 0),
                        Course_CourseId = c.Guid(),
                        Department_DepartmentId = c.Guid(),
                        Session_SessionId = c.Guid(),
                        University_UniversityId = c.Guid(),
                    })
                .PrimaryKey(t => t.StudentId)
                .ForeignKey("dbo.Courses", t => t.Course_CourseId)
                .ForeignKey("dbo.Departments", t => t.Department_DepartmentId)
                .ForeignKey("dbo.Sessions", t => t.Session_SessionId)
                .ForeignKey("dbo.Universities", t => t.University_UniversityId)
                .Index(t => t.Course_CourseId)
                .Index(t => t.Department_DepartmentId)
                .Index(t => t.Session_SessionId)
                .Index(t => t.University_UniversityId);
            
            CreateTable(
                "dbo.Universities",
                c => new
                    {
                        UniversityId = c.Guid(nullable: false),
                        UnivesityName = c.String(unicode: false),
                        UniversitySlogan = c.String(unicode: false),
                    })
                .PrimaryKey(t => t.UniversityId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Students", "University_UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Departments", "University_UniversityId", "dbo.Universities");
            DropForeignKey("dbo.Students", "Session_SessionId", "dbo.Sessions");
            DropForeignKey("dbo.Students", "Department_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Students", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.FacultyMembers", "Department_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Courses", "Department_DepartmentId", "dbo.Departments");
            DropForeignKey("dbo.Grades", "Degree_DegreeId", "dbo.Degrees");
            DropForeignKey("dbo.Degrees", "DegreeType_DegreeTypeId", "dbo.DegreeTypes");
            DropForeignKey("dbo.DegreeRequirments", "Degree_DegreeId", "dbo.Degrees");
            DropForeignKey("dbo.Degrees", "Course_CourseId", "dbo.Courses");
            DropForeignKey("dbo.Sessions", "Application_ApplicationId", "dbo.Applications");
            DropIndex("dbo.Students", new[] { "University_UniversityId" });
            DropIndex("dbo.Students", new[] { "Session_SessionId" });
            DropIndex("dbo.Students", new[] { "Department_DepartmentId" });
            DropIndex("dbo.Students", new[] { "Course_CourseId" });
            DropIndex("dbo.FacultyMembers", new[] { "Department_DepartmentId" });
            DropIndex("dbo.Departments", new[] { "University_UniversityId" });
            DropIndex("dbo.Grades", new[] { "Degree_DegreeId" });
            DropIndex("dbo.DegreeRequirments", new[] { "Degree_DegreeId" });
            DropIndex("dbo.Degrees", new[] { "DegreeType_DegreeTypeId" });
            DropIndex("dbo.Degrees", new[] { "Course_CourseId" });
            DropIndex("dbo.Courses", new[] { "Department_DepartmentId" });
            DropIndex("dbo.Sessions", new[] { "Application_ApplicationId" });
            DropTable("dbo.Universities");
            DropTable("dbo.Students");
            DropTable("dbo.FacultyMembers");
            DropTable("dbo.Departments");
            DropTable("dbo.Grades");
            DropTable("dbo.DegreeTypes");
            DropTable("dbo.DegreeRequirments");
            DropTable("dbo.Degrees");
            DropTable("dbo.Courses");
            DropTable("dbo.Sessions");
            DropTable("dbo.Applications");
        }
    }
}
