package com.example.universidad.Entity;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.Data;

@Entity
@Data
@Table (name = "Profesores")

public class Profesor {
    @Id
    @GeneratedValue (strategy = GenerationType.IDENTITY)
    private long  profesorId; 
    private String nombre;
    private String apellido;
    private String Email;
    private String telefono; 
}