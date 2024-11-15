package com.example.universidad.Entity;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.Data;

@Entity
@Data 
@Table(name = "Salones")
public class Salon {
    @Id
    @GeneratedValue(strategy= GenerationType.IDENTITY)
    private long salonId;
    private String nombre_salon;
    private int capacidad; 
}
