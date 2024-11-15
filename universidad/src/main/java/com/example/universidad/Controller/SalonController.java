package com.example.universidad.Controller;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;

import com.example.universidad.Entity.Salon;
import com.example.universidad.Service.SalonService;

import org.springframework.web.bind.annotation.PostMapping;



@Controller
@RequestMapping ("/salones")
public class SalonController {

    @Autowired
    private SalonService salonService;

    @GetMapping
    public String listarSalon (Model model) {
        model.addAttribute("salones", salonService.findAll());
        return "VerSalones";
    }

    @GetMapping("/crear")
    public String crearSalon( Model model) {
        model.addAttribute("salon", new Salon() );
        return "crearSalon";
    }

    @PostMapping("/guardar")
    public String guardarSalon(Salon salon ) {
        salonService.save(salon);
        return "redirect:/salones";
    }

    @GetMapping("/eliminar/{id}")
    public String eliminarSalon (@PathVariable Long id) {
        salonService.delete(id);
        return "redirect:/salones";
    }
    
    
    
    
}
