package com.example.universidad.Repository;

import org.springframework.data.jpa.repository.JpaRepository;

import com.example.universidad.Entity.Profesor;

public interface ProfesorRepository extends JpaRepository<Profesor, Long>{

}
