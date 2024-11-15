package com.example.universidad.Repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.example.universidad.Entity.Estudiante;

public interface EstudianteRepository extends JpaRepository<Estudiante, Long> {

}
