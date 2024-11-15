package com.example.universidad.Controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestMapping;

import com.example.universidad.Entity.Profesor;
import com.example.universidad.Service.ProfesorService;




@Controller
@RequestMapping ("/profesores")
public class ProfesorController {

    @Autowired
    private ProfesorService profesorService;

    @GetMapping
    public String listarProfesor(Model model) {
        model.addAttribute ("profesores", profesorService.findAll());
        return "VerProfesores";
    }

    @GetMapping("/crear")
    public String crearProfesor(Model model) {
        model.addAttribute("profesor", new Profesor());
        return "crearProfesor";

    }

    @PostMapping("/guardar")
    public String guardarProfesor(Profesor profesor) {
        profesorService.save(profesor);
        return "redirect:/profesores";

    }

    @GetMapping("/eliminar/{id}")
    public String eliminarProfesor (@PathVariable Long id)  {
        profesorService.delete(id);
        return "redirect:/profesores";
    }
    
    
    
    

}
