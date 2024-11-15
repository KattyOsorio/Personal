package com.example.universidad.Repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.example.universidad.Entity.Materia;

public interface MateriaRepository extends JpaRepository<Materia, Long> {

}
