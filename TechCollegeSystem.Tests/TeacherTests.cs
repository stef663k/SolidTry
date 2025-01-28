using TechCollegeSystem.Models;
using TechCollegeSystem.Interface;
using Xunit;
using System.Linq;

namespace TechCollegeSystem.Tests;

public class TeacherTests
{
    [Fact]
    public void EnrollInSubject_ShouldAddSubjectToList()
    {
        // Arrange
        var teacher = new Teachers();
        string subject = "Mathematics";

        // Act
        teacher.EnrollInSubject(subject);

        // Assert
        Assert.Contains(subject, teacher.EnrolledSubjects);
    }

    [Fact]
    public void UnenrollFromSubject_ShouldRemoveSubjectFromList()
    {
        // Arrange
        var teacher = new Teachers();
        string subject = "Mathematics";
        teacher.EnrollInSubject(subject);

        // Act
        teacher.UnenrollFromSubject(subject);

        // Assert
        Assert.DoesNotContain(subject, teacher.EnrolledSubjects);
    }

    [Fact]
    public void AssignToTeam_ShouldAddTeamAndSubject()
    {
        // Arrange
        var teacher = new Teachers();
        string team = "Class A";
        string subject = "Mathematics";
        teacher.EnrollInSubject(subject);

        // Act
        teacher.AssignToTeam(team, subject);

        // Assert
        Assert.Contains(subject, teacher.TeamTeachingAssignments[team]);
    }

    [Fact]
    public void RemoveFromTeam_ShouldRemoveSubjectFromTeam()
    {
        // Arrange
        var teacher = new Teachers();
        string team = "Class A";
        string subject = "Mathematics";
        teacher.EnrollInSubject(subject);
        teacher.AssignToTeam(team, subject);

        // Act
        teacher.RemoveFromTeam(team, subject);

        // Assert
        Assert.False(
            teacher.TeamTeachingAssignments.Any(t => t.Value.Contains(subject)),
            "Subject should not be assigned to any team"
        );
    }
} 