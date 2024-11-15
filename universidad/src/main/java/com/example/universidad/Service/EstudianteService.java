package com.example.universidad.Service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.universidad.Entity.Estudiante;
import com.example.universidad.Repository.EstudianteRepository;

@Service
public class EstudianteService {

    @Autowired
    private EstudianteRepository estudianteRepository;

    public void save (Estudiante estudiante){
        estudianteRepository.save(estudiante);
    }

    public List<Estudiante>findAll(){
        return estudianteRepository.findAll();
    }

    public Estudiante findById(Long Id){
        return estudianteRepository.findById(Id).orElse(null);
    }

    public void delete (Long Id){
    estudianteRepository.deleteById(Id);

    }

}
