package com.example.universidad.Service;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.universidad.Entity.Salon;
import com.example.universidad.Repository.SalonRepository;

@Service
public class SalonService {

    @Autowired
    private SalonRepository salonRepository;

    public void  save (Salon salon){
         salonRepository.save (salon);
    }

    public List<Salon> findAll (){
        return salonRepository.findAll();
    }

    public Salon findById(Long Id){
        return salonRepository.findById(Id).orElse(null);
    }

    public void delete (Long Id){
        salonRepository.deleteById(Id);
    }
    

}
