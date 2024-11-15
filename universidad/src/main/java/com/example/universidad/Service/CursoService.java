package com.example.universidad.Service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.universidad.Entity.Curso;
import com.example.universidad.Repository.CursoRepository;


@Service
public class CursoService {

    @Autowired
    private CursoRepository cursoRepository;

    public void save(Curso curso){
      cursoRepository.save(curso);
    }

    public  List<Curso> findAll(){
        return cursoRepository.findAll();
    }
    public Curso findById(Long Id) {
        return cursoRepository.findById(Id).orElse(null);
    }
    
    public void delete(Long Id){
    cursoRepository.deleteById(Id);
}


}
