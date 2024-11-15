package com.example.universidad.Entity;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;
import lombok.Data;

@Entity
@Data
@Table (name = "Materias")

public class Materia {
    @Id
    @GeneratedValue(strategy= GenerationType.IDENTITY)
    private long materiaId; 
    private String nombre;
    private String creditos;
    
    @ManyToOne
    @JoinColumn (name = "profesorId")
    private Profesor profesor;


}