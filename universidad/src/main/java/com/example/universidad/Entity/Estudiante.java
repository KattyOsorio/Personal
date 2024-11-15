
package com.example.universidad.Entity;

import java.time.LocalDate;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Entity
@Data
@NoArgsConstructor
@AllArgsConstructor
@Table (name = "Estudiantes")
public class Estudiante {

    @Id
    @GeneratedValue (strategy = GenerationType.IDENTITY)
    private long estudianteId;
    private String nombre; 
    private String apellido;
    private LocalDate fechaNacimiento;
    private String email; 
}