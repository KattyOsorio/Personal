package com.example.universidad.Entity;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;


@Entity 
@Data 
@Table(name = "Cursos")
@NoArgsConstructor
@AllArgsConstructor
public class Curso {
    @Id
    @GeneratedValue(strategy= GenerationType.IDENTITY)
    private long cursoId;
    private String nombreCurso; 

    @ManyToOne
    @JoinColumn (name = "salonId")
    private Salon salon;

    @ManyToOne
    @JoinColumn (name = "estudianteId")
    private Estudiante estudiante;

    @ManyToOne
    @JoinColumn (name = "materiaId")
    private Materia materia;

}
