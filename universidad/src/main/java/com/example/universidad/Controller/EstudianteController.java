package com.example.universidad.Controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;

import com.example.universidad.Entity.Estudiante;
import com.example.universidad.Service.EstudianteService;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.PostMapping;




@Controller
@RequestMapping ("/estudiantes")
public class EstudianteController {


    @Autowired
    private EstudianteService estudianteService;

    @GetMapping
    public String ListarEstudiante(Model model) {
        model.addAttribute("estudiantes", estudianteService.findAll());
        return "VerEstudiantes";
    }

    @GetMapping("/crear")
    public String crearEstudiante (Model model) {
        model.addAttribute("estudiante", new Estudiante());
        return "crearEstudiante";
    }

    @PostMapping("/guardar")
    public String guardarEstudiante (Estudiante estudiante) {
        estudianteService.save(estudiante);
        return "redirect:/estudiantes";
    }

    @GetMapping("/eliminar/{id}")
    public String eliminarEstudiante (@PathVariable Long id) {
        estudianteService.delete(id);
        return "redirect:/estudiantes";
    }
}
