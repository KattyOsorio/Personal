package com.example.universidad.Controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;

import com.example.universidad.Entity.Materia;
import com.example.universidad.Service.MateriaService;

import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;




@Controller
@RequestMapping ("/materias")
public class MateriaController {

    @Autowired
    private MateriaService materiaService;

    @GetMapping
    public String listarMateria (Model model) {
        model.addAttribute("materias", materiaService.findAll());
        return "verMaterias";
    }
    
    @GetMapping("/crear")
    public String crearMateria (Model model) {
        model.addAttribute("materia", new Materia());
        return "crearMateria";
    }

    @PostMapping("/guardar")
    public String guardarMateria(Materia materia) {
        materiaService.save(materia);
        return "redirect:/materias";
    }

    @GetMapping("/eliminar/{id}")
    public String eliminarMateria(@PathVariable Long id) {
        materiaService.delete(id);
        return "redirect:/materias";
    }
}
