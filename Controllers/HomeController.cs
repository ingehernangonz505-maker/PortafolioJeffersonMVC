using Microsoft.AspNetCore.Mvc;
using PortafolioJeffersonMVC.Models;

namespace PortafolioJeffersonMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        var model = new PortfolioViewModel
        {
            Name = "Jefferson Hernández",
            Profession = "Estudiante de Ingeniería en Sistemas de Información",
            Location = "Nicaragua",
            Introduction = "Me interesa el desarrollo de software, la creación de aplicaciones móviles y el diseño de soluciones tecnológicas que ayuden a resolver problemas reales.",
            About = "Soy Jefferson Hernández, estudiante de Ingeniería en Sistemas de Información. Me encuentro desarrollando mis conocimientos en programación y diseño de sistemas.",
            AboutDetails = "Me interesa crear aplicaciones útiles, trabajar en equipo y aprender nuevas herramientas. He trabajado en ideas de aplicaciones móviles con Flutter y en proyectos que utilizan Firebase, HTML, CSS y GitHub.",
            Objective = "Quiero seguir aprendiendo, fortalecer mis habilidades como desarrollador y participar en proyectos que generen un impacto positivo mediante la tecnología.",
            Skills = new List<Skill>
            {
                new(" </> ", "Desarrollo web", "Creación de páginas con HTML y CSS."),
                new("📱", "Flutter", "Desarrollo de interfaces para aplicaciones móviles."),
                new("🔥", "Firebase", "Exploración de servicios para aplicaciones y datos."),
                new("⌘", "GitHub", "Control de versiones y organización del código."),
                new("🗄️", "Bases de datos", "Aprendizaje de consultas y gestión de información."),
                new("🤝", "Trabajo en equipo", "Colaboración, comunicación y metodología Scrum.")
            },
            Projects = new List<Project>
            {
                new("01", "APLICACIÓN MÓVIL", "Agro Native Origins", "Propuesta de plataforma digital para conectar a productores agrícolas con consumidores y facilitar la comercialización de productos locales.", new[] { "Flutter", "Firebase" }),
                new("02", "SISTEMA WEB", "Veterinaria M&L", "Sistema orientado a mejorar el control de productos, el inventario y las ventas de una veterinaria.", new[] { "HTML", "CSS", "ASP.NET" }),
                new("03", "DESARROLLO WEB", "Mi portafolio personal", "Página personal para presentar mi perfil, habilidades, proyectos y crecimiento profesional.", new[] { "HTML", "CSS", "Diseño web" })
            }
        };

        return View(model);
    }

    public IActionResult Error()
    {
        return View();
    }
}
