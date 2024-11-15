package com.example.universidad.Controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.PathVariable;

import com.example.universidad.Entity.Curso;
import com.example.universidad.Service.CursoService;

@Controller
@RequestMapping("/cursos")
public class CursoController {

   @Autowired
   private CursoService cursoService;

    // Mostrar todos los cursos
    @GetMapping
    public String listarCurso(Model model) {
        model.addAttribute("cursos", cursoService.findAll());
        return "VerCursos";  // Devuelve la vista de todos los cursos
    }

    // Mostrar formulario para crear un curso
    @GetMapping("/crear")
    public String crearCurso(Model model) {
        model.addAttribute("curso", new Curso());  // Crear un objeto vacío de Curso para el formulario
        return "crearCurso";  // Devuelve el formulario para crear el curso
    }

    // Guardar el nuevo curso
    @PostMapping("/guardar")
    public String guardarCurso(Curso curso) {
        cursoService.save(curso);  // Guarda el curso en la base de datos
        return "redirect:/cursos";  // Redirige a la página de lista de cursos
    }

    // Eliminar un curso por su ID
    @GetMapping("/eliminar/{id}")
    public String eliminarCurso(@PathVariable Long id) {
        cursoService.delete(id);  // Elimina el curso por el ID
        return "redirect:/cursos";  // Redirige a la lista de cursos
    }
}
