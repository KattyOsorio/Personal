package com.example.universidad.Repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.example.universidad.Entity.Curso;


public interface CursoRepository extends JpaRepository<Curso, Long> {


}
