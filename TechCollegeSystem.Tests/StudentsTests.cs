using TechCollegeSystem.Models;
using TechCollegeSystem.Interface;
using Xunit;

namespace TechCollegeSystem.Tests;

public class StudentsTests
{
    [Fact]
    public void EnrollInSubject_ShouldAddSubjectToList()
    {
        // Arrange
        var student = new Students();
        string subject = "Mathematics";

        // Act
        student.EnrollInSubject(subject);

        // Assert
        Assert.Contains(subject, student.EnrolledSubjects);
    }

    [Fact]
    public void UnenrollFromSubject_ShouldRemoveSubjectAndGrade()
    {
        // Arrange
        var student = new Students();
        string subject = "Mathematics";
        student.EnrollInSubject(subject);
        student.SetGrade(subject, 10);

        // Act
        student.UnenrollFromSubject(subject);

        // Assert
        Assert.DoesNotContain(subject, student.EnrolledSubjects);
        Assert.DoesNotContain(subject, student.SubjectGrades.Keys);
    }

    [Fact]
    public void SetGrade_ShouldSetGradeForEnrolledSubject()
    {
        // Arrange
        var student = new Students();
        string subject = "Mathematics";
        int grade = 10;
        student.EnrollInSubject(subject);

        // Act
        student.SetGrade(subject, grade);

        // Assert
        Assert.Equal(grade, student.SubjectGrades[subject]);
    }

    [Fact]
    public void CalculateAverageGrade_ShouldReturnCorrectAverage()
    {
        // Arrange
        var student = new Students();
        student.EnrollInSubject("Mathematics");
        student.EnrollInSubject("Physics");
        student.SetGrade("Mathematics", 10);
        student.SetGrade("Physics", 12);

        // Act
        double average = student.CalculateAverageGrade();

        // Assert
        Assert.Equal(11, average);
    }

    [Fact]
    public void CalculateAverageGrade_NoGrades_ShouldReturnZero()
    {
        // Arrange
        var student = new Students();

        // Act
        double average = student.CalculateAverageGrade();

        // Assert
        Assert.Equal(0, average);
    }
} 