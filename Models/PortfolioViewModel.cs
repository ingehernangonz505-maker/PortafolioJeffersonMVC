namespace PortafolioJeffersonMVC.Models;

public class PortfolioViewModel
{
    public string Name { get; set; } = "";
    public string Profession { get; set; } = "";
    public string Location { get; set; } = "";
    public string Introduction { get; set; } = "";
    public string About { get; set; } = "";
    public string AboutDetails { get; set; } = "";
    public string Objective { get; set; } = "";
    public List<Skill> Skills { get; set; } = new();
    public List<Project> Projects { get; set; } = new();
}

public record Skill(string Icon, string Name, string Description);

public record Project(
    string Number,
    string Type,
    string Name,
    string Description,
    string[] Technologies);
