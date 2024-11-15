package com.example.universidad.Service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.universidad.Entity.Materia;
import com.example.universidad.Repository.MateriaRepository;

@Service
public class MateriaService {

    @Autowired
    private MateriaRepository materiaRepository;

    public void save (Materia materia){
        materiaRepository.save(materia);
    }

    public List<Materia> findAll(){
        return materiaRepository.findAll();
    }

    public Materia findById (Long Id){
        return materiaRepository.findById(Id).orElse(null);
    }

    public void delete (Long Id){
        materiaRepository.deleteById(Id);
    }




}
