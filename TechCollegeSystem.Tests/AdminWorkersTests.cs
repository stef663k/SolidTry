using TechCollegeSystem.Models;
using TechCollegeSystem.Interface;
using Xunit;

namespace TechCollegeSystem.Tests;

public class AdminWorkersTests
{
    [Fact]
    public void AddStudents_ShouldAddStudentToList()
    {
        // Arrange
        var adminWorker = new AdminWorkers();
        var student = new Students();

        // Act
        adminWorker.AddStudents(student);

        // Assert
        Assert.Contains(student, adminWorker.ResponsibleForStudents);
    }

    [Fact]
    public void RemoveStudents_ShouldRemoveStudentFromList()
    {
        // Arrange
        var adminWorker = new AdminWorkers();
        var student = new Students();
        adminWorker.AddStudents(student);

        // Act
        adminWorker.RemoveStudents(student);

        // Assert
        Assert.DoesNotContain(student, adminWorker.ResponsibleForStudents);
    }

    [Fact]
    public void TransferStudent_ShouldRemoveStudentFromList()
    {
        // Arrange
        var adminWorker = new AdminWorkers();
        var student = new Students();
        adminWorker.AddStudents(student);

        // Act
        adminWorker.TransferStudent(student);

        // Assert
        Assert.DoesNotContain(student, adminWorker.ResponsibleForStudents);
    }
} 