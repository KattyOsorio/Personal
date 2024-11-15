package com.example.universidad.Service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.universidad.Entity.Profesor;
import com.example.universidad.Repository.ProfesorRepository;

@Service
public class ProfesorService {

    @Autowired
    private ProfesorRepository profesorRepository;

    public void save(Profesor profesor){
         profesorRepository.save(profesor);
    }

    public List<Profesor> findAll(){
        return profesorRepository.findAll();
    }

    public Profesor findById (long Id){
        return profesorRepository.findById(Id).orElse(null);
    }

    public void delete (Long Id){
        profesorRepository.deleteById(Id);
    }

}
